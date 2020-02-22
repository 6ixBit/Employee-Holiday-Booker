using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_REST_app.Models
{
    public class HolidayModel
    {
        Holiday_bookingsEntities db = new Holiday_bookingsEntities();

        // @desc Returns all holidays off a specific user
        public List<Holidays> get_employee_holidays(int employee_id)
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

        ///@desc Submit holiday request
        public void submit_holiday_request(string email, DateTime holiday_start, DateTime holiday_end, bool constraints_broken)
        {
            EmployeeModel user = new EmployeeModel();

            // Call get employee id from model to retrieve employee id of the user
            int user_id = user.get_employee_id(email);

            // Bind parameters passed to Holidays object
            Holiday new_holiday = new Holiday
            {
                Employee_ID = user_id,
                holiday_start = holiday_start,
                holiday_end = holiday_end,
                holiday_status = "Pending", // Set users status to pending, once admin has approved/rejected it will be modified 
                constraints_broken = constraints_broken
            };
            db.Holidays.Add(new_holiday);
            db.SaveChanges();
        }
    }
}