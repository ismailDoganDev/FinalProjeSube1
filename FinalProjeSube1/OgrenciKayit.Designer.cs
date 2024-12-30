namespace FinalProjeSube1
{
    partial class OgrenciKayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbxSinif = new ComboBox();
            txtNumara = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBul = new TextBox();
            btnKaydet = new Button();
            btnUpdate = new Button();
            btnBul = new Button();
            label5 = new Label();
            label6 = new Label();
            btnGecis = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbxSinif);
            groupBox1.Controls.Add(txtNumara);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Location = new Point(66, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Kaydetme Formu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 224);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 13;
            label4.Text = "Sınıf Seçiniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 169);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 12;
            label3.Text = "Numara:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 116);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 11;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 61);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 10;
            label1.Text = "Ad:";
            // 
            // cmbxSinif
            // 
            cmbxSinif.FormattingEnabled = true;
            cmbxSinif.Location = new Point(119, 221);
            cmbxSinif.Name = "cmbxSinif";
            cmbxSinif.Size = new Size(156, 28);
            cmbxSinif.TabIndex = 9;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(119, 166);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(156, 27);
            txtNumara.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(119, 61);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(156, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(119, 113);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(156, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtBul
            // 
            txtBul.Location = new Point(529, 125);
            txtBul.Name = "txtBul";
            txtBul.Size = new Size(125, 27);
            txtBul.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(66, 302);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(305, 54);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Öğrenci Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(66, 375);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(305, 58);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(529, 172);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(125, 29);
            btnBul.TabIndex = 8;
            btnBul.Text = "Öğrenci Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(529, 94);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 14;
            label5.Text = "Öğrenci Bul:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 128);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 15;
            label6.Text = "Numara Giriniz:";
            // 
            // btnGecis
            // 
            btnGecis.Location = new Point(66, 455);
            btnGecis.Name = "btnGecis";
            btnGecis.Size = new Size(305, 54);
            btnGecis.TabIndex = 16;
            btnGecis.Text = "Ders Kayıt Ekranına Geçiniz";
            btnGecis.UseVisualStyleBackColor = true;
            btnGecis.Click += btnGecis_Click;
            // 
            // OgrenciKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 544);
            Controls.Add(btnGecis);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnBul);
            Controls.Add(btnUpdate);
            Controls.Add(btnKaydet);
            Controls.Add(txtBul);
            Controls.Add(groupBox1);
            Name = "OgrenciKayit";
            Text = "OgrenciKaydet";
            Load += OgrenciKayit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbxSinif;
        private TextBox txtNumara;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBul;
        private Button btnKaydet;
        private Button btnUpdate;
        private Button btnBul;
        private Label label5;
        private Label label6;
        private Button btnGecis;
    }
}