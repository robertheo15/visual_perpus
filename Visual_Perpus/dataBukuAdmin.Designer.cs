
namespace Visual_Perpus
{
    partial class Databukuadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Databukuadmin));
            this.DataGridBook = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddBook = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridBook
            // 
            this.DataGridBook.AllowUserToAddRows = false;
            this.DataGridBook.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridBook.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Col1,
            this.Col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6});
            this.DataGridBook.DoubleBuffered = true;
            this.DataGridBook.EnableHeadersVisualStyles = false;
            this.DataGridBook.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridBook.HeaderForeColor = System.Drawing.Color.Black;
            this.DataGridBook.Location = new System.Drawing.Point(27, 140);
            this.DataGridBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridBook.Name = "DataGridBook";
            this.DataGridBook.ReadOnly = true;
            this.DataGridBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridBook.RowHeadersWidth = 51;
            this.DataGridBook.RowTemplate.Height = 24;
            this.DataGridBook.Size = new System.Drawing.Size(708, 367);
            this.DataGridBook.TabIndex = 19;
            this.DataGridBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBook_CellContentClick);
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 125;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Title";
            this.Col1.MinimumWidth = 6;
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Width = 125;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "author";
            this.Col2.MinimumWidth = 6;
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Width = 125;
            // 
            // col3
            // 
            this.col3.HeaderText = "year";
            this.col3.MinimumWidth = 6;
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Width = 125;
            // 
            // col4
            // 
            this.col4.HeaderText = "quantity";
            this.col4.MinimumWidth = 6;
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            this.col4.Width = 125;
            // 
            // col5
            // 
            this.col5.HeaderText = "type";
            this.col5.MinimumWidth = 6;
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            this.col5.Width = 125;
            // 
            // col6
            // 
            this.col6.HeaderText = "price";
            this.col6.MinimumWidth = 6;
            this.col6.Name = "col6";
            this.col6.ReadOnly = true;
            this.col6.Width = 125;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "CARI";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuThinButton21.Location = new System.Drawing.Point(311, 91);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(152, 33);
            this.bunifuThinButton21.TabIndex = 18;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(27, 81);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(278, 36);
            this.bunifuMaterialTextbox1.TabIndex = 17;
            this.bunifuMaterialTextbox1.Text = "Search Book";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(772, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "DAFTAR BUKU";
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.ActiveBorderThickness = 1;
            this.BtnAddBook.ActiveCornerRadius = 20;
            this.BtnAddBook.ActiveFillColor = System.Drawing.Color.SpringGreen;
            this.BtnAddBook.ActiveForecolor = System.Drawing.Color.White;
            this.BtnAddBook.ActiveLineColor = System.Drawing.Color.SpringGreen;
            this.BtnAddBook.BackColor = System.Drawing.Color.White;
            this.BtnAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddBook.BackgroundImage")));
            this.BtnAddBook.ButtonText = "TAMBAH";
            this.BtnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBook.ForeColor = System.Drawing.Color.Black;
            this.BtnAddBook.IdleBorderThickness = 1;
            this.BtnAddBook.IdleCornerRadius = 20;
            this.BtnAddBook.IdleFillColor = System.Drawing.Color.White;
            this.BtnAddBook.IdleForecolor = System.Drawing.Color.SpringGreen;
            this.BtnAddBook.IdleLineColor = System.Drawing.Color.SpringGreen;
            this.BtnAddBook.Location = new System.Drawing.Point(523, 91);
            this.BtnAddBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(99, 33);
            this.BtnAddBook.TabIndex = 20;
            this.BtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "HAPUS";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Crimson;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton23.Location = new System.Drawing.Point(636, 91);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(99, 33);
            this.bunifuThinButton23.TabIndex = 21;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // Databukuadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 556);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.DataGridBook);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Databukuadmin";
            this.Text = "dataBukuAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridBook;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAddBook;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;
    }
}