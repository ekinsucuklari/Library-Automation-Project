namespace RememberMe
{
    partial class UCListOfBorrowed
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BorrowedPanel = new System.Windows.Forms.Panel();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.lblBorr = new System.Windows.Forms.Label();
            this.BorrowedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowedPanel
            // 
            this.BorrowedPanel.Controls.Add(this.dgvBorrowedBooks);
            this.BorrowedPanel.Controls.Add(this.lblBorr);
            this.BorrowedPanel.Location = new System.Drawing.Point(3, 22);
            this.BorrowedPanel.Name = "BorrowedPanel";
            this.BorrowedPanel.Size = new System.Drawing.Size(1496, 833);
            this.BorrowedPanel.TabIndex = 0;
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.AllowUserToAddRows = false;
            this.dgvBorrowedBooks.AllowUserToDeleteRows = false;
            this.dgvBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(46, 106);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.RowHeadersWidth = 62;
            this.dgvBorrowedBooks.RowTemplate.Height = 28;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(1217, 502);
            this.dgvBorrowedBooks.TabIndex = 1;
            this.dgvBorrowedBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBorrowedBooks_CellFormatting_1);
            // 
            // lblBorr
            // 
            this.lblBorr.AutoSize = true;
            this.lblBorr.Location = new System.Drawing.Point(502, 14);
            this.lblBorr.Name = "lblBorr";
            this.lblBorr.Size = new System.Drawing.Size(204, 20);
            this.lblBorr.TabIndex = 0;
            this.lblBorr.Text = "LIST BORROWED BOOKS";
            // 
            // UCListOfBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BorrowedPanel);
            this.Name = "UCListOfBorrowed";
            this.Size = new System.Drawing.Size(1536, 873);
            this.Load += new System.EventHandler(this.UCListOfBorrowed_Load);
            this.BorrowedPanel.ResumeLayout(false);
            this.BorrowedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BorrowedPanel;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.Label lblBorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    }
}
