using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Hash Code Implementation for User Password
            string sSourceData;
            byte[] tmpSource;
            byte[] tmpHash;

            sSourceData = PasswordTextbox.Text;
            //Create a byte array from source data.
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);

            System.Console.WriteLine("Hello, World!");

            //Compute hash based on source data.
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            Console.WriteLine(ByteArrayToString(tmpHash));
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Hash Code Implementation for User Password
            string userPassword;
            byte[] tmpSource;
            byte[] passwordHash;

            userPassword = PasswordTextbox.Text;
            // Create a byte array from inputted password.
            tmpSource = ASCIIEncoding.ASCII.GetBytes(userPassword);

            // Compute hash based on inputted password.
            passwordHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            Console.WriteLine(ByteArrayToString(passwordHash));

            // Check whether hash matches entry in database.
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
    }
}
