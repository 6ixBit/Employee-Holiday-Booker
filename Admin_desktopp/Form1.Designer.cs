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
            this.login_Panel.SuspendLayout();
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
            this.login_Panel.Location = new System.Drawing.Point(284, 109);
            this.login_Panel.Name = "login_Panel";
            this.login_Panel.Size = new System.Drawing.Size(331, 195);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 414);
            this.Controls.Add(this.login_Panel);
            this.Name = "Form1";
            this.Text = "Admin desktop for holiday bookings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_Panel.ResumeLayout(false);
            this.login_Panel.PerformLayout();
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
    }
}

