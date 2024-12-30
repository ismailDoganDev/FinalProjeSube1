namespace FinalProjeSube1
{
    partial class DersKayit
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtDersKod = new TextBox();
            txtDersAd = new TextBox();
            btnEkle = new Button();
            btnDersGecis = new Button();
            btnDersUpdate = new Button();
            txtDersBul = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnDersBul = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDersKod);
            groupBox1.Controls.Add(txtDersAd);
            groupBox1.Location = new Point(71, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Ekleme Formu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 149);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Ders Kodu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 70);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Ders Adı:";
            // 
            // txtDersKod
            // 
            txtDersKod.Location = new Point(114, 146);
            txtDersKod.Name = "txtDersKod";
            txtDersKod.Size = new Size(125, 27);
            txtDersKod.TabIndex = 1;
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(114, 67);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(125, 27);
            txtDersAd.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(71, 254);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(282, 44);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ders Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDersGecis
            // 
            btnDersGecis.Location = new Point(71, 382);
            btnDersGecis.Name = "btnDersGecis";
            btnDersGecis.Size = new Size(282, 43);
            btnDersGecis.TabIndex = 5;
            btnDersGecis.Text = "Öğrenci Kaydetme Ekranına Geç";
            btnDersGecis.UseVisualStyleBackColor = true;
            btnDersGecis.Click += btnDersGecis_Click;
            // 
            // btnDersUpdate
            // 
            btnDersUpdate.Location = new Point(71, 320);
            btnDersUpdate.Name = "btnDersUpdate";
            btnDersUpdate.Size = new Size(282, 44);
            btnDersUpdate.TabIndex = 6;
            btnDersUpdate.Text = "Güncelle";
            btnDersUpdate.UseVisualStyleBackColor = true;
            btnDersUpdate.Click += btnDersUpdate_Click;
            // 
            // txtDersBul
            // 
            txtDersBul.Location = new Point(550, 88);
            txtDersBul.Name = "txtDersBul";
            txtDersBul.Size = new Size(125, 27);
            txtDersBul.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 65);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "Ders Bul:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 91);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 9;
            label4.Text = "Ders Kodu Giriniz:";
            // 
            // btnDersBul
            // 
            btnDersBul.Location = new Point(550, 130);
            btnDersBul.Name = "btnDersBul";
            btnDersBul.Size = new Size(125, 44);
            btnDersBul.TabIndex = 10;
            btnDersBul.Text = "Ders Bul";
            btnDersBul.UseVisualStyleBackColor = true;
            btnDersBul.Click += btnDersBul_Click;
            // 
            // DersKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDersBul);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDersBul);
            Controls.Add(btnDersUpdate);
            Controls.Add(btnEkle);
            Controls.Add(btnDersGecis);
            Controls.Add(groupBox1);
            Name = "DersKayit";
            Text = "DersKayit";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtDersKod;
        private TextBox txtDersAd;
        private Button btnEkle;
        private Button btnDersGecis;
        private Button btnDersUpdate;
        private TextBox txtDersBul;
        private Label label3;
        private Label label4;
        private Button btnDersBul;
    }
}