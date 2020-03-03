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
    }
}
