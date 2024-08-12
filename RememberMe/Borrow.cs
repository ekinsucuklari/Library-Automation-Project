using System;
using System.Drawing;
using System.Windows.Forms;

namespace RememberMe
{
    public partial class Borrow : Form
    {
        private const string placeholderText = "Search members by name.";

        private int selectedBookId;
        private int selectedMemberId;
        private SQL sql = new SQL();

        public Borrow(int bookId)
        {
            InitializeComponent();
            selectedBookId = bookId;
        }

        private void Borrow_Load(object sender, EventArgs e)
        {

            dtpEndDate.MinDate = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(15);


            dgvBorrow.SelectionChanged += dgvBorrow_SelectionChanged;
            txtSelMem.Text = placeholderText;
            txtSelMem.ForeColor = Color.LightGray;
            txtSelMem.Enter += txtSelMem_Enter;
            txtSelMem.Leave += txtSelMem_Leave;
            btnSelSearch.Click += btnSelSearch_Click;
            dgvBorrow.DataSource = SQL.ListMembers();
        }

        private void dgvBorrow_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBorrow.SelectedRows.Count > 0)
            {
                try
                {
                    selectedMemberId = Convert.ToInt32(dgvBorrow.SelectedRows[0].Cells[0].Value);
                    MessageBox.Show($"Selected Member ID: {selectedMemberId}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = dtpEndDate.Value;

            if (selectedMemberId > 0)
            {
                SQL.InsertBorrowRecord(selectedMemberId, selectedBookId, startDate, endDate);
                SQL.Connect();
                MessageBox.Show("Book borrowed successfully!");
                this.Close();
                //artık borrowed a eklendiği için books tan silicez.
                SQL.DeleteRecord(selectedBookId);
                SQL.UpdateRanks();
               

            }
            else
            {
                MessageBox.Show("Please select a member.");
            }

        }
        
        private void txtSelMem_Enter(object sender, EventArgs e)
        {
            if (txtSelMem.Text == placeholderText)
            {
                txtSelMem.Text = "";
                txtSelMem.ForeColor = Color.Black;
            }
        }

        private void txtSelMem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSelMem.Text))
            {
                txtSelMem.Text = placeholderText;
                txtSelMem.ForeColor = Color.LightGray;
            }
        }

        private void btnSelSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSelMem.Text;
            if (searchName == placeholderText || string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter a name to search.");
            }
            else
            {
                dgvBorrow.DataSource = SQL.SearchMembersByName(searchName);
            }
        }


    }
}
