namespace FinalProjeSube1
{
    partial class SinifKayit
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
            txtSinifAd = new TextBox();
            txtKont = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSnfKaydet = new Button();
            btnSnfBul = new Button();
            btnSnfUpdate = new Button();
            btnSnfGecis = new Button();
            txtBul = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSinifAd);
            groupBox1.Controls.Add(txtKont);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(103, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sınıf Kaydetme Formu";
            // 
            // txtSinifAd
            // 
            txtSinifAd.Location = new Point(92, 78);
            txtSinifAd.Name = "txtSinifAd";
            txtSinifAd.Size = new Size(125, 27);
            txtSinifAd.TabIndex = 3;
            // 
            // txtKont
            // 
            txtKont.Location = new Point(92, 131);
            txtKont.Name = "txtKont";
            txtKont.Size = new Size(125, 27);
            txtKont.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Sınıf Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 134);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Kontenjan:";
            // 
            // btnSnfKaydet
            // 
            btnSnfKaydet.Location = new Point(103, 262);
            btnSnfKaydet.Name = "btnSnfKaydet";
            btnSnfKaydet.Size = new Size(243, 45);
            btnSnfKaydet.TabIndex = 4;
            btnSnfKaydet.Text = "Kaydet";
            btnSnfKaydet.UseVisualStyleBackColor = true;
            btnSnfKaydet.Click += btnSnfKaydet_Click;
            // 
            // btnSnfBul
            // 
            btnSnfBul.Location = new Point(554, 171);
            btnSnfBul.Name = "btnSnfBul";
            btnSnfBul.Size = new Size(125, 29);
            btnSnfBul.TabIndex = 5;
            btnSnfBul.Text = "Bul";
            btnSnfBul.UseVisualStyleBackColor = true;
            btnSnfBul.Click += btnSnfBul_Click;
            // 
            // btnSnfUpdate
            // 
            btnSnfUpdate.Location = new Point(103, 313);
            btnSnfUpdate.Name = "btnSnfUpdate";
            btnSnfUpdate.Size = new Size(243, 44);
            btnSnfUpdate.TabIndex = 6;
            btnSnfUpdate.Text = "Güncelle";
            btnSnfUpdate.UseVisualStyleBackColor = true;
            btnSnfUpdate.Click += btnSnfUpdate_Click;
            // 
            // btnSnfGecis
            // 
            btnSnfGecis.Location = new Point(103, 363);
            btnSnfGecis.Name = "btnSnfGecis";
            btnSnfGecis.Size = new Size(243, 49);
            btnSnfGecis.TabIndex = 7;
            btnSnfGecis.Text = "Ders Kaydetme Ekranına Geç";
            btnSnfGecis.UseVisualStyleBackColor = true;
            btnSnfGecis.Click += btnSnfGecis_Click;
            // 
            // txtBul
            // 
            txtBul.Location = new Point(554, 138);
            txtBul.Name = "txtBul";
            txtBul.Size = new Size(125, 27);
            txtBul.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 115);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 9;
            label3.Text = "Sınıf Bul:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 141);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 10;
            label4.Text = "Sınf Adını Yazınız:";
            // 
            // SinifKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBul);
            Controls.Add(btnSnfGecis);
            Controls.Add(btnSnfUpdate);
            Controls.Add(btnSnfKaydet);
            Controls.Add(btnSnfBul);
            Controls.Add(groupBox1);
            Name = "SinifKayit";
            Text = "SinifKayit";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSinifAd;
        private TextBox txtKont;
        private Label label2;
        private Label label1;
        private Button btnSnfKaydet;
        private Button btnSnfBul;
        private Button btnSnfUpdate;
        private Button btnSnfGecis;
        private TextBox txtBul;
        private Label label3;
        private Label label4;
    }
}