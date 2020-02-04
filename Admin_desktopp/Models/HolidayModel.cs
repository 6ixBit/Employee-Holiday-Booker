using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_desktopp.Models
{
    public class HolidayModel
    {
        Holiday_bookingsEntities db = new Holiday_bookingsEntities();

        public void get_all_holiday_requests()
        {
            // var Registration = dc.registration.Select(reg => reg);
            var holiday = db.Holidays.Select(row => row).ToList();
            Console.WriteLine(holiday);


        }
    }
}
