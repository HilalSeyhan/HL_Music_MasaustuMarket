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
    public partial class FormFaturaEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormFaturaEkle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormFaturaEkle_Load(object sender, EventArgs e)
        {
            var faturaListem = c.faturaBilgi.Where(x=>x.faturaBilgiDurum == true).Select(x => new
            {
                FaturaId = x.faturaBilgiID,
                Personel = x.personeller.ad + " " + x.personeller.soyad,
                Müşteri = x.musteriler.ad + " " + x.musteriler.soyad,
                Tarih = x.tarih,
                Saat = x.saat,
                VergiDairesi = x.vergiDairsei,
                FaturaNumarası = x.SeriSiraNo
            }).ToList();
            gridControl1.DataSource = faturaListem;

            txtEditTarih.ReadOnly = true;
            txtEditSaat.ReadOnly = true;
            txtEditFaturaNo.ReadOnly = true;

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

            txtEditTarih.Text = DateTime.Now.ToShortDateString().ToString();
            txtEditSaat.Text = DateTime.Now.ToShortTimeString().ToString();

            var vergiDairelerim = c.vergiDaireleri.Select(x => new
            {
                Id = x.vergiDairesiId,
                VergiDairesi = x.adi
            }).ToList();
            lookUpEditVergiDairesi.Properties.DataSource = vergiDairelerim;

            smplBtnOnayla.Enabled = false;
            smplBtnIptalEt.Enabled = false;

        }

        private void smplBtnFaturaNoAl_Click(object sender, EventArgs e)
        {
            if (lookUpEditPersonel.EditValue != null && lookUpEditMusteri.EditValue != null && txtEditTarih.Text != "" && txtEditSaat.Text != "" && lookUpEditVergiDairesi.EditValue != null)
            {
                lookUpEditPersonel.Enabled = false;
                lookUpEditMusteri.Enabled = false;
                lookUpEditVergiDairesi.Enabled = false;

                Random rnd = new Random();//benzersiz satış takip numarası oluşturuyorum.
                string[] karakterler = { "a", "b", "c", "d" };
                int k1, k2, k3;
                k1 = rnd.Next(0, 4);
                k2 = rnd.Next(0, 4);
                k3 = rnd.Next(0, 4);
                int s1, s2, s3;
                s1 = rnd.Next(100, 1000);
                s2 = rnd.Next(10, 99);
                s3 = rnd.Next(10, 99);
                string kod = s1.ToString() + karakterler[k1] + s2.ToString() + karakterler[k2] + s3.ToString() + karakterler[k3];
                txtEditFaturaNo.Text = kod;

                smplBtnFaturaNoAl.Enabled = false;
                smplBtnOnayla.Enabled = true;
                smplBtnIptalEt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnIptalEt_Click(object sender, EventArgs e)
        {
            lookUpEditPersonel.EditValue = null;
            lookUpEditPersonel.Enabled = true;
            lookUpEditMusteri.EditValue = null;
            lookUpEditMusteri.Enabled = true;
            txtEditTarih.Text = DateTime.Now.ToShortDateString().ToString();
            txtEditSaat.Text = DateTime.Now.ToShortTimeString().ToString();
            lookUpEditVergiDairesi.EditValue = null;
            lookUpEditVergiDairesi.Enabled = true;
            txtEditFaturaNo.Text = " ";
            smplBtnFaturaNoAl.Enabled = true;
            smplBtnIptalEt.Enabled = false;
            smplBtnOnayla.Enabled = false;
        }

        private void smplBtnOnayla_Click(object sender, EventArgs e)
        {
            if (lookUpEditPersonel.EditValue != null && lookUpEditMusteri.EditValue != null && txtEditTarih.Text != "" && txtEditSaat.Text != "" && lookUpEditVergiDairesi.EditValue != null && txtEditFaturaNo.Text != "")
            {
                faturaBilgi fb = new faturaBilgi();
                fb.teslimEden = byte.Parse(lookUpEditPersonel.EditValue.ToString());
                fb.teslimAlan = int.Parse(lookUpEditMusteri.EditValue.ToString());
                fb.tarih = txtEditTarih.Text;
                fb.saat = txtEditSaat.Text;
                fb.vergiDairsei = lookUpEditVergiDairesi.Text;
                fb.SeriSiraNo = txtEditFaturaNo.Text;
                fb.faturaBilgiDurum = true;
                c.faturaBilgi.Add(fb);
                c.SaveChanges();
                MessageBox.Show("Fatura Girişi Başarıyla Tamamlandı..\nFaturalar Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lookUpEditPersonel.EditValue = null;
                lookUpEditPersonel.Enabled = true;
                lookUpEditMusteri.EditValue = null;
                lookUpEditMusteri.Enabled = true;
                txtEditTarih.Text = DateTime.Now.ToShortDateString().ToString();
                txtEditSaat.Text = DateTime.Now.ToShortTimeString().ToString();
                lookUpEditVergiDairesi.EditValue = null;
                lookUpEditVergiDairesi.Enabled = true;
                txtEditFaturaNo.Text = " ";
                smplBtnFaturaNoAl.Enabled = true;
                smplBtnIptalEt.Enabled = false;
                smplBtnOnayla.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var faturaListem = c.faturaBilgi.Where(x => x.faturaBilgiDurum == true).Select(x => new
            {
                FaturaId = x.faturaBilgiID,
                Personel = x.personeller.ad + " " + x.personeller.soyad,
                Müşteri = x.musteriler.ad + " " + x.musteriler.soyad,
                Tarih = x.tarih,
                Saat = x.saat,
                VergiDairesi = x.vergiDairsei,
                FaturaNumarası = x.SeriSiraNo
            }).ToList();
            gridControl1.DataSource = faturaListem;
        }
    }
}