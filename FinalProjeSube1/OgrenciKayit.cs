using Microsoft.EntityFrameworkCore;
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
    public partial class OgrenciKayit : Form
    {
        Ogrenci? ogr;
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            using (var context = new OgrenciDbContext())
            {
                var siniflar = context.Siniflar.Select(s => new { Id = s.SinifId, Ad = s.SinifAd }).ToList();
                cmbxSinif.DisplayMember = "Ad";
                cmbxSinif.ValueMember = "Id";
                cmbxSinif.DataSource = siniflar;
            }
        }


        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (cmbxSinif.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir sýnýf seçiniz.");
                return;
            }
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    var ogr = new Ogrenci
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Numara = txtNumara.Text,
                        SinifId = (int)cmbxSinif.SelectedValue

                    };

                    ogr.SinifAd = context.Siniflar.Find(ogr.SinifId).SinifAd;

                    context.Ogrenciler.Add(ogr);

                    context.SaveChanges();
                    MessageBox.Show("Öðrenci baþarýyla kaydedildi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata ile karþýlaþýldý." + "/n" + ex);
            }
        }
        private void btnBul_Click_1(object sender, EventArgs e)
        {

            try
            {

                using (var context = new OgrenciDbContext())
                {
                    var ogr = context.Ogrenciler.Find(Convert.ToInt32(txtBul.Text));

                    if (ogr != null)
                    {
                        this.ogr = ogr;
                        txtAd.Text = ogr.Ad;
                        txtSoyad.Text = ogr.Soyad;
                        txtNumara.Text = ogr.Numara;
                        cmbxSinif.Text = ogr.SinifAd;
                    }


                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    if (ogr != null)
                    {
                        ogr.Numara = txtNumara.Text.Trim();
                        ogr.Ad = txtAd.Text.Trim();
                        ogr.Soyad = txtSoyad.Text.Trim();
                        ogr.SinifId = (int)cmbxSinif.SelectedValue;
                        context.Entry(ogr).State = EntityState.Modified;
                        MessageBox.Show(context.SaveChanges() > 0 ? "Güncelleme baþarýyla gerçekleþti" : "Bir sorun oluþtu");
                    }
                    else
                    {
                        MessageBox.Show("Öðrenci bulunamadý Lütfen Id girip bula týklayýnýz sonra tektar deneyiniz.");
                    }



                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnGecis_Click(object sender, EventArgs e)
                {
                    this.Hide();
                    OgrenciDersKayit Odk = new OgrenciDersKayit()
                    {
                        OgrenciAd = txtAd.Text,
                        OgrenciSoyad = txtSoyad.Text,
                        OgrenciNumara = txtNumara.Text,
                        SinifId = (int)cmbxSinif.SelectedValue

                    };
                    Odk.Show();
                }




        
    }
}