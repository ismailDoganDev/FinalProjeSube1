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
    public partial class DersKayit : Form
    {
        Ders? drs;
        public DersKayit()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    var ders = new Ders
                    {
                        DersKod = txtDersKod.Text,
                        DersAd = txtDersAd.Text
                    };
                    context.Dersler.Add(ders);
                    context.SaveChanges();
                    MessageBox.Show("Ders başarıyla kaydedildi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata ile karşılaşıldı." + "/n" + ex);
            }
        }

        private void btnDersBul_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new OgrenciDbContext())
                {
                    var snf = context.Siniflar.Find(int.Parse(txtDersKod.Text.Trim()));
                    if (drs != null)
                    {
                        this.drs = drs;
                        txtDersAd.Text = drs.DersAd;
                        txtDersKod.Text = drs.DersKod;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDersUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OgrenciDbContext())
                {
                    if (drs != null)
                    {
                        drs.DersAd = txtDersAd.Text.Trim();
                        drs.DersKod = txtDersKod.Text.Trim();
                        context.Entry(drs).State = EntityState.Modified;
                        MessageBox.Show(context.SaveChanges() > 0 ? "Güncelleme başarıyla gerçekleşti" : "Bir sorun oluştu");
                    }
                    else
                    {
                        MessageBox.Show("Ders bulunamadı Lütfen Ders Kodunu girip bula tıklayınız sonra tektar deneyiniz.");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDersGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciKayit Ok = new OgrenciKayit();
            Ok.Show();
        }
    }


}

