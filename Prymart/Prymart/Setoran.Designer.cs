namespace Prymart
{
    partial class Setoran
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
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.NoKeuanganPendapatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoStrukSetoran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalSetoran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NilaiPenjualanSetoran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.SystemColors.Window;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(524, 396);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(178, 20);
            this.textBox23.TabIndex = 93;
            this.textBox23.Text = "57.000";
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.Window;
            this.textBox22.Location = new System.Drawing.Point(62, 396);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(475, 20);
            this.textBox22.TabIndex = 92;
            this.textBox22.Text = "TOTAL";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 33);
            this.button3.TabIndex = 83;
            this.button3.Text = "Selesai";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 223);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 95;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox2.Location = new System.Drawing.Point(62, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 143);
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Thistle;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(125, 162);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 24);
            this.textBox2.TabIndex = 96;
            this.textBox2.Text = "Tanggal Awal";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(286, 161);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker2.TabIndex = 97;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Thistle;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(125, 223);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 18);
            this.textBox3.TabIndex = 98;
            this.textBox3.Text = "Tanggal Akhir";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoKeuanganPendapatan,
            this.NoStrukSetoran,
            this.TanggalSetoran,
            this.NilaiPenjualanSetoran});
            this.dataGridView1.Location = new System.Drawing.Point(62, 277);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 122);
            this.dataGridView1.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(-1, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(770, 42);
            this.label10.TabIndex = 328;
            this.label10.Text = "KEUANGAN PENDAPATAN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // NoKeuanganPendapatan
            // 
            this.NoKeuanganPendapatan.HeaderText = "NO";
            this.NoKeuanganPendapatan.MinimumWidth = 6;
            this.NoKeuanganPendapatan.Name = "NoKeuanganPendapatan";
            this.NoKeuanganPendapatan.ReadOnly = true;
            this.NoKeuanganPendapatan.Width = 90;
            // 
            // NoStrukSetoran
            // 
            this.NoStrukSetoran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoStrukSetoran.HeaderText = "NO STRUK";
            this.NoStrukSetoran.MinimumWidth = 6;
            this.NoStrukSetoran.Name = "NoStrukSetoran";
            this.NoStrukSetoran.ReadOnly = true;
            // 
            // TanggalSetoran
            // 
            this.TanggalSetoran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TanggalSetoran.HeaderText = "TANGGAL";
            this.TanggalSetoran.MinimumWidth = 6;
            this.TanggalSetoran.Name = "TanggalSetoran";
            this.TanggalSetoran.ReadOnly = true;
            // 
            // NilaiPenjualanSetoran
            // 
            this.NilaiPenjualanSetoran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NilaiPenjualanSetoran.HeaderText = "NILAI PENJUALAN (Rp)";
            this.NilaiPenjualanSetoran.MinimumWidth = 6;
            this.NilaiPenjualanSetoran.Name = "NilaiPenjualanSetoran";
            this.NilaiPenjualanSetoran.ReadOnly = true;
            // 
            // Setoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(770, 471);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Setoran";
            this.Text = "Setoran";
            this.Load += new System.EventHandler(this.Setoran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoKeuanganPendapatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoStrukSetoran;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalSetoran;
        private System.Windows.Forms.DataGridViewTextBoxColumn NilaiPenjualanSetoran;
    }
}