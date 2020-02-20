using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_desktopp.Models;

namespace Admin_desktopp
{
    public partial class create_employee_form : Form
    {
        public create_employee_form()
        {
            InitializeComponent();
        }

        private void create_employee_form_Load(object sender, EventArgs e)
        {
            // Static roles for users
            string[] system_roles = new string[] {"Admin", "User"};

            string[] department = new string[] { "Engineering", "Plumbing", "Roofing", "Carpentry", "Bricklaying", "Office" };

            string[] employee_roles = new string[] { "Head", "Deputy Head", "Manager", "Apprentice", "Junior Member", "Senior Member" };


            // Add roles to Combo boxes
            foreach (var sys_role in system_roles)
            {
                comboBox_systemRole.Items.Add(sys_role);
            }

            foreach (var emp_role in employee_roles)
            {
                comboBox_EmployeeRole.Items.Add(emp_role);
            }

            foreach (var deprt in department)
            {
                comboBox_departments.Items.Add(deprt);
            }

            // Make combo boxes uneditable
            comboBox_departments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_EmployeeRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_systemRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void submit_new_user_btn_Click(object sender, EventArgs e)
        {
            Employee new_user = new Employee
            {
                name_ = textBox_name.Text,
                email = textBox_email.Text,
                password = textBox_password.Text,
                department = (string) comboBox_departments.SelectedItem,
                system_role = (string) comboBox_systemRole.SelectedItem,
                employee_role = (string) comboBox_EmployeeRole.SelectedItem,
                join_date = DateTime.Today
            };

            // Add user to database
            EmployeeModel em = new EmployeeModel();

            try
            {
                em.add_employee(new_user.name_, new_user.email, new_user.password, new_user.employee_role, new_user.department, new_user.system_role);
                MessageBox.Show($"Successfully added new user: {new_user.email}");
                this.Close();
            } catch (Exception ex)
            {
                // Spawn message box to alert user that insert failed
                MessageBox.Show($"Failed to add new user: {ex}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
