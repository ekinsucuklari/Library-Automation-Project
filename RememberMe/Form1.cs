using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RememberMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void LoadCredentials()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username))
            {
                txtName.Text = Properties.Settings.Default.Username;
                string encryptedPassword = Properties.Settings.Default.Password;
                string salt = Properties.Settings.Default.Salt;  

            }
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void mail_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password.");
                    return; 
                }

                SQL.InsertData(name, password);

                Operations opr = new Operations();
                this.Hide();
                opr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            try
            {
                bool isValid = SQL.ValidateLogin(name, password);

                if (isValid)
                {
                    Operations opr = new Operations();
                    this.Hide();
                    opr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SQL.Connect();
            LoadCredentials();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.CloseConnection();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShow.Checked ? '\0' : '*';
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
