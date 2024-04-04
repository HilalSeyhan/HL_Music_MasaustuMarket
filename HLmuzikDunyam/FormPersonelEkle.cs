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
    public partial class FormPersonelEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormPersonelEkle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        int secilenIl;
        string secilenIlIsım, secilenIlce;

        private void FormPersonelEkle_Load(object sender, EventArgs e)
        {
            var personelListem = c.personeller.Where(x => x.personelDurum == true && x.departmanlar.departmanDurum == true).Select(x => new
            {
                PersonelID = x.personelID,
                TC = x.tc,
                Ad = x.ad,
                Soyad = x.soyad,
                Telefon = x.telefon,
                Mail = x.mail,
                Departman = x.departmanlar.departmanAdi,
                KullanıcıAdı = x.perKullaniciAdi,
                Parola = x.perParola,
                İl = x.il,
                İlçe = x.ilce,
                Adres = x.adres
            }).ToList();
            gridControl2.DataSource = personelListem;

            txtEdtID.ReadOnly = true;

            var departmanlarim = c.departmanlar.Select(y => new {
                y.departmanID,
                y.departmanAdi
            }).ToList();
            lookUpEdit3.Properties.DataSource = departmanlarim;

            var illerim = c.iller.Select(x => new {
                x.illerID,
                x.sehir
            }).ToList();
            lookUpEdit1.Properties.DataSource = illerim;
        }

        private void smplBtnKaydet_Click(object sender, EventArgs e)
        {
            if (mskdTxtBoxTC.Text != "" && txtEdtAd.Text != "" && txtEdtSoyad.Text != "" && mskdTxtBoxTelefon.Text != "" && txtEdtMail.Text != "" && lookUpEdit3.Text != "" && txtEdtKullaniciAdi.Text != "" && txtEdtParola.Text != "" && lookUpEdit1.Text != "" && lookUpEdit2.Text != "" && txtBoxAdres.Text != "")
            {
                personeller p = new personeller();
                p.tc = mskdTxtBoxTC.Text;
                p.ad = txtEdtAd.Text;
                p.soyad = txtEdtSoyad.Text;
                p.telefon = mskdTxtBoxTelefon.Text;
                p.mail = txtEdtMail.Text;
                p.departmanId = byte.Parse(lookUpEdit3.EditValue.ToString());
                p.perKullaniciAdi = txtEdtKullaniciAdi.Text;
                p.perParola = txtEdtParola.Text;
                p.il = lookUpEdit1.Text;
                p.ilce = lookUpEdit2.Text;
                p.adres = txtBoxAdres.Text;
                p.personelDurum = true;
                p.covidDurum = false;
                c.personeller.Add(p);
                c.SaveChanges();
                MessageBox.Show("Personel Kaydedildi..\nPersoneller Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEdtID.Text = "";
                mskdTxtBoxTC.Text = "";
                txtEdtAd.Text = "";
                txtEdtSoyad.Text = "";
                mskdTxtBoxTelefon.Text = "";
                txtEdtMail.Text = "";
                lookUpEdit3.Text = "";
                txtEdtKullaniciAdi.Text = "";
                txtEdtParola.Text = "";
                lookUpEdit1.Text = "";
                lookUpEdit2.Text = "";
                txtBoxAdres.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var personelListem = c.personeller.Where(x => x.personelDurum == true).Select(x => new
            {
                PersonelID = x.personelID,
                TC = x.tc,
                Ad = x.ad,
                Soyad = x.soyad,
                Telefon = x.telefon,
                Mail = x.mail,
                Departman = x.departmanlar.departmanAdi,
                KullanıcıAdı = x.perKullaniciAdi,
                Parola = x.perParola,
                İl = x.il,
                İlçe = x.ilce,
                Adres = x.adres
            }).ToList();
            gridControl2.DataSource = personelListem;
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