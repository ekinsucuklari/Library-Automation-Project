namespace RememberMe
{
    partial class Borrow
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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.lblMember = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtSelMem = new System.Windows.Forms.TextBox();
            this.btnSelSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(57, 416);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(120, 20);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Borrowed Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(321, 416);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(76, 20);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "Deadline:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(373, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(147, 20);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "BORROW A BOOK";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(549, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(198, 165);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersWidth = 62;
            this.dgvBorrow.RowTemplate.Height = 28;
            this.dgvBorrow.Size = new System.Drawing.Size(516, 226);
            this.dgvBorrow.TabIndex = 8;
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(57, 193);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(135, 20);
            this.lblMember.TabIndex = 9;
            this.lblMember.Text = "Select A Member:";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpStart.Enabled = false;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(198, 416);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(117, 26);
            this.dtpStart.TabIndex = 10;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(403, 416);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(117, 26);
            this.dtpEndDate.TabIndex = 11;
            this.dtpEndDate.Value = new System.DateTime(2024, 8, 3, 0, 0, 0, 0);
            // 
            // txtSelMem
            // 
            this.txtSelMem.Location = new System.Drawing.Point(348, 113);
            this.txtSelMem.Name = "txtSelMem";
            this.txtSelMem.Size = new System.Drawing.Size(238, 26);
            this.txtSelMem.TabIndex = 12;
            this.txtSelMem.Enter += new System.EventHandler(this.txtSelMem_Enter);
            this.txtSelMem.Leave += new System.EventHandler(this.txtSelMem_Leave);
            // 
            // btnSelSearch
            // 
            this.btnSelSearch.Location = new System.Drawing.Point(613, 107);
            this.btnSelSearch.Name = "btnSelSearch";
            this.btnSelSearch.Size = new System.Drawing.Size(101, 39);
            this.btnSelSearch.TabIndex = 13;
            this.btnSelSearch.Text = "Search";
            this.btnSelSearch.UseVisualStyleBackColor = true;
            this.btnSelSearch.Click += new System.EventHandler(this.btnSelSearch_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 504);
            this.Controls.Add(this.btnSelSearch);
            this.Controls.Add(this.txtSelMem);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Name = "Borrow";
            this.Text = "Borrow";
            
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        //private girisDataSet2TableAdapters.MembersTableAdapter membersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSelMem;
        private System.Windows.Forms.Button btnSelSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}