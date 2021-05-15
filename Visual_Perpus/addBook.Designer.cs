
namespace Visual_Perpus
{
    partial class Addbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addbook));
            this.year = new System.Windows.Forms.Label();
            this.BtnAddBook = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextBoxType = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.BookYear = new System.Windows.Forms.DateTimePicker();
            this.TextBoxQty = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.Label();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.Label();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.year.ForeColor = System.Drawing.Color.Black;
            this.year.Location = new System.Drawing.Point(78, 165);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(90, 17);
            this.year.TabIndex = 383;
            this.year.Text = "Tahun Terbit";
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.ActiveBorderThickness = 1;
            this.BtnAddBook.ActiveCornerRadius = 20;
            this.BtnAddBook.ActiveFillColor = System.Drawing.Color.Turquoise;
            this.BtnAddBook.ActiveForecolor = System.Drawing.Color.DarkOliveGreen;
            this.BtnAddBook.ActiveLineColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnAddBook.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddBook.BackgroundImage")));
            this.BtnAddBook.ButtonText = "TAMBAH";
            this.BtnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBook.ForeColor = System.Drawing.Color.White;
            this.BtnAddBook.IdleBorderThickness = 1;
            this.BtnAddBook.IdleCornerRadius = 20;
            this.BtnAddBook.IdleFillColor = System.Drawing.Color.OliveDrab;
            this.BtnAddBook.IdleForecolor = System.Drawing.Color.White;
            this.BtnAddBook.IdleLineColor = System.Drawing.Color.OliveDrab;
            this.BtnAddBook.Location = new System.Drawing.Point(333, 289);
            this.BtnAddBook.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(99, 38);
            this.BtnAddBook.TabIndex = 380;
            this.BtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // TextBoxType
            // 
            this.TextBoxType.Location = new System.Drawing.Point(215, 214);
            this.TextBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxType.Name = "TextBoxType";
            this.TextBoxType.Size = new System.Drawing.Size(217, 22);
            this.TextBoxType.TabIndex = 379;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.type.ForeColor = System.Drawing.Color.Black;
            this.type.Location = new System.Drawing.Point(78, 218);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(71, 17);
            this.type.TabIndex = 378;
            this.type.Text = "Tipe buku";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(215, 52);
            this.TextBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(217, 22);
            this.TextBoxTitle.TabIndex = 376;
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.location.ForeColor = System.Drawing.Color.Black;
            this.location.Location = new System.Drawing.Point(78, 136);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(33, 17);
            this.location.TabIndex = 375;
            this.location.Text = "Rak";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(78, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(78, 17);
            this.title.TabIndex = 374;
            this.title.Text = "Judul Buku";
            // 
            // BookYear
            // 
            this.BookYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookYear.Location = new System.Drawing.Point(215, 161);
            this.BookYear.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.BookYear.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BookYear.Name = "BookYear";
            this.BookYear.Size = new System.Drawing.Size(217, 22);
            this.BookYear.TabIndex = 387;
            // 
            // TextBoxQty
            // 
            this.TextBoxQty.Location = new System.Drawing.Point(215, 188);
            this.TextBoxQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxQty.Name = "TextBoxQty";
            this.TextBoxQty.Size = new System.Drawing.Size(217, 22);
            this.TextBoxQty.TabIndex = 389;
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.qty.ForeColor = System.Drawing.Color.Black;
            this.qty.Location = new System.Drawing.Point(78, 192);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(53, 17);
            this.qty.TabIndex = 388;
            this.qty.Text = "Jumlah";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(215, 240);
            this.TextBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(217, 22);
            this.TextBoxPrice.TabIndex = 391;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(78, 244);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(83, 17);
            this.price.TabIndex = 390;
            this.price.Text = "Harga Buku";
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.Location = new System.Drawing.Point(215, 79);
            this.TextBoxAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(217, 22);
            this.TextBoxAuthor.TabIndex = 393;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.author.ForeColor = System.Drawing.Color.Black;
            this.author.Location = new System.Drawing.Point(78, 82);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(54, 17);
            this.author.TabIndex = 392;
            this.author.Text = "Penulis";
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(215, 107);
            this.TextBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(217, 22);
            this.TextBoxCategory.TabIndex = 395;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.Location = new System.Drawing.Point(78, 110);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(76, 21);
            this.category.TabIndex = 394;
            this.category.Text = "Kategori";
            // 
            // TextBoxLocation
            // 
            this.TextBoxLocation.Location = new System.Drawing.Point(215, 135);
            this.TextBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(217, 22);
            this.TextBoxLocation.TabIndex = 396;
            // 
            // Addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 391);
            this.Controls.Add(this.TextBoxLocation);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.category);
            this.Controls.Add(this.TextBoxAuthor);
            this.Controls.Add(this.author);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.price);
            this.Controls.Add(this.TextBoxQty);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.BookYear);
            this.Controls.Add(this.year);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.TextBoxType);
            this.Controls.Add(this.type);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.location);
            this.Controls.Add(this.title);
            this.Name = "Addbook";
            this.Text = "Addmember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label year;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAddBook;
        private System.Windows.Forms.TextBox TextBoxType;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DateTimePicker BookYear;
        private System.Windows.Forms.TextBox TextBoxQty;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox TextBoxLocation;
    }
}