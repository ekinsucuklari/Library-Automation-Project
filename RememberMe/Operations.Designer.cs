namespace RememberMe
{
    partial class Operations
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
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.groupBoxMembers = new System.Windows.Forms.GroupBox();
            this.btnAddMem = new System.Windows.Forms.Button();
            this.btnListMem = new System.Windows.Forms.Button();
            this.groupBoxBooks = new System.Windows.Forms.GroupBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.groupBoxBorrow = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnListBorrow = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.groupBoxMembers.SuspendLayout();
            this.groupBoxBooks.SuspendLayout();
            this.groupBoxBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(700, 30);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(345, 26);
            this.txtSearchBook.TabIndex = 0;
            this.txtSearchBook.Enter += new System.EventHandler(this.txtSearchBook_Enter);
            this.txtSearchBook.Leave += new System.EventHandler(this.txtSearchBook_Leave);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(1060, 30);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(94, 37);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // groupBoxMembers
            // 
            this.groupBoxMembers.Controls.Add(this.btnAddMem);
            this.groupBoxMembers.Controls.Add(this.btnListMem);
            this.groupBoxMembers.Location = new System.Drawing.Point(12, 229);
            this.groupBoxMembers.Name = "groupBoxMembers";
            this.groupBoxMembers.Size = new System.Drawing.Size(227, 193);
            this.groupBoxMembers.TabIndex = 2;
            this.groupBoxMembers.TabStop = false;
            this.groupBoxMembers.Text = "Member Operations";
            // 
            // btnAddMem
            // 
            this.btnAddMem.Location = new System.Drawing.Point(6, 83);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Size = new System.Drawing.Size(215, 58);
            this.btnAddMem.TabIndex = 5;
            this.btnAddMem.Text = "Add Member";
            this.btnAddMem.UseVisualStyleBackColor = true;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // btnListMem
            // 
            this.btnListMem.Location = new System.Drawing.Point(6, 25);
            this.btnListMem.Name = "btnListMem";
            this.btnListMem.Size = new System.Drawing.Size(215, 52);
            this.btnListMem.TabIndex = 6;
            this.btnListMem.Text = "List Members";
            this.btnListMem.UseVisualStyleBackColor = true;
            this.btnListMem.Click += new System.EventHandler(this.btnListMem_Click);
            // 
            // groupBoxBooks
            // 
            this.groupBoxBooks.Controls.Add(this.btnDeleteBook);
            this.groupBoxBooks.Controls.Add(this.btnAddBook);
            this.groupBoxBooks.Location = new System.Drawing.Point(12, 376);
            this.groupBoxBooks.Name = "groupBoxBooks";
            this.groupBoxBooks.Size = new System.Drawing.Size(227, 191);
            this.groupBoxBooks.TabIndex = 3;
            this.groupBoxBooks.TabStop = false;
            this.groupBoxBooks.Text = "Book Operations";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(6, 83);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(215, 56);
            this.btnDeleteBook.TabIndex = 8;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(6, 25);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(215, 52);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // groupBoxBorrow
            // 
            this.groupBoxBorrow.Controls.Add(this.btnReturn);
            this.groupBoxBorrow.Controls.Add(this.btnBorrow);
            this.groupBoxBorrow.Controls.Add(this.btnListBorrow);
            this.groupBoxBorrow.Location = new System.Drawing.Point(12, 521);
            this.groupBoxBorrow.Name = "groupBoxBorrow";
            this.groupBoxBorrow.Size = new System.Drawing.Size(227, 222);
            this.groupBoxBorrow.TabIndex = 4;
            this.groupBoxBorrow.TabStop = false;
            this.groupBoxBorrow.Text = "Borrowing";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(6, 158);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(215, 58);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(6, 25);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(215, 64);
            this.btnBorrow.TabIndex = 8;
            this.btnBorrow.Text = "Borrow A Book";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnListBorrow
            // 
            this.btnListBorrow.Location = new System.Drawing.Point(6, 95);
            this.btnListBorrow.Name = "btnListBorrow";
            this.btnListBorrow.Size = new System.Drawing.Size(215, 57);
            this.btnListBorrow.TabIndex = 9;
            this.btnListBorrow.Text = "List Borrowed Books";
            this.btnListBorrow.UseVisualStyleBackColor = true;
            this.btnListBorrow.Click += new System.EventHandler(this.btnListBorrow_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(333, 171);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidth = 62;
            this.dataGridViewBooks.RowTemplate.Height = 28;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1300, 700);
            this.dataGridViewBooks.TabIndex = 5;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(1354, 119);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(279, 28);
            this.comboBoxGenre.TabIndex = 6;
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.BackColor = System.Drawing.Color.Transparent;
            this.OperationsPanel.Location = new System.Drawing.Point(333, 171);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(1300, 700);
            this.OperationsPanel.TabIndex = 7;
            this.OperationsPanel.Visible = false;
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 956);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.groupBoxBorrow);
            this.Controls.Add(this.groupBoxBooks);
            this.Controls.Add(this.groupBoxMembers);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.txtSearchBook);
            this.Name = "Operations";
            this.Text = "Operations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operations_FormClosing);
            this.Load += new System.EventHandler(this.Operations_Load);
            this.groupBoxMembers.ResumeLayout(false);
            this.groupBoxBooks.ResumeLayout(false);
            this.groupBoxBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.GroupBox groupBoxMembers;
        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.Button btnListMem;
        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox groupBoxBorrow;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnListBorrow;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button btnDeleteBook;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel OperationsPanel;
        //private girisDataSet4TableAdapters.BookTableAdapter bookTableAdapter1;
    }
}