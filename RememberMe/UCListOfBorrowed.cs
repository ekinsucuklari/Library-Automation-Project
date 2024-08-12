using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RememberMe
{
    public partial class UCListOfBorrowed : UserControl
    {
        public UCListOfBorrowed()
        {
            InitializeComponent();
        }

        public DataGridView dgvBorrowedBooksGrid
        {
            get { return this.dgvBorrowedBooks; }
        }

        private void UCListOfBorrowed_Load(object sender, EventArgs e)
        {
            SQL.SearchBorrowedBooks(dgvBorrowedBooksGrid);
        }

        private void dgvBorrowedBooks_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBorrowedBooks.Columns[e.ColumnIndex].Name == "End_Date")
            {
                DateTime endDate;
                if (DateTime.TryParse(e.Value?.ToString(), out endDate))
                {
                    if (endDate < DateTime.Now)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
