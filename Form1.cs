using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        public SqlTransaction myTransaction;

        public Form1()
        {
            InitializeComponent();

            //operation.Items.Clear();
            //operation.Items.Add("Show all");
            //operation.Items.Add("Show with starting grade: ");
            
            //String connectionString = "Server = DESKTOP-EK1AC4K; Database = MovieRentalSystem; Trusted_Connection = yes;";
            //SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            // Starting the connection
            SqlConnection myConnection = new SqlConnection("user id=movieadmin;" + // Username
                                         "password=1234;" + // Password
                                         "server=localhost;" + // IP for the server
                                         "Trusted_Connection=yes;" +
                                         "database=MovieRentalSystem; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds

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
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    int col = myReader.GetOrdinal("PasswordHash");

                    // Checks password hash with inputted password hash and prints a message.
                    if (myReader.GetString(col) == ByteArrayToString(passwordHash))
                    {
                        LoginResultLabel.Text = "You have been logged in successfully.";
                        LoginButton.Enabled = false;

                        // Bringing back tab pages on successful log in
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
                myReader = myCommand.ExecuteReader();

                Customer.Rows.Clear();
                while (myReader.Read())
                {
                    Customer.Rows.Add(myReader["CustomerID"].ToString(), myReader["FirstName"].ToString(), 
                        myReader["LastName"].ToString(), myReader["EmailAddress"].ToString(), 
                        myReader["AcctNum"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString());
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

            myCommand.CommandText = "select * from CustomerPhone where CustomerID = " + Customer.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            VUPhoneListBox.Items.Clear();

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    VUPhoneListBox.Items.Add(myReader["PhoneNum"].ToString() + " (" + myReader["PhoneType"].ToString() + ")");
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
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
            DeleteCustomerButton.Enabled = false;

            VUAcctNumTextbox.ReadOnly = true;
            VUAddressTextbox.ReadOnly = true;
            VUCityTextbox.ReadOnly = true;
            VUCreditTextbox.ReadOnly = true;
            VUEmailTextbox.ReadOnly = true;
            VUFirstNameTextbox.ReadOnly = true;
            VULastNameTextbox.ReadOnly = true;
            VUPhoneComboBox.Enabled = false;
            VUPhoneTextbox.ReadOnly = true;
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
            DeleteCustomerButton.Enabled = true;

            VUAcctNumTextbox.ReadOnly = false;
            VUAddressTextbox.ReadOnly = false;
            VUCityTextbox.ReadOnly = false;
            VUCreditTextbox.ReadOnly = false;
            VUEmailTextbox.ReadOnly = false;
            VUFirstNameTextbox.ReadOnly = false;
            VULastNameTextbox.ReadOnly = false;
            VUPhoneComboBox.Enabled = true;
            VUPhoneTextbox.ReadOnly = false;
            VUPostalCodeTextbox.ReadOnly = false;
            VUProvinceComboBox.Enabled = true;
        }

        private void Customer_SelectionChanged(object sender, EventArgs e)
        {
            bool isCellSelected = Customer.SelectedCells.Count > 0 && Customer.SelectedCells[0].Value != null;
            ViewDetailsButton.Enabled = isCellSelected;
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            //  CAN WE MAKE DELETE CUSTOMER CHANGE CUSTOMER FROM ACTIVE TO INACTIVE INSTEAD OF DELETING ALL RECORDS?

            string customerID = Customer.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            // Delete records from all tables with CustomerID as foreign key
            myCommand.CommandText = "delete from QueueUp where CustomerID = " + customerID;
            myCommand.ExecuteNonQuery();
            myCommand.CommandText = "delete from RateActor where RentalID in (select RentalID from Rental where CustomerID = " + customerID + ")";
            myCommand.ExecuteNonQuery();
            myCommand.CommandText = "delete from Rental where CustomerID = " + customerID;
            myCommand.ExecuteNonQuery();
            myCommand.CommandText = "delete from CustomerPhone where CustomerID = " + customerID;
            myCommand.ExecuteNonQuery();

            // Delete customer record from Customer table
            myCommand.CommandText = "delete from Customer where CustomerID = " + customerID;
            myCommand.ExecuteNonQuery();

            MessageBox.Show("Customer has been deleted."); // should have an "are you sure?" message maybe??

            // Change screens back to search screen
            SearchCustomerPanel.Visible = true;
            SearchButton.PerformClick(); // FIX THIS LATER (pull query into its own UpdateCustomerDataGrid method)
            ViewCustomerPanel.Visible = false;
            AddCustomerPanel.Visible = false;

            UpdateTitleLabel.Visible = false;
            ViewTitleLabel.Visible = true;

            SaveUpdatesButton.Visible = false;
            MoveToUpdateButton.Visible = true;
            DeleteCustomerButton.Visible = false;
            DeleteCustomerButton.Enabled = false;

            VUAcctNumTextbox.ReadOnly = true;
            VUAddressTextbox.ReadOnly = true;
            VUCityTextbox.ReadOnly = true;
            VUCreditTextbox.ReadOnly = true;
            VUEmailTextbox.ReadOnly = true;
            VUFirstNameTextbox.ReadOnly = true;
            VULastNameTextbox.ReadOnly = true;
            VUPhoneComboBox.Enabled = false;
            VUPhoneTextbox.ReadOnly = true;
            VUPostalCodeTextbox.ReadOnly = true;
            VUProvinceComboBox.Enabled = false;
        }

        private void AddSaveCustomerButton_Click(object sender, EventArgs e)
        {
            // ADDS CUSTOMERS WHEN FIELDS ARE EMPTY!! NEED TO FIX 

            if (AddAcctNumTextbox.Text == string.Empty)
            {
                // customer is creating new acct num
                myCommand.CommandText = "insert into Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, " +
                    "EmailAddress, AcctNum, CreditCardNum) values (next value for Customer_CustomerID_Seq, '" + AddLastNameTextbox.Text +
                    "', '" + AddFirstNameTextbox.Text + "', '" + AddAddressTextbox.Text + "', '" + AddCityTextbox.Text + "', '" +
                    AddProvinceComboBox.Text + "', '" + AddPostalCodeTextbox.Text + "', '" + AddEmailTextbox.Text +
                    "', next value for Customer_AcctNum_Seq, '" + AddCreditTextbox.Text + "')";
            }
            else
            {
                // adding customer to existing acct
                myCommand.CommandText = "insert into Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, " +
                    "EmailAddress, AcctNum, AcctCreateDate, CreditCardNum) values (next value for Customer_CustomerID_Seq, '" +
                    AddLastNameTextbox.Text + "', '" + AddFirstNameTextbox.Text + "', '" + AddAddressTextbox.Text + "', '" + AddCityTextbox.Text +
                    "', '" + AddProvinceComboBox.Text + "', '" + AddPostalCodeTextbox.Text + "', '" + AddEmailTextbox.Text + "', " +
                    AddAcctNumTextbox.Text + ", (select AcctCreateDate from Customer where AcctNum = " + AddAcctNumTextbox.Text + "), '" +
                    AddCreditTextbox.Text + "')";
            }

            myCommand.ExecuteNonQuery();

            //MessageBox.Show(myCommand.CommandText);

            AddAcctNumTextbox.Text = string.Empty;
            AddAddressTextbox.Text = string.Empty;
            AddCityTextbox.Text = string.Empty;
            AddCreditTextbox.Text = string.Empty;
            AddEmailTextbox.Text = string.Empty;
            AddFirstNameTextbox.Text = string.Empty;
            AddLastNameTextbox.Text = string.Empty;
            AddPhoneListBox.Items.Clear();
            AddPhoneComboBox.Text = string.Empty;
            AddPhoneTextbox.Text = string.Empty;
            AddPostalCodeTextbox.Text = string.Empty;
            AddProvinceComboBox.Text = string.Empty;
        }

        private void AddPhoneButton_Click(object sender, EventArgs e)
        {
            if (AddPhoneTextbox.Text.Length > 0 && AddPhoneComboBox.Text.Length > 0)
            {
                AddPhoneListBox.Items.Add(AddPhoneTextbox.Text + " (" + AddPhoneComboBox.Text + ")");
                AddPhoneTextbox.Text = string.Empty;
                AddPhoneComboBox.Text = string.Empty;
            }
        }

        private void AddPhoneTextbox_TextChanged(object sender, EventArgs e)
        {
            if (AddPhoneComboBox.Text.Length > 0 && AddPhoneTextbox.Text.Length == 10)
            {
                AddPhoneButton.Enabled = true;
            }
            else
            {
                AddPhoneButton.Enabled = false;
            }
        }

        private void AddPhoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddPhoneComboBox.Text.Length > 0 && AddPhoneTextbox.Text.Length == 10)
            {
                AddPhoneButton.Enabled = true;
            }
            else
            {
                AddPhoneButton.Enabled = false;
            }
        }

        private void VUPhoneButton_Click(object sender, EventArgs e)
        {
            if (VUPhoneTextbox.Text.Length > 0 && VUPhoneComboBox.Text.Length > 0)
            {
                VUPhoneListBox.Items.Add(VUPhoneTextbox.Text + " (" + VUPhoneComboBox.Text + ")");
                VUPhoneTextbox.Text = string.Empty;
                VUPhoneComboBox.Text = string.Empty;
            }
        }

        private void VUPhoneTextbox_TextChanged(object sender, EventArgs e)
        {
            if (VUPhoneComboBox.Text.Length > 0 && VUPhoneTextbox.Text.Length == 10)
            {
                VUPhoneButton.Enabled = true;
            }
            else
            {
                VUPhoneButton.Enabled = false;
            }
        }

        private void VUPhoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VUPhoneComboBox.Text.Length > 0 && VUPhoneTextbox.Text.Length == 10)
            {
                VUPhoneButton.Enabled = true;
            }
            else
            {
                VUPhoneButton.Enabled = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void EditMoviesButton_Click(object sender, EventArgs e)
        {

        }

        private void MovieSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MovieSearchbutton_Click(object sender, EventArgs e)
        {

        }

        private void MoviesDisplayed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {

        }
// RENT / DISPENSE SCREEN CODE

        private void rentCustSearchBttn_Click(object sender, EventArgs e)
        {
            if (rentCustByIdRadio.Checked)
            {
                myCommand.CommandText = "select * from Customer where CustomerID = " + rentCustSearchTB.Text;

            }
            else if (rentCustByEmailRadio.Checked)
            {
                myCommand.CommandText = "select * from Customer where EmailAddress = '" + rentCustSearchTB.Text + "'";
            }
            else
            {
                myCommand.CommandText = "select * from Customer where LastName = '" + rentCustSearchTB.Text + "'";
            }

            try
            {
                myReader = myCommand.ExecuteReader();

                rentCustSearchDGV.Rows.Clear();
                while (myReader.Read())
                {
                    rentCustSearchDGV.Rows.Add(myReader["CustomerID"].ToString(), 
                        myReader["LastName"].ToString(), myReader["AcctNum"].ToString(), 
                        myReader["EmailAddress"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void rentCustViewBttn_Click(object sender, EventArgs e)
        {
            rentDispensePanel.Visible = true;
            rentCustSearchPanel.Visible = false;

            int customerID = Convert.ToInt32(rentCustSearchDGV.SelectedCells[0].OwningRow.Cells[0].Value);
            myCommand.CommandText = "select * from Customer where CustomerID = " + customerID;

            try
            {
                // Display Customer Information
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    rentCustIdResultLabel.Text = myReader.GetInt32(0).ToString();
                    rentLNResultLabel.Text = myReader.GetString(1);
                    rentFNResultLabel.Text = myReader.GetString(2);
                    rentEmailResultLabel.Text = myReader.GetString(7);
                    rentAcctResultLabel.Text = myReader.GetInt32(8).ToString();
                }

                myReader.Close();

                // Display Customer Movie Queue in Data Grid View
                myCommand.CommandText = "select * from QueueUp where CustomerID = " + customerID;

                myReader = myCommand.ExecuteReader();

                rentCustQueueDGV.Rows.Clear();
                while (myReader.Read())
                {
                    rentCustQueueDGV.Rows.Add(myReader["MovieID"].ToString());
                }

                myReader.Close();

                // Display Customer Rental History in Data Grid View
                myCommand.CommandText = "select * from Rental where CustomerID = " + customerID;

                myReader = myCommand.ExecuteReader();

                rentCustHistoryDGV.Rows.Clear();
                while (myReader.Read())
                {
                    rentCustHistoryDGV.Rows.Add(myReader["RentalID"].ToString(),
                        myReader["MovieID"].ToString(), myReader["EmployeeID"].ToString(),
                        myReader["CheckoutDate"].ToString(), myReader["ReturnDate"].ToString());
                }

                myReader.Close();


            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void rentCancelBttn_Click(object sender, EventArgs e)
        {
            // Try to understand Claire's logic behind their code. :)
            rentCustSearchPanel.Visible = true;
            rentDispensePanel.Visible = false;
        }

        private void rentDispenseBttn_Click(object sender, EventArgs e)
        {
            int movieID = Convert.ToInt32(rentCustQueueDGV.SelectedCells[0].OwningRow.Cells[0].Value);
            string currentUserName = Environment.UserName;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd"); // Get current date

            SqlTransaction myTransaction = null;



            try
            {
                // Start Transaction
                myTransaction = myConnection.BeginTransaction();
                // Attach transaction to myCommand
                myCommand.Transaction = myTransaction;

                int currentEmployee = -1; // Default value if not found
                myCommand.CommandText = "select EmployeeID from Employee where LastName like '" + currentUserName + "%'";



                myReader = myCommand.ExecuteReader();

                if (myReader.Read()) // If employee exists
                {
                    currentEmployee = myReader.GetInt32(0);
                }
                myReader.Close();


                // Insert into Rental table
                myCommand.CommandText = "INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie)" +
                    "VALUES (NEXT VALUE FOR Rental_RentalID_Seq, " + movieID + ", " + rentCustIdResultLabel.Text + ", " + currentEmployee + ", '" + currentDate + "', NULL, NULL)";
                myCommand.ExecuteNonQuery();

                // Delete from QueueUp Table 
                myCommand.CommandText = "DELETE FROM QueueUp WHERE CustomerID = " + rentCustIdResultLabel.Text + " AND MovieID = " + movieID;
                myCommand.ExecuteNonQuery();



                // Commit transaction
                myTransaction.Commit(); 

            }
            catch (Exception e3)
            {
                if (myTransaction != null)
                {
                    // Rollback in case of an error
                    myTransaction.Rollback();
                }

                MessageBox.Show(e3.ToString(), "Error");
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Test
            // test  2
        }
    }
}
