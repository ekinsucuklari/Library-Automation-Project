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
    public partial class Operations : Form
    {
        private const string placeholderText = "Search books.";
        private UCListOfBorrowed ucBorrowed;
        public Operations()
        {
            InitializeComponent();
            InitializeucBorrowed();
        }


        private void InitializeucBorrowed()
        {
            ucBorrowed = new UCListOfBorrowed();
            ucBorrowed.Dock = DockStyle.Fill;
            OperationsPanel.Controls.Add(ucBorrowed);
        }
        public void OpenBorrowForm(int bookId)
        {
            Borrow borrowForm = new Borrow(bookId);
            borrowForm.ShowDialog();
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'girisDataSetBoook.Book' table. You can move, or remove it, as needed.

            txtSearchBook.Text = placeholderText;
            txtSearchBook.ForeColor = Color.LightGray;
            txtSearchBook.Enter += new EventHandler(txtSearchBook_Enter);
            txtSearchBook.Leave += new EventHandler(txtSearchBook_Leave);
            btnSearchBook.Click += new EventHandler(btnSearchBook_Click);
            
            LoadGenres();
            comboBoxGenre.SelectedIndexChanged += new EventHandler(comboBoxGenres_SelectedIndexChanged);
            dataGridViewBooks.DataSource = SQL.GetAllBooks();
            dataGridViewBooks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.ShowDialog();
        }

        private void btnListMem_Click(object sender, EventArgs e)
        {
            ListMem listMem = new ListMem();
            listMem.ShowDialog();
        }

        private void Operations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchBook = txtSearchBook.Text;
            if (searchBook == placeholderText || string.IsNullOrEmpty(searchBook))
            {

            }
            else
            {
                SQL.SearchBooks(searchBook, dataGridViewBooks);
            }
        }

        private void txtSearchBook_Enter(object sender, EventArgs e)
        {
            if (txtSearchBook.Text == placeholderText)
            {
                txtSearchBook.Text = "";
                txtSearchBook.ForeColor = Color.Black;
            }
        }

        private void txtSearchBook_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBook.Text))
            {
                txtSearchBook.Text = placeholderText;
                txtSearchBook.ForeColor = Color.LightGray;
            }
        }
        private void LoadGenres()
        {
            var genres = SQL.GetGenres();
            comboBoxGenre.Items.Add("All");
            comboBoxGenre.Items.AddRange(genres.ToArray());
        }
        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenre = comboBoxGenre.SelectedItem.ToString();
            SearchBooksByGenre(selectedGenre);
        }

        private void SearchBooksByGenre(string genre)
        {
            DataTable books;
            if (genre != "All")
                books = SQL.SearchBooksByGenre(genre);
            else
                books = SQL.GetAllBooks();
            dataGridViewBooks.DataSource = books;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addB = new AddBook();
            addB.ShowDialog();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {

                int rank = Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells[0].Value);

                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    SQL.DeleteRecord(rank);
                    SQL.UpdateRanks();
                    RefreshBooks();

                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void RefreshBooks()
        {
            SQL.SearchBooks("", dataGridViewBooks);
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewBooks.SelectedRows[0];

                    int selectedBookId = Convert.ToInt32(selectedRow.Cells[0].Value);


                    OpenBorrowForm(selectedBookId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az bir kitap seçin.");
            }
            RefreshBooks();
        }


        private void btnListBorrow_Click(object sender, EventArgs e)
        {
            btnSearchBook.Visible = false;  
            txtSearchBook.Visible=false;
            comboBoxGenre.Visible = false;
            ucBorrowed.Visible = true;
            OperationsPanel.Visible = !OperationsPanel.Visible;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (ucBorrowed.dgvBorrowedBooksGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ucBorrowed.dgvBorrowedBooksGrid.SelectedRows[0];
                int selectedId = Convert.ToInt32(ucBorrowed.dgvBorrowedBooksGrid.SelectedRows[0].Cells["id"].Value);

                SQL.Connect();
                SQL.DeleteBorrowedRecord(selectedId);
                SQL.UpdateRanks();
                SQL.RefreshBorrowed(ucBorrowed.dgvBorrowedBooksGrid);

                string query = "SELECT * FROM Borrow";
                DataTable dt = SQL.BindToGrid(query);

                ucBorrowed.dgvBorrowedBooksGrid.DataSource = dt;
                if (ucBorrowed.dgvBorrowedBooksGrid.Columns["id"] != null)
                {
                    ucBorrowed.dgvBorrowedBooksGrid.Columns["id"].Visible = false;
                }
                if (ucBorrowed.dgvBorrowedBooksGrid.Columns["Member_id"] != null)
                {
                    ucBorrowed.dgvBorrowedBooksGrid.Columns["Member_id"].Visible = false;
                }
                if (ucBorrowed.dgvBorrowedBooksGrid.Columns["Book_id"] != null)
                {
                    ucBorrowed.dgvBorrowedBooksGrid.Columns["Book_id"].Visible = false;
                }


            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }


}