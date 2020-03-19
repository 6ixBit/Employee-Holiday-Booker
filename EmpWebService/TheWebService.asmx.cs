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

        // METHODS FOR CONSTRAINT ALGORITHM //

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
        public bool check_if_dates_are_in_certain_period(DateTime[] days_between_holiday, DateTime constraint_start_date, DateTime constraint_end_date)
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

        //@desc Returns all the head and deputy employees of a department
        public List<Employees> get_head_and_deputy_of_department(string department)
        {
            var query = (from emp in db.Employees
                         where emp.department == department 
                         && emp.employee_role == "Head" 
                         || emp.employee_role == "Deputy Head" 
                         select emp);

            // List to hold results
            List<Employees> my_employees = new List<Employees>();

            foreach (var emp in query)
            {
                // New Instance from Holidays class for each result
                Employees user_employee = new Employees();
                user_employee.ID_ = emp.Employee_ID;
                user_employee.Name_ = emp.name_;
                user_employee.Email = emp.email;
                user_employee.Password = emp.password;
                user_employee.System_role = emp.system_role;
                user_employee.Join_date = (DateTime)emp.join_date;
                user_employee.Department = emp.department;
                user_employee.Employee_role = emp.employee_role;
                user_employee.Holiday_days_available = (int)emp.holiday_days_available;

                // Add each employee to list
                my_employees.Add(user_employee);
            }
            return my_employees;
        }

        // @desc Returns manager and senior member from department
        public List<Employees> get_seniors_of_department(string department)
        {
            var query = (from emp in db.Employees
                         where emp.department == department
                         && emp.employee_role == "Manager"
                         || emp.employee_role == "Senior Member"
                         select emp);

            // List to hold results
            List<Employees> my_employees = new List<Employees>();

            foreach (var emp in query)
            {
                // New Instance from Holidays class for each result
                Employees user_employee = new Employees();
                user_employee.ID_ = emp.Employee_ID;
                user_employee.Name_ = emp.name_;
                user_employee.Email = emp.email;
                user_employee.Password = emp.password;
                user_employee.System_role = emp.system_role;
                user_employee.Join_date = (DateTime)emp.join_date;
                user_employee.Department = emp.department;
                user_employee.Employee_role = emp.employee_role;
                user_employee.Holiday_days_available = (int)emp.holiday_days_available;

                // Add each employee to list
                my_employees.Add(user_employee);
            }
            return my_employees;
        }

        // @desc Get all employees from department
        public List<Employees> get_all_of_department(string department, int employee_that_submitted_holiday_ID)
        {
            var query = (from emp in db.Employees
                         where emp.department == department
                         && emp.Employee_ID != employee_that_submitted_holiday_ID
                         select emp);

            // List to hold results
            List<Employees> my_employees = new List<Employees>();

            foreach (var emp in query)
            {
                // New Instance from Holidays class for each result
                Employees user_employee = new Employees();
                user_employee.ID_ = emp.Employee_ID;
                user_employee.Name_ = emp.name_;
                user_employee.Email = emp.email;
                user_employee.Password = emp.password;
                user_employee.System_role = emp.system_role;
                user_employee.Join_date = (DateTime)emp.join_date;
                user_employee.Department = emp.department;
                user_employee.Employee_role = emp.employee_role;
                user_employee.Holiday_days_available = (int)emp.holiday_days_available;

                // Add each employee to list
                my_employees.Add(user_employee);
            }
            return my_employees;
        }

        // @desc Returns all holidays off a specific user
        public List<Holidays> get_holidays(int employee_id)
        {
            var query = (from hol in db.Holidays
                         where hol.Employee_ID == employee_id && hol.holiday_status == "Accepted"
                         select hol);

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
            return userHolidays;
        }

        //@desc Check whether employee has holiday or not
        public bool does_employee_have_holiday_clash(int ID, DateTime empHolStart, DateTime empHolEnd)
        { 
            // Get current holidays for head/Deputy head
            var current_holidays = get_holidays(ID); 

            // Get days between user request holiday to check if dates clash with head or deputys head holidays
            var days_between_holiday_request = get_days_between_dates(empHolStart, empHolEnd);

            // Loop over holidays and check if theres a clash, if so return true.
            foreach (var holiday in current_holidays)
            {
                // Get days between employee for head/ Deputy head
                var days_holiday_for_head = get_days_between_dates(holiday.Holiday_start, holiday.Holiday_end);

                // For each day in a holiday for the head, compare it to a day for the user requested holiday
                foreach(var date in days_holiday_for_head)
                {
                    foreach(var requested_date in days_between_holiday_request)
                    {
                        // If any of the dates match then a head will not be in and therefore raises a constraint.
                        if (date == requested_date)
                        {
                            return true;
                        }
                    }
                }

            }
            return false;
        }

        [WebMethod] // @desc Constraint checking Algorithm.
        public void submit_holiday_with_constraint_checking(string emp_email, DateTime holiday_start, DateTime holiday_end)
        {
            // CONSTRAINTS TO BE APPLIED, FALSE BY DEFAULT.
            bool days_exceeded = false;
            bool head_depHead_absent = false;
            bool seniorStaff_absent = false;
            bool department_absent = false;

            // Get days left for employee.
            var holiday_days_available = get_holiday_days_available(emp_email);

            // Get days between holiday start and end
            var days_between_holiday_request = get_days_between_dates(holiday_start, holiday_end);

            // Check whether they're between 23rd Dec to 3rd Jan.
            bool do_constraints_not_apply = check_if_dates_are_in_certain_period(days_between_holiday_request, new DateTime(2020, 12, 23), new DateTime(2021, 01, 3)); 

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

            // Apply further constraints by getting info for EMPLOYEE.
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

            // GET employee info of head and deputy of department for the employees department
            var head_and_deputy_employees = get_head_and_deputy_of_department(current_employee.Department);

            // Loop over each and check if the employees clash with holiday dates
            foreach (var employee in head_and_deputy_employees)
            {
                if (does_employee_have_holiday_clash(employee.ID_, holiday_start, holiday_end) == true ) {
                    head_depHead_absent = true;
                }
            }

            // GET Manager and Senior member that are on duty during holiday request
            var senior_employees_of_department = get_seniors_of_department(current_employee.Department);

            // Flags get triggered to true if atleast one senior member is present.
            bool manager_present = false;
            bool senior_member = false;

            foreach (var employee in senior_employees_of_department)
            {
                // Check if atleast a manager is present
                if (employee.Employee_role == "Manager")
                {
                    if (does_employee_have_holiday_clash(employee.ID_, holiday_start, holiday_end) == false) // If there are no clashes which means manager is present
                    {
                        manager_present = true;
                    }
                }

                // Check if a senior member is present
                if (employee.Employee_role == "Senior Member")
                {
                    if (does_employee_have_holiday_clash(employee.ID_, holiday_start, holiday_end) == false) // If there are no clashes which means senior member is present
                    {
                        senior_member = true;
                    }
                }
            }

            // If Manager and Senior Staff are not present during these periods.
            if (manager_present != true && senior_member != true)
            {
                seniorStaff_absent = true;
            }

            // Get all employees from department
            var employees_frm_department = get_all_of_department(current_employee.Department, current_employee.ID_);

            // Store numbers of employees from department
            int total_of_department = employees_frm_department.Count;
            int total_emp_available = 0;

            // For each employee check whether or not they are available during the employees submitted holiday.
            foreach (var department_employee in employees_frm_department)
            {
                if(does_employee_have_holiday_clash(department_employee.ID_, holiday_start, holiday_end) == false) // IF an employee is available on during the dates then increment 
                {
                    total_emp_available += 1;
                }
            }

            // Get percentage of employees available
            var percentage_of_employees_available = total_emp_available / total_of_department * 100;

            // Check if percentage of available department constraint should apply if holiday is in the month of August
            foreach(var date in days_between_holiday_request)
            {
                if(date.Month == 8) // If holiday request is in month of August.
                {
                    if(percentage_of_employees_available >= 40) // Is the percentage of employees greater than 40%
                    {
                        // Submit holiday as other constraints do not apply.
                        submit_holiday_request(emp_email, holiday_start, holiday_end, days_exceeded, head_depHead_absent, seniorStaff_absent, department_absent);
                    }
                    else // Is the percentage of employees less than 40%
                    {
                        department_absent = true;
                        submit_holiday_request(emp_email, holiday_start, holiday_end, days_exceeded, head_depHead_absent, seniorStaff_absent, department_absent);
                    }
                } else // Not in August so reduced constraint for August does not apply.
                {
                    if (percentage_of_employees_available >= 60) // Is the percentage of employees greater than 40%
                    {
                        submit_holiday_request(emp_email, holiday_start, holiday_end, days_exceeded, head_depHead_absent, seniorStaff_absent, department_absent);
                    } else
                    {
                        department_absent = true;
                        submit_holiday_request(emp_email, holiday_start, holiday_end, days_exceeded, head_depHead_absent, seniorStaff_absent, department_absent);
                    }
                }
            }
        }

        // METHODS FOR PRIORITISATION ALGORITHM //





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
