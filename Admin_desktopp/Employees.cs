using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_desktopp
{
    public class Employees
    {
        private string email;
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
            get { return holiday_days_available;  }
            set { holiday_days_available = value; }
        }

        public override string ToString()
        {
            return $"{Email} - {Name_} - {Employee_role} - {System_role} - {Join_date} - {Holiday_days_available}";
        }
    }
}
