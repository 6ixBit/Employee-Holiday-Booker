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
    public partial class Edit_employee : Form
    {
        public Edit_employee()
        {
            InitializeComponent();
        }

        private void Edit_employee_Load(object sender, EventArgs e)
        {
            // Static roles for users
            string[] system_roles = new string[] { "Admin", "User" };

            string[] department = new string[] { "Engineering", "Plumbing", "Roofing", "Carpentry", "Bricklaying", "Office" };

            string[] employee_roles = new string[] { "Head", "Deputy Head", "Manager", "Apprentice", "Junior Member", "Senior Member" };


            // Add roles to Combo boxes
            foreach (var sys_role in system_roles)
            {
                comboBox_edit_sysRole.Items.Add(sys_role);
            }

            foreach (var emp_role in employee_roles)
            {
                comboBox_edit_emp_role.Items.Add(emp_role);
            }

            foreach (var deprt in department)
            {
                comboBox_edit_department.Items.Add(deprt);
            }

            // Make combo boxes uneditable
            comboBox_edit_department.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_edit_emp_role.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_edit_sysRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string old_user_email = textBox_edit_email.Text;

            EmployeeModel em = new EmployeeModel();
            var old_employee = em.get_employee_byEmail(old_user_email);

            try
            {
                // Modify user details
                em.edit_employee_email(old_employee.Email, textBox_edit_email.Text);
                em.edit_employee_name(old_employee.Email, textBox_edit_name.Text);
                em.edit_employee_password(old_employee.Email, textBox_edit_password.Text);
                em.edit_system_role(old_employee.Email, comboBox_edit_sysRole.Text);
                em.edit_employee_department(old_employee.Email, comboBox_edit_department.Text);

                MessageBox.Show("User was successfully modified");
            } catch (Exception es)
            {
                Console.WriteLine(es);
                MessageBox.Show($"Failed to edit user: {old_user_email}", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
