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

        private static string ByteArrayToString(byte[] arrInput) // Hash Code Function
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
            ViewCustomerPanel.Visible = false;
        }

        private void MoveToAddButton_Click(object sender, EventArgs e)
        {
            AddCustomerPanel.Visible = true;
            SearchCustomerPanel.Visible = false;
            ViewCustomerPanel.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (FirstNameRadioButton.Checked)
            {
                myCommand.CommandText = "select * from Customer where FirstName = '" + SearchTextBox.Text + "'";
            }
            else if (LastNameRadioButton.Checked)
            {
                myCommand.CommandText = "select * from Customer where LastName = '" + SearchTextBox.Text + "'";
            }
            else
            {
                myCommand.CommandText = "select * from Customer where EmailAddress = '" + SearchTextBox.Text + "'";
            }

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                Customer.Rows.Clear();
                while (myReader.Read())
                {
                    Customer.Rows.Add(myReader["CustomerID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["EmailAddress"].ToString(), myReader["AcctNum"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            int selectedCellCount = Customer.GetCellCount(DataGridViewElementStates.Selected);

            //if (selectedCellCount != 7)
            //{
            //    MessageBox.Show("Please select a complete customer record to proceed.");
            //}
            //else
            //{
            ViewCustomerPanel.Visible = true;
            AddCustomerPanel.Visible = false;
            SearchCustomerPanel.Visible = false;

            myCommand.CommandText = "select * from Customer where CustomerID = " + Customer.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    VULastNameTextbox.Text = myReader.GetString(1);
                    VUFirstNameTextbox.Text = myReader.GetString(2);
                    VUAddressTextbox.Text = myReader.GetString(3);
                    VUCityTextbox.Text = myReader.GetString(4);
                    VUProvinceComboBox.SelectedItem = myReader.GetString(5);
                    VUPostalCodeTextbox.Text = myReader.GetString(6);
                    VUEmailTextbox.Text = myReader.GetString(7);
                    VUAcctNumTextbox.Text = myReader.GetValue(8).ToString();
                    VUCreditTextbox.Text = myReader.GetString(10);
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            //}
        }

        private void CancelViewingButton_Click(object sender, EventArgs e)
        {
            SearchCustomerPanel.Visible = true;
            ViewCustomerPanel.Visible = false;
            AddCustomerPanel.Visible = false;

            UpdateTitleLabel.Visible = false;
            ViewTitleLabel.Visible = true;

            SaveUpdatesButton.Visible = false;
            MoveToUpdateButton.Visible = true;
            DeleteCustomerButton.Visible = false;

            VUAcctNumTextbox.ReadOnly = true;
            VUAddressTextbox.ReadOnly = true;
            VUCityTextbox.ReadOnly = true;
            VUCreditTextbox.ReadOnly = true;
            VUEmailTextbox.ReadOnly = true;
            VUFirstNameTextbox.ReadOnly = true;
            VULastNameTextbox.ReadOnly = true;
            VUPostalCodeTextbox.ReadOnly = true;
            VUProvinceComboBox.Enabled = false;
        }

        private void MoveToUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateTitleLabel.Visible = true;
            ViewTitleLabel.Visible = false;

            SaveUpdatesButton.Visible = true;
            MoveToUpdateButton.Visible = false;
            DeleteCustomerButton.Visible = true;

            VUAcctNumTextbox.ReadOnly = false;
            VUAddressTextbox.ReadOnly = false;
            VUCityTextbox.ReadOnly = false;
            VUCreditTextbox.ReadOnly = false;
            VUEmailTextbox.ReadOnly = false;
            VUFirstNameTextbox.ReadOnly = false;
            VULastNameTextbox.ReadOnly = false;
            VUPostalCodeTextbox.ReadOnly = false;
            VUProvinceComboBox.Enabled = true;
        }

        private void Customer_SelectionChanged(object sender, EventArgs e)
        {
            bool isCellSelected = Customer.SelectedCells.Count > 0 && Customer.SelectedCells[0].Value != null;
            ViewDetailsButton.Enabled = isCellSelected;
        }
    }
}
