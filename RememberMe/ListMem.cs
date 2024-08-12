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
    public partial class ListMem : Form
    {
        private const string placeholderText = "Search members by name.";
        public ListMem()
        {
            InitializeComponent();
        }

        private void ListMem_Load(object sender, EventArgs e)
        {
            txtSearchName.Text = placeholderText;
            txtSearchName.ForeColor = Color.LightGray;
            SQL.Connect();
            dataGridViewMembers.DataSource =  SQL.ListMembers();

        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            if (txtSearchName.Text ==placeholderText)
            {
                txtSearchName.Text = "";
                txtSearchName.ForeColor= Color.Black;
            }
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                txtSearchName.Text = placeholderText;
                txtSearchName.ForeColor = Color.LightGray;
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text;
            if (searchName == placeholderText || string.IsNullOrEmpty(searchName))
            {
                
            }
            else
            {
                dataGridViewMembers.DataSource = SQL.SearchMembersByName(searchName);
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

