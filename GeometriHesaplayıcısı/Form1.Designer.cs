namespace GeometriHesaplayıcısı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKenar = new System.Windows.Forms.TextBox();
            this.textBoxKısaKenar = new System.Windows.Forms.TextBox();
            this.textBoxUzunKenar = new System.Windows.Forms.TextBox();
            this.textBoxYarıCap = new System.Windows.Forms.TextBox();
            this.labelKare = new System.Windows.Forms.Label();
            this.labelDikdortgen = new System.Windows.Forms.Label();
            this.labeldaire = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(102, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(529, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "ALAN HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 145);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geometry Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.labelKare);
            this.panel2.Controls.Add(this.textBoxKenar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-2, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 239);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.labelDikdortgen);
            this.panel3.Controls.Add(this.textBoxUzunKenar);
            this.panel3.Controls.Add(this.textBoxKısaKenar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(268, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 239);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(257, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 178);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(521, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 178);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.labeldaire);
            this.panel6.Controls.Add(this.textBoxYarıCap);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Location = new System.Drawing.Point(534, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(254, 236);
            this.panel6.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(51, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kenar (m) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kısa Kenar (m) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Uzun Kenar (m) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yarı Çap (m) :";
            // 
            // textBoxKenar
            // 
            this.textBoxKenar.Location = new System.Drawing.Point(96, 123);
            this.textBoxKenar.Name = "textBoxKenar";
            this.textBoxKenar.Size = new System.Drawing.Size(100, 20);
            this.textBoxKenar.TabIndex = 6;
            this.textBoxKenar.Text = "0";
            // 
            // textBoxKısaKenar
            // 
            this.textBoxKısaKenar.Location = new System.Drawing.Point(104, 118);
            this.textBoxKısaKenar.Name = "textBoxKısaKenar";
            this.textBoxKısaKenar.Size = new System.Drawing.Size(100, 20);
            this.textBoxKısaKenar.TabIndex = 9;
            this.textBoxKısaKenar.Text = "0";
            // 
            // textBoxUzunKenar
            // 
            this.textBoxUzunKenar.Location = new System.Drawing.Point(104, 144);
            this.textBoxUzunKenar.Name = "textBoxUzunKenar";
            this.textBoxUzunKenar.Size = new System.Drawing.Size(100, 20);
            this.textBoxUzunKenar.TabIndex = 10;
            this.textBoxUzunKenar.Text = "0";
            // 
            // textBoxYarıCap
            // 
            this.textBoxYarıCap.Location = new System.Drawing.Point(103, 134);
            this.textBoxYarıCap.Name = "textBoxYarıCap";
            this.textBoxYarıCap.Size = new System.Drawing.Size(100, 20);
            this.textBoxYarıCap.TabIndex = 2;
            this.textBoxYarıCap.Text = "0";
            // 
            // labelKare
            // 
            this.labelKare.AutoSize = true;
            this.labelKare.Location = new System.Drawing.Point(93, 211);
            this.labelKare.Name = "labelKare";
            this.labelKare.Size = new System.Drawing.Size(13, 13);
            this.labelKare.TabIndex = 11;
            this.labelKare.Text = "0";
            // 
            // labelDikdortgen
            // 
            this.labelDikdortgen.AutoSize = true;
            this.labelDikdortgen.Location = new System.Drawing.Point(101, 211);
            this.labelDikdortgen.Name = "labelDikdortgen";
            this.labelDikdortgen.Size = new System.Drawing.Size(13, 13);
            this.labelDikdortgen.TabIndex = 11;
            this.labelDikdortgen.Text = "0";
            // 
            // labeldaire
            // 
            this.labeldaire.AutoSize = true;
            this.labeldaire.Location = new System.Drawing.Point(110, 211);
            this.labeldaire.Name = "labeldaire";
            this.labeldaire.Size = new System.Drawing.Size(13, 13);
            this.labeldaire.TabIndex = 3;
            this.labeldaire.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Geometri Hesaplayıcı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelKare;
        private System.Windows.Forms.TextBox textBoxKenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDikdortgen;
        private System.Windows.Forms.TextBox textBoxUzunKenar;
        private System.Windows.Forms.TextBox textBoxKısaKenar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labeldaire;
        private System.Windows.Forms.TextBox textBoxYarıCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

