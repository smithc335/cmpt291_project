using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_Project
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Form1()
        {
            InitializeComponent();

            ///////////////////////////////
            //operation.Items.Clear();
            //operation.Items.Add("Show all");
            //operation.Items.Add("Show with starting grade: ");
            //////////////////////////////////
            ///
            //String connectionString = "Server = DESKTOP-EK1AC4K; Database = MovieRentalSystem; Trusted_Connection = yes;";


            /* Starting the connection */
            SqlConnection myConnection = new SqlConnection("user id=movieadmin;" + // Username
                                         "password=1234;" + // Password
                                         "server=localhost;" + // IP for the server
                                         "Trusted_Connection=yes;" +
                                         "database=MovieRentalSystem; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds

            //SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            // Hiding tab pages on initialization
            MovieRentalTabControl.TabPages.Remove(CustomersTabPage);
            MovieRentalTabControl.TabPages.Remove(MoviesTabPage);
            MovieRentalTabControl.TabPages.Remove(RentalsTabPage);
            MovieRentalTabControl.TabPages.Remove(ReportsTabPage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Hash Code Implementation for User Password
            string userPassword;
            byte[] tmpSource;
            byte[] passwordHash;

            userPassword = PasswordTextbox.Text;
            // Create a byte array from inputted password
            tmpSource = ASCIIEncoding.ASCII.GetBytes(userPassword);

            // Compute hash based on inputted password
            passwordHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            //Console.WriteLine(ByteArrayToString(passwordHash));

            // Check whether hash matches entry in database
            myCommand.CommandText = "select PasswordHash from UserLogin where Username = '" + UsernameTextbox.Text + "'";

            // Set incorrect message before executing query
            LoginResultLabel.Text = "Username and/or password is incorrect.";

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    int col = myReader.GetOrdinal("PasswordHash");

                    // Checks password hash with inputted password hash and prints a message.
                    if (myReader.GetString(col) == ByteArrayToString(passwordHash))
                    {
                        LoginResultLabel.Text = "You have been logged in successfully.";

                        // Bringing back tab pages on successful log in
                        // WILL DUPLICATE TABS IF LOGIN BUTTON CLICKED TWICE
                        MovieRentalTabControl.TabPages.Insert(1, CustomersTabPage);
                        MovieRentalTabControl.TabPages.Insert(2, MoviesTabPage);
                        MovieRentalTabControl.TabPages.Insert(3, RentalsTabPage);
                        MovieRentalTabControl.TabPages.Insert(4, ReportsTabPage);
                    }
                }

                LoginResultLabel.Visible = true;
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        // Hash Code Function
        private static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        private void MoveToSearchButton_Click(object sender, EventArgs e)
        {
            SearchCustomerPanel.Visible = true;
            AddCustomerPanel.Visible = false;
        }

        private void MoveToAddButton_Click(object sender, EventArgs e)
        {
            AddCustomerPanel.Visible = true;
            SearchCustomerPanel.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Customer where FirstName = '" + SearchTextBox.Text + "'";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                Customer.Rows.Clear();
                while (myReader.Read())
                {
                    Customer.Rows.Add(myReader["CustomerID"].ToString(), myReader["name"].ToString(), myReader["grade"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
    }
}
