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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginResultLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.MoviesTabPage = new System.Windows.Forms.TabPage();
            this.RentalsTabPage = new System.Windows.Forms.TabPage();
            this.ReportsTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovieRentalTabControl.SuspendLayout();
            this.LogInTabPage.SuspendLayout();
            this.MoviesTabPage.SuspendLayout();
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
            this.MovieRentalTabControl.Location = new System.Drawing.Point(16, 15);
            this.MovieRentalTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MovieRentalTabControl.Name = "MovieRentalTabControl";
            this.MovieRentalTabControl.SelectedIndex = 0;
            this.MovieRentalTabControl.Size = new System.Drawing.Size(1035, 517);
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
            this.LogInTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.LogInTabPage.Name = "LogInTabPage";
            this.LogInTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.LogInTabPage.Size = new System.Drawing.Size(1027, 488);
            this.LogInTabPage.TabIndex = 0;
            this.LogInTabPage.Text = "Log In";
            this.LogInTabPage.UseVisualStyleBackColor = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(120, 97);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(192, 26);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Enter Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginResultLabel
            // 
            this.LoginResultLabel.AutoSize = true;
            this.LoginResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginResultLabel.Location = new System.Drawing.Point(379, 295);
            this.LoginResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginResultLabel.Name = "LoginResultLabel";
            this.LoginResultLabel.Size = new System.Drawing.Size(98, 20);
            this.LoginResultLabel.TabIndex = 5;
            this.LoginResultLabel.Text = "Login Result";
            this.LoginResultLabel.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(120, 167);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(187, 26);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Enter Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(127, 271);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(208, 69);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.Location = new System.Drawing.Point(384, 97);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(299, 26);
            this.UsernameTextbox.TabIndex = 2;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.Location = new System.Drawing.Point(384, 167);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(299, 26);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.CustomersTabPage.Size = new System.Drawing.Size(1027, 488);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesTabPage
            // 
            this.MoviesTabPage.Controls.Add(this.panel1);
            this.MoviesTabPage.Location = new System.Drawing.Point(4, 25);
            this.MoviesTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.MoviesTabPage.Name = "MoviesTabPage";
            this.MoviesTabPage.Size = new System.Drawing.Size(1027, 488);
            this.MoviesTabPage.TabIndex = 2;
            this.MoviesTabPage.Text = "Movies";
            this.MoviesTabPage.UseVisualStyleBackColor = true;
            // 
            // RentalsTabPage
            // 
            this.RentalsTabPage.Location = new System.Drawing.Point(4, 25);
            this.RentalsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.RentalsTabPage.Name = "RentalsTabPage";
            this.RentalsTabPage.Size = new System.Drawing.Size(1027, 488);
            this.RentalsTabPage.TabIndex = 3;
            this.RentalsTabPage.Text = "Rentals";
            this.RentalsTabPage.UseVisualStyleBackColor = true;
            // 
            // ReportsTabPage
            // 
            this.ReportsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ReportsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ReportsTabPage.Name = "ReportsTabPage";
            this.ReportsTabPage.Size = new System.Drawing.Size(1027, 488);
            this.ReportsTabPage.TabIndex = 4;
            this.ReportsTabPage.Text = "Reports";
            this.ReportsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 482);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 546);
            this.Controls.Add(this.MovieRentalTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Movie Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MovieRentalTabControl.ResumeLayout(false);
            this.LogInTabPage.ResumeLayout(false);
            this.LogInTabPage.PerformLayout();
            this.MoviesTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}

