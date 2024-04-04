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
    public partial class FormMusteriEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormMusteriEkle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        int secilenIl;
        string secilenIlIsım, secilenIlce;

        private void FormMusteriEkle_Load(object sender, EventArgs e)
        {
            var musteriListem = c.musteriler.Where(x => x.musteriDurum == true).Select(x => new
            {
                MüşteriID = x.musteriID,
                TC = x.tc,
                Ad = x.ad,
                Soyad = x.soyad,
                Telefon = x.telefon,
                Mail = x.mail,
                İl = x.il,
                İlçe = x.ilce,
                Adres = x.adres
            }).ToList();
            gridControl2.DataSource = musteriListem;

            txtEdtID.ReadOnly = true;

            var illerim = c.iller.Select(x => new {
                x.illerID,
                x.sehir
            }).ToList();
            lookUpEdit1.Properties.DataSource = illerim;
        }

        private void smplBtnKaydet_Click(object sender, EventArgs e)
        {
            if (mskdTxtBoxTC.Text != "" && txtEdtMusteriAd.Text != "" && txtEdtMusteriSoyad.Text != "" && mskdTxtBoxTelefon.Text != "" && txtEdtMail.Text != "" && lookUpEdit1.Text != "" && lookUpEdit2.Text != "" && txtBoxAdres.Text != "")
            {
                musteriler m = new musteriler();
                m.tc = mskdTxtBoxTC.Text;
                m.ad = txtEdtMusteriAd.Text;
                m.soyad = txtEdtMusteriSoyad.Text;
                m.telefon = mskdTxtBoxTelefon.Text;
                m.mail = txtEdtMail.Text;
                m.adres = txtBoxAdres.Text;
                m.musteriDurum = true;
                c.musteriler.Add(m);
                c.SaveChanges();
                MessageBox.Show("Müşteri Kaydedildi..\nMüşteriler Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEdtID.Text = "";
                mskdTxtBoxTC.Text = "";
                txtEdtMusteriAd.Text = "";
                txtEdtMusteriSoyad.Text = "";
                mskdTxtBoxTelefon.Text = "";
                txtEdtMail.Text = "";
                txtBoxAdres.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var musteriListem = c.musteriler.Where(x => x.musteriDurum == true).Select(x => new
            {
                MüşteriID = x.musteriID,
                TC = x.tc,
                Ad = x.ad,
                Soyad = x.soyad,
                Telefon = x.telefon,
                Mail = x.mail,
                İl = x.il,
                İlçe = x.ilce,
                Adres = x.adres
            }).ToList();
            gridControl2.DataSource = musteriListem;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            secilenIl = int.Parse(lookUpEdit1.EditValue.ToString());
            secilenIlIsım = lookUpEdit1.Text;
            lookUpEdit2.Properties.DataSource = (from y in c.ilceler
                                                 select new
                                                 {
                                                     y.ilcelerID,
                                                     y.ilce,
                                                     y.iLId
                                                 }).Where(z => z.iLId == secilenIl).ToList();
            txtBoxAdres.Text = "";
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilenIlce = lookUpEdit2.Text;
            var adresBirlestir = secilenIlce + "/" + secilenIlIsım;
            txtBoxAdres.Text = adresBirlestir;
        }
    }
}