
namespace Visual_Perpus
{
    partial class Datapinjam
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
            this.label2 = new System.Windows.Forms.Label();
            this.DataPeminjaman = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1108, 52);
            this.label2.TabIndex = 22;
            this.label2.Text = "DATA PEMINJAMAN TERLAMBAT";
            // 
            // DataPeminjaman
            // 
            this.DataPeminjaman.AllowUserToAddRows = false;
            this.DataPeminjaman.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataPeminjaman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataPeminjaman.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataPeminjaman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataPeminjaman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataPeminjaman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPeminjaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.NIM,
            this.FirstName,
            this.LastName,
            this.RegisterDate,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataPeminjaman.DoubleBuffered = true;
            this.DataPeminjaman.EnableHeadersVisualStyles = false;
            this.DataPeminjaman.HeaderBgColor = System.Drawing.Color.Aqua;
            this.DataPeminjaman.HeaderForeColor = System.Drawing.Color.Black;
            this.DataPeminjaman.Location = new System.Drawing.Point(42, 106);
            this.DataPeminjaman.Name = "DataPeminjaman";
            this.DataPeminjaman.ReadOnly = true;
            this.DataPeminjaman.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataPeminjaman.RowHeadersWidth = 51;
            this.DataPeminjaman.RowTemplate.Height = 24;
            this.DataPeminjaman.Size = new System.Drawing.Size(962, 454);
            this.DataPeminjaman.TabIndex = 26;
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
            // Datapinjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 702);
            this.Controls.Add(this.DataPeminjaman);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datapinjam";
            this.Text = "dataPinjam";
            ((System.ComponentModel.ISupportInitialize)(this.DataPeminjaman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataPeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}