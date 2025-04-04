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
        public string currentEmployee;

        public Form1()
        {
            InitializeComponent();

            //operation.Items.Clear();
            //operation.Items.Add("Show all");
            //operation.Items.Add("Show with starting grade: ");
            
            //String connectionString = "Server = DESKTOP-EK1AC4K; Database = MovieRentalSystem; Trusted_Connection = yes;";
            //SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            // Starting the connection
            this.myConnection = new SqlConnection("user id=movieadmin;" + // Username
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
            myCommand.CommandText = "select EmployeeID, PasswordHash from UserLogin where Username = '" + UsernameTextbox.Text + "'";

            // Set incorrect message before executing query
            LoginResultLabel.Text = "Username and/or password is incorrect.";

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    currentEmployee = myReader["EmployeeID"].ToString();
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

        private void SearchButton_Click(object sender, EventArgs e) // Customer Search Button
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
                    VUPhoneListBox.Items.Add(myReader["PhoneNum"].ToString() + " - " + myReader["PhoneType"].ToString());
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

            MessageBox.Show("Customer has been deleted.");

            // Change screens back to search screen
            SearchCustomerPanel.Visible = true;
            SearchButton.PerformClick(); // could pull query into its own UpdateCustomerDataGrid method
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

        private void SetAddNewCustomerButton()
        {
            AddSaveCustomerButton.Enabled = (AddFirstNameTextbox.Text != "" && AddLastNameTextbox.Text != "" && AddEmailTextbox.Text != "" &&
                AddCreditTextbox.Text != "" && AddAddressTextbox.Text != "" && AddCityTextbox.Text != "" && AddProvinceComboBox.Text != "" &&
                AddPostalCodeTextbox.Text != "");
        }

        private void AddFirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewCustomerButton();
        }

        private void AddLastNameTextbox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewCustomerButton();
        }

        private void AddEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewCustomerButton();
        }

        private void AddCreditTextbox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewCustomerButton();
        }

        private void AddAddressTextbox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewCustomerButton();
        }

        private void AddCityTextbox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewCustomerButton();
        }

        private void AddProvinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAddNewCustomerButton();
        }

        private void AddPostalCodeTextbox_TextChanged(object sender, EventArgs e)
        {
            SetAddNewCustomerButton();
        }

        private void AddSaveCustomerButton_Click(object sender, EventArgs e)
        {
            // DOESN'T CHECK IF CUSTOMER EXISTS OR NOT (unique combination of first name, last name, and email?)
            string[] phoneNumbers;

            // Add customer to Customer table
            if (AddAcctNumTextbox.Text == "")
            {
                // Customer is creating new acct num
                myCommand.CommandText = "insert into Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, " +
                    "EmailAddress, AcctNum, CreditCardNum) values (next value for Customer_CustomerID_Seq, '" + AddLastNameTextbox.Text +
                    "', '" + AddFirstNameTextbox.Text + "', '" + AddAddressTextbox.Text + "', '" + AddCityTextbox.Text + "', '" +
                    AddProvinceComboBox.Text + "', '" + AddPostalCodeTextbox.Text + "', '" + AddEmailTextbox.Text +
                    "', next value for Customer_AcctNum_Seq, '" + AddCreditTextbox.Text + "')";
            }
            else
            {
                // Adding customer to existing acct
                myCommand.CommandText = "insert into Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, " +
                    "EmailAddress, AcctNum, AcctCreateDate, CreditCardNum) values (next value for Customer_CustomerID_Seq, '" +
                    AddLastNameTextbox.Text + "', '" + AddFirstNameTextbox.Text + "', '" + AddAddressTextbox.Text + "', '" + AddCityTextbox.Text +
                    "', '" + AddProvinceComboBox.Text + "', '" + AddPostalCodeTextbox.Text + "', '" + AddEmailTextbox.Text + "', " +
                    AddAcctNumTextbox.Text + ", (select distinct AcctCreateDate from Customer where AcctNum = " + AddAcctNumTextbox.Text + "), '" +
                    AddCreditTextbox.Text + "')";
            }

            myCommand.ExecuteNonQuery();

            // Add phone numbers to CustomerPhone table
            if (AddPhoneListBox.Items.Count > 0)
            {
                for (int i = 0; i < AddPhoneListBox.Items.Count;  i++)
                {
                    myCommand.CommandText = "insert into CustomerPhone (CustomerID, PhoneNum, PhoneType) values ((select CustomerID from Customer " +
                        "where EmailAddress = '" + AddEmailTextbox.Text + "'), '";

                    phoneNumbers = AddPhoneListBox.Items[i].ToString().Split(' ');
                    myCommand.CommandText += phoneNumbers[0] + "', '" + phoneNumbers[2] + "')";

                    myCommand.ExecuteNonQuery();
                }
            }

            AddAcctNumTextbox.Text = "";
            AddAddressTextbox.Text = "";
            AddCityTextbox.Text = "";
            AddCreditTextbox.Text = "";
            AddEmailTextbox.Text = "";
            AddFirstNameTextbox.Text = "";
            AddLastNameTextbox.Text = "";
            AddPhoneListBox.Items.Clear();
            AddPhoneComboBox.Text = "";
            AddPhoneTextbox.Text = "";
            AddPostalCodeTextbox.Text = "";
            AddProvinceComboBox.Text = "";

            MessageBox.Show("Customer has been added.");

            // Change screens back to search screen
            SearchCustomerPanel.Visible = true;
            SearchButton.PerformClick();
            ViewCustomerPanel.Visible = false;
            AddCustomerPanel.Visible = false;
        }

        private void AddPhoneButton_Click(object sender, EventArgs e)
        {
            if (AddPhoneTextbox.Text.Length > 0 && AddPhoneComboBox.Text.Length > 0)
            {
                AddPhoneListBox.Items.Add(AddPhoneTextbox.Text + " - " + AddPhoneComboBox.Text);
                AddPhoneTextbox.Text = "";
                AddPhoneComboBox.Text = "";
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
                VUPhoneListBox.Items.Add(VUPhoneTextbox.Text + " - " + VUPhoneComboBox.Text);
                VUPhoneTextbox.Text = "";
                VUPhoneComboBox.Text = "";
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

        private void SaveUpdatesButton_Click(object sender, EventArgs e)
        {
            string customerID = Customer.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string[] phoneNumbers;

            // Update record in Customer table
            myCommand.CommandText = "update Customer set FirstName = '" + VUFirstNameTextbox.Text + "', LastName = '" + VULastNameTextbox.Text +
                "', EmailAddress = '" + VUEmailTextbox.Text + "', CreditCardNum = '" + VUCreditTextbox.Text + "', AcctNum = " +
                VUAcctNumTextbox.Text + ", Address = '" + VUAddressTextbox.Text + "', City = '" + VUCityTextbox.Text + "', Province = '" +
                VUProvinceComboBox.Text + "', PostalCode = '" + VUPostalCodeTextbox.Text + "' where CustomerID = " + customerID;

            myCommand.ExecuteNonQuery();

            // Update records in CustomerPhone table
            myCommand.CommandText = "delete from CustomerPhone where CustomerID = " + customerID;
            myCommand.ExecuteNonQuery();

            if (VUPhoneListBox.Items.Count > 0)
            {
                for (int i = 0; i < VUPhoneListBox.Items.Count; i++)
                {
                    myCommand.CommandText = "insert into CustomerPhone (CustomerID, PhoneNum, PhoneType) values (" + customerID + ", '";

                    phoneNumbers = VUPhoneListBox.Items[i].ToString().Split(' ');
                    myCommand.CommandText += phoneNumbers[0] + "', '" + phoneNumbers[2] + "')";

                    myCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Customer information has been updated.");

            // Change screens back to search screen
            SearchCustomerPanel.Visible = true;
            SearchButton.PerformClick();
            ViewCustomerPanel.Visible = false;
            AddCustomerPanel.Visible = false;
        }

        private void VUPhoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VUDeletePhoneButton.Enabled = (VUPhoneListBox.SelectedItem != null);
        }

        private void VUDeletePhoneButton_Click(object sender, EventArgs e)
        {
            VUPhoneListBox.Items.Remove(VUPhoneListBox.SelectedItem);
        }


// RENT / DISPENSE SCREEN CODE

        private void rentCustSearchBttn_Click(object sender, EventArgs e)
        {
            if (rentCustByFirstNameRadio.Checked)
            {
                myCommand.CommandText = "select * from Customer where FirstName = '" + rentCustSearchTB.Text + "'";

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
            //DispenseBttnDisable();

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
                myCommand.CommandText = "select * from QueueUp as Q, Movie as M where Q.MovieID = M.MovieID and CustomerID = " + customerID;

                myReader = myCommand.ExecuteReader();

                //bool firstRowChecked = false;

                rentCustQueueDGV.Rows.Clear();
                while (myReader.Read())
                {
                    //if (!firstRowChecked)
                    //{
                    //    firstRowChecked = true;
                    //    if (myReader["MovieID"] == DBNull.Value)
                    //    {
                    //        MessageBox.Show("First is Null");
                    //    }
                    //}

                        rentCustQueueDGV.Rows.Add(myReader["MovieID"].ToString(), myReader["Name"].ToString(), myReader["NumCopies"].ToString());
                }

                myReader.Close();

                // Display Customer Rental History in Data Grid View
                myCommand.CommandText = "select * from Rental where CustomerID = " + customerID;

                bool hasUnreturnedMovie = false;

                myReader = myCommand.ExecuteReader();

                rentCustHistoryDGV.Rows.Clear();
                while (myReader.Read())
                {
                    if (myReader["ReturnDate"] == DBNull.Value)
                    {
                        hasUnreturnedMovie = true;
                    }

                    rentCustHistoryDGV.Rows.Add(myReader["RentalID"].ToString(),
                        myReader["MovieID"].ToString(), myReader["EmployeeID"].ToString(),
                        myReader["CheckoutDate"].ToString(), myReader["ReturnDate"].ToString());
                }

                myReader.Close();


                if (hasUnreturnedMovie)
                {
                    rentDispenseBttn.Enabled = false;
                }
                else
                {
                    rentDispenseBttn.Enabled = true;
                }


            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void rentCancelBttn_Click(object sender, EventArgs e)
        {
            rentCustSearchPanel.Visible = true;
            rentDispensePanel.Visible = false;
            //rentCustQueueDGV.Rows.Clear();
            //rentCustHistoryDGV.Rows.Clear();
        }

        private void rentDispenseBttn_Click(object sender, EventArgs e)
        {
            string movieID = rentCustQueueDGV.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd"); // Get current date

            SqlTransaction myTransaction = null;

            try
            {
                // Start Transaction
                myTransaction = myConnection.BeginTransaction();
                // Attach transaction to myCommand
                myCommand.Transaction = myTransaction;

                //string currentEmployee = "-1"; // Default value if not found
                //myCommand.CommandText = "select EmployeeID from Employee where LastName like '" + currentEmployee + "%'";

                //MessageBox.Show(myCommand.CommandText);

                //myReader = myCommand.ExecuteReader();

                //while (myReader.Read()) // If employee exists
                //{
                //    currentEmployee = myReader.GetString(0);
                //}
                //myReader.Close();

                //MessageBox.Show(currentEmployee);


                // Insert into Rental table
                myCommand.CommandText = "INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie)" +
                    "VALUES (NEXT VALUE FOR Rental_RentalID_Seq, " + movieID + ", " + rentCustIdResultLabel.Text + ", " + currentEmployee + ", '" + currentDate + "', NULL, NULL)";
                myCommand.ExecuteNonQuery();

                // Delete from QueueUp Table 
                myCommand.CommandText = "DELETE FROM QueueUp WHERE CustomerID = " + rentCustIdResultLabel.Text + " AND MovieID = " + movieID;
                myCommand.ExecuteNonQuery();



                // Commit transaction
                myTransaction.Commit();
                ReduceNumCopies();
                LoadQueueUPData();
                LoadRentalHistoryData();
                rentBackBttnReveal();


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



        private void LoadQueueUPData()
        {
            rentCustQueueDGV.Columns.Clear();
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM QueueUp WHERE CustomerID = " + rentCustIdResultLabel.Text, myConnection);
            DataTable dataTable = new DataTable();
            myAdapter.Fill(dataTable);
            rentCustQueueDGV.DataSource = dataTable;
        }

        private void LoadRentalHistoryData()
        {
            rentCustHistoryDGV.Columns.Clear();
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM Rental WHERE CustomerID = " + rentCustIdResultLabel.Text, myConnection);
            DataTable dataTable = new DataTable();
            myAdapter.Fill(dataTable);
            rentCustHistoryDGV.DataSource = dataTable;
        }

        private void ReduceNumCopies()
        {
            string movieID = rentCustQueueDGV.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            myCommand.CommandText = "UPDATE Movie SET NumCopies = NumCopies - 1 WHERE MovieID = " + movieID + "AND NumCopies > 0";
            myCommand.ExecuteNonQuery();
        }

        private void rentBackBttnReveal()
        {
            rentCancelBttn.Visible = false;
            rentBackBttn.Visible = true;
            rentCancelBttn.Enabled = false;
            rentBackBttn.Enabled = true;

        }


        // MOVIE FEATURE CODE

        private void MovieSearchButton_Click(object sender, EventArgs e)
        {
            // Check connection (using class-level variable, not local)
            if (this.myConnection == null || this.myConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not initialized or open.");
                return;
            }

            string userInput = MovieSearchTextBox.Text.Trim();
            string query = "";

            if (ActorRadioButton.Checked) // Search by Actor
            {
                query = @"
            SELECT DISTINCT M.MovieID, M.Name, M.Type, M.NumCopies, M.DistributionFee
            FROM Movie M
            JOIN AppearedIn AI ON M.MovieID = AI.MovieID
            JOIN Actor A ON AI.ActorID = A.ActorID
            WHERE A.Name LIKE @search";
            }
            else if (TitleRadioButton.Checked) // Search by Title
            {
                query = @"
            SELECT MovieID, Name, Type, NumCopies, DistributionFee
            FROM Movie
            WHERE Name LIKE @search";
            }
            else if (GenreRadioButton.Checked) // Search by Genre
            {
                query = @"
            SELECT MovieID, Name, Type, NumCopies, DistributionFee
            FROM Movie
            WHERE Type LIKE @search";
            }
            //else
            //{
            //    MessageBox.Show("Please select a search filter (Actor, Title, Genre).");
            //    return;
            //}

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, this.myConnection))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + userInput + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        MovieDetailsGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading movies: " + ex.Message);
            }
        }

        private void AddMovieButton_Click(object sender, EventArgs e) // ADDED CODE FROM KOVIDH'S BRANCH
        {
            AddMovieNameTextbox.Text = "";
            AddMovieGenreTextbox.Text = "";
            AddMovieCopiesTextbox.Text = "";
            AddMovieFeeTextbox.Text = "";

            SearchMoviePanel.Visible = false;
            AddMoviePanel.Visible = true;
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            if (MovieDetailsGrid.SelectedRows.Count > 0)
            {
                string movieId = MovieDetailsGrid.SelectedRows[0].Cells["MovieID"].Value.ToString();

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this movie?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        // Start a transaction to ensure all deletes succeed or fail together
                        SqlTransaction transaction = myConnection.BeginTransaction();

                        try
                        {
                            // First delete related records in child tables
                            // 1. Delete from RateActor (through Rental)
                            myCommand.CommandText = @"
                        DELETE FROM RateActor 
                        WHERE RentalID IN (
                            SELECT RentalID FROM Rental WHERE MovieID = @MovieID
                        )";
                            myCommand.Parameters.Clear();
                            myCommand.Parameters.AddWithValue("@MovieID", movieId);
                            myCommand.Transaction = transaction;
                            myCommand.ExecuteNonQuery();

                            // 2. Delete from Rental
                            myCommand.CommandText = "DELETE FROM Rental WHERE MovieID = @MovieID";
                            myCommand.ExecuteNonQuery();

                            // 3. Delete from QueueUp
                            myCommand.CommandText = "DELETE FROM QueueUp WHERE MovieID = @MovieID";
                            myCommand.ExecuteNonQuery();

                            // 4. Delete from AppearedIn
                            myCommand.CommandText = "DELETE FROM AppearedIn WHERE MovieID = @MovieID";
                            myCommand.ExecuteNonQuery();

                            // Finally delete the movie itself
                            myCommand.CommandText = "DELETE FROM Movie WHERE MovieID = @MovieID";
                            myCommand.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Movie deleted successfully.");

                            // Refresh the movie list
                            //MovieSearchbutton_Click(null, null);
                            MovieSearchButton.PerformClick();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error deleting movie: " + ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error starting transaction: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to delete.");
            }

        }

        private void LoadAllMovies()
        {
            string query = "SELECT MovieID, MovieName, MovieGenre, NumCopies, NumRented, DistributionFee FROM Movie";
            SqlDataAdapter adapter = new SqlDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MovieDetailsGrid.DataSource = dt;
        }

        private void EditMoviesButton_Click(object sender, EventArgs e) // ADDED CODE FROM KOVIDH'S BRANCH
        {
            if (MovieDetailsGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = MovieDetailsGrid.SelectedRows[0];

                EditMovieIDLabel.Text = selectedRow.Cells["MovieID"].Value.ToString();
                EditMovieNameTextbox.Text = selectedRow.Cells["Name"].Value.ToString();
                EditMovieGenreTextbox.Text = selectedRow.Cells["Type"].Value.ToString();
                EditMovieCopiesTextbox.Text = selectedRow.Cells["NumCopies"].Value.ToString();
                EditMovieFeeTextbox.Text = selectedRow.Cells["DistributionFee"].Value.ToString();

                SearchMoviePanel.Visible = false;
                EditMoviePanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a movie to edit.");
            }
        }

        private void SaveMovieChangesButton_Click(object sender, EventArgs e) // ADDED CODE FROM KOVIDH'S BRANCH
        {
            string movieId = EditMovieIDLabel.Text;
            string newName = EditMovieNameTextbox.Text;
            string newGenre = EditMovieGenreTextbox.Text;
            int newCopies = int.Parse(EditMovieCopiesTextbox.Text);
            decimal newFee = decimal.Parse(EditMovieFeeTextbox.Text);

            try
            {
                string query = "UPDATE Movie SET Name = @name, Type = @genre, NumCopies = @copies, DistributionFee = @fee WHERE MovieID = @id";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@genre", newGenre);
                    cmd.Parameters.AddWithValue("@copies", newCopies);
                    cmd.Parameters.AddWithValue("@fee", newFee);
                    cmd.Parameters.AddWithValue("@id", movieId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Movie details updated.");
                SearchMoviePanel.Visible = true;
                EditMoviePanel.Visible = false;
                MovieSearchButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating movie: " + ex.Message);
            }
        }

        private void CancelEditMovieButton_Click(object sender, EventArgs e) // ADDED CODE FROM KOVIDH'S BRANCH
        {
            SearchMoviePanel.Visible = true;
            EditMoviePanel.Visible = false;
        }

        private void SaveNewMovieButton_Click(object sender, EventArgs e) // ADDED CODE FROM KOVIDH'S BRANCH
        {
            string name = AddMovieNameTextbox.Text;
            string genre = AddMovieGenreTextbox.Text;
            int copies;
            decimal fee;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(genre) ||
                !int.TryParse(AddMovieCopiesTextbox.Text, out copies) ||
                !decimal.TryParse(AddMovieFeeTextbox.Text, out fee))
            {
                MessageBox.Show("Please fill all fields with valid values.");
                return;
            }

            try
            {
                string query = @"
             INSERT INTO Movie (MovieID, Name, Type, NumCopies, DistributionFee)
             VALUES (NEXT VALUE FOR Movie_MovieID_Seq, @name, @genre, @copies, @fee)";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@copies", copies);
                    cmd.Parameters.AddWithValue("@fee", fee);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("New movie added.");
                AddMoviePanel.Visible = false;
                SearchMoviePanel.Visible = true;
                MovieSearchButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding movie: " + ex.Message);
            }
        }

        private void CancelAddMovieButton_Click(object sender, EventArgs e) // ADDED CODE FROM KOVIDH'S BRANCH
        {
            AddMoviePanel.Visible = false;
            SearchMoviePanel.Visible = true;
        }

        private void YearlyIncomeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YearlyIncomeRadioButton.Checked)
            {
                myCommand.CommandText = "select distinct year(CheckoutDate) as Year from Rental";

                try
                {
                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        YearlyIncomeComboBox.Items.Add(myReader["Year"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");

                }
            }

            YearlyIncomeComboBox.Enabled = true;
        }

        private void ExecuteReportButton_Click(object sender, EventArgs e)
        {
            ReportsAvailablePanel.Visible = false;

            if (Top5MoviesRadioButton.Checked) // Top 5 Movies
            {
                ReportTypeLabel.Text = Top5MoviesRadioButton.Text;

                myCommand.CommandText = "SELECT * " +
                    "FROM (SELECT M2.Name as MovieName, AVG(R2.CustRateMovie) as avgRating2 " +
                    "FROM Movie M2, Rental R2 " +
                    "WHERE M2.MovieID = R2.RentalID " +
                    "GROUP BY M2.Name) as Ranked " +
                    "WHERE Ranked.avgRating2 >= (SELECT avgRating " +
                    "FROM (SELECT M.Name, AVG(R.CustRateMovie) as avgRating, " +
                    "ROW_NUMBER() OVER (ORDER BY AVG(R.CustRateMovie) DESC) as rowNum " +
                    "FROM Movie M, Rental R " +
                    "WHERE M.MovieID = R.RentalID " +
                    "GROUP BY M.Name) As Ranked2 " +
                    "WHERE rowNum = 5) " +
                    "ORDER BY Ranked.avgRating2 DESC";

                ReportDataGrid.Columns.Clear();
                ReportDataGrid.Columns.Add("MovieName", "Movie Name");
                ReportDataGrid.Columns.Add("avgRating2", "Average Rating");
                ReportDataGrid.Columns[0].Width = 300;
                ReportDataGrid.Columns[1].Width = 300;

                try
                {
                    myReader = myCommand.ExecuteReader();

                    ReportDataGrid.Rows.Clear();
                    while (myReader.Read())
                    {
                        ReportDataGrid.Rows.Add(myReader["MovieName"].ToString(), myReader["avgRating2"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (Top5CustRadioButton.Checked) // Top 5 Customers
            {
                ReportTypeLabel.Text = Top5CustRadioButton.Text;

                myCommand.CommandText = "SELECT * " +
                    "FROM (SELECT C.CustomerID, " +
                    "(SELECT (C1.FirstName) + ' ' + (C1.LastName) " +
                    "FROM Customer C1 " +
                    "WHERE C1.CustomerID = C.CustomerID) AS FullName, " +
                    "(SELECT COUNT(R1.RentalID) " +
                    "FROM Rental R1 " +
                    "WHERE R1.CustomerID = C.CustomerID) AS NumberOfRentals, " +
                    "ROW_NUMBER() OVER (ORDER BY (SELECT COUNT(*) FROM Rental R1 WHERE R1.CustomerID = C.CustomerID) DESC) AS RankOfRentals " +
                    "FROM Customer C) AS RankedCustomers " +
                    "WHERE (RankOfRentals <= 5) " +
                    "ORDER BY NumberOfRentals DESC";

                //myCommand.CommandText = "SELECT * " +
                //    "FROM (SELECT C.CustomerID, " +
                //    "(SELECT C1.FirstName + ' ' + C1.LastName " +
                //    "FROM Customer C1 " +
                //    "WHERE C1.CustomerID = C.CustomerID) as FullName, COUNT(*) as NumberOfRentals " +
                //    "FROM Customer C, Rental R " +
                //    "WHERE C.CustomerID = R.CustomerID " +
                //    "GROUP BY C.CustomerID) as RankedCustomers " +
                //    "WHERE RankedCustomers.NumberOfRentals >= " +
                //    "(SELECT NumberOfRentals " +
                //    "FROM (SELECT C.CustomerID, COUNT(*) AS NumberOfRentals, ROW_NUMBER() OVER (ORDER BY COUNT(*) DESC) as rowNum " +
                //    "FROM Customer C, Rental R " +
                //    "WHERE C.CustomerID = R.CustomerID " +
                //    "GROUP BY C.CustomerID) as Ranked2 " +
                //    "WHERE rowNum = 5) " +
                //    "ORDER BY RankedCustomers.NumberOfRentals DESC";

                ReportDataGrid.Columns.Clear();
                ReportDataGrid.Columns.Add("CustomerID", "ID");
                ReportDataGrid.Columns.Add("FullName", "Customer Name");
                ReportDataGrid.Columns.Add("NumberOfRentals", "Number of Rentals");
                ReportDataGrid.Columns[0].Width = 75;
                ReportDataGrid.Columns[1].Width = 300;
                ReportDataGrid.Columns[2].Width = 300;

                try
                {
                    myReader = myCommand.ExecuteReader();

                    ReportDataGrid.Rows.Clear();
                    while (myReader.Read())
                    {
                        ReportDataGrid.Rows.Add(myReader["CustomerID"].ToString(), myReader["FullName"].ToString(),
                            myReader["NumberOfRentals"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (Top5ActorsRadioButton.Checked) // Top 5 Actors
            {
                ReportTypeLabel.Text = Top5ActorsRadioButton.Text;

                myCommand.CommandText = "SELECT * " +
                    "FROM (SELECT A2.Name AS ActorName, COUNT(*) AS NumViewed2 " +
                    "FROM Actor A2, AppearedIn AI2, Rental R2 " +
                    "WHERE A2.ActorID = AI2.ActorID and AI2.MovieID = R2.MovieID " +
                    "GROUP BY A2.Name) AS Ranked " +
                    "WHERE Ranked.NumViewed2 >= (SELECT NumViewed " +
                    "FROM (SELECT A.Name, COUNT(*) AS NumViewed, ROW_NUMBER() OVER " +
                    "(ORDER BY COUNT(*) DESC) AS rowNum " +
                    "FROM Actor A, AppearedIn AI, Rental R " +
                    "WHERE A.ActorID = AI.ActorID and AI.MovieID = R.MovieID " +
                    "GROUP BY A.Name) AS Ranked2 " +
                    "WHERE rowNum = 5) " +
                    "ORDER BY Ranked.NumViewed2 DESC";

                ReportDataGrid.Columns.Clear();
                ReportDataGrid.Columns.Add("ActorName", "Actor Name");
                ReportDataGrid.Columns.Add("NumViewed2", "Number of Appearances in Movie Rentals");
                ReportDataGrid.Columns[0].Width = 300;
                ReportDataGrid.Columns[1].Width = 300;

                try
                {
                    myReader = myCommand.ExecuteReader();

                    ReportDataGrid.Rows.Clear();
                    while (myReader.Read())
                    {
                        ReportDataGrid.Rows.Add(myReader["ActorName"].ToString(), myReader["NumViewed2"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (SortEmployeesRadioButton.Checked) // Sorted Employees
            {
                ReportTypeLabel.Text = SortEmployeesRadioButton.Text;

                myCommand.CommandText = "SELECT E.EmployeeID, " +
                    "(E.FirstName) + ' ' + (E.LastName) as FullName, " +
                    "(SELECT COUNT(R.RentalID) " +
                    "FROM Rental R " +
                    "WHERE R.EmployeeID = E.EmployeeID) as NumberOfRentalsDispensed " +
                    "FROM Employee E " +
                    "ORDER BY (SELECT COUNT(R.RentalID) " +
                    "FROM Rental R " +
                    "WHERE R.EmployeeID = E.EmployeeID) DESC";

                ReportDataGrid.Columns.Clear();
                ReportDataGrid.Columns.Add("EmployeeID", "ID");
                ReportDataGrid.Columns.Add("FullName", "Employee Name");
                ReportDataGrid.Columns.Add("NumberOfRentalsDispensed", "Number of Rentals Dispensed");
                ReportDataGrid.Columns[0].Width = 75;
                ReportDataGrid.Columns[1].Width = 300;
                ReportDataGrid.Columns[2].Width = 300;

                try
                {
                    myReader = myCommand.ExecuteReader();

                    ReportDataGrid.Rows.Clear();
                    while (myReader.Read())
                    {
                        ReportDataGrid.Rows.Add(myReader["EmployeeID"].ToString(), myReader["FullName"].ToString(),
                            myReader["NumberOfRentalsDispensed"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else // Total Income Specified by Year
            {
                ReportTypeLabel.Text = YearlyIncomeRadioButton.Text + ": " + YearlyIncomeComboBox.Text;

                myCommand.CommandText = "SELECT Month(CheckoutDate) as monthDate, SUM(DistributionFee) as monthlyIncome " +
                    "FROM Rental R, Movie M " +
                    "WHERE M.MovieID = R.MovieID and Year(CheckoutDate) = " + YearlyIncomeComboBox.Text + " " +
                    "GROUP BY Month(CheckoutDate) " +
                    "ORDER BY monthDate";

                ReportDataGrid.Columns.Clear();
                ReportDataGrid.Columns.Add("monthDate", "Month");
                ReportDataGrid.Columns.Add("monthlyIncome", "Income");
                ReportDataGrid.Columns[0].Width = 300;
                ReportDataGrid.Columns[1].Width = 300;

                try
                {
                    myReader = myCommand.ExecuteReader();

                    ReportDataGrid.Rows.Clear();
                    while (myReader.Read())
                    {
                        ReportDataGrid.Rows.Add(myReader["monthDate"].ToString(), myReader["monthlyIncome"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            ReportDisplayPanel.Visible = true;
        }

        private void ExitReportViewButton_Click(object sender, EventArgs e)
        {
            ReportsAvailablePanel.Visible = true;
            ReportDisplayPanel.Visible = false;
        }

        private void rentBackBttn_Click(object sender, EventArgs e)
        {
            rentCustSearchPanel.Visible = true;
            rentDispensePanel.Visible = false;
        }
    }
}
