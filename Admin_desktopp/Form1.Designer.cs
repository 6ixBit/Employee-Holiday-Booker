namespace Admin_desktopp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.username_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.login_Panel = new System.Windows.Forms.Panel();
            this.failed_login_Label = new System.Windows.Forms.Label();
            this.main_Panel = new System.Windows.Forms.Panel();
            this.button_delete_employee = new System.Windows.Forms.Button();
            this.button_edit_employee = new System.Windows.Forms.Button();
            this.button_create_emp = new System.Windows.Forms.Button();
            this.user_panel_label = new System.Windows.Forms.Label();
            this.Employee_dataGrid = new System.Windows.Forms.DataGridView();
            this.Email_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeRole_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemRole_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_holidays_button = new System.Windows.Forms.Button();
            this.view_users_btn = new System.Windows.Forms.Button();
            this.UI_panel = new System.Windows.Forms.Panel();
            this.holiday_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Holiday_dataGrid = new System.Windows.Forms.DataGridView();
            this.EmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolidayStart_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolidayEnd_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolidayStatus_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstraintsBroken_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holiday_panel_label = new System.Windows.Forms.Label();
            this.login_Panel.SuspendLayout();
            this.main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGrid)).BeginInit();
            this.UI_panel.SuspendLayout();
            this.holiday_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Holiday_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(123, 124);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(88, 23);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(120, 85);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(100, 20);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(120, 30);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(100, 20);
            this.username_textBox.TabIndex = 3;
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Location = new System.Drawing.Point(117, 14);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(35, 13);
            this.username_Label.TabIndex = 4;
            this.username_Label.Text = "Email:";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(120, 69);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(53, 13);
            this.password_Label.TabIndex = 5;
            this.password_Label.Text = "Password";
            // 
            // login_Panel
            // 
            this.login_Panel.Controls.Add(this.failed_login_Label);
            this.login_Panel.Controls.Add(this.username_textBox);
            this.login_Panel.Controls.Add(this.username_Label);
            this.login_Panel.Controls.Add(this.password_Label);
            this.login_Panel.Controls.Add(this.password_textBox);
            this.login_Panel.Controls.Add(this.login_button);
            this.login_Panel.Location = new System.Drawing.Point(757, 48);
            this.login_Panel.Name = "login_Panel";
            this.login_Panel.Size = new System.Drawing.Size(338, 194);
            this.login_Panel.TabIndex = 6;
            // 
            // failed_login_Label
            // 
            this.failed_login_Label.AutoSize = true;
            this.failed_login_Label.ForeColor = System.Drawing.Color.Red;
            this.failed_login_Label.Location = new System.Drawing.Point(56, 163);
            this.failed_login_Label.Name = "failed_login_Label";
            this.failed_login_Label.Size = new System.Drawing.Size(262, 13);
            this.failed_login_Label.TabIndex = 6;
            this.failed_login_Label.Text = "Failed to login, the details you enetered are inncorrect!";
            this.failed_login_Label.Visible = false;
            // 
            // main_Panel
            // 
            this.main_Panel.Controls.Add(this.button_delete_employee);
            this.main_Panel.Controls.Add(this.button_edit_employee);
            this.main_Panel.Controls.Add(this.button_create_emp);
            this.main_Panel.Controls.Add(this.user_panel_label);
            this.main_Panel.Controls.Add(this.Employee_dataGrid);
            this.main_Panel.Location = new System.Drawing.Point(12, 12);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(1187, 397);
            this.main_Panel.TabIndex = 7;
            this.main_Panel.Visible = false;
            // 
            // button_delete_employee
            // 
            this.button_delete_employee.Location = new System.Drawing.Point(322, 350);
            this.button_delete_employee.Name = "button_delete_employee";
            this.button_delete_employee.Size = new System.Drawing.Size(100, 23);
            this.button_delete_employee.TabIndex = 12;
            this.button_delete_employee.Text = "Delete Employee";
            this.button_delete_employee.UseVisualStyleBackColor = true;
            this.button_delete_employee.Click += new System.EventHandler(this.button_delete_employee_Click);
            // 
            // button_edit_employee
            // 
            this.button_edit_employee.Location = new System.Drawing.Point(191, 350);
            this.button_edit_employee.Name = "button_edit_employee";
            this.button_edit_employee.Size = new System.Drawing.Size(90, 23);
            this.button_edit_employee.TabIndex = 11;
            this.button_edit_employee.Text = "Edit Employee";
            this.button_edit_employee.UseVisualStyleBackColor = true;
            this.button_edit_employee.Click += new System.EventHandler(this.button_edit_employee_Click);
            // 
            // button_create_emp
            // 
            this.button_create_emp.Location = new System.Drawing.Point(43, 350);
            this.button_create_emp.Name = "button_create_emp";
            this.button_create_emp.Size = new System.Drawing.Size(112, 23);
            this.button_create_emp.TabIndex = 8;
            this.button_create_emp.Text = "Create Employee";
            this.button_create_emp.UseVisualStyleBackColor = true;
            this.button_create_emp.Click += new System.EventHandler(this.button_create_emp_Click);
            // 
            // user_panel_label
            // 
            this.user_panel_label.AutoSize = true;
            this.user_panel_label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_panel_label.Location = new System.Drawing.Point(9, 15);
            this.user_panel_label.Name = "user_panel_label";
            this.user_panel_label.Size = new System.Drawing.Size(154, 28);
            this.user_panel_label.TabIndex = 7;
            this.user_panel_label.Text = "All Employees";
            // 
            // Employee_dataGrid
            // 
            this.Employee_dataGrid.AllowUserToAddRows = false;
            this.Employee_dataGrid.AllowUserToDeleteRows = false;
            this.Employee_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email_,
            this.Name_,
            this.EmployeeRole_,
            this.Department_,
            this.SystemRole_,
            this.JoinDate_});
            this.Employee_dataGrid.Location = new System.Drawing.Point(14, 61);
            this.Employee_dataGrid.Name = "Employee_dataGrid";
            this.Employee_dataGrid.ReadOnly = true;
            this.Employee_dataGrid.Size = new System.Drawing.Size(642, 228);
            this.Employee_dataGrid.TabIndex = 0;
            this.Employee_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_dataGrid_CellContentClick);
            // 
            // Email_
            // 
            this.Email_.HeaderText = "Email";
            this.Email_.Name = "Email_";
            this.Email_.ReadOnly = true;
            // 
            // Name_
            // 
            this.Name_.HeaderText = "Name";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            // 
            // EmployeeRole_
            // 
            this.EmployeeRole_.HeaderText = "Employee Role";
            this.EmployeeRole_.Name = "EmployeeRole_";
            this.EmployeeRole_.ReadOnly = true;
            // 
            // Department_
            // 
            this.Department_.HeaderText = "Department";
            this.Department_.Name = "Department_";
            this.Department_.ReadOnly = true;
            // 
            // SystemRole_
            // 
            this.SystemRole_.HeaderText = "System Role";
            this.SystemRole_.Name = "SystemRole_";
            this.SystemRole_.ReadOnly = true;
            // 
            // JoinDate_
            // 
            this.JoinDate_.HeaderText = "Join Date";
            this.JoinDate_.Name = "JoinDate_";
            this.JoinDate_.ReadOnly = true;
            // 
            // view_holidays_button
            // 
            this.view_holidays_button.Location = new System.Drawing.Point(94, 7);
            this.view_holidays_button.Name = "view_holidays_button";
            this.view_holidays_button.Size = new System.Drawing.Size(82, 23);
            this.view_holidays_button.TabIndex = 7;
            this.view_holidays_button.Text = "View Holidays";
            this.view_holidays_button.UseVisualStyleBackColor = true;
            this.view_holidays_button.Click += new System.EventHandler(this.view_holidays_button_Click);
            // 
            // view_users_btn
            // 
            this.view_users_btn.Location = new System.Drawing.Point(13, 7);
            this.view_users_btn.Name = "view_users_btn";
            this.view_users_btn.Size = new System.Drawing.Size(75, 23);
            this.view_users_btn.TabIndex = 8;
            this.view_users_btn.Text = "View Users";
            this.view_users_btn.UseVisualStyleBackColor = true;
            this.view_users_btn.Click += new System.EventHandler(this.view_users_btn_Click);
            // 
            // UI_panel
            // 
            this.UI_panel.Controls.Add(this.view_users_btn);
            this.UI_panel.Controls.Add(this.view_holidays_button);
            this.UI_panel.Location = new System.Drawing.Point(478, 415);
            this.UI_panel.Name = "UI_panel";
            this.UI_panel.Size = new System.Drawing.Size(190, 33);
            this.UI_panel.TabIndex = 9;
            this.UI_panel.Visible = false;
            // 
            // holiday_Panel
            // 
            this.holiday_Panel.Controls.Add(this.label1);
            this.holiday_Panel.Controls.Add(this.Holiday_dataGrid);
            this.holiday_Panel.Controls.Add(this.holiday_panel_label);
            this.holiday_Panel.Location = new System.Drawing.Point(18, 486);
            this.holiday_Panel.Name = "holiday_Panel";
            this.holiday_Panel.Size = new System.Drawing.Size(1181, 279);
            this.holiday_Panel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Outstanding requests";
            // 
            // Holiday_dataGrid
            // 
            this.Holiday_dataGrid.AllowUserToAddRows = false;
            this.Holiday_dataGrid.AllowUserToDeleteRows = false;
            this.Holiday_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Holiday_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeEmail,
            this.HolidayStart_,
            this.HolidayEnd_,
            this.HolidayStatus_,
            this.ConstraintsBroken_});
            this.Holiday_dataGrid.Location = new System.Drawing.Point(8, 115);
            this.Holiday_dataGrid.Name = "Holiday_dataGrid";
            this.Holiday_dataGrid.ReadOnly = true;
            this.Holiday_dataGrid.Size = new System.Drawing.Size(545, 139);
            this.Holiday_dataGrid.TabIndex = 8;
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.HeaderText = "Email";
            this.EmployeeEmail.Name = "EmployeeEmail";
            this.EmployeeEmail.ReadOnly = true;
            // 
            // HolidayStart_
            // 
            this.HolidayStart_.HeaderText = "Holiday Start";
            this.HolidayStart_.Name = "HolidayStart_";
            this.HolidayStart_.ReadOnly = true;
            // 
            // HolidayEnd_
            // 
            this.HolidayEnd_.HeaderText = "Holiday End";
            this.HolidayEnd_.Name = "HolidayEnd_";
            this.HolidayEnd_.ReadOnly = true;
            // 
            // HolidayStatus_
            // 
            this.HolidayStatus_.HeaderText = "Holiday Status";
            this.HolidayStatus_.Name = "HolidayStatus_";
            this.HolidayStatus_.ReadOnly = true;
            // 
            // ConstraintsBroken_
            // 
            this.ConstraintsBroken_.HeaderText = "Constraints Broken";
            this.ConstraintsBroken_.Name = "ConstraintsBroken_";
            this.ConstraintsBroken_.ReadOnly = true;
            // 
            // holiday_panel_label
            // 
            this.holiday_panel_label.AutoSize = true;
            this.holiday_panel_label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holiday_panel_label.Location = new System.Drawing.Point(3, 10);
            this.holiday_panel_label.Name = "holiday_panel_label";
            this.holiday_panel_label.Size = new System.Drawing.Size(204, 28);
            this.holiday_panel_label.TabIndex = 0;
            this.holiday_panel_label.Text = "Employee Holidays";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 806);
            this.Controls.Add(this.login_Panel);
            this.Controls.Add(this.holiday_Panel);
            this.Controls.Add(this.UI_panel);
            this.Controls.Add(this.main_Panel);
            this.Name = "Form1";
            this.Text = "Admin desktop for holiday bookings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_Panel.ResumeLayout(false);
            this.login_Panel.PerformLayout();
            this.main_Panel.ResumeLayout(false);
            this.main_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGrid)).EndInit();
            this.UI_panel.ResumeLayout(false);
            this.holiday_Panel.ResumeLayout(false);
            this.holiday_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Holiday_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.Panel login_Panel;
        private System.Windows.Forms.Label failed_login_Label;
        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.DataGridView Employee_dataGrid;
        private System.Windows.Forms.Button view_holidays_button;
        private System.Windows.Forms.Button view_users_btn;
        private System.Windows.Forms.Label user_panel_label;
        private System.Windows.Forms.Panel UI_panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeRole_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemRole_;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDate_;
        private System.Windows.Forms.Panel holiday_Panel;
        private System.Windows.Forms.Label holiday_panel_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Holiday_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolidayStart_;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolidayEnd_;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolidayStatus_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstraintsBroken_;
        private System.Windows.Forms.Button button_create_emp;
        private System.Windows.Forms.Button button_edit_employee;
        private System.Windows.Forms.Button button_delete_employee;
    }
}

