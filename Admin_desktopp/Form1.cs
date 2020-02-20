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
        string selected_emp_email;
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
            holiday_Panel.Hide();
        }

        private void view_users_btn_Click(object sender, EventArgs e)
        {
            EmployeeModel em = new EmployeeModel();

            // Refresh results on button click
            Employee_dataGrid.Rows.Clear();
            Employee_dataGrid.Refresh();

            // Fetch results from database
            List<Employees> all_employees = em.get_all_employees();

            // Append results row by row
            foreach (var emp in all_employees)
            {
                Employee_dataGrid.Rows.Add(emp.Email, emp.Name_, emp.Employee_role, emp.Department, emp.System_role, emp.Join_date);
            }
            // Hide any other panels and show clicked one
            holiday_Panel.Hide();
            main_Panel.Show();
        }

        private void view_holidays_button_Click(object sender, EventArgs e)
        {
            HolidayModel hm = new HolidayModel();

            // Clear rows to avoid dup;icates upon button click
            Holiday_dataGrid.Rows.Clear();
            Holiday_dataGrid.Refresh();

            // Fetch results from database
            List<Holidays> outstanding_holidays = hm.get_outstanding_holiday_requests();

            // Append results row by row
            foreach (var hol in outstanding_holidays)
            {
                // To parse employee id to email - FIX NEEDED when passing value to function, returns empty.
                // EmployeeModel em = new EmployeeModel();
                // var email = em.get_employee(hol.Employee_ID);

                Holiday_dataGrid.Rows.Add(hol.Employee_ID, hol.Holiday_start, hol.Holiday_end, hol.Holiday_status, hol.Constraints_broken);
            }
            // Hide any other panels and show clicked one
            main_Panel.Hide();
            holiday_Panel.Show();
        }

        private void button_create_emp_Click(object sender, EventArgs e)
        {
            // Spawn add user form on button click
            var create_user = new create_employee_form();
            create_user.Show();
        }

        private void Employee_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set index on clicked event
            int index = e.RowIndex;

            // Map row clicked on to a variable
            DataGridViewRow selectedrow = Employee_dataGrid.Rows[index];

            // Store email of selected user
            string selected_user = selectedrow.Cells[0].Value.ToString();

            textBox1.Text = selected_user;
            textBox2.Text = selectedrow.Cells[1].Value.ToString();

            // Test
            selected_emp_email = selectedrow.Cells[0].Value.ToString();
        }

        private void button_delete_employee_Click(object sender, EventArgs e)
        {
            bool check_value = string.IsNullOrEmpty(selected_emp_email);

            if (check_value == true)
            {
                // IF empty then display something else
                MessageBox.Show("No user has been selected", "Action failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                DialogResult delete_user = MessageBox.Show($"Are you sure you want to delete: {selected_emp_email}", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (delete_user == DialogResult.Yes)
                {
                    // IF user selects yes then delete employee
                    EmployeeModel em = new EmployeeModel();
                    em.delete_employee(selected_emp_email);
                }
            }
        }
    }
}
