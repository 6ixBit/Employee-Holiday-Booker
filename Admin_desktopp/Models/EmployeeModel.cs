using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_desktopp.Models
{
    public partial class EmployeeModel
    {
        Holiday_bookingsEntities db = new Holiday_bookingsEntities();

        // @desc Adds new employee to database
        public void add_employee(String name, String email, String password, String employee_role, String department, String system_role)
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

        // @desc Assigns employee to a specific role
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
        public void get_system_role(String email)
        {

        }




    }
}
