using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Desktop
{
    public partial class Form1 : Form
    {
        // Initialise connection as client to service.
        Employee_Desktop.ServiceReference1.TheWebServiceSoapClient client = new ServiceReference1.TheWebServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to login with form data
                if(client.login_employee(textBox_email.Text, textBox_password.Text) == false)
                {
                    // IF it failed then show error label to notify user of system status.
                    label_login_error.Show();
                } else
                { // IF login was successful
                    panel_login.Hide();
                    panel_holiday.Show();

                    // Set label of employee to thier email address if login is successful
                    label_empEmail.Text = textBox_email.Text;
                }
            } catch (Exception es)
            {
                Console.WriteLine(es);
            }
        }

        private void button_SubmitHol_Click(object sender, EventArgs e)
        {
            try
            {
                // Submit user holiday request on submit button click
                client.submit_holiday_request(textBox_email.Text, Convert.ToDateTime(textBox_holStart.Text), Convert.ToDateTime(textBox_holEnd.Text), "Pending", false, false, false, false);
                
                // Clear textboxes 
                textBox_holStart.Text = "";
                textBox_holEnd.Text = "";

                // Alert user on system status
                MessageBox.Show("Your holiday request has been successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception es)
            {
                MessageBox.Show("Failed to submit holiday", "Submission failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(es);
            }  
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            // Clear textboxes 
            textBox_holStart.Text = "";
            textBox_holEnd.Text = "";

            textBox_password.Text = "";

            // Swap panels around
            panel_holiday.Hide();
            panel_login.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
