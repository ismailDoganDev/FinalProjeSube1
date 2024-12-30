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
    public partial class SinifKayit : Form
    {
        Sinif? snf;
        public SinifKayit()
        {
            InitializeComponent();
        }

        private void btnSnfKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new OgrenciDbContext())
                {
                    var sinif = new Sinif
                    {
                        SinifAd = txtSinifAd.Text,
                        Kontenjan = txtKont.Text

                    };
                    context.Siniflar.Add(sinif);
                    context.SaveChanges();
                    MessageBox.Show("Sınıf başarıyla kaydedildi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata ile karşılaşıldı." + "/n" + ex);
            }

        }

        private void btnSnfBul_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    var snf = context.Siniflar.Find(int.Parse(txtBul.Text.Trim()));
                    if (snf != null)
                    {
                        this.snf = snf;
                        txtSinifAd.Text = snf.SinifAd;
                        txtKont.Text = snf.Kontenjan;

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSnfUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    if (snf != null)
                    {
                        snf.SinifAd = txtSinifAd.Text.Trim();
                        snf.Kontenjan = txtKont.Text.Trim();
                        context.Entry(snf).State = EntityState.Modified;
                        MessageBox.Show(context.SaveChanges() > 0 ? "Güncelleme başarıyla gerçekleşti" : "Bir sorun oluştu");
                    }
                    else
                    {
                        MessageBox.Show("Sınıf bulunamadı Lütfen Sınıf adını girip bula tıklayınız sonra tektar deneyiniz.");
                    }



                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSnfGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            DersKayit Dk = new DersKayit();
            Dk.Show();
        }
    }
}
