namespace NotOrtalama
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
            this.ad = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.not1 = new System.Windows.Forms.TextBox();
            this.not2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblOrt = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.hesap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(171, 86);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(100, 22);
            this.ad.TabIndex = 0;
            this.ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(171, 154);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 22);
            this.num.TabIndex = 1;
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // not1
            // 
            this.not1.Location = new System.Drawing.Point(171, 223);
            this.not1.MaxLength = 3;
            this.not1.Name = "not1";
            this.not1.Size = new System.Drawing.Size(100, 22);
            this.not1.TabIndex = 2;
            this.not1.TextChanged += new System.EventHandler(this.not1_TextChanged);
            this.not1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.not1_KeyPress);
            // 
            // not2
            // 
            this.not2.Location = new System.Drawing.Point(171, 297);
            this.not2.MaxLength = 3;
            this.not2.Name = "not2";
            this.not2.Size = new System.Drawing.Size(100, 22);
            this.not2.TabIndex = 3;
            this.not2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.not2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "I.Dönem Notu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "II.Dönem Notu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Öğrenci Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Öğrenci Numarası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Not Ortalaması:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Durum:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(588, 92);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 16);
            this.lblAd.TabIndex = 12;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(591, 160);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 16);
            this.lblNum.TabIndex = 13;
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Location = new System.Drawing.Point(591, 229);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(0, 16);
            this.lblOrt.TabIndex = 14;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(591, 303);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 16);
            this.lblDurum.TabIndex = 15;
            // 
            // hesap
            // 
            this.hesap.Location = new System.Drawing.Point(171, 351);
            this.hesap.Name = "hesap";
            this.hesap.Size = new System.Drawing.Size(100, 23);
            this.hesap.TabIndex = 16;
            this.hesap.Text = "Hesapla";
            this.hesap.UseVisualStyleBackColor = true;
            this.hesap.Click += new System.EventHandler(this.hesap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hesap);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.not2);
            this.Controls.Add(this.not1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox not1;
        private System.Windows.Forms.TextBox not2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button hesap;
        private System.Windows.Forms.Button button1;
    }
}

