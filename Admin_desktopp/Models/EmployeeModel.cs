﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_desktopp.Models
{
    public class EmployeeModel
    {
        readonly FinalEntities db = new FinalEntities();

        // @desc Adds new employee to database
        public void add_employee(String name, String email, String password, String employee_role, String department, int holiday_days_available=30, String system_role="User")
        {
            // Bind parameters passed to Employee object
            Employee new_user = new Employee
            {
                email = email,
                name_ = name,
                password = password,
                employee_role = employee_role,
                department = department,
                join_date = DateTime.Today,
                holiday_days_available = holiday_days_available,  // Every employee starts with 30 days holiday
                system_role = system_role
            };
            db.Employees.Add(new_user);
            db.SaveChanges();
        }

        // @desc Returns info about user if email is matched
        public String get_employee(int employee_id)
        { //: TODO Add try catch to handle errors
            Employee employee = db.Employees.FirstOrDefault(e => e.Employee_ID == employee_id);
            return employee.email;
        }

        // @desc Returns info about user if email is matched
        public Employees get_employee_byEmail(string employee_email)
        { 
            Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);

            // Write Db results to employee object
            Employees my_employee = new Employees
            {
                Name_ = employee.name_,
                Email = employee.email,
                Password = employee.password,
                Department = employee.department,
                System_role = employee.system_role,
                Employee_role = employee.employee_role,
                Holiday_days_available = (int)employee.holiday_days_available
            };

            return my_employee;
        }

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

        // @desc Assigns employee to a specific role
        public void assign_EmployeeRole(String employee_email, String role)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);
            employee.employee_role = role;
            db.SaveChanges();
        }

        // @desc Assigns employee to a specific department
        public void assign_EmployeeDepartment(String employee_email, String department)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);
            employee.department = department;
            db.SaveChanges();

            Console.WriteLine(employee.email);
            Console.WriteLine(employee.department);
        }

        // @desc Delete an employee based on 
        public void delete_employee(String employee_email)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        // @desc Returns the system role (admin or user) of a particular user
        public String get_system_role(String email)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == email);
            return employee.system_role;
        }

        // @desc Update the system role of an employee
        public void edit_system_role(String email, String new_system_role)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == email);
            employee.system_role = new_system_role;
            db.SaveChanges();
        }

        // @desc Update the password of an employee
        public void edit_employee_password(String email, String new_password)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == email);
            employee.password = new_password;
            db.SaveChanges();
        }

        /// @desc Update the name of an employee
        public void edit_employee_name(String email, String new_name)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == email);
            employee.name_ = new_name;
            db.SaveChanges();
        }

        // @desc Update the email of an employee
        public void edit_employee_email(String email, String new_email)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == email);
            employee.email = new_email;
            db.SaveChanges();
        }

        // @desc Update the department of the employee
        public void edit_employee_department(String email, String new_department)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == email);
            employee.department = new_department;
            db.SaveChanges();
        }

        // @desc Returns employees that are available for a particular date
        public List<Employees> get_employees_available_for_specific_date(DateTime date)
        {
            var query = (from emp in db.Employees
                         join hm in db.Holidays 
                         on emp.Employee_ID equals hm.Employee_ID
                         where hm.holiday_start != date && hm.holiday_status != "Accepted" && hm.holiday_end != date
                         orderby emp.email ascending
                         select emp).Distinct(); 

            List<Employees> employees_on_holiday = new List<Employees>();

            foreach (var employee in query)
            {
                // New Instance from Holidays class for each result
                Employees user_employee = new Employees();

                user_employee.Name_ = employee.name_;
                user_employee.Email = employee.email;
                user_employee.Password = employee.password;
                user_employee.System_role = employee.system_role;
                user_employee.Join_date = (DateTime)employee.join_date;
                user_employee.Department = employee.department;
                user_employee.Employee_role = employee.employee_role;
                user_employee.Holiday_days_available = (int)employee.holiday_days_available;

                // Add each employee to list
                employees_on_holiday.Add(user_employee);
            }
            return employees_on_holiday;
        }

        // @desc Returns employees that are not available for a particular date
        public List<Employees> get_employees_not_available_for_specific_date(DateTime date)
        {   
            var query = (from emp in db.Employees
                         join hm in db.Holidays
                         on emp.Employee_ID equals hm.Employee_ID
                         where hm.holiday_start == date && hm.holiday_status == "Accepted"
                         select emp).Distinct();

            List<Employees> employees_not_on_holiday = new List<Employees>();

            foreach (var employee in query)
            {
                // New Instance from Holidays class for each result
                Employees user_employee = new Employees();

                user_employee.Name_ = employee.name_;
                user_employee.Email = employee.email;
                user_employee.Password = employee.password;
                user_employee.System_role = employee.system_role;
                user_employee.Join_date = (DateTime)employee.join_date;
                user_employee.Department = employee.department;
                user_employee.Employee_role = employee.employee_role;
                user_employee.Holiday_days_available = (int)employee.holiday_days_available;

                // Add each employee to list
                employees_not_on_holiday.Add(user_employee);

                Console.WriteLine(user_employee.Email);
            }
            return employees_not_on_holiday;
        }

        // Using employee email, get holiday dates where stats = accepted and all constraints are 0
        public List<Holidays> get_employee_holidays(string employee_email)
        {
            // JOIN the two tables and return the holiday dates where the email passed is equal to that 
            // within the table and the status of the holiday is accepted and therefore constraints met.
            var query = (from emp in db.Employees
                         join hm in db.Holidays
                         on emp.Employee_ID equals hm.Employee_ID
                         where emp.email == employee_email && 
                         hm.holiday_status == "Accepted" &&
                         hm.days_exceeded == false && 
                         hm.head_depHead_absent == false &&
                         hm.seniorStaff_absent == false &&
                         hm.Department_absent == false
                         select hm).Distinct();

            List<Holidays> userHolidays = new List<Holidays>();

            foreach(var holiday in query)
            {
                // New Instance from Holidays class for each result
                Holidays my_holiday = new Holidays();

                my_holiday.Holiday_start = (DateTime)holiday.holiday_start;
                my_holiday.Holiday_end = (DateTime)holiday.holiday_end;

                // Add each holiday object to list
                userHolidays.Add(my_holiday);
            }
            return userHolidays;
        }

        //@desc Returns the days between holidays in an array of dates
        public DateTime[] get_days_between_holiday(DateTime holiday_start, DateTime holiday_end)
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

        //@desc Returns all employees
        public List<Employees> get_all_employees()
        {
            var query = (from emp in db.Employees select emp);

            // List to hold results
            List<Employees> my_employees = new List<Employees>();

            foreach (var emp in query)
            {
                // New Instance from Holidays class for each result
                Employees user_employee = new Employees();
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
    }
}
