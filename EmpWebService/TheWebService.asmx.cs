using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EmpWebService
{
    /// <summary>
    /// Summary description for TheWebService
    /// </summary>
    [WebService(Namespace = "http://tempurideya.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TheWebService : System.Web.Services.WebService
    {
        // Get DB instance
        readonly EmpHolidayEntities db = new EmpHolidayEntities();

        [WebMethod]
        // @desc Returns user info if employee exists, else false
        public bool login_employee(String email, String password)
        {
            Employee employee = db.Employees.FirstOrDefault(user => user.email == email && user.password == password);

            if (employee != null)
            {
                return true;
            }
            return false;
        }

        [WebMethod]
        //@desc Submit holiday request
        public void submit_holiday_request(string email, DateTime holiday_start, DateTime holiday_end, bool days_exceeded, bool head_depHead_absent, bool seniorStaff_absent, bool Department_absent, string holiday_status = "Pending")
        {
            // Get all details for employee based on their email
            var user = get_employee_byEmail(email);

            // Bind parameters passed to Holidays object
            Holiday new_holiday = new Holiday
            {
                Employee_ID = user.ID_,
                holiday_start = holiday_start,
                holiday_end = holiday_end,
                holiday_status = holiday_status, // Set users status to pending, once admin has approved/rejected it will be modified 
                days_exceeded = days_exceeded,
                head_depHead_absent = head_depHead_absent,
                seniorStaff_absent = seniorStaff_absent,
                Department_absent = Department_absent
            };

            db.Holidays.Add(new_holiday);
            db.SaveChanges();
        }

        [WebMethod]
        public List<Holidays> get_outstanding_holiday_requests_for_employee(string email)
        {
            // Get Employee_ID for user by email
            var user = get_employee_byEmail(email);

            // Query to select all elements that are pending
            var query = (from hol in db.Holidays where hol.Employee_ID == user.ID_ select hol);

            List<Holidays> userHolidays = new List<Holidays>();

            foreach (var holiday in query)
            {
                // New Instance from Holidays class for each result
                Holidays my_holiday = new Holidays();

                my_holiday.Employee_ID = (int)holiday.Employee_ID;
                my_holiday.Holiday_ID = holiday.Holiday_ID;
                my_holiday.Holiday_start = (DateTime)holiday.holiday_start;
                my_holiday.Holiday_end = (DateTime)holiday.holiday_end;
                my_holiday.Holiday_status = holiday.holiday_status;
                my_holiday.Days_exceeded = (bool)holiday.days_exceeded;
                my_holiday.department_Absent = (bool)holiday.Department_absent;
                my_holiday.Head_depHead_absent = (bool)holiday.head_depHead_absent;
                my_holiday.SeniorStaff_absent = (bool)holiday.seniorStaff_absent;

                // Add each holiday object to list
                userHolidays.Add(my_holiday);
            }
            foreach (var hold in userHolidays)
            {
                Console.WriteLine(hold);
            }
            return userHolidays;
        }

        // NON WEB METHODS //

        // @desc Returns info about user if email is matched
        public Employees get_employee_byEmail(string employee_email)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);

            // Write Db results to employee object
            Employees my_employee = new Employees
            {
                Name_ = employee.name_,
                ID_ = employee.Employee_ID,
                Email = employee.email,
                Password = employee.password,
                Department = employee.department,
                System_role = employee.system_role,
                Employee_role = employee.employee_role,
                Holiday_days_available = (int)employee.holiday_days_available
            };

            return my_employee;
        }

        // @desc Returns number of days an employee has left.
        public int get_holiday_days_available(string email)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == email);

            return (int) employee.holiday_days_available;
        }

        //@desc Returns the days between holidays in an array of dates
        public DateTime[] get_days_between_dates(DateTime holiday_start, DateTime holiday_end)
        {
            // Dyanimc arraylist to hold dates between days
            var absentDates = new List<DateTime>();

            // Add days between dates to arraylist
            for (var dt = holiday_start; dt <= holiday_end; dt = dt.AddDays(1))
            {
                absentDates.Add((DateTime)dt);
            }

            // Convert arraylist with dates to array so they can be set to Bold in Calendar
            DateTime[] actualAbsentDates = absentDates.ToArray();
            return actualAbsentDates;
        }

        //@desc Checks whether array of dates are between 23rd Dec - 3rd Jan (Constrains do not apply during this)
        public bool check_if_dates_are_in_constraint_period(DateTime[] days_between_holiday, DateTime constraint_start_date, DateTime constraint_end_date)
        {
            // Get dates between constraint dates
            var days_between_constraints = get_days_between_dates(constraint_start_date, constraint_end_date);

            // Now compare if any of the days from holiday request matches a date where the constraints applies.
            foreach(var day in days_between_holiday)
            {
                foreach(var constraint_day in days_between_constraints)
                {
                    if (day.Month == constraint_day.Month && day.Day == constraint_day.Day)
                    {   // IF days between holiday matches a day from constraint then return true, else false
                        return true;
                    }
                }
            }

            return false;
        }

        //@desc Checks if employee has been at company for more than 5 years
        public bool employed_longer_than_five_years(DateTime employee_join_date) 
        {
            // Get todays date and check if employee has been employed longer than 5 years.
            var todays_date = DateTime.Today;

            if (todays_date.Year - employee_join_date.Year > 5)
            {
                return true;
            }
            return false;
        }

        [WebMethod] // @desc Constraint checking Algorithm.
        public void apply_constraint_checking(string emp_email, DateTime holiday_start, DateTime holiday_end)
        {
            // CONSTRAINTS TO BE APPLIED, FALSE BY DEFAULT
            bool days_exceeded = false;
            bool head_depHead_absent = false;
            bool seniorStaff_absent = false;
            bool department_absent = false;

            // Get days left for employee.
            var holiday_days_available = get_holiday_days_available(emp_email);

            // Get days between holiday start and end
            var days_between_holiday_request = get_days_between_dates(holiday_start, holiday_end);

            // Check whether they're between 23rd Dec to 3rd Jan.
            bool do_constraints_not_apply = check_if_dates_are_in_constraint_period(days_between_holiday_request, new DateTime(2020, 12, 23), new DateTime(2021, 01, 3)); 

            // If holiday is between Dec 23rd and 3rd Jan then it returns true as constraints should not apply and holiday should be submitted.
            if (do_constraints_not_apply == true)
            { 
                try
                {   // Submit holiday with unmodified constraints.
                    Console.WriteLine("No further constraints.");
                    submit_holiday_request(emp_email, holiday_start, holiday_end, days_exceeded, head_depHead_absent, seniorStaff_absent, department_absent);
                } catch (Exception es)
                {
                    Console.WriteLine(es);
                }   
            }

            // Apply further constraints by getting info for employee.
            var current_employee = get_employee_byEmail(emp_email);

            // Verify whether or not employee qualifies for additional holiday days
            bool add_additional_holiday = employed_longer_than_five_years(current_employee.Join_date);

            var todays_date = DateTime.Today;

            if (add_additional_holiday == true)
            { // Compute number of days to be addded based on amount of years worked.
                int total_holidays_days = holiday_days_available + (todays_date.Year - current_employee.Join_date.Year) / 5;

                // Check if holiday requests exceeds the number of days the employee has available to them.
                if(total_holidays_days - days_between_holiday_request.Length < 0)
                {
                    days_exceeded = true;
                }
            }

            // GET IDs of head and depauty of department for the employees department

            
        
        }











    }

    // Employee class to hold objects with its associated value
    public class Employees
    {
        private string email;
        private int id_;
        private string name_;
        private string password;
        private string employee_role;
        private string department;
        private DateTime join_date;
        private string system_role;
        private int holiday_days_available;

        public Employees() { }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int ID_
        {
            get { return id_; }
            set { id_ = value; }
        }

        public string Name_
        {
            get { return name_; }
            set { name_ = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Employee_role
        {
            get { return employee_role; }
            set { employee_role = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public DateTime Join_date
        {
            get { return join_date; }
            set { join_date = value; }
        }

        public string System_role
        {
            get { return system_role; }
            set { system_role = value; }
        }

        public int Holiday_days_available
        {
            get { return holiday_days_available; }
            set { holiday_days_available = value; }
        }

        public override string ToString()
        {
            return $"{Email} - {Name_} - {Employee_role} - {System_role} - {Join_date} - {Holiday_days_available}";
        }
    }

    public class Holidays
    {
        private int employee_id;
        public int holiday_id;
        private DateTime holiday_start;
        private DateTime holiday_end;
        private String holiday_status;
        private bool days_exceeded;
        private bool head_depHead_absent;
        private bool seniorStaff_absent;
        private bool Department_absent;

        public Holidays(int employee_id, int holiday_id, DateTime holiday_start, DateTime holiday_end, String holiday_status, bool days_exceeded, bool head_depHead_absent, bool seniorStaff_absent, bool Department_absent)
        {
            this.employee_id = employee_id;
            this.holiday_id = holiday_id;
            this.holiday_start = holiday_start;
            this.holiday_end = holiday_end;
            this.holiday_status = holiday_status;
            this.days_exceeded = days_exceeded;
            this.head_depHead_absent = head_depHead_absent;
            this.Department_absent = Department_absent;
            this.seniorStaff_absent = seniorStaff_absent;

        }

        public Holidays() { }

        public int Employee_ID
        {
            get { return employee_id; }
            set { employee_id = value; }
        }

        public int Holiday_ID
        {
            get { return holiday_id; }
            set { holiday_id = value; }
        }

        public DateTime Holiday_start
        {
            get { return holiday_start; }
            set { holiday_start = value; }
        }

        public DateTime Holiday_end
        {
            get { return holiday_end; }
            set { holiday_end = value; }
        }

        public String Holiday_status
        {
            get { return holiday_status; }
            set { holiday_status = value; }
        }

        public Boolean Days_exceeded
        {
            get { return days_exceeded; }
            set { days_exceeded = value; }
        }

        public Boolean Head_depHead_absent
        {
            get { return head_depHead_absent; }
            set { head_depHead_absent = value; }
        }

        public Boolean department_Absent
        {
            get { return Department_absent; }
            set { Department_absent = value; }
        }

        public Boolean SeniorStaff_absent
        {
            get { return seniorStaff_absent; }
            set { seniorStaff_absent = value; }
        }

        public override string ToString()
        {
            return $"{Holiday_ID} - {Employee_ID} - {Holiday_start} - {Holiday_end} - {Holiday_status} - {Days_exceeded}";
        }

    }
}
