﻿
namespace Visual_Perpus
{
    partial class Peminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peminjaman));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxNimPeminjaman = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnSearchPeminjaman = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BtnPinjamBuku = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtBoxIdBookPeminjaman = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBoxErrorNim = new System.Windows.Forms.TextBox();
            this.TxtBoxErrorBook = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(53, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(53, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "PEMINJAMAN";
            // 
            // TxtBoxNimPeminjaman
            // 
            this.TxtBoxNimPeminjaman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxNimPeminjaman.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtBoxNimPeminjaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxNimPeminjaman.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBoxNimPeminjaman.HintText = "";
            this.TxtBoxNimPeminjaman.isPassword = false;
            this.TxtBoxNimPeminjaman.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.TxtBoxNimPeminjaman.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtBoxNimPeminjaman.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.TxtBoxNimPeminjaman.LineThickness = 3;
            this.TxtBoxNimPeminjaman.Location = new System.Drawing.Point(145, 105);
            this.TxtBoxNimPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxNimPeminjaman.Name = "TxtBoxNimPeminjaman";
            this.TxtBoxNimPeminjaman.Size = new System.Drawing.Size(370, 44);
            this.TxtBoxNimPeminjaman.TabIndex = 2;
            this.TxtBoxNimPeminjaman.Text = "Insert NIM here";
            this.TxtBoxNimPeminjaman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBoxNimPeminjaman.OnValueChanged += new System.EventHandler(this.LabelNimPeminjaman_OnValueChanged);
            // 
            // BtnSearchPeminjaman
            // 
            this.BtnSearchPeminjaman.ActiveBorderThickness = 1;
            this.BtnSearchPeminjaman.ActiveCornerRadius = 20;
            this.BtnSearchPeminjaman.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchPeminjaman.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSearchPeminjaman.ActiveLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchPeminjaman.BackColor = System.Drawing.Color.White;
            this.BtnSearchPeminjaman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearchPeminjaman.BackgroundImage")));
            this.BtnSearchPeminjaman.ButtonText = "CARI";
            this.BtnSearchPeminjaman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchPeminjaman.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchPeminjaman.ForeColor = System.Drawing.Color.Black;
            this.BtnSearchPeminjaman.IdleBorderThickness = 1;
            this.BtnSearchPeminjaman.IdleCornerRadius = 20;
            this.BtnSearchPeminjaman.IdleFillColor = System.Drawing.Color.White;
            this.BtnSearchPeminjaman.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchPeminjaman.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchPeminjaman.Location = new System.Drawing.Point(524, 117);
            this.BtnSearchPeminjaman.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSearchPeminjaman.Name = "BtnSearchPeminjaman";
            this.BtnSearchPeminjaman.Size = new System.Drawing.Size(202, 41);
            this.BtnSearchPeminjaman.TabIndex = 3;
            this.BtnSearchPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSearchPeminjaman.Click += new System.EventHandler(this.BtnSearchPeminjaman_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(524, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Maksimal Peminjaman Buku :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(524, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Maksimal Lama Peminjaman :";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(58, 405);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1007, 158);
            this.bunifuCustomDataGrid1.TabIndex = 14;
            // 
            // BtnPinjamBuku
            // 
            this.BtnPinjamBuku.ActiveBorderThickness = 1;
            this.BtnPinjamBuku.ActiveCornerRadius = 20;
            this.BtnPinjamBuku.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnPinjamBuku.ActiveForecolor = System.Drawing.Color.White;
            this.BtnPinjamBuku.ActiveLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnPinjamBuku.BackColor = System.Drawing.Color.White;
            this.BtnPinjamBuku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPinjamBuku.BackgroundImage")));
            this.BtnPinjamBuku.ButtonText = "PINJAM";
            this.BtnPinjamBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPinjamBuku.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPinjamBuku.ForeColor = System.Drawing.Color.Black;
            this.BtnPinjamBuku.IdleBorderThickness = 1;
            this.BtnPinjamBuku.IdleCornerRadius = 20;
            this.BtnPinjamBuku.IdleFillColor = System.Drawing.Color.White;
            this.BtnPinjamBuku.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.BtnPinjamBuku.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnPinjamBuku.Location = new System.Drawing.Point(615, 346);
            this.BtnPinjamBuku.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPinjamBuku.Name = "BtnPinjamBuku";
            this.BtnPinjamBuku.Size = new System.Drawing.Size(202, 41);
            this.BtnPinjamBuku.TabIndex = 17;
            this.BtnPinjamBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPinjamBuku.Click += new System.EventHandler(this.BtnPinjamBuku_Click);
            // 
            // TxtBoxIdBookPeminjaman
            // 
            this.TxtBoxIdBookPeminjaman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxIdBookPeminjaman.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtBoxIdBookPeminjaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxIdBookPeminjaman.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBoxIdBookPeminjaman.HintText = "";
            this.TxtBoxIdBookPeminjaman.isPassword = false;
            this.TxtBoxIdBookPeminjaman.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.TxtBoxIdBookPeminjaman.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtBoxIdBookPeminjaman.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.TxtBoxIdBookPeminjaman.LineThickness = 3;
            this.TxtBoxIdBookPeminjaman.Location = new System.Drawing.Point(236, 339);
            this.TxtBoxIdBookPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxIdBookPeminjaman.Name = "TxtBoxIdBookPeminjaman";
            this.TxtBoxIdBookPeminjaman.Size = new System.Drawing.Size(370, 44);
            this.TxtBoxIdBookPeminjaman.TabIndex = 16;
            this.TxtBoxIdBookPeminjaman.Text = "Insert Book ID Here";
            this.TxtBoxIdBookPeminjaman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBoxIdBookPeminjaman.OnValueChanged += new System.EventHandler(this.LabelIdBookPeminjaman_OnValueChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(56, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 37);
            this.label13.TabIndex = 15;
            this.label13.Text = "KODE BUKU :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(58, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 152);
            this.panel1.TabIndex = 18;
            // 
            // TxtBoxErrorNim
            // 
            this.TxtBoxErrorNim.Location = new System.Drawing.Point(892, 124);
            this.TxtBoxErrorNim.Multiline = true;
            this.TxtBoxErrorNim.Name = "TxtBoxErrorNim";
            this.TxtBoxErrorNim.ReadOnly = true;
            this.TxtBoxErrorNim.Size = new System.Drawing.Size(173, 34);
            this.TxtBoxErrorNim.TabIndex = 20;
            this.TxtBoxErrorNim.TextChanged += new System.EventHandler(this.TxtBoxErrorNim_TextChanged);
            // 
            // TxtBoxErrorBook
            // 
            this.TxtBoxErrorBook.Location = new System.Drawing.Point(892, 350);
            this.TxtBoxErrorBook.Multiline = true;
            this.TxtBoxErrorBook.Name = "TxtBoxErrorBook";
            this.TxtBoxErrorBook.ReadOnly = true;
            this.TxtBoxErrorBook.Size = new System.Drawing.Size(173, 34);
            this.TxtBoxErrorBook.TabIndex = 21;
            this.TxtBoxErrorBook.TextChanged += new System.EventHandler(this.TxtBoxErrorBook_TextChanged);
            // 
            // Peminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 677);
            this.Controls.Add(this.TxtBoxErrorBook);
            this.Controls.Add(this.TxtBoxErrorNim);
            this.Controls.Add(this.BtnPinjamBuku);
            this.Controls.Add(this.TxtBoxIdBookPeminjaman);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.BtnSearchPeminjaman);
            this.Controls.Add(this.TxtBoxNimPeminjaman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Peminjaman";
            this.Text = "PEMINJAMAN";
            this.Load += new System.EventHandler(this.peminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBoxNimPeminjaman;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSearchPeminjaman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnPinjamBuku;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBoxIdBookPeminjaman;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBoxErrorNim;
        private System.Windows.Forms.TextBox TxtBoxErrorBook;
    }
}