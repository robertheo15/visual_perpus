
namespace Visual_Perpus
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label2 = new System.Windows.Forms.Label();
            this.DataReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSearchLaporan = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LabelError = new System.Windows.Forms.Label();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(48, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1029, 52);
            this.label2.TabIndex = 28;
            this.label2.Text = "LAPORAN";
            // 
            // DataReport
            // 
            this.DataReport.AllowUserToAddRows = false;
            this.DataReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataReport.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.NIM,
            this.FirstName,
            this.LastName,
            this.RegisterDate,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataReport.DoubleBuffered = true;
            this.DataReport.EnableHeadersVisualStyles = false;
            this.DataReport.HeaderBgColor = System.Drawing.Color.Aqua;
            this.DataReport.HeaderForeColor = System.Drawing.Color.Black;
            this.DataReport.Location = new System.Drawing.Point(54, 178);
            this.DataReport.Name = "DataReport";
            this.DataReport.ReadOnly = true;
            this.DataReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataReport.RowHeadersWidth = 51;
            this.DataReport.RowTemplate.Height = 24;
            this.DataReport.Size = new System.Drawing.Size(962, 454);
            this.DataReport.TabIndex = 31;
            // 
            // col1
            // 
            this.col1.HeaderText = "No Order";
            this.col1.MinimumWidth = 6;
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 125;
            // 
            // NIM
            // 
            this.NIM.HeaderText = "First Name";
            this.NIM.MinimumWidth = 6;
            this.NIM.Name = "NIM";
            this.NIM.ReadOnly = true;
            this.NIM.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Last Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Title Book";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // RegisterDate
            // 
            this.RegisterDate.HeaderText = "Date From";
            this.RegisterDate.MinimumWidth = 6;
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            this.RegisterDate.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date To";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Return";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(51, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "From";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(459, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 37);
            this.label3.TabIndex = 35;
            this.label3.Text = "To";
            // 
            // BtnSearchLaporan
            // 
            this.BtnSearchLaporan.ActiveBorderThickness = 1;
            this.BtnSearchLaporan.ActiveCornerRadius = 20;
            this.BtnSearchLaporan.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchLaporan.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSearchLaporan.ActiveLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchLaporan.BackColor = System.Drawing.Color.White;
            this.BtnSearchLaporan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearchLaporan.BackgroundImage")));
            this.BtnSearchLaporan.ButtonText = "CARI";
            this.BtnSearchLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchLaporan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchLaporan.ForeColor = System.Drawing.Color.Black;
            this.BtnSearchLaporan.IdleBorderThickness = 1;
            this.BtnSearchLaporan.IdleCornerRadius = 20;
            this.BtnSearchLaporan.IdleFillColor = System.Drawing.Color.White;
            this.BtnSearchLaporan.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchLaporan.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchLaporan.Location = new System.Drawing.Point(775, 119);
            this.BtnSearchLaporan.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSearchLaporan.Name = "BtnSearchLaporan";
            this.BtnSearchLaporan.Size = new System.Drawing.Size(202, 41);
            this.BtnSearchLaporan.TabIndex = 36;
            this.BtnSearchLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSearchLaporan.Click += new System.EventHandler(this.BtnSearchLaporan_Click);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelError.Location = new System.Drawing.Point(620, 79);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(29, 29);
            this.LabelError.TabIndex = 37;
            this.LabelError.Text = "--";
            // 
            // DateFrom
            // 
            this.DateFrom.CustomFormat = "yyyy-MM-dd";
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFrom.Location = new System.Drawing.Point(170, 129);
            this.DateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(237, 22);
            this.DateFrom.TabIndex = 352;
            // 
            // DateTo
            // 
            this.DateTo.CustomFormat = "yyyy-MM-dd";
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTo.Location = new System.Drawing.Point(516, 129);
            this.DateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(237, 22);
            this.DateTo.TabIndex = 353;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 740);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.BtnSearchLaporan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataReport);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "report";
            ((System.ComponentModel.ISupportInitialize)(this.DataReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSearchLaporan;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
    }
}