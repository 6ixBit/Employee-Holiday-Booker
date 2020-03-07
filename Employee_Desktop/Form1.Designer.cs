namespace Employee_Desktop
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
            this.panel_login = new System.Windows.Forms.Panel();
            this.Login_button = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_holiday = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_empEmail = new System.Windows.Forms.Label();
            this.textBox_holStart = new System.Windows.Forms.TextBox();
            this.textBox_holEnd = new System.Windows.Forms.TextBox();
            this.button_logOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_SubmitHol = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_login_error = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.panel_holiday.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.label_login_error);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.label_Email);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Controls.Add(this.textBox_email);
            this.panel_login.Controls.Add(this.Login_button);
            this.panel_login.Location = new System.Drawing.Point(13, 13);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(774, 330);
            this.panel_login.TabIndex = 0;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(348, 235);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(333, 146);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(333, 195);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(333, 127);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(37, 13);
            this.label_Email.TabIndex = 3;
            this.label_Email.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Desktop Application";
            // 
            // panel_holiday
            // 
            this.panel_holiday.Controls.Add(this.label7);
            this.panel_holiday.Controls.Add(this.label6);
            this.panel_holiday.Controls.Add(this.label5);
            this.panel_holiday.Controls.Add(this.button_SubmitHol);
            this.panel_holiday.Controls.Add(this.label4);
            this.panel_holiday.Controls.Add(this.button_logOut);
            this.panel_holiday.Controls.Add(this.textBox_holEnd);
            this.panel_holiday.Controls.Add(this.textBox_holStart);
            this.panel_holiday.Controls.Add(this.label_empEmail);
            this.panel_holiday.Controls.Add(this.label1);
            this.panel_holiday.Location = new System.Drawing.Point(13, 349);
            this.panel_holiday.Name = "panel_holiday";
            this.panel_holiday.Size = new System.Drawing.Size(775, 320);
            this.panel_holiday.TabIndex = 1;
            this.panel_holiday.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Email:";
            // 
            // label_empEmail
            // 
            this.label_empEmail.AutoSize = true;
            this.label_empEmail.Location = new System.Drawing.Point(129, 28);
            this.label_empEmail.Name = "label_empEmail";
            this.label_empEmail.Size = new System.Drawing.Size(35, 13);
            this.label_empEmail.TabIndex = 1;
            this.label_empEmail.Text = "label4";
            // 
            // textBox_holStart
            // 
            this.textBox_holStart.Location = new System.Drawing.Point(221, 154);
            this.textBox_holStart.Name = "textBox_holStart";
            this.textBox_holStart.Size = new System.Drawing.Size(100, 20);
            this.textBox_holStart.TabIndex = 2;
            // 
            // textBox_holEnd
            // 
            this.textBox_holEnd.Location = new System.Drawing.Point(421, 154);
            this.textBox_holEnd.Name = "textBox_holEnd";
            this.textBox_holEnd.Size = new System.Drawing.Size(100, 20);
            this.textBox_holEnd.TabIndex = 3;
            // 
            // button_logOut
            // 
            this.button_logOut.Location = new System.Drawing.Point(672, 281);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(83, 22);
            this.button_logOut.TabIndex = 4;
            this.button_logOut.Text = "Log Out";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Submit a Holiday request";
            // 
            // button_SubmitHol
            // 
            this.button_SubmitHol.Location = new System.Drawing.Point(321, 226);
            this.button_SubmitHol.Name = "button_SubmitHol";
            this.button_SubmitHol.Size = new System.Drawing.Size(102, 23);
            this.button_SubmitHol.TabIndex = 6;
            this.button_SubmitHol.Text = "Submit Holiday";
            this.button_SubmitHol.UseVisualStyleBackColor = true;
            this.button_SubmitHol.Click += new System.EventHandler(this.button_SubmitHol_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Holiday start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Holiday end";
            // 
            // label_login_error
            // 
            this.label_login_error.AutoSize = true;
            this.label_login_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_error.ForeColor = System.Drawing.Color.Red;
            this.label_login_error.Location = new System.Drawing.Point(338, 274);
            this.label_login_error.Name = "label_login_error";
            this.label_login_error.Size = new System.Drawing.Size(95, 16);
            this.label_login_error.TabIndex = 6;
            this.label_login_error.Text = "Failed to login!";
            this.label_login_error.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(87, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Format: YYYY-MM-DD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 688);
            this.Controls.Add(this.panel_holiday);
            this.Controls.Add(this.panel_login);
            this.Name = "Form1";
            this.Text = "Employee Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_holiday.ResumeLayout(false);
            this.panel_holiday.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Panel panel_holiday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_SubmitHol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.TextBox textBox_holEnd;
        private System.Windows.Forms.TextBox textBox_holStart;
        private System.Windows.Forms.Label label_empEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_login_error;
        private System.Windows.Forms.Label label7;
    }
}

