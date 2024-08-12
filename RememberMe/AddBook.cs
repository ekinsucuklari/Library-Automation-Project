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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            SQL.Connect();
        }
        private void AddBook_FormClosing(object sender, EventArgs e)
        {
            SQL.CloseConnection();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string Title = textBoxTitle.Text;
            string Author = textBoxAuthor.Text;
            string  Publisher = textBoxPublisher.Text;
            string  Genre = textBoxGenre.Text;

            SQL.AddBook(Title, Author, Publisher, Genre);
            MessageBox.Show("Member added!");
        }
    }
}
