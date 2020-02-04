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
        HolidayBookingsEntities db = new HolidayBookingsEntities();

        public void get_all_holiday_requests()
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

            Console.WriteLine(userHolidays[0]);
            Console.WriteLine(userHolidays[1]);
            Console.WriteLine(userHolidays[2]);
        }



    }
}
