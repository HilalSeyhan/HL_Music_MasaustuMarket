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
    public partial class FormPersoneller : DevExpress.XtraEditors.XtraForm
    {
        public FormPersoneller()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormPersoneller_Load(object sender, EventArgs e)
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
                İl = x.il,
                İlçe = x.ilce,
                Adres = x.adres
            }).ToList();
            gridControl2.DataSource = personelListem;

            txtEdtID.ReadOnly = true;
            txtEdtTC.ReadOnly = true;
            txtEdtAd.ReadOnly = true;
            txtEdtSoyad.ReadOnly = true;
            mskdTxtBoxTelefon.ReadOnly = true;
            txtEdtMail.ReadOnly = true;
            txtEdtDepartman.ReadOnly = true;
            txtEdtKullaniciAdi.ReadOnly = true;
            txtEdtIl.ReadOnly = true;
            txtEdtIlce.ReadOnly = true;
            txtBoxAdres.ReadOnly = true;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView2.GetFocusedRowCellValue("PersonelID").ToString();
            txtEdtTC.Text = gridView2.GetFocusedRowCellValue("TC").ToString();
            txtEdtAd.Text = gridView2.GetFocusedRowCellValue("Ad").ToString();
            txtEdtSoyad.Text = gridView2.GetFocusedRowCellValue("Soyad").ToString();
            mskdTxtBoxTelefon.Text = gridView2.GetFocusedRowCellValue("Telefon").ToString();
            txtEdtMail.Text = gridView2.GetFocusedRowCellValue("Mail").ToString();
            txtEdtDepartman.Text = gridView2.GetFocusedRowCellValue("Departman").ToString();
            txtEdtKullaniciAdi.Text = gridView2.GetFocusedRowCellValue("KullanıcıAdı").ToString();
            txtEdtIl.Text = gridView2.GetFocusedRowCellValue("İl").ToString();
            txtEdtIlce.Text = gridView2.GetFocusedRowCellValue("İlçe").ToString();
            txtBoxAdres.Text = gridView2.GetFocusedRowCellValue("Adres").ToString();
        }

    }
}