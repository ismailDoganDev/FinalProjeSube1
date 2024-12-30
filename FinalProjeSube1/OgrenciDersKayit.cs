using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjeSube1
{


    public partial class OgrenciDersKayit : Form
    {
        internal string OgrenciAd;
        internal string OgrenciSoyad;
        internal string OgrenciNumara;
        internal int SinifId;

        public OgrenciDersKayit()
        {
            InitializeComponent();
        }

        private void btnDersKayit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OgrenciAd))
            {
                MessageBox.Show("Öğrenci bilgileri eksik.");
                return;
            }

            int ogrenciId; // Bu ID’yi bulmak için veritabanından almak gerekecek  

            using (var context = new OgrenciDbContext())
            {
                var ogrenci = context.Ogrenciler.FirstOrDefault(o =>
                    o.Ad == OgrenciAd && o.Soyad == OgrenciSoyad);

                if (ogrenci != null)
                {
                    ogrenciId = ogrenci.OgrenciId;

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["DersId"].Value != null)
                        {
                            int dersId = Convert.ToInt32(row.Cells["DersId"].Value);

                            var ogrenciDers = new OgrenciDers
                            {
                                OgrenciId = ogrenciId,
                                DersId = dersId
                            };

                            context.OgrenciDersler.Add(ogrenciDers);
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Dersler başarıyla kaydedildi!");
                }
            }
        }

        private void OgrenciDersKayit_Load(object sender, EventArgs e)
        {
            lblOgrenciBilgileri.Text = $"AD: {OgrenciAd}  SOYAD: {OgrenciSoyad}  NUMARA: {OgrenciNumara} SINIF: {SinifId}";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("DersId", "Ders ID");
            dataGridView1.Columns.Add("DersKod", "Ders Kodu");
            dataGridView1.Columns.Add("DersAd", "Ders Adı");

            using (var context = new OgrenciDbContext())
            {

                var dersler = context.Dersler.ToList();


                foreach (var ders in dersler)
                {
                    dataGridView1.Rows.Add(ders.DersId, ders.DersKod, ders.DersAd);
                }
            }
        }

    }
}
