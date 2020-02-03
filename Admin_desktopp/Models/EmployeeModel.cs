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
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);
        }








    }
}
