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
        private string selected_emp_email;
        private int selected_holiday;
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

            // Clear rows to avoid duplicates upon button click
            Holiday_dataGrid.Rows.Clear();
            Holiday_dataGrid.Refresh();

            // Fetch results from database
            List<Holidays> outstanding_holidays = hm.get_outstanding_holiday_requests();

            // Append results row by row
            foreach (var hol in outstanding_holidays)
            {
                Holiday_dataGrid.Rows.Add(hol.holiday_id, hol.Holiday_start, hol.Holiday_end, hol.Holiday_status, hol.Constraints_broken);
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
                    try
                    {
                        EmployeeModel em = new EmployeeModel();
                        em.delete_employee(selected_emp_email);

                        // Show message box once its been done
                        MessageBox.Show("User deleted, click on view users to update table.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception ex)
                    {
                        // If it failed alert user that the action failed
                        MessageBox.Show("Failed to delete user", "Action failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error: ", ex);
                    }
                   
                }
            }
        }

        private void button_edit_employee_Click(object sender, EventArgs e)
        {
            var edit_user = new Edit_employee();
            edit_user.Show();
        }

        public String SendDetails
        {
            get { return selected_emp_email; }
        }

        private void Holiday_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set index on clicked event
            int index = e.RowIndex;

            DataGridViewRow selectedRow = Holiday_dataGrid.Rows[index];

            // Set to global variable so it can be read
            selected_holiday = int.Parse(selectedRow.Cells[0].Value.ToString());
        }

        private void button_accept_req_Click(object sender, EventArgs e)
        {
            int selected_emp_email = int.Parse(Holiday_dataGrid.CurrentCell.Value.ToString());

            try
            {
                HolidayModel hm = new HolidayModel();
                hm.accept_holiday(selected_emp_email);

                // Update table with new results
                Holiday_dataGrid.Rows.Clear();
                Holiday_dataGrid.Refresh();
            } catch (Exception es)
            {
                Console.WriteLine(es);
                MessageBox.Show("Action failed whilst trying to alter the status of this holiday");
            }
            
        }

        private void button_decline_req_Click(object sender, EventArgs e)
        {
            int selected_emp_email = int.Parse(Holiday_dataGrid.CurrentCell.Value.ToString());
            try
            {
                HolidayModel hm = new HolidayModel();
                hm.reject_holiday(selected_emp_email);

                // Update table with new results
                Holiday_dataGrid.Refresh();
            } catch (Exception es)
            {
                Console.WriteLine(es);
                MessageBox.Show("Action failed whilst trying to alter the status of this holiday");
            }
        }
    }
}
