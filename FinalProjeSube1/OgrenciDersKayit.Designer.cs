namespace FinalProjeSube1
{
    partial class OgrenciDersKayit
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
            dataGridView1 = new DataGridView();
            btnDersKayit = new Button();
            lblOgrenciBilgileri = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(643, 234);
            dataGridView1.TabIndex = 1;
            // 
            // btnDersKayit
            // 
            btnDersKayit.Location = new Point(39, 386);
            btnDersKayit.Name = "btnDersKayit";
            btnDersKayit.Size = new Size(331, 29);
            btnDersKayit.TabIndex = 2;
            btnDersKayit.Text = "Öğrencinin Derslerini kaydet";
            btnDersKayit.UseVisualStyleBackColor = true;
            btnDersKayit.Click += btnDersKayit_Click;
            // 
            // lblOgrenciBilgileri
            // 
            lblOgrenciBilgileri.AutoSize = true;
            lblOgrenciBilgileri.Location = new Point(39, 81);
            lblOgrenciBilgileri.Name = "lblOgrenciBilgileri";
            lblOgrenciBilgileri.Size = new Size(241, 20);
            lblOgrenciBilgileri.TabIndex = 4;
            lblOgrenciBilgileri.Text = "Öğrencinin Bilgileri Buraya Gelecek";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 41);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 5;
            label1.Text = "Öğrenci Bilgileri:";
            // 
            // OgrenciDersKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblOgrenciBilgileri);
            Controls.Add(btnDersKayit);
            Controls.Add(dataGridView1);
            Name = "OgrenciDersKayit";
            Text = "OgrenciDersKayit";
            Load += OgrenciDersKayit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDersKayit;
        private Label lblOgrenciBilgileri;
        private Label label1;
    }
}