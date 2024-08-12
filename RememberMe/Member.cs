using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RememberMe
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtMemName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            SQL.AddMember(name, phone, address);
            MessageBox.Show("Member added!");
        }

        private void Member_Load(object sender, EventArgs e)
        {
            SQL.Connect();

        }

        private void Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.CloseConnection();
        }
    }
}
