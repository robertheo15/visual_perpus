
namespace Visual_Perpus
{
    partial class Datamember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datamember));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnAddDataMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DataGridMember = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearchMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextBoxSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMember)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuThinButton23.Location = new System.Drawing.Point(638, 91);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(99, 33);
            this.bunifuThinButton23.TabIndex = 27;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // BtnAddDataMember
            // 
            this.BtnAddDataMember.ActiveBorderThickness = 1;
            this.BtnAddDataMember.ActiveCornerRadius = 20;
            this.BtnAddDataMember.ActiveFillColor = System.Drawing.Color.SpringGreen;
            this.BtnAddDataMember.ActiveForecolor = System.Drawing.Color.White;
            this.BtnAddDataMember.ActiveLineColor = System.Drawing.Color.SpringGreen;
            this.BtnAddDataMember.BackColor = System.Drawing.Color.White;
            this.BtnAddDataMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddDataMember.BackgroundImage")));
            this.BtnAddDataMember.ButtonText = "TAMBAH";
            this.BtnAddDataMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddDataMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddDataMember.ForeColor = System.Drawing.Color.Black;
            this.BtnAddDataMember.IdleBorderThickness = 1;
            this.BtnAddDataMember.IdleCornerRadius = 20;
            this.BtnAddDataMember.IdleFillColor = System.Drawing.Color.White;
            this.BtnAddDataMember.IdleForecolor = System.Drawing.Color.SpringGreen;
            this.BtnAddDataMember.IdleLineColor = System.Drawing.Color.SpringGreen;
            this.BtnAddDataMember.Location = new System.Drawing.Point(524, 91);
            this.BtnAddDataMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAddDataMember.Name = "BtnAddDataMember";
            this.BtnAddDataMember.Size = new System.Drawing.Size(99, 33);
            this.BtnAddDataMember.TabIndex = 26;
            this.BtnAddDataMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddDataMember.Click += new System.EventHandler(this.BtnAddDataMember_Click);
            // 
            // DataGridMember
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridMember.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.NIM,
            this.FirstName,
            this.LastName,
            this.RegisterDate});
            this.DataGridMember.DoubleBuffered = true;
            this.DataGridMember.EnableHeadersVisualStyles = false;
            this.DataGridMember.HeaderBgColor = System.Drawing.Color.Aqua;
            this.DataGridMember.HeaderForeColor = System.Drawing.Color.Black;
            this.DataGridMember.Location = new System.Drawing.Point(28, 140);
            this.DataGridMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridMember.Name = "DataGridMember";
            this.DataGridMember.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridMember.RowHeadersWidth = 51;
            this.DataGridMember.RowTemplate.Height = 24;
            this.DataGridMember.Size = new System.Drawing.Size(708, 367);
            this.DataGridMember.TabIndex = 25;
            // 
            // col1
            // 
            this.col1.HeaderText = "Username";
            this.col1.MinimumWidth = 6;
            this.col1.Name = "col1";
            this.col1.Width = 125;
            // 
            // NIM
            // 
            this.NIM.HeaderText = "NIM";
            this.NIM.MinimumWidth = 6;
            this.NIM.Name = "NIM";
            this.NIM.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // RegisterDate
            // 
            this.RegisterDate.HeaderText = "Register Date";
            this.RegisterDate.MinimumWidth = 6;
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Width = 125;
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.ActiveBorderThickness = 1;
            this.BtnSearchMember.ActiveCornerRadius = 20;
            this.BtnSearchMember.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchMember.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSearchMember.ActiveLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchMember.BackColor = System.Drawing.Color.White;
            this.BtnSearchMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearchMember.BackgroundImage")));
            this.BtnSearchMember.ButtonText = "CARI";
            this.BtnSearchMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchMember.ForeColor = System.Drawing.Color.Black;
            this.BtnSearchMember.IdleBorderThickness = 1;
            this.BtnSearchMember.IdleCornerRadius = 20;
            this.BtnSearchMember.IdleFillColor = System.Drawing.Color.White;
            this.BtnSearchMember.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchMember.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchMember.Location = new System.Drawing.Point(313, 91);
            this.BtnSearchMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(152, 33);
            this.BtnSearchMember.TabIndex = 24;
            this.BtnSearchMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxSearch.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearch.HintText = "";
            this.TextBoxSearch.isPassword = false;
            this.TextBoxSearch.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.TextBoxSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBoxSearch.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.TextBoxSearch.LineThickness = 3;
            this.TextBoxSearch.Location = new System.Drawing.Point(28, 81);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(278, 36);
            this.TextBoxSearch.TabIndex = 23;
            this.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(772, 42);
            this.label2.TabIndex = 22;
            this.label2.Text = "DATA MEMBER";
            // 
            // Datamember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 587);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.BtnAddDataMember);
            this.Controls.Add(this.DataGridMember);
            this.Controls.Add(this.BtnSearchMember);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Datamember";
            this.Text = "dataMember";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAddDataMember;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridMember;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSearchMember;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
    }
}