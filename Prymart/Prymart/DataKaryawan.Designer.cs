namespace Prymart
{
    partial class DataKaryawan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataKaryawan));
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.NEGARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODE_POS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JABATAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANGGAL_LAHIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMPAT_LAHIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(1095, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 28);
            this.button1.TabIndex = 320;
            this.button1.Text = "TAMBAH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Thistle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-53, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1403, 52);
            this.label10.TabIndex = 344;
            this.label10.Text = "DATA KARYAWAN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NEGARA
            // 
            this.NEGARA.HeaderText = "NEGARA";
            this.NEGARA.MinimumWidth = 6;
            this.NEGARA.Name = "NEGARA";
            this.NEGARA.Width = 125;
            // 
            // KODE_POS
            // 
            this.KODE_POS.HeaderText = "KODE POS";
            this.KODE_POS.MinimumWidth = 6;
            this.KODE_POS.Name = "KODE_POS";
            this.KODE_POS.Width = 125;
            // 
            // KOTA
            // 
            this.KOTA.HeaderText = "KOTA";
            this.KOTA.MinimumWidth = 6;
            this.KOTA.Name = "KOTA";
            this.KOTA.Width = 125;
            // 
            // JABATAN
            // 
            this.JABATAN.HeaderText = "JABATAN";
            this.JABATAN.MinimumWidth = 6;
            this.JABATAN.Name = "JABATAN";
            this.JABATAN.Width = 125;
            // 
            // NO_HP
            // 
            this.NO_HP.HeaderText = "NO TLPN";
            this.NO_HP.MinimumWidth = 6;
            this.NO_HP.Name = "NO_HP";
            this.NO_HP.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 125;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ALAMAT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // TANGGAL_LAHIR
            // 
            this.TANGGAL_LAHIR.HeaderText = "TANGGAL LAHIR";
            this.TANGGAL_LAHIR.MinimumWidth = 6;
            this.TANGGAL_LAHIR.Name = "TANGGAL_LAHIR";
            this.TANGGAL_LAHIR.Width = 125;
            // 
            // TEMPAT_LAHIR
            // 
            this.TEMPAT_LAHIR.HeaderText = "TEMPAT LAHIR";
            this.TEMPAT_LAHIR.MinimumWidth = 6;
            this.TEMPAT_LAHIR.Name = "TEMPAT_LAHIR";
            this.TEMPAT_LAHIR.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "NAMA LENGKAP";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 50;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.TEMPAT_LAHIR,
            this.TANGGAL_LAHIR,
            this.Column5,
            this.EMAIL,
            this.NO_HP,
            this.JABATAN,
            this.KOTA,
            this.KODE_POS,
            this.NEGARA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(40, 133);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1186, 474);
            this.bunifuCustomDataGrid1.TabIndex = 343;
            // 
            // DataKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 650);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataKaryawan";
            this.Load += new System.EventHandler(this.DataKaryawan_Load);
            this.Shown += new System.EventHandler(this.DataKaryawan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEGARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE_POS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn JABATAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TANGGAL_LAHIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPAT_LAHIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}