namespace GörselProgramlama1.Sınıf._2dönemProjeOdevi
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSifreYenile = new Guna.UI2.WinForms.Guna2Button();
            this.txtYeniSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKullaniciAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnSifreYenile);
            this.guna2Panel1.Controls.Add(this.txtYeniSifre);
            this.guna2Panel1.Controls.Add(this.txtKullaniciAdi);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(307, 57);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(610, 593);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnSifreYenile
            // 
            this.btnSifreYenile.BorderRadius = 10;
            this.btnSifreYenile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSifreYenile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSifreYenile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSifreYenile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSifreYenile.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSifreYenile.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnSifreYenile.ForeColor = System.Drawing.Color.White;
            this.btnSifreYenile.Location = new System.Drawing.Point(65, 451);
            this.btnSifreYenile.Name = "btnSifreYenile";
            this.btnSifreYenile.Size = new System.Drawing.Size(483, 64);
            this.btnSifreYenile.TabIndex = 8;
            this.btnSifreYenile.Text = "Reset Password";
            this.btnSifreYenile.Click += new System.EventHandler(this.btnSifreYenile_Click);
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.BorderRadius = 10;
            this.txtYeniSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYeniSifre.DefaultText = "";
            this.txtYeniSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYeniSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYeniSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYeniSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYeniSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.txtYeniSifre.ForeColor = System.Drawing.Color.Black;
            this.txtYeniSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYeniSifre.Location = new System.Drawing.Point(65, 346);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.PlaceholderText = "New Password";
            this.txtYeniSifre.SelectedText = "";
            this.txtYeniSifre.Size = new System.Drawing.Size(483, 48);
            this.txtYeniSifre.TabIndex = 7;
            this.txtYeniSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderRadius = 10;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.DefaultText = "";
            this.txtKullaniciAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKullaniciAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKullaniciAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullaniciAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullaniciAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(65, 241);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PlaceholderText = "Username";
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(483, 48);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AcceptButton = this.btnSifreYenile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 772);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBS-ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSifreYenile;
        private Guna.UI2.WinForms.Guna2TextBox txtYeniSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtKullaniciAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}