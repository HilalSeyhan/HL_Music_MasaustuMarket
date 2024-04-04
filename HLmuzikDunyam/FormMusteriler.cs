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
    public partial class FormMusteriler : DevExpress.XtraEditors.XtraForm
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormMusteriler_Load(object sender, EventArgs e)
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
    }
}