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
    public partial class FormMusteriPasifle : DevExpress.XtraEditors.XtraForm
    {
        public FormMusteriPasifle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormMusteriPasifle_Load(object sender, EventArgs e)
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
            mskdTxtBoxTC.ReadOnly = true;
            txtEdtMusteriAd.ReadOnly = true;
            txtEdtMusteriSoyad.ReadOnly = true;
            mskdTxtBoxTelefon.ReadOnly = true;
            txtEdtMail.ReadOnly = true;
            txtEdtIl.ReadOnly = true;
            txtEdtIlce.ReadOnly = true;
            txtBoxAdres.ReadOnly = true;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView2.GetFocusedRowCellValue("MüşteriID").ToString();
            mskdTxtBoxTC.Text = gridView2.GetFocusedRowCellValue("TC").ToString();
            txtEdtMusteriAd.Text = gridView2.GetFocusedRowCellValue("Ad").ToString();
            txtEdtMusteriSoyad.Text = gridView2.GetFocusedRowCellValue("Soyad").ToString();
            mskdTxtBoxTelefon.Text = gridView2.GetFocusedRowCellValue("Telefon").ToString();
            txtEdtMail.Text = gridView2.GetFocusedRowCellValue("Mail").ToString();
            txtEdtIl.Text = gridView2.GetFocusedRowCellValue("İl").ToString();
            txtEdtIlce.Text = gridView2.GetFocusedRowCellValue("İlçe").ToString();
            txtBoxAdres.Text = gridView2.GetFocusedRowCellValue("Adres").ToString();
        }

        private void smplBtnPasifle_Click(object sender, EventArgs e)
        {
            int secilenId = int.Parse(txtEdtID.Text);
            var bul = c.musteriler.Find(secilenId);
            bul.musteriDurum = false;
            c.SaveChanges();
            MessageBox.Show("Müşteri Pasifleşti..\nMüşteriler Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}