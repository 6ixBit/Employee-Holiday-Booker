using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_desktopp;

namespace Admin_desktopp.Models
{
    public class HolidayModel
    {
        readonly HolidayBookingsEntities db = new HolidayBookingsEntities();

        // @desc Returns all holiday requests 
        public List<Holidays> get_all_holiday_requests()
        {
            // Query to select all elements
            var query = (from hol in db.Holidays select hol);

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
                my_holiday.Constraints_broken = (bool)holiday.constraints_broken;

                // Add each holiday object to list
                userHolidays.Add(my_holiday);
            }
            return userHolidays;
        }

        // @desc Returns all holidays off a specific user
        public List<Holidays> get_holiday(int employee_id)
        {
            var query = (from hol in db.Holidays
                         where hol.Employee_ID == employee_id 
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
                my_holiday.Constraints_broken = (bool)holiday.constraints_broken;

                // Add each holiday object to list
                userHolidays.Add(my_holiday);
            }

            return userHolidays;
        }

        // @desc Updates holiday request to accepted status
        public void accept_holiday(int holiday_id)
        {
            Holiday holiday = db.Holidays.FirstOrDefault(h => h.Holiday_ID == holiday_id);
            holiday.holiday_status = "Accepted";
            db.SaveChanges();
        }

        // @desc Updates holiday request to rejected status
        public void reject_holiday(int holiday_id)
        {
            Holiday holiday = db.Holidays.FirstOrDefault(h => h.Holiday_ID == holiday_id);
            holiday.holiday_status = "Rejected";
            db.SaveChanges();
        }
  
        // @desc Returns employees that are not available for a particular date
        public List<int> get_employees_not_available_for_specific_date(DateTime date)
        { // FIX NEEDED, PORT TO EMPLOYEE TABLE
            var query = (from hol in db.Holidays
                         where hol.holiday_start != date
                         select hol);

            List<int> employees_not_on_holiday = new List<int>();

            foreach (var employee in query)
            {
                employees_not_on_holiday.Add((int)employee.Employee_ID);
            }
            Console.WriteLine(employees_not_on_holiday[0]);
            Console.WriteLine(employees_not_on_holiday[1]);
            Console.WriteLine(employees_not_on_holiday[2]);
            return employees_not_on_holiday;
        }

    }
}
