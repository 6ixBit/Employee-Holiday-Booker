using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Admin_desktopp.Models;

namespace Admin_desktopp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            EmployeeModel em = new EmployeeModel();

            em.get_all_employees();
       
            try
            {         
                if (em.login_employee(username_textBox.Text, password_textBox.Text) == false)
                {   // IF login fails  
                    failed_login_Label.Visible = true;
                }

                // Hide login panels and show main app
                login_Panel.Hide();
                main_Panel.Show();

                // Spawn data grids


            } catch (Exception err)
            { 
                Console.WriteLine("Failed to login: " + err);
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
