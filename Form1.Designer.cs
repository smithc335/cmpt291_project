namespace CMPT291_Project
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
            this.MovieRentalTabControl = new System.Windows.Forms.TabControl();
            this.LogInTabPage = new System.Windows.Forms.TabPage();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.SystemNameLabel = new System.Windows.Forms.Label();
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.LoginResultLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.AddCustomerPanel = new System.Windows.Forms.Panel();
            this.AddEmailLabel = new System.Windows.Forms.Label();
            this.AddEmailTextbox = new System.Windows.Forms.TextBox();
            this.AddPostalCodeLabel = new System.Windows.Forms.Label();
            this.AddPostalCodeTextbox = new System.Windows.Forms.TextBox();
            this.AddProvinceLabel = new System.Windows.Forms.Label();
            this.AddCityLabel = new System.Windows.Forms.Label();
            this.AddCityTextbox = new System.Windows.Forms.TextBox();
            this.AddAddressLabel = new System.Windows.Forms.Label();
            this.AddAddressTextbox = new System.Windows.Forms.TextBox();
            this.AddLastNameLabel = new System.Windows.Forms.Label();
            this.AddLastNameTextbox = new System.Windows.Forms.TextBox();
            this.AddFirstNameLabel = new System.Windows.Forms.Label();
            this.AddFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.MoveToSearchButton = new System.Windows.Forms.Button();
            this.AddCustomersLabel = new System.Windows.Forms.Label();
            this.SearchCustomerPanel = new System.Windows.Forms.Panel();
            this.EmailRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstNameRadioButton = new System.Windows.Forms.RadioButton();
            this.LastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.CustSearchInstructionsLabel = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcctNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MoveToAddButton = new System.Windows.Forms.Button();
            this.EditCustomerPanel = new System.Windows.Forms.Panel();
            this.BackToSearchButton = new System.Windows.Forms.Button();
            this.MoviesTabPage = new System.Windows.Forms.TabPage();
            this.RentalsTabPage = new System.Windows.Forms.TabPage();
            this.ReportsTabPage = new System.Windows.Forms.TabPage();
            this.AddAcctNumLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddAcctNumInstLabel = new System.Windows.Forms.Label();
            this.AddCreditLabel = new System.Windows.Forms.Label();
            this.AddCreditTextbox = new System.Windows.Forms.TextBox();
            this.AddSaveCustomerButton = new System.Windows.Forms.Button();
            this.AddProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MovieRentalTabControl.SuspendLayout();
            this.LogInTabPage.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.AddCustomerPanel.SuspendLayout();
            this.SearchCustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).BeginInit();
            this.EditCustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieRentalTabControl
            // 
            this.MovieRentalTabControl.Controls.Add(this.LogInTabPage);
            this.MovieRentalTabControl.Controls.Add(this.CustomersTabPage);
            this.MovieRentalTabControl.Controls.Add(this.MoviesTabPage);
            this.MovieRentalTabControl.Controls.Add(this.RentalsTabPage);
            this.MovieRentalTabControl.Controls.Add(this.ReportsTabPage);
            this.MovieRentalTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieRentalTabControl.Location = new System.Drawing.Point(17, 15);
            this.MovieRentalTabControl.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MovieRentalTabControl.Name = "MovieRentalTabControl";
            this.MovieRentalTabControl.SelectedIndex = 0;
            this.MovieRentalTabControl.Size = new System.Drawing.Size(886, 535);
            this.MovieRentalTabControl.TabIndex = 6;
            // 
            // LogInTabPage
            // 
            this.LogInTabPage.Controls.Add(this.LoginPanel);
            this.LogInTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInTabPage.Location = new System.Drawing.Point(4, 25);
            this.LogInTabPage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.LogInTabPage.Name = "LogInTabPage";
            this.LogInTabPage.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.LogInTabPage.Size = new System.Drawing.Size(878, 506);
            this.LogInTabPage.TabIndex = 0;
            this.LogInTabPage.Text = "Log In";
            this.LogInTabPage.UseVisualStyleBackColor = true;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.LoginPanel.Controls.Add(this.SystemNameLabel);
            this.LoginPanel.Controls.Add(this.LoginTitleLabel);
            this.LoginPanel.Controls.Add(this.PasswordTextbox);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.UsernameTextbox);
            this.LoginPanel.Controls.Add(this.LoginResultLabel);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Location = new System.Drawing.Point(12, 11);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(853, 484);
            this.LoginPanel.TabIndex = 8;
            // 
            // SystemNameLabel
            // 
            this.SystemNameLabel.AutoSize = true;
            this.SystemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemNameLabel.Location = new System.Drawing.Point(100, 81);
            this.SystemNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.SystemNameLabel.Name = "SystemNameLabel";
            this.SystemNameLabel.Size = new System.Drawing.Size(238, 26);
            this.SystemNameLabel.TabIndex = 7;
            this.SystemNameLabel.Text = "Movie Rental System";
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleLabel.Location = new System.Drawing.Point(101, 119);
            this.LoginTitleLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(148, 24);
            this.LoginTitleLabel.TabIndex = 6;
            this.LoginTitleLabel.Text = "Employee Login";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.Location = new System.Drawing.Point(206, 248);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(422, 23);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(101, 191);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(96, 20);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.Location = new System.Drawing.Point(206, 191);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(422, 23);
            this.UsernameTextbox.TabIndex = 2;
            // 
            // LoginResultLabel
            // 
            this.LoginResultLabel.AutoSize = true;
            this.LoginResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginResultLabel.Location = new System.Drawing.Point(254, 323);
            this.LoginResultLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LoginResultLabel.Name = "LoginResultLabel";
            this.LoginResultLabel.Size = new System.Drawing.Size(87, 17);
            this.LoginResultLabel.TabIndex = 5;
            this.LoginResultLabel.Text = "Login Result";
            this.LoginResultLabel.Visible = false;
            this.LoginResultLabel.Click += new System.EventHandler(this.LoginResultLabel_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(101, 305);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(111, 52);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(101, 248);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 20);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.SearchCustomerPanel);
            this.CustomersTabPage.Controls.Add(this.EditCustomerPanel);
            this.CustomersTabPage.Controls.Add(this.AddCustomerPanel);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersTabPage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CustomersTabPage.Size = new System.Drawing.Size(878, 506);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // AddCustomerPanel
            // 
            this.AddCustomerPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.AddCustomerPanel.Controls.Add(this.AddProvinceComboBox);
            this.AddCustomerPanel.Controls.Add(this.AddSaveCustomerButton);
            this.AddCustomerPanel.Controls.Add(this.AddCreditLabel);
            this.AddCustomerPanel.Controls.Add(this.AddCreditTextbox);
            this.AddCustomerPanel.Controls.Add(this.AddAcctNumInstLabel);
            this.AddCustomerPanel.Controls.Add(this.AddAcctNumLabel);
            this.AddCustomerPanel.Controls.Add(this.textBox1);
            this.AddCustomerPanel.Controls.Add(this.AddEmailLabel);
            this.AddCustomerPanel.Controls.Add(this.AddEmailTextbox);
            this.AddCustomerPanel.Controls.Add(this.AddPostalCodeLabel);
            this.AddCustomerPanel.Controls.Add(this.AddPostalCodeTextbox);
            this.AddCustomerPanel.Controls.Add(this.AddProvinceLabel);
            this.AddCustomerPanel.Controls.Add(this.AddCityLabel);
            this.AddCustomerPanel.Controls.Add(this.AddCityTextbox);
            this.AddCustomerPanel.Controls.Add(this.AddAddressLabel);
            this.AddCustomerPanel.Controls.Add(this.AddAddressTextbox);
            this.AddCustomerPanel.Controls.Add(this.AddLastNameLabel);
            this.AddCustomerPanel.Controls.Add(this.AddLastNameTextbox);
            this.AddCustomerPanel.Controls.Add(this.AddFirstNameLabel);
            this.AddCustomerPanel.Controls.Add(this.AddFirstNameTextbox);
            this.AddCustomerPanel.Controls.Add(this.MoveToSearchButton);
            this.AddCustomerPanel.Controls.Add(this.AddCustomersLabel);
            this.AddCustomerPanel.Location = new System.Drawing.Point(12, 11);
            this.AddCustomerPanel.Margin = new System.Windows.Forms.Padding(5);
            this.AddCustomerPanel.Name = "AddCustomerPanel";
            this.AddCustomerPanel.Size = new System.Drawing.Size(853, 484);
            this.AddCustomerPanel.TabIndex = 0;
            this.AddCustomerPanel.Visible = false;
            // 
            // AddEmailLabel
            // 
            this.AddEmailLabel.AutoSize = true;
            this.AddEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmailLabel.Location = new System.Drawing.Point(25, 102);
            this.AddEmailLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddEmailLabel.Name = "AddEmailLabel";
            this.AddEmailLabel.Size = new System.Drawing.Size(102, 17);
            this.AddEmailLabel.TabIndex = 18;
            this.AddEmailLabel.Text = "Email Address:";
            // 
            // AddEmailTextbox
            // 
            this.AddEmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmailTextbox.Location = new System.Drawing.Point(141, 99);
            this.AddEmailTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddEmailTextbox.Name = "AddEmailTextbox";
            this.AddEmailTextbox.Size = new System.Drawing.Size(282, 23);
            this.AddEmailTextbox.TabIndex = 19;
            // 
            // AddPostalCodeLabel
            // 
            this.AddPostalCodeLabel.AutoSize = true;
            this.AddPostalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPostalCodeLabel.Location = new System.Drawing.Point(24, 357);
            this.AddPostalCodeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddPostalCodeLabel.Name = "AddPostalCodeLabel";
            this.AddPostalCodeLabel.Size = new System.Drawing.Size(88, 17);
            this.AddPostalCodeLabel.TabIndex = 16;
            this.AddPostalCodeLabel.Text = "Postal Code:";
            // 
            // AddPostalCodeTextbox
            // 
            this.AddPostalCodeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPostalCodeTextbox.Location = new System.Drawing.Point(127, 354);
            this.AddPostalCodeTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddPostalCodeTextbox.Name = "AddPostalCodeTextbox";
            this.AddPostalCodeTextbox.Size = new System.Drawing.Size(282, 23);
            this.AddPostalCodeTextbox.TabIndex = 17;
            // 
            // AddProvinceLabel
            // 
            this.AddProvinceLabel.AutoSize = true;
            this.AddProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProvinceLabel.Location = new System.Drawing.Point(393, 322);
            this.AddProvinceLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddProvinceLabel.Name = "AddProvinceLabel";
            this.AddProvinceLabel.Size = new System.Drawing.Size(67, 17);
            this.AddProvinceLabel.TabIndex = 14;
            this.AddProvinceLabel.Text = "Province:";
            // 
            // AddCityLabel
            // 
            this.AddCityLabel.AutoSize = true;
            this.AddCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCityLabel.Location = new System.Drawing.Point(24, 322);
            this.AddCityLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddCityLabel.Name = "AddCityLabel";
            this.AddCityLabel.Size = new System.Drawing.Size(35, 17);
            this.AddCityLabel.TabIndex = 12;
            this.AddCityLabel.Text = "City:";
            // 
            // AddCityTextbox
            // 
            this.AddCityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCityTextbox.Location = new System.Drawing.Point(73, 319);
            this.AddCityTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddCityTextbox.Name = "AddCityTextbox";
            this.AddCityTextbox.Size = new System.Drawing.Size(282, 23);
            this.AddCityTextbox.TabIndex = 13;
            // 
            // AddAddressLabel
            // 
            this.AddAddressLabel.AutoSize = true;
            this.AddAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAddressLabel.Location = new System.Drawing.Point(24, 287);
            this.AddAddressLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddAddressLabel.Name = "AddAddressLabel";
            this.AddAddressLabel.Size = new System.Drawing.Size(64, 17);
            this.AddAddressLabel.TabIndex = 10;
            this.AddAddressLabel.Text = "Address:";
            // 
            // AddAddressTextbox
            // 
            this.AddAddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAddressTextbox.Location = new System.Drawing.Point(102, 284);
            this.AddAddressTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddAddressTextbox.Name = "AddAddressTextbox";
            this.AddAddressTextbox.Size = new System.Drawing.Size(328, 23);
            this.AddAddressTextbox.TabIndex = 11;
            // 
            // AddLastNameLabel
            // 
            this.AddLastNameLabel.AutoSize = true;
            this.AddLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLastNameLabel.Location = new System.Drawing.Point(439, 65);
            this.AddLastNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddLastNameLabel.Name = "AddLastNameLabel";
            this.AddLastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.AddLastNameLabel.TabIndex = 8;
            this.AddLastNameLabel.Text = "Last Name:";
            // 
            // AddLastNameTextbox
            // 
            this.AddLastNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLastNameTextbox.Location = new System.Drawing.Point(533, 62);
            this.AddLastNameTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddLastNameTextbox.Name = "AddLastNameTextbox";
            this.AddLastNameTextbox.Size = new System.Drawing.Size(282, 23);
            this.AddLastNameTextbox.TabIndex = 9;
            // 
            // AddFirstNameLabel
            // 
            this.AddFirstNameLabel.AutoSize = true;
            this.AddFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFirstNameLabel.Location = new System.Drawing.Point(24, 65);
            this.AddFirstNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddFirstNameLabel.Name = "AddFirstNameLabel";
            this.AddFirstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.AddFirstNameLabel.TabIndex = 6;
            this.AddFirstNameLabel.Text = "First Name:";
            // 
            // AddFirstNameTextbox
            // 
            this.AddFirstNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFirstNameTextbox.Location = new System.Drawing.Point(118, 62);
            this.AddFirstNameTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddFirstNameTextbox.Name = "AddFirstNameTextbox";
            this.AddFirstNameTextbox.Size = new System.Drawing.Size(282, 23);
            this.AddFirstNameTextbox.TabIndex = 7;
            // 
            // MoveToSearchButton
            // 
            this.MoveToSearchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.MoveToSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToSearchButton.ForeColor = System.Drawing.Color.White;
            this.MoveToSearchButton.Location = new System.Drawing.Point(238, 428);
            this.MoveToSearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.MoveToSearchButton.Name = "MoveToSearchButton";
            this.MoveToSearchButton.Size = new System.Drawing.Size(117, 39);
            this.MoveToSearchButton.TabIndex = 5;
            this.MoveToSearchButton.Text = "Cancel";
            this.MoveToSearchButton.UseVisualStyleBackColor = false;
            this.MoveToSearchButton.Click += new System.EventHandler(this.MoveToSearchButton_Click);
            // 
            // AddCustomersLabel
            // 
            this.AddCustomersLabel.AutoSize = true;
            this.AddCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomersLabel.Location = new System.Drawing.Point(23, 18);
            this.AddCustomersLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddCustomersLabel.Name = "AddCustomersLabel";
            this.AddCustomersLabel.Size = new System.Drawing.Size(162, 20);
            this.AddCustomersLabel.TabIndex = 1;
            this.AddCustomersLabel.Text = "Add New Customer";
            // 
            // SearchCustomerPanel
            // 
            this.SearchCustomerPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.SearchCustomerPanel.Controls.Add(this.EmailRadioButton);
            this.SearchCustomerPanel.Controls.Add(this.FirstNameRadioButton);
            this.SearchCustomerPanel.Controls.Add(this.LastNameRadioButton);
            this.SearchCustomerPanel.Controls.Add(this.DeleteCustomerButton);
            this.SearchCustomerPanel.Controls.Add(this.EditCustomerButton);
            this.SearchCustomerPanel.Controls.Add(this.CustSearchInstructionsLabel);
            this.SearchCustomerPanel.Controls.Add(this.Customer);
            this.SearchCustomerPanel.Controls.Add(this.SearchButton);
            this.SearchCustomerPanel.Controls.Add(this.SearchTextBox);
            this.SearchCustomerPanel.Controls.Add(this.MoveToAddButton);
            this.SearchCustomerPanel.Location = new System.Drawing.Point(12, 11);
            this.SearchCustomerPanel.Margin = new System.Windows.Forms.Padding(5);
            this.SearchCustomerPanel.Name = "SearchCustomerPanel";
            this.SearchCustomerPanel.Size = new System.Drawing.Size(853, 484);
            this.SearchCustomerPanel.TabIndex = 2;
            // 
            // EmailRadioButton
            // 
            this.EmailRadioButton.AutoSize = true;
            this.EmailRadioButton.Location = new System.Drawing.Point(417, 21);
            this.EmailRadioButton.Name = "EmailRadioButton";
            this.EmailRadioButton.Size = new System.Drawing.Size(114, 21);
            this.EmailRadioButton.TabIndex = 15;
            this.EmailRadioButton.Text = "email address";
            this.EmailRadioButton.UseVisualStyleBackColor = true;
            // 
            // FirstNameRadioButton
            // 
            this.FirstNameRadioButton.AutoSize = true;
            this.FirstNameRadioButton.Checked = true;
            this.FirstNameRadioButton.Location = new System.Drawing.Point(209, 21);
            this.FirstNameRadioButton.Name = "FirstNameRadioButton";
            this.FirstNameRadioButton.Size = new System.Drawing.Size(88, 21);
            this.FirstNameRadioButton.TabIndex = 14;
            this.FirstNameRadioButton.TabStop = true;
            this.FirstNameRadioButton.Text = "first name";
            this.FirstNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // LastNameRadioButton
            // 
            this.LastNameRadioButton.AutoSize = true;
            this.LastNameRadioButton.Location = new System.Drawing.Point(312, 21);
            this.LastNameRadioButton.Name = "LastNameRadioButton";
            this.LastNameRadioButton.Size = new System.Drawing.Size(87, 21);
            this.LastNameRadioButton.TabIndex = 13;
            this.LastNameRadioButton.Text = "last name";
            this.LastNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DeleteCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCustomerButton.ForeColor = System.Drawing.Color.White;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(274, 430);
            this.DeleteCustomerButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(155, 39);
            this.DeleteCustomerButton.TabIndex = 12;
            this.DeleteCustomerButton.Text = "Delete Customer";
            this.DeleteCustomerButton.UseVisualStyleBackColor = false;
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCustomerButton.ForeColor = System.Drawing.Color.White;
            this.EditCustomerButton.Location = new System.Drawing.Point(27, 430);
            this.EditCustomerButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(227, 39);
            this.EditCustomerButton.TabIndex = 11;
            this.EditCustomerButton.Text = "Edit Customer Information";
            this.EditCustomerButton.UseVisualStyleBackColor = false;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // CustSearchInstructionsLabel
            // 
            this.CustSearchInstructionsLabel.AutoSize = true;
            this.CustSearchInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSearchInstructionsLabel.Location = new System.Drawing.Point(24, 23);
            this.CustSearchInstructionsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CustSearchInstructionsLabel.Name = "CustSearchInstructionsLabel";
            this.CustSearchInstructionsLabel.Size = new System.Drawing.Size(165, 17);
            this.CustSearchInstructionsLabel.TabIndex = 10;
            this.CustSearchInstructionsLabel.Text = "Search customers by:";
            // 
            // Customer
            // 
            this.Customer.AllowUserToResizeColumns = false;
            this.Customer.AllowUserToResizeRows = false;
            this.Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.LastName,
            this.EmailAddress,
            this.AcctNum,
            this.City,
            this.Province});
            this.Customer.Location = new System.Drawing.Point(27, 109);
            this.Customer.Margin = new System.Windows.Forms.Padding(5);
            this.Customer.Name = "Customer";
            this.Customer.RowHeadersWidth = 51;
            this.Customer.Size = new System.Drawing.Size(804, 301);
            this.Customer.TabIndex = 9;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 50;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Width = 200;
            // 
            // AcctNum
            // 
            this.AcctNum.HeaderText = "Account Number";
            this.AcctNum.Name = "AcctNum";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // Province
            // 
            this.Province.HeaderText = "Province";
            this.Province.Name = "Province";
            this.Province.Width = 75;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(603, 52);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(139, 39);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(27, 57);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(549, 26);
            this.SearchTextBox.TabIndex = 7;
            // 
            // MoveToAddButton
            // 
            this.MoveToAddButton.BackColor = System.Drawing.Color.SteelBlue;
            this.MoveToAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToAddButton.ForeColor = System.Drawing.Color.White;
            this.MoveToAddButton.Location = new System.Drawing.Point(634, 430);
            this.MoveToAddButton.Margin = new System.Windows.Forms.Padding(5);
            this.MoveToAddButton.Name = "MoveToAddButton";
            this.MoveToAddButton.Size = new System.Drawing.Size(197, 39);
            this.MoveToAddButton.TabIndex = 6;
            this.MoveToAddButton.Text = "Add New Customer";
            this.MoveToAddButton.UseVisualStyleBackColor = false;
            this.MoveToAddButton.Click += new System.EventHandler(this.MoveToAddButton_Click);
            // 
            // EditCustomerPanel
            // 
            this.EditCustomerPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.EditCustomerPanel.Controls.Add(this.comboBox1);
            this.EditCustomerPanel.Controls.Add(this.button1);
            this.EditCustomerPanel.Controls.Add(this.label1);
            this.EditCustomerPanel.Controls.Add(this.textBox2);
            this.EditCustomerPanel.Controls.Add(this.label3);
            this.EditCustomerPanel.Controls.Add(this.textBox3);
            this.EditCustomerPanel.Controls.Add(this.label4);
            this.EditCustomerPanel.Controls.Add(this.textBox4);
            this.EditCustomerPanel.Controls.Add(this.label5);
            this.EditCustomerPanel.Controls.Add(this.textBox5);
            this.EditCustomerPanel.Controls.Add(this.label6);
            this.EditCustomerPanel.Controls.Add(this.label7);
            this.EditCustomerPanel.Controls.Add(this.textBox6);
            this.EditCustomerPanel.Controls.Add(this.label8);
            this.EditCustomerPanel.Controls.Add(this.textBox7);
            this.EditCustomerPanel.Controls.Add(this.label9);
            this.EditCustomerPanel.Controls.Add(this.textBox8);
            this.EditCustomerPanel.Controls.Add(this.label10);
            this.EditCustomerPanel.Controls.Add(this.textBox9);
            this.EditCustomerPanel.Controls.Add(this.label11);
            this.EditCustomerPanel.Controls.Add(this.BackToSearchButton);
            this.EditCustomerPanel.Location = new System.Drawing.Point(12, 11);
            this.EditCustomerPanel.Margin = new System.Windows.Forms.Padding(5);
            this.EditCustomerPanel.Name = "EditCustomerPanel";
            this.EditCustomerPanel.Size = new System.Drawing.Size(853, 484);
            this.EditCustomerPanel.TabIndex = 6;
            this.EditCustomerPanel.Visible = false;
            // 
            // BackToSearchButton
            // 
            this.BackToSearchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BackToSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToSearchButton.ForeColor = System.Drawing.Color.White;
            this.BackToSearchButton.Location = new System.Drawing.Point(297, 428);
            this.BackToSearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.BackToSearchButton.Name = "BackToSearchButton";
            this.BackToSearchButton.Size = new System.Drawing.Size(125, 39);
            this.BackToSearchButton.TabIndex = 5;
            this.BackToSearchButton.Text = "Cancel";
            this.BackToSearchButton.UseVisualStyleBackColor = false;
            this.BackToSearchButton.Click += new System.EventHandler(this.BackToSearchButton_Click);
            // 
            // MoviesTabPage
            // 
            this.MoviesTabPage.Location = new System.Drawing.Point(4, 25);
            this.MoviesTabPage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MoviesTabPage.Name = "MoviesTabPage";
            this.MoviesTabPage.Size = new System.Drawing.Size(878, 506);
            this.MoviesTabPage.TabIndex = 2;
            this.MoviesTabPage.Text = "Movies";
            this.MoviesTabPage.UseVisualStyleBackColor = true;
            // 
            // RentalsTabPage
            // 
            this.RentalsTabPage.Location = new System.Drawing.Point(4, 25);
            this.RentalsTabPage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RentalsTabPage.Name = "RentalsTabPage";
            this.RentalsTabPage.Size = new System.Drawing.Size(878, 506);
            this.RentalsTabPage.TabIndex = 3;
            this.RentalsTabPage.Text = "Rentals";
            this.RentalsTabPage.UseVisualStyleBackColor = true;
            // 
            // ReportsTabPage
            // 
            this.ReportsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ReportsTabPage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ReportsTabPage.Name = "ReportsTabPage";
            this.ReportsTabPage.Size = new System.Drawing.Size(878, 506);
            this.ReportsTabPage.TabIndex = 4;
            this.ReportsTabPage.Text = "Reports";
            this.ReportsTabPage.UseVisualStyleBackColor = true;
            // 
            // AddAcctNumLabel
            // 
            this.AddAcctNumLabel.AutoSize = true;
            this.AddAcctNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAcctNumLabel.Location = new System.Drawing.Point(25, 213);
            this.AddAcctNumLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddAcctNumLabel.Name = "AddAcctNumLabel";
            this.AddAcctNumLabel.Size = new System.Drawing.Size(117, 17);
            this.AddAcctNumLabel.TabIndex = 20;
            this.AddAcctNumLabel.Text = "Account Number:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(156, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 23);
            this.textBox1.TabIndex = 21;
            // 
            // AddAcctNumInstLabel
            // 
            this.AddAcctNumInstLabel.AutoSize = true;
            this.AddAcctNumInstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAcctNumInstLabel.Location = new System.Drawing.Point(452, 217);
            this.AddAcctNumInstLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddAcctNumInstLabel.Name = "AddAcctNumInstLabel";
            this.AddAcctNumInstLabel.Size = new System.Drawing.Size(183, 13);
            this.AddAcctNumInstLabel.TabIndex = 22;
            this.AddAcctNumInstLabel.Text = "Leave blank if creating new account.";
            // 
            // AddCreditLabel
            // 
            this.AddCreditLabel.AutoSize = true;
            this.AddCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCreditLabel.Location = new System.Drawing.Point(25, 137);
            this.AddCreditLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddCreditLabel.Name = "AddCreditLabel";
            this.AddCreditLabel.Size = new System.Drawing.Size(137, 17);
            this.AddCreditLabel.TabIndex = 23;
            this.AddCreditLabel.Text = "Credit Card Number:";
            // 
            // AddCreditTextbox
            // 
            this.AddCreditTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCreditTextbox.Location = new System.Drawing.Point(176, 134);
            this.AddCreditTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddCreditTextbox.Name = "AddCreditTextbox";
            this.AddCreditTextbox.Size = new System.Drawing.Size(282, 23);
            this.AddCreditTextbox.TabIndex = 24;
            // 
            // AddSaveCustomerButton
            // 
            this.AddSaveCustomerButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddSaveCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSaveCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddSaveCustomerButton.Location = new System.Drawing.Point(27, 428);
            this.AddSaveCustomerButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddSaveCustomerButton.Name = "AddSaveCustomerButton";
            this.AddSaveCustomerButton.Size = new System.Drawing.Size(185, 39);
            this.AddSaveCustomerButton.TabIndex = 25;
            this.AddSaveCustomerButton.Text = "Add New Customer";
            this.AddSaveCustomerButton.UseVisualStyleBackColor = false;
            // 
            // AddProvinceComboBox
            // 
            this.AddProvinceComboBox.FormattingEnabled = true;
            this.AddProvinceComboBox.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.AddProvinceComboBox.Location = new System.Drawing.Point(470, 319);
            this.AddProvinceComboBox.Name = "AddProvinceComboBox";
            this.AddProvinceComboBox.Size = new System.Drawing.Size(121, 24);
            this.AddProvinceComboBox.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.comboBox1.Location = new System.Drawing.Point(469, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 39);
            this.button1.TabIndex = 47;
            this.button1.Text = "Save Customer Information";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Credit Card Number:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(175, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 23);
            this.textBox2.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Account Number:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(155, 210);
            this.textBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 23);
            this.textBox3.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email Address:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(140, 99);
            this.textBox4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(282, 23);
            this.textBox4.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Postal Code:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(126, 354);
            this.textBox5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(282, 23);
            this.textBox5.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Province:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "City:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(72, 319);
            this.textBox6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(282, 23);
            this.textBox6.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Address:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(101, 284);
            this.textBox7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(328, 23);
            this.textBox7.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Last Name:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(532, 62);
            this.textBox8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(282, 23);
            this.textBox8.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "First Name:";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(117, 62);
            this.textBox9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(282, 23);
            this.textBox9.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Edit Customer Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 565);
            this.Controls.Add(this.MovieRentalTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Movie Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MovieRentalTabControl.ResumeLayout(false);
            this.LogInTabPage.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.CustomersTabPage.ResumeLayout(false);
            this.AddCustomerPanel.ResumeLayout(false);
            this.AddCustomerPanel.PerformLayout();
            this.SearchCustomerPanel.ResumeLayout(false);
            this.SearchCustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).EndInit();
            this.EditCustomerPanel.ResumeLayout(false);
            this.EditCustomerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MovieRentalTabControl;
        private System.Windows.Forms.TabPage LogInTabPage;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginResultLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TabPage MoviesTabPage;
        private System.Windows.Forms.TabPage RentalsTabPage;
        private System.Windows.Forms.TabPage ReportsTabPage;
        private System.Windows.Forms.Panel AddCustomerPanel;
        private System.Windows.Forms.Panel SearchCustomerPanel;
        private System.Windows.Forms.Label AddCustomersLabel;
        private System.Windows.Forms.Button MoveToSearchButton;
        private System.Windows.Forms.Button MoveToAddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView Customer;
        private System.Windows.Forms.Label CustSearchInstructionsLabel;
        private System.Windows.Forms.Button EditCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Panel EditCustomerPanel;
        private System.Windows.Forms.Button BackToSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcctNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.Label SystemNameLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.RadioButton EmailRadioButton;
        private System.Windows.Forms.RadioButton FirstNameRadioButton;
        private System.Windows.Forms.RadioButton LastNameRadioButton;
        private System.Windows.Forms.Label AddFirstNameLabel;
        private System.Windows.Forms.TextBox AddFirstNameTextbox;
        private System.Windows.Forms.Label AddCityLabel;
        private System.Windows.Forms.TextBox AddCityTextbox;
        private System.Windows.Forms.Label AddAddressLabel;
        private System.Windows.Forms.TextBox AddAddressTextbox;
        private System.Windows.Forms.Label AddLastNameLabel;
        private System.Windows.Forms.TextBox AddLastNameTextbox;
        private System.Windows.Forms.Label AddProvinceLabel;
        private System.Windows.Forms.Label AddEmailLabel;
        private System.Windows.Forms.TextBox AddEmailTextbox;
        private System.Windows.Forms.Label AddPostalCodeLabel;
        private System.Windows.Forms.TextBox AddPostalCodeTextbox;
        private System.Windows.Forms.Button AddSaveCustomerButton;
        private System.Windows.Forms.Label AddCreditLabel;
        private System.Windows.Forms.TextBox AddCreditTextbox;
        private System.Windows.Forms.Label AddAcctNumInstLabel;
        private System.Windows.Forms.Label AddAcctNumLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox AddProvinceComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
    }
}

