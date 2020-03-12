using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_login_Click(object sender, EventArgs e)
        {
            // Initialise connection as client to SOAP service.
            Employee_WebApp.WebAppServiceReference.TheWebServiceSoapClient client = new WebAppServiceReference.TheWebServiceSoapClient();

            try
            {
                // Attempt to login with form data
                if (client.login_employee(TextBox_email.Text, TextBox_password.Text) == false)
                {
                    // IF it failed then show error to notify user of system status.
                    Response.Write("Failed to log you in");
                }
                else
                { // IF login was successful
                    Session["CurrentUser"] = TextBox_email.Text; // Start a session

                    // Redirect to holiday page on successful login
                    Response.Redirect("SubmitHoliday.aspx");
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es);
            }


        }
    }
}