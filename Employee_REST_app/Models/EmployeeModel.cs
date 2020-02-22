using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_REST_app.Models
{
    public class EmployeeModel
    {
        Holiday_bookingsEntities db = new Holiday_bookingsEntities();

        //@desc Checks user login info against db records
        public bool login_employee(String email, String password)
        {
            Employee employee = db.Employees.FirstOrDefault(user => user.email == email && user.password == password);
    
            if (employee != null)
            { // IF login was successful
                Console.WriteLine(employee.email);
                Console.WriteLine(employee.password);
                Console.WriteLine(employee.Employee_ID);
                Console.WriteLine(employee.join_date);
                return true;
            }
            return false;
        }

        // @desc Returns employee info if email is matched
        public void get_employee(String employee_email)
        { //: TODO Add try catch to handle errors
            Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);
        }

        // @desc Returns info about user if email is matched
        public int get_employee_id(String employee_email)
        { //: TODO Add try catch to handle errors
            try
            {
                Employee employee = db.Employees.FirstOrDefault(e => e.email == employee_email);
                return employee.Employee_ID;
            } catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e);
                return 0;
            }
            
        }

    }
}