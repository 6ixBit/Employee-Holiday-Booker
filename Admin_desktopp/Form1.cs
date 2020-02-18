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

            try
            {         
                if (em.login_employee(username_textBox.Text, password_textBox.Text) == false)
                {   // IF login fails  
                    failed_login_Label.Visible = true;
                } else
                {
                    // Hide login panels and show main app
                    login_Panel.Hide();
                    main_Panel.Show();
                    UI_panel.Show();

                    // Data grid config
                    Employee_dataGrid.AutoGenerateColumns = false;

                    // Fetch results from database
                    List<Employees> all_employees = em.get_all_employees();

                    // Append results row by row
                    foreach (var emp in all_employees)
                    {
                        Employee_dataGrid.Rows.Add(emp.Email, emp.Name_, emp.Employee_role, emp.Department, emp.System_role, emp.Join_date);
                    }
                }

            } catch (Exception err)
            { 
                Console.WriteLine("Failed to login: " + err);
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main_Panel.Hide();

        }
    }
}
