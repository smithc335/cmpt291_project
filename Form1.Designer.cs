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
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginResultLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.MoviesTabPage = new System.Windows.Forms.TabPage();
            this.RentalsTabPage = new System.Windows.Forms.TabPage();
            this.ReportsTabPage = new System.Windows.Forms.TabPage();
            this.AddCustomerPanel = new System.Windows.Forms.Panel();
            this.AddCustomersLabel = new System.Windows.Forms.Label();
            this.SearchCustomerPanel = new System.Windows.Forms.Panel();
            this.SearchCustomerLabel = new System.Windows.Forms.Label();
            this.MoveToSearchButton = new System.Windows.Forms.Button();
            this.MoveToAddButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.DataGridView();
            this.MovieRentalTabControl.SuspendLayout();
            this.LogInTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.AddCustomerPanel.SuspendLayout();
            this.SearchCustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).BeginInit();
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
            this.MovieRentalTabControl.Location = new System.Drawing.Point(12, 12);
            this.MovieRentalTabControl.Name = "MovieRentalTabControl";
            this.MovieRentalTabControl.SelectedIndex = 0;
            this.MovieRentalTabControl.Size = new System.Drawing.Size(776, 420);
            this.MovieRentalTabControl.TabIndex = 6;
            // 
            // LogInTabPage
            // 
            this.LogInTabPage.Controls.Add(this.UsernameLabel);
            this.LogInTabPage.Controls.Add(this.LoginResultLabel);
            this.LogInTabPage.Controls.Add(this.PasswordLabel);
            this.LogInTabPage.Controls.Add(this.LoginButton);
            this.LogInTabPage.Controls.Add(this.UsernameTextbox);
            this.LogInTabPage.Controls.Add(this.PasswordTextbox);
            this.LogInTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInTabPage.Location = new System.Drawing.Point(4, 25);
            this.LogInTabPage.Name = "LogInTabPage";
            this.LogInTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogInTabPage.Size = new System.Drawing.Size(768, 391);
            this.LogInTabPage.TabIndex = 0;
            this.LogInTabPage.Text = "Log In";
            this.LogInTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.SearchCustomerPanel);
            this.CustomersTabPage.Controls.Add(this.AddCustomerPanel);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(768, 391);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(90, 79);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(192, 26);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Enter Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(90, 136);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(187, 26);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Enter Password:";
            // 
            // LoginResultLabel
            // 
            this.LoginResultLabel.AutoSize = true;
            this.LoginResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginResultLabel.Location = new System.Drawing.Point(284, 240);
            this.LoginResultLabel.Name = "LoginResultLabel";
            this.LoginResultLabel.Size = new System.Drawing.Size(98, 20);
            this.LoginResultLabel.TabIndex = 5;
            this.LoginResultLabel.Text = "Login Result";
            this.LoginResultLabel.Visible = false;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.Location = new System.Drawing.Point(288, 136);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(225, 26);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(95, 220);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(156, 56);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.Location = new System.Drawing.Point(288, 79);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(225, 26);
            this.UsernameTextbox.TabIndex = 2;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // MoviesTabPage
            // 
            this.MoviesTabPage.Location = new System.Drawing.Point(4, 25);
            this.MoviesTabPage.Name = "MoviesTabPage";
            this.MoviesTabPage.Size = new System.Drawing.Size(768, 391);
            this.MoviesTabPage.TabIndex = 2;
            this.MoviesTabPage.Text = "Movies";
            this.MoviesTabPage.UseVisualStyleBackColor = true;
            // 
            // RentalsTabPage
            // 
            this.RentalsTabPage.Location = new System.Drawing.Point(4, 25);
            this.RentalsTabPage.Name = "RentalsTabPage";
            this.RentalsTabPage.Size = new System.Drawing.Size(768, 391);
            this.RentalsTabPage.TabIndex = 3;
            this.RentalsTabPage.Text = "Rentals";
            this.RentalsTabPage.UseVisualStyleBackColor = true;
            // 
            // ReportsTabPage
            // 
            this.ReportsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ReportsTabPage.Name = "ReportsTabPage";
            this.ReportsTabPage.Size = new System.Drawing.Size(768, 391);
            this.ReportsTabPage.TabIndex = 4;
            this.ReportsTabPage.Text = "Reports";
            this.ReportsTabPage.UseVisualStyleBackColor = true;
            // 
            // AddCustomerPanel
            // 
            this.AddCustomerPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.AddCustomerPanel.Controls.Add(this.MoveToSearchButton);
            this.AddCustomerPanel.Controls.Add(this.AddCustomersLabel);
            this.AddCustomerPanel.Location = new System.Drawing.Point(6, 6);
            this.AddCustomerPanel.Name = "AddCustomerPanel";
            this.AddCustomerPanel.Size = new System.Drawing.Size(756, 379);
            this.AddCustomerPanel.TabIndex = 0;
            this.AddCustomerPanel.Visible = false;
            // 
            // AddCustomersLabel
            // 
            this.AddCustomersLabel.AutoSize = true;
            this.AddCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomersLabel.Location = new System.Drawing.Point(20, 20);
            this.AddCustomersLabel.Name = "AddCustomersLabel";
            this.AddCustomersLabel.Size = new System.Drawing.Size(164, 26);
            this.AddCustomersLabel.TabIndex = 1;
            this.AddCustomersLabel.Text = "Add Customer";
            // 
            // SearchCustomerPanel
            // 
            this.SearchCustomerPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.SearchCustomerPanel.Controls.Add(this.Customer);
            this.SearchCustomerPanel.Controls.Add(this.SearchButton);
            this.SearchCustomerPanel.Controls.Add(this.SearchTextBox);
            this.SearchCustomerPanel.Controls.Add(this.MoveToAddButton);
            this.SearchCustomerPanel.Controls.Add(this.SearchCustomerLabel);
            this.SearchCustomerPanel.Location = new System.Drawing.Point(6, 6);
            this.SearchCustomerPanel.Name = "SearchCustomerPanel";
            this.SearchCustomerPanel.Size = new System.Drawing.Size(756, 379);
            this.SearchCustomerPanel.TabIndex = 2;
            // 
            // SearchCustomerLabel
            // 
            this.SearchCustomerLabel.AutoSize = true;
            this.SearchCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerLabel.Location = new System.Drawing.Point(20, 20);
            this.SearchCustomerLabel.Name = "SearchCustomerLabel";
            this.SearchCustomerLabel.Size = new System.Drawing.Size(197, 26);
            this.SearchCustomerLabel.TabIndex = 1;
            this.SearchCustomerLabel.Text = "Search Customer";
            // 
            // MoveToSearchButton
            // 
            this.MoveToSearchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.MoveToSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToSearchButton.ForeColor = System.Drawing.Color.White;
            this.MoveToSearchButton.Location = new System.Drawing.Point(578, 292);
            this.MoveToSearchButton.Name = "MoveToSearchButton";
            this.MoveToSearchButton.Size = new System.Drawing.Size(156, 67);
            this.MoveToSearchButton.TabIndex = 5;
            this.MoveToSearchButton.Text = "Search Customers";
            this.MoveToSearchButton.UseVisualStyleBackColor = false;
            this.MoveToSearchButton.Click += new System.EventHandler(this.MoveToSearchButton_Click);
            // 
            // MoveToAddButton
            // 
            this.MoveToAddButton.BackColor = System.Drawing.Color.SteelBlue;
            this.MoveToAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToAddButton.ForeColor = System.Drawing.Color.White;
            this.MoveToAddButton.Location = new System.Drawing.Point(561, 308);
            this.MoveToAddButton.Name = "MoveToAddButton";
            this.MoveToAddButton.Size = new System.Drawing.Size(173, 51);
            this.MoveToAddButton.TabIndex = 6;
            this.MoveToAddButton.Text = "Add Customer";
            this.MoveToAddButton.UseVisualStyleBackColor = false;
            this.MoveToAddButton.Click += new System.EventHandler(this.MoveToAddButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(25, 64);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(501, 26);
            this.SearchTextBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(561, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(173, 51);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Customer
            // 
            this.Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer.Location = new System.Drawing.Point(25, 113);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(501, 246);
            this.Customer.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.MovieRentalTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Movie Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MovieRentalTabControl.ResumeLayout(false);
            this.LogInTabPage.ResumeLayout(false);
            this.LogInTabPage.PerformLayout();
            this.CustomersTabPage.ResumeLayout(false);
            this.AddCustomerPanel.ResumeLayout(false);
            this.AddCustomerPanel.PerformLayout();
            this.SearchCustomerPanel.ResumeLayout(false);
            this.SearchCustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).EndInit();
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
        private System.Windows.Forms.Label SearchCustomerLabel;
        private System.Windows.Forms.Label AddCustomersLabel;
        private System.Windows.Forms.Button MoveToSearchButton;
        private System.Windows.Forms.Button MoveToAddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView Customer;
    }
}

