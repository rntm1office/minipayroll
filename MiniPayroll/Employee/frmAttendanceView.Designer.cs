namespace MiniPayroll.Employee
{
    partial class frmAttendanceView
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTotDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgWorkingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "All",
            "Emp Id"});
            this.cmbSearch.Location = new System.Drawing.Point(169, 28);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(164, 26);
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(169, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 24);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(315, 101);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 30);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEmpId,
            this.dgEmpName,
            this.dgYear,
            this.dgMonth,
            this.dgTotDays,
            this.dgWorkingDays,
            this.dgPresent,
            this.dgAbsent,
            this.dgLop});
            this.dataGridView1.Location = new System.Drawing.Point(18, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 291);
            this.dataGridView1.TabIndex = 4;
            // 
            // dgEmpId
            // 
            this.dgEmpId.HeaderText = "Emp Id";
            this.dgEmpId.Name = "dgEmpId";
            this.dgEmpId.ReadOnly = true;
            // 
            // dgEmpName
            // 
            this.dgEmpName.HeaderText = "Name";
            this.dgEmpName.Name = "dgEmpName";
            this.dgEmpName.ReadOnly = true;
            // 
            // dgYear
            // 
            this.dgYear.HeaderText = "Year";
            this.dgYear.Name = "dgYear";
            this.dgYear.ReadOnly = true;
            // 
            // dgMonth
            // 
            this.dgMonth.HeaderText = "Month";
            this.dgMonth.Name = "dgMonth";
            this.dgMonth.ReadOnly = true;
            // 
            // dgTotDays
            // 
            this.dgTotDays.HeaderText = "Total Days";
            this.dgTotDays.Name = "dgTotDays";
            this.dgTotDays.ReadOnly = true;
            // 
            // dgWorkingDays
            // 
            this.dgWorkingDays.HeaderText = "Working Days";
            this.dgWorkingDays.Name = "dgWorkingDays";
            this.dgWorkingDays.ReadOnly = true;
            // 
            // dgPresent
            // 
            this.dgPresent.HeaderText = "Present";
            this.dgPresent.Name = "dgPresent";
            this.dgPresent.ReadOnly = true;
            // 
            // dgAbsent
            // 
            this.dgAbsent.HeaderText = "Absent";
            this.dgAbsent.Name = "dgAbsent";
            this.dgAbsent.ReadOnly = true;
            // 
            // dgLop
            // 
            this.dgLop.HeaderText = "Lop";
            this.dgLop.Name = "dgLop";
            this.dgLop.ReadOnly = true;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbYear.Location = new System.Drawing.Point(413, 27);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(176, 26);
            this.cmbYear.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year :";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(413, 57);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(176, 26);
            this.cmbMonth.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Month :";
            // 
            // frmAttendanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 467);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmAttendanceView";
            this.Text = "Attendance View";
            this.Load += new System.EventHandler(this.frmAttendanceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTotDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgWorkingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLop;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label3;
    }
}