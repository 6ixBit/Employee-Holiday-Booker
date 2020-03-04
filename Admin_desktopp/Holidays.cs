using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_desktopp
{
    public class Holidays
    {
        private int employee_id;
        public int holiday_id;
        private DateTime holiday_start;
        private DateTime holiday_end;
        private String holiday_status;
        private bool days_exceeded;
        private bool head_depHead_absent;
        private bool seniorStaff_absent;
        private bool Department_absent;

        public Holidays(int employee_id, int holiday_id, DateTime holiday_start, DateTime holiday_end, String holiday_status, bool days_exceeded, bool head_depHead_absent, bool seniorStaff_absent, bool Department_absent)
        {
            this.employee_id = employee_id;
            this.holiday_id = holiday_id;
            this.holiday_start = holiday_start;
            this.holiday_end = holiday_end;
            this.holiday_status = holiday_status;
            this.days_exceeded = days_exceeded;
            this.head_depHead_absent = head_depHead_absent;
            this.Department_absent = Department_absent;
            this.seniorStaff_absent = seniorStaff_absent;

        }

        public Holidays() {}

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

        public Boolean Days_exceeded
        {
            get { return days_exceeded; }
            set { days_exceeded = value; }
        }

        public Boolean Head_depHead_absent
        {
            get { return head_depHead_absent; }
            set { head_depHead_absent = value; }
        }

        public Boolean department_Absent
        {
            get { return Department_absent; }
            set { Department_absent = value; }
        }

        public Boolean SeniorStaff_absent
        {
            get { return seniorStaff_absent; }
            set { seniorStaff_absent = value; }
        }

        public override string ToString()
        {
            return $"{Holiday_ID} - {Employee_ID} - {Holiday_start} - {Holiday_end} - {Holiday_status} - {Days_exceeded}";
        }

    }
}
