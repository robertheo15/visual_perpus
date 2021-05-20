
namespace Visual_Perpus
{
    partial class Databukumember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Databukumember));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSearchBook = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextboxIdBook = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DataGridBookMember = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBookMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(62, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1029, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "DAFTAR BUKU";
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.ActiveBorderThickness = 1;
            this.BtnSearchBook.ActiveCornerRadius = 20;
            this.BtnSearchBook.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchBook.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSearchBook.ActiveLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchBook.BackColor = System.Drawing.Color.White;
            this.BtnSearchBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearchBook.BackgroundImage")));
            this.BtnSearchBook.ButtonText = "CARI";
            this.BtnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchBook.ForeColor = System.Drawing.Color.Black;
            this.BtnSearchBook.IdleBorderThickness = 1;
            this.BtnSearchBook.IdleCornerRadius = 20;
            this.BtnSearchBook.IdleFillColor = System.Drawing.Color.White;
            this.BtnSearchBook.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchBook.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSearchBook.Location = new System.Drawing.Point(626, 134);
            this.BtnSearchBook.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(202, 41);
            this.BtnSearchBook.TabIndex = 5;
            this.BtnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // TextboxIdBook
            // 
            this.TextboxIdBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxIdBook.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxIdBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxIdBook.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxIdBook.HintText = "";
            this.TextboxIdBook.isPassword = false;
            this.TextboxIdBook.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.TextboxIdBook.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxIdBook.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.TextboxIdBook.LineThickness = 3;
            this.TextboxIdBook.Location = new System.Drawing.Point(237, 122);
            this.TextboxIdBook.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxIdBook.Name = "TextboxIdBook";
            this.TextboxIdBook.Size = new System.Drawing.Size(370, 44);
            this.TextboxIdBook.TabIndex = 4;
            this.TextboxIdBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DataGridBookMember
            // 
            this.DataGridBookMember.AllowUserToAddRows = false;
            this.DataGridBookMember.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridBookMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridBookMember.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridBookMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBookMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBookMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridBookMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBookMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.Author,
            this.Year,
            this.Qty,
            this.Price,
            this.Type});
            this.DataGridBookMember.DoubleBuffered = true;
            this.DataGridBookMember.EnableHeadersVisualStyles = false;
            this.DataGridBookMember.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridBookMember.HeaderForeColor = System.Drawing.Color.Black;
            this.DataGridBookMember.Location = new System.Drawing.Point(68, 194);
            this.DataGridBookMember.Name = "DataGridBookMember";
            this.DataGridBookMember.ReadOnly = true;
            this.DataGridBookMember.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridBookMember.RowHeadersWidth = 51;
            this.DataGridBookMember.RowTemplate.Height = 24;
            this.DataGridBookMember.Size = new System.Drawing.Size(1023, 452);
            this.DataGridBookMember.TabIndex = 15;
            this.DataGridBookMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // BookID
            // 
            this.BookID.HeaderText = "Book ID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(97, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Book :";
            // 
            // Databukumember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridBookMember);
            this.Controls.Add(this.BtnSearchBook);
            this.Controls.Add(this.TextboxIdBook);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Databukumember";
            this.Text = "dataBukuMember";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBookMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSearchBook;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxIdBook;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridBookMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label label1;
    }
}