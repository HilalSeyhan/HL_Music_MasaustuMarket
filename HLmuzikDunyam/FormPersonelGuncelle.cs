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
    public partial class FormPersonelGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public FormPersonelGuncelle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        int secilenIl;
        string secilenIlIsım, secilenIlce;

        private void FormPersonelGuncelle_Load(object sender, EventArgs e)
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
            mskdTxtBoxTC.ReadOnly = true;

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

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView2.GetFocusedRowCellValue("PersonelID").ToString();
            mskdTxtBoxTC.Text = gridView2.GetFocusedRowCellValue("TC").ToString();
            txtEdtAd.Text = gridView2.GetFocusedRowCellValue("Ad").ToString();
            txtEdtSoyad.Text = gridView2.GetFocusedRowCellValue("Soyad").ToString();
            mskdTxtBoxTelefon.Text = gridView2.GetFocusedRowCellValue("Telefon").ToString();
            txtEdtMail.Text = gridView2.GetFocusedRowCellValue("Mail").ToString();
            lookUpEdit3.Text = gridView2.GetFocusedRowCellValue("Departman").ToString();
            txtEdtKullaniciAdi.Text = gridView2.GetFocusedRowCellValue("KullanıcıAdı").ToString();
            txtEdtParola.Text = gridView2.GetFocusedRowCellValue("Parola").ToString();
            lookUpEdit1.Text = gridView2.GetFocusedRowCellValue("İl").ToString();
            lookUpEdit2.Text = gridView2.GetFocusedRowCellValue("İlçe").ToString();
            txtBoxAdres.Text = gridView2.GetFocusedRowCellValue("Adres").ToString();
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (mskdTxtBoxTC.Text != "" && txtEdtAd.Text != "" && txtEdtSoyad.Text != "" && mskdTxtBoxTelefon.Text != "" && txtEdtMail.Text != "" && lookUpEdit3.Text != "" && txtEdtKullaniciAdi.Text != "" && txtEdtParola.Text != "" && lookUpEdit1.Text != "" && lookUpEdit2.Text != "" && txtBoxAdres.Text != "")
            {
                int secilenId = int.Parse(txtEdtID.Text);
                var bul = c.personeller.Find(secilenId);
                bul.tc = mskdTxtBoxTC.Text;
                bul.ad = txtEdtAd.Text;
                bul.soyad = txtEdtSoyad.Text;
                bul.telefon = mskdTxtBoxTelefon.Text;
                bul.mail = txtEdtMail.Text;
                bul.departmanId = byte.Parse(lookUpEdit3.EditValue.ToString());
                bul.perKullaniciAdi = txtEdtKullaniciAdi.Text;
                bul.perParola = txtEdtParola.Text;
                bul.il = lookUpEdit1.Text;
                bul.ilce = lookUpEdit2.Text;
                bul.adres = txtBoxAdres.Text;
                c.SaveChanges();
                MessageBox.Show("Personel Güncellendi..\nPersoneller Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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