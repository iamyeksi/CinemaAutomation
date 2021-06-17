
namespace CinemaAutomation
{
    partial class SeansEkleme
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboSalon = new System.Windows.Forms.ComboBox();
            this.comboFilm = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seans12 = new System.Windows.Forms.RadioButton();
            this.seans11 = new System.Windows.Forms.RadioButton();
            this.seans10 = new System.Windows.Forms.RadioButton();
            this.seans9 = new System.Windows.Forms.RadioButton();
            this.seans8 = new System.Windows.Forms.RadioButton();
            this.seans7 = new System.Windows.Forms.RadioButton();
            this.seans6 = new System.Windows.Forms.RadioButton();
            this.seans5 = new System.Windows.Forms.RadioButton();
            this.seans4 = new System.Windows.Forms.RadioButton();
            this.seans3 = new System.Windows.Forms.RadioButton();
            this.seans2 = new System.Windows.Forms.RadioButton();
            this.seans1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(319, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboSalon
            // 
            this.comboSalon.FormattingEnabled = true;
            this.comboSalon.Location = new System.Drawing.Point(319, 64);
            this.comboSalon.Name = "comboSalon";
            this.comboSalon.Size = new System.Drawing.Size(179, 21);
            this.comboSalon.TabIndex = 16;
            this.comboSalon.SelectedIndexChanged += new System.EventHandler(this.comboSalon_SelectedIndexChanged);
            // 
            // comboFilm
            // 
            this.comboFilm.FormattingEnabled = true;
            this.comboFilm.Location = new System.Drawing.Point(319, 27);
            this.comboFilm.Name = "comboFilm";
            this.comboFilm.Size = new System.Drawing.Size(179, 21);
            this.comboFilm.TabIndex = 15;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(319, 257);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(274, 43);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seans12);
            this.groupBox1.Controls.Add(this.seans11);
            this.groupBox1.Controls.Add(this.seans10);
            this.groupBox1.Controls.Add(this.seans9);
            this.groupBox1.Controls.Add(this.seans8);
            this.groupBox1.Controls.Add(this.seans7);
            this.groupBox1.Controls.Add(this.seans6);
            this.groupBox1.Controls.Add(this.seans5);
            this.groupBox1.Controls.Add(this.seans4);
            this.groupBox1.Controls.Add(this.seans3);
            this.groupBox1.Controls.Add(this.seans2);
            this.groupBox1.Controls.Add(this.seans1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(319, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 106);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // seans12
            // 
            this.seans12.AutoSize = true;
            this.seans12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans12.Location = new System.Drawing.Point(199, 71);
            this.seans12.Name = "seans12";
            this.seans12.Size = new System.Drawing.Size(62, 20);
            this.seans12.TabIndex = 11;
            this.seans12.TabStop = true;
            this.seans12.Text = "21:00";
            this.seans12.UseVisualStyleBackColor = true;
            // 
            // seans11
            // 
            this.seans11.AutoSize = true;
            this.seans11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans11.Location = new System.Drawing.Point(131, 71);
            this.seans11.Name = "seans11";
            this.seans11.Size = new System.Drawing.Size(62, 20);
            this.seans11.TabIndex = 10;
            this.seans11.TabStop = true;
            this.seans11.Text = "20:00";
            this.seans11.UseVisualStyleBackColor = true;
            // 
            // seans10
            // 
            this.seans10.AutoSize = true;
            this.seans10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans10.Location = new System.Drawing.Point(73, 71);
            this.seans10.Name = "seans10";
            this.seans10.Size = new System.Drawing.Size(62, 20);
            this.seans10.TabIndex = 9;
            this.seans10.TabStop = true;
            this.seans10.Text = "19:00";
            this.seans10.UseVisualStyleBackColor = true;
            // 
            // seans9
            // 
            this.seans9.AutoSize = true;
            this.seans9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans9.Location = new System.Drawing.Point(6, 71);
            this.seans9.Name = "seans9";
            this.seans9.Size = new System.Drawing.Size(62, 20);
            this.seans9.TabIndex = 8;
            this.seans9.TabStop = true;
            this.seans9.Text = "18:00";
            this.seans9.UseVisualStyleBackColor = true;
            // 
            // seans8
            // 
            this.seans8.AutoSize = true;
            this.seans8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans8.Location = new System.Drawing.Point(199, 45);
            this.seans8.Name = "seans8";
            this.seans8.Size = new System.Drawing.Size(62, 20);
            this.seans8.TabIndex = 7;
            this.seans8.TabStop = true;
            this.seans8.Text = "17:00";
            this.seans8.UseVisualStyleBackColor = true;
            // 
            // seans7
            // 
            this.seans7.AutoSize = true;
            this.seans7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans7.Location = new System.Drawing.Point(131, 45);
            this.seans7.Name = "seans7";
            this.seans7.Size = new System.Drawing.Size(62, 20);
            this.seans7.TabIndex = 6;
            this.seans7.TabStop = true;
            this.seans7.Text = "16:00";
            this.seans7.UseVisualStyleBackColor = true;
            // 
            // seans6
            // 
            this.seans6.AutoSize = true;
            this.seans6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans6.Location = new System.Drawing.Point(73, 45);
            this.seans6.Name = "seans6";
            this.seans6.Size = new System.Drawing.Size(62, 20);
            this.seans6.TabIndex = 5;
            this.seans6.TabStop = true;
            this.seans6.Text = "15:00";
            this.seans6.UseVisualStyleBackColor = true;
            // 
            // seans5
            // 
            this.seans5.AutoSize = true;
            this.seans5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans5.Location = new System.Drawing.Point(6, 45);
            this.seans5.Name = "seans5";
            this.seans5.Size = new System.Drawing.Size(62, 20);
            this.seans5.TabIndex = 4;
            this.seans5.TabStop = true;
            this.seans5.Text = "14:00";
            this.seans5.UseVisualStyleBackColor = true;
            // 
            // seans4
            // 
            this.seans4.AutoSize = true;
            this.seans4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans4.Location = new System.Drawing.Point(199, 19);
            this.seans4.Name = "seans4";
            this.seans4.Size = new System.Drawing.Size(62, 20);
            this.seans4.TabIndex = 3;
            this.seans4.TabStop = true;
            this.seans4.Text = "13:00";
            this.seans4.UseVisualStyleBackColor = true;
            // 
            // seans3
            // 
            this.seans3.AutoSize = true;
            this.seans3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans3.Location = new System.Drawing.Point(131, 19);
            this.seans3.Name = "seans3";
            this.seans3.Size = new System.Drawing.Size(62, 20);
            this.seans3.TabIndex = 2;
            this.seans3.TabStop = true;
            this.seans3.Text = "12:00";
            this.seans3.UseVisualStyleBackColor = true;
            // 
            // seans2
            // 
            this.seans2.AutoSize = true;
            this.seans2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans2.Location = new System.Drawing.Point(73, 19);
            this.seans2.Name = "seans2";
            this.seans2.Size = new System.Drawing.Size(62, 20);
            this.seans2.TabIndex = 1;
            this.seans2.TabStop = true;
            this.seans2.Text = "11:00";
            this.seans2.UseVisualStyleBackColor = true;
            // 
            // seans1
            // 
            this.seans1.AutoSize = true;
            this.seans1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seans1.Location = new System.Drawing.Point(6, 19);
            this.seans1.Name = "seans1";
            this.seans1.Size = new System.Drawing.Size(62, 20);
            this.seans1.TabIndex = 0;
            this.seans1.TabStop = true;
            this.seans1.Text = "10:00";
            this.seans1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seans:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(253, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Salon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Film:";
            // 
            // SeansEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(846, 353);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboSalon);
            this.Controls.Add(this.comboFilm);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeansEkleme";
            this.Text = "SeansEkleme";
            this.Load += new System.EventHandler(this.SeansEkleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboSalon;
        private System.Windows.Forms.ComboBox comboFilm;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton seans12;
        private System.Windows.Forms.RadioButton seans11;
        private System.Windows.Forms.RadioButton seans10;
        private System.Windows.Forms.RadioButton seans9;
        private System.Windows.Forms.RadioButton seans8;
        private System.Windows.Forms.RadioButton seans7;
        private System.Windows.Forms.RadioButton seans6;
        private System.Windows.Forms.RadioButton seans5;
        private System.Windows.Forms.RadioButton seans4;
        private System.Windows.Forms.RadioButton seans3;
        private System.Windows.Forms.RadioButton seans2;
        private System.Windows.Forms.RadioButton seans1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}