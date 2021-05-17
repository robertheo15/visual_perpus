
namespace Visual_Perpus
{
    partial class Addmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addmember));
            this.BtnAddMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAddMember
            // 
            this.BtnAddMember.ActiveBorderThickness = 1;
            this.BtnAddMember.ActiveCornerRadius = 20;
            this.BtnAddMember.ActiveFillColor = System.Drawing.Color.Turquoise;
            this.BtnAddMember.ActiveForecolor = System.Drawing.Color.DarkOliveGreen;
            this.BtnAddMember.ActiveLineColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnAddMember.BackColor = System.Drawing.Color.White;
            this.BtnAddMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddMember.BackgroundImage")));
            this.BtnAddMember.ButtonText = "TAMBAH";
            this.BtnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddMember.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMember.ForeColor = System.Drawing.Color.White;
            this.BtnAddMember.IdleBorderThickness = 1;
            this.BtnAddMember.IdleCornerRadius = 20;
            this.BtnAddMember.IdleFillColor = System.Drawing.Color.OliveDrab;
            this.BtnAddMember.IdleForecolor = System.Drawing.Color.White;
            this.BtnAddMember.IdleLineColor = System.Drawing.Color.OliveDrab;
            this.BtnAddMember.Location = new System.Drawing.Point(370, 265);
            this.BtnAddMember.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAddMember.Name = "BtnAddMember";
            this.BtnAddMember.Size = new System.Drawing.Size(99, 38);
            this.BtnAddMember.TabIndex = 367;
            this.BtnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(252, 144);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(217, 22);
            this.TextBoxUsername.TabIndex = 352;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 347;
            this.label1.Text = "Username";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(252, 170);
            this.TextBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(217, 22);
            this.TextBoxFirstName.TabIndex = 369;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(104, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 368;
            this.label3.Text = "Nama depan";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(252, 196);
            this.TextBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(217, 22);
            this.TextBoxLastName.TabIndex = 371;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(104, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 370;
            this.label4.Text = "Nama belakang";
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(252, 118);
            this.textBoxNIM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(217, 22);
            this.textBoxNIM.TabIndex = 373;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(104, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 372;
            this.label2.Text = "NIM";
            // 
            // Addmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 414);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddMember);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label1);
            this.Name = "Addmember";
            this.Text = "addBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 BtnAddMember;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.Label label2;
    }
}