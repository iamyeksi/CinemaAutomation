
namespace CinemaAutomation
{
    partial class YoneticiGirisEkrani
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
            this.btnprev = new System.Windows.Forms.Button();
            this.btnkullanicigiris = new System.Windows.Forms.Button();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.Color.Transparent;
            this.btnprev.FlatAppearance.BorderSize = 0;
            this.btnprev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnprev.ForeColor = System.Drawing.Color.White;
            this.btnprev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprev.Location = new System.Drawing.Point(68, 283);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(175, 33);
            this.btnprev.TabIndex = 52;
            this.btnprev.Text = "ANASAYFA";
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnkullanicigiris
            // 
            this.btnkullanicigiris.BackColor = System.Drawing.Color.Transparent;
            this.btnkullanicigiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkullanicigiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullanicigiris.ForeColor = System.Drawing.Color.White;
            this.btnkullanicigiris.Location = new System.Drawing.Point(68, 245);
            this.btnkullanicigiris.Name = "btnkullanicigiris";
            this.btnkullanicigiris.Size = new System.Drawing.Size(175, 32);
            this.btnkullanicigiris.TabIndex = 51;
            this.btnkullanicigiris.Text = "GİRİŞ";
            this.btnkullanicigiris.UseVisualStyleBackColor = false;
            this.btnkullanicigiris.Click += new System.EventHandler(this.btnkullanicigiris_Click);
            // 
            // txtparola
            // 
            this.txtparola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparola.Location = new System.Drawing.Point(68, 214);
            this.txtparola.Multiline = true;
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(175, 25);
            this.txtparola.TabIndex = 50;
            this.txtparola.Text = "Parola";
            this.txtparola.Click += new System.EventHandler(this.txtparola_Click);
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Location = new System.Drawing.Point(68, 183);
            this.txtkullaniciadi.Multiline = true;
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(175, 25);
            this.txtkullaniciadi.TabIndex = 49;
            this.txtkullaniciadi.Text = "Kullanıcı Adı";
            this.txtkullaniciadi.Click += new System.EventHandler(this.txtkullaniciadi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaAutomation.Properties.Resources._21_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // YoneticiGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(304, 341);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnkullanicigiris);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "YoneticiGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş Ekranı";
            this.Load += new System.EventHandler(this.YoneticiGirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnkullanicigiris;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.TextBox txtkullaniciadi;
    }
}