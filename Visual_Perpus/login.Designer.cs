
namespace Visual_Perpus
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextBoxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.ActiveBorderThickness = 1;
            this.BtnLogin.ActiveCornerRadius = 20;
            this.BtnLogin.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.BtnLogin.ActiveLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
            this.BtnLogin.ButtonText = "LOGIN";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.IdleBorderThickness = 1;
            this.BtnLogin.IdleCornerRadius = 20;
            this.BtnLogin.IdleFillColor = System.Drawing.Color.White;
            this.BtnLogin.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.BtnLogin.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.BtnLogin.Location = new System.Drawing.Point(485, 406);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(202, 41);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxUsername.HintText = "";
            this.TextBoxUsername.isPassword = false;
            this.TextBoxUsername.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.TextBoxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBoxUsername.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.TextBoxUsername.LineThickness = 3;
            this.TextBoxUsername.Location = new System.Drawing.Point(465, 258);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(370, 44);
            this.TextBoxUsername.TabIndex = 5;
            this.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(312, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username :";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxPassword.HintText = "";
            this.TextBoxPassword.isPassword = false;
            this.TextBoxPassword.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.TextBoxPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBoxPassword.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.TextBoxPassword.LineThickness = 3;
            this.TextBoxPassword.Location = new System.Drawing.Point(465, 329);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(370, 44);
            this.TextBoxPassword.TabIndex = 8;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxPassword.OnValueChanged += new System.EventHandler(this.TextBoxPassword_OnValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(317, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 723);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "login";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 BtnLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxUsername;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxPassword;
        private System.Windows.Forms.Label label2;
    }
}