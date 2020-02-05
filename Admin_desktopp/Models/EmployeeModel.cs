﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_desktopp.Models
{
    public class EmployeeModel
    {
        HolidayBookingsEntities db = new HolidayBookingsEntities();

        // @desc Adds new employee to database
        public void add_employee(String name, String email, String password, String employee_role, String department, String system_role="User")
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
                system_role = system_role
            };
            db.Employees.Add(new_user);
            db.SaveChanges();
        }

        // @desc Returns info about user if ID is matched
        public void get_employee(String employee_email)
        { //: TODO Add try catch to handle errors
            Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);
        }

        // @desc Returns user info if employee exists, else false
        public bool login_employee(String email, String password)
        {

            Employee employee = db.Employees.FirstOrDefault(user => user.email == email && user.password == password);

            if (employee != null)
            {
                Console.WriteLine(employee.email);
                Console.WriteLine(employee.password);
                Console.WriteLine(employee.Employee_ID);
                Console.WriteLine(employee.join_date);
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

        // @desc Returns employees that are available for a particular date
        public List<Employees> get_employees_available_for_specific_date(DateTime date)
        {
            var query = (from emp in db.Employees
                         join hm in db.Holidays 
                         on emp.Employee_ID equals hm.Employee_ID
                         where hm.holiday_start == date
                         select emp); 

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

                // Add each employee to list
                employees_on_holiday.Add(user_employee);
            }
            Console.WriteLine(employees_on_holiday[0]);
            return employees_on_holiday;
        }

        public void get_all_employees()
        {

        }
    }
}
