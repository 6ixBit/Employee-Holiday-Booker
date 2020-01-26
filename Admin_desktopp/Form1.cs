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
            Database my_db = new Database(); //Make instance of database class

            try
            {
                if (my_db.login_user(username_textBox.Text, password_textBox.Text) == true)
                {
                    //Hide login form on successful Authentication
                    login_Panel.Hide();
                }

            } catch (Exception err)
            {
                failed_login_Label.Visible = true;
                Console.WriteLine("Failed to login: " + err);
            }
            
        }
    }

    public class Database
    {
        public bool login_user(string username, string password)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\Users\The Emperor\source\repos\6ixBit\COMP-1690\employee_db.mdb"; //Needs to be changed to relative path.

            string login_query = $"SELECT email, password FROM Employee WHERE email = '{username}' AND password = '{password}';";
            OleDbCommand myCommand = new OleDbCommand(login_query, connection); 

            try
            { // Attempt to connect to database
                connection.Open();

                if (myCommand.ExecuteNonQuery() == 0)
                {
                    // Error occured
                    return false;
                }

                // TODO: Add check to ensure there was a match in the database. - FIX NEEDED
                Console.WriteLine("Query was executed successfully");
                return true;

            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            } finally { connection.Close(); }
        }
    }
}
