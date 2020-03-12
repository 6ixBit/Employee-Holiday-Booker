using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_WebApp
{
    public partial class ViewHolidays : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialise connection as client to SOAP service.
            Employee_WebApp.WebAppServiceReference.TheWebServiceSoapClient client = new WebAppServiceReference.TheWebServiceSoapClient();

            // Get holidays for user using the session started on login.
            var holidays = client.get_outstanding_holiday_requests_for_employee(Session["CurrentUser"].ToString());

            // Display data in table.
            foreach (var holiday in holidays)
            {
                //  Define a row to host the the data
                TableRow row = new TableRow();

                // Cells for each column 
                TableCell Firstcell = new TableCell();
                TableCell SecondCell = new TableCell();
                TableCell ThirdCell = new TableCell();

                // Set text for each holiday
                Firstcell.Text = $"{holiday.Holiday_start}";
                SecondCell.Text = $"{holiday.Holiday_end}";
                ThirdCell.Text = $"{holiday.Holiday_status}";

                // Add the populated cell to this row
                row.Cells.Add(Firstcell);
                row.Cells.Add(SecondCell);
                row.Cells.Add(ThirdCell);

                // Add modified row to table.
                Table1.Rows.Add(row);
            }
        }

        protected void GridView_holidays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}