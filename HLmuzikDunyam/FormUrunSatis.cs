using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HLmuzikDunyam
{
    public partial class FormUrunSatis : DevExpress.XtraEditors.XtraForm
    {
        public FormUrunSatis()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        int secilenUrun;

        private void FormUrunSatis_Load(object sender, EventArgs e)
        {
            nUpDownAdet.Maximum = 10;
            var satisListem = c.satislar.Select(x => new
            {
                SatışId = x.satisID,
                ÜrünAdı = x.urunler.urunAd,
                SatışFiyatı = x.satisFiyat,
                Adet = x.adet,
                ToplamTutar = x.toplamTutar,
                Personel = x.personeller.ad + " " + x.personeller.soyad,
                Müşteri = x.musteriler.ad + " " + x.musteriler.soyad,
                Tarih = x.tarih,
                SatışNumarası = x.seriSiraNo
            }).ToList();
            gridControl2.DataSource = satisListem;

            txtEdtSatisFiyat.ReadOnly = true;
            txtEdtToplamTutar.ReadOnly = true;
            txtEditTarih.ReadOnly = true;
            txtEditSatisNo.ReadOnly = true;

            var urunlerim = c.urunler.Where(x => x.urunDurum == true).Select(x => new
            {
                ÜrünId = x.urunID,
                ÜrünAdı = x.urunAd
            }).ToList();
            lookUpEditUrun.Properties.DataSource = urunlerim;

            txtEditTarih.Text = DateTime.Now.ToShortDateString().ToString();

            var personellerim = c.personeller.Where(x => x.personelDurum == true).Select(x => new
            {
                PersonelId = x.personelID,
                AdSoyad = x.ad + " " + x.soyad
            }).ToList();
            lookUpEditPersonel.Properties.DataSource = personellerim;

            var musterilerim = c.musteriler.Where(x => x.musteriDurum == true).Select(x => new
            {
                MüşteriId = x.musteriID,
                AdSoyad = x.ad + " " + x.soyad
            }).ToList();
            lookUpEditMusteri.Properties.DataSource = musterilerim;

            smplBtnSatisYap.Enabled = false;
            smplBtnIptalEt.Enabled = false;

        }

        private void lookUpEditUrun_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditUrun.EditValue != null)
            {
                secilenUrun = int.Parse(lookUpEditUrun.EditValue.ToString());

                var sorgu = c.urunler.SingleOrDefault(r => r.urunID == secilenUrun);

                if (sorgu != null)
                {
                    txtEdtSatisFiyat.Text = sorgu.satisFiyat.ToString();
                }
            }
        }

        private void nUpDownAdet_ValueChanged(object sender, EventArgs e)
        {
            if (nUpDownAdet.Value != 0)
            {
                txtEdtToplamTutar.Text = (decimal.Parse(txtEdtSatisFiyat.Text) * (nUpDownAdet.Value)).ToString();
            }
            else
            {
                txtEdtToplamTutar.Text = " ";
            }
        }

        private void smplBtnSatisNoAl_Click(object sender, EventArgs e)
        {
            if (lookUpEditUrun.EditValue != null && txtEdtSatisFiyat.Text != "" && nUpDownAdet.Value != 0 && txtEdtToplamTutar.Text != "" && lookUpEditPersonel.EditValue != null && lookUpEditMusteri.EditValue != null && txtEditTarih.Text != "")
            {
                lookUpEditUrun.Enabled = false;
                lookUpEditPersonel.Enabled = false;
                lookUpEditMusteri.Enabled = false;
                nUpDownAdet.Enabled = false;

                Random rnd = new Random();//benzersiz satış takip numarası oluşturuyorum.
                string[] karakterler = { "A", "B", "C", "D" };
                int k1, k2, k3;
                k1 = rnd.Next(0, 4);
                k2 = rnd.Next(0, 4);
                k3 = rnd.Next(0, 4);
                int s1, s2, s3;
                s1 = rnd.Next(100, 1000);
                s2 = rnd.Next(10, 99);
                s3 = rnd.Next(10, 99);
                string kod = s1.ToString() + karakterler[k1] + s2.ToString() + karakterler[k2] + s3.ToString() + karakterler[k3];
                txtEditSatisNo.Text = kod;

                smplBtnSatisNoAl.Enabled = false;
                smplBtnSatisYap.Enabled = true;
                smplBtnIptalEt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void smplBtnIptalEt_Click(object sender, EventArgs e)
        {
            lookUpEditUrun.EditValue = null;
            lookUpEditUrun.Enabled = true;
            txtEdtSatisFiyat.Text = " ";
            nUpDownAdet.Value = 0;
            nUpDownAdet.Enabled = true;
            txtEdtToplamTutar.Text = " ";
            lookUpEditPersonel.EditValue = null;
            lookUpEditPersonel.Enabled = true;
            lookUpEditMusteri.EditValue = null;
            lookUpEditMusteri.Enabled = true;
            txtEditTarih.Text = DateTime.Now.ToShortDateString().ToString();
            txtEditSatisNo.Text = " ";
            smplBtnSatisNoAl.Enabled = true;
            smplBtnIptalEt.Enabled = false;
            smplBtnSatisYap.Enabled = false;
        }

        private void smplBtnSatisYap_Click(object sender, EventArgs e)
        {
            if (lookUpEditUrun.EditValue != null && txtEdtSatisFiyat.Text != "" && nUpDownAdet.Value != 0 && txtEdtToplamTutar.Text != "" && lookUpEditPersonel.EditValue != null && lookUpEditMusteri.EditValue != null && txtEditTarih.Text != "" && txtEditSatisNo.Text != "")
            {
                satislar s = new satislar();
                s.urunId = int.Parse(lookUpEditUrun.EditValue.ToString());
                s.satisFiyat = decimal.Parse(txtEdtSatisFiyat.Text);
                s.adet = short.Parse(nUpDownAdet.Value.ToString());
                s.toplamTutar = decimal.Parse(txtEdtToplamTutar.Text);
                s.personelId = byte.Parse(lookUpEditPersonel.EditValue.ToString());
                s.musteriId = int.Parse(lookUpEditMusteri.EditValue.ToString());
                s.tarih = txtEditTarih.Text;
                s.seriSiraNo = txtEditSatisNo.Text;
                c.satislar.Add(s);
                c.SaveChanges();
                MessageBox.Show("Satış Başarıyla Tamamlandı..\nSatışlar Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lookUpEditUrun.EditValue = null;
                lookUpEditUrun.Enabled = true;
                txtEdtSatisFiyat.Text = " ";
                nUpDownAdet.Value = 0;
                nUpDownAdet.Enabled = true;
                txtEdtToplamTutar.Text = " ";
                lookUpEditPersonel.EditValue = null;
                lookUpEditPersonel.Enabled = true;
                lookUpEditMusteri.EditValue = null;
                lookUpEditMusteri.Enabled = true;
                txtEditSatisNo.Text = " ";
                smplBtnSatisNoAl.Enabled = true;
                smplBtnIptalEt.Enabled = false;
                smplBtnSatisYap.Enabled = false;

            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var satisListem = c.satislar.Select(x => new
            {
                SatışId = x.satisID,
                ÜrünAdı = x.urunler.urunAd,
                SatışFiyatı = x.satisFiyat,
                Adet = x.adet,
                ToplamTutar = x.toplamTutar,
                Personel = x.personeller.ad + " " + x.personeller.soyad,
                Müşteri = x.musteriler.ad + " " + x.musteriler.soyad,
                Tarih = x.tarih,
                SatışNumarası = x.seriSiraNo
            }).ToList();
            gridControl2.DataSource = satisListem;
        }
    }
}