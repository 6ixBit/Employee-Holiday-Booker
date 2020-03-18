using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_WebApp
{
    public partial class SubmitHoliday : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_submitHoliday_Click(object sender, EventArgs e)
        {
            // Initialise connection as client to SOAP service.
            Employee_WebApp.WebAppServiceReference.TheWebServiceSoapClient client = new WebAppServiceReference.TheWebServiceSoapClient();

            // On Submission of holiday do stuff
            try
            {
                // Submit user holiday request on submit button click
                client.submit_holiday_with_constraint_checking(Session["CurrentUser"].ToString(), Convert.ToDateTime(TextBox_holidayStart.Text), Convert.ToDateTime(TextBox_holidayEnd.Text));

                // Clear textboxes on successful submission
                TextBox_holidayStart.Text = "";
                TextBox_holidayEnd.Text = "";

                Response.Write("<script> alert('Your holiday was successfully submitted!'); </script>");
            }
            catch (Exception es)
            {
                // Show an error if it failed.
                Response.Write("<script> alert('Failed to submit holiday, please check the format of the dates you entered!'); </script>");
                Console.WriteLine(es);
            }
        }

        protected void Button_viewHol_Click(object sender, EventArgs e)
        {
            // Direct to View holiday screen
            Response.Redirect("ViewHolidays.aspx");
        }
    }
}