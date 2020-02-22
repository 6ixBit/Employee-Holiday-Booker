using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_REST_app.Models
{
    public class Holidays
    {
        private int employee_id;
        public int holiday_id;
        private DateTime holiday_start;
        private DateTime holiday_end;
        private String holiday_status;
        private bool constraints_broken;

        public Holidays(int employee_id, int holiday_id, DateTime holiday_start, DateTime holiday_end, String holiday_status, bool constraints_broken)
        {
            this.employee_id = employee_id;
            this.holiday_id = holiday_id;
            this.holiday_start = holiday_start;
            this.holiday_end = holiday_end;
            this.holiday_status = holiday_status;
            this.constraints_broken = constraints_broken;
        }

        public Holidays() { }

        public int Employee_ID
        {
            get { return employee_id; }
            set { employee_id = value; }
        }

        public int Holiday_ID
        {
            get { return holiday_id; }
            set { holiday_id = value; }
        }

        public DateTime Holiday_start
        {
            get { return holiday_start; }
            set { holiday_start = value; }
        }

        public DateTime Holiday_end
        {
            get { return holiday_end; }
            set { holiday_end = value; }
        }

        public String Holiday_status
        {
            get { return holiday_status; }
            set { holiday_status = value; }
        }

        public Boolean Constraints_broken
        {
            get { return constraints_broken; }
            set { constraints_broken = value; }
        }

        public override string ToString()
        {
            return $"{Holiday_ID} - {Employee_ID} - {Holiday_start} - {Holiday_end} - {Holiday_status}";
        }
    }
}