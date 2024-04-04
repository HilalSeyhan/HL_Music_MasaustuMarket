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
    public partial class FormCovidListesi : DevExpress.XtraEditors.XtraForm
    {
        public FormCovidListesi()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormCovidListesi_Load(object sender, EventArgs e)
        {
            var covidListem = c.personeller.Where(x => x.personelDurum == true).Select(x => new
            {
                PersonelId = x.personelID,
                TC = x.tc,
                Ad = x.ad,
                Soyad = x.soyad,
                Telefon = x.telefon,
                Departman = x.departmanlar.departmanAdi,
                CovidDurum = x.covidDurum.ToString(),
                Adres = x.adres
            }).ToList();
            gridControl2.DataSource = covidListem;

            txtEdtID.ReadOnly = true;
            txtEdtTC.ReadOnly = true;
            txtEdtPersonelAd.ReadOnly = true;
            txtEdtPersonelSoyad.ReadOnly = true;
            mskdTxtBoxTelefon.ReadOnly = true;
            txtEdtDepartman.ReadOnly = true;
            txtEdtCovidDurum.ReadOnly = true;
            txtBoxAdres.ReadOnly = true;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView2.GetFocusedRowCellValue("PersonelId").ToString();
            txtEdtTC.Text = gridView2.GetFocusedRowCellValue("TC").ToString();
            txtEdtPersonelAd.Text = gridView2.GetFocusedRowCellValue("Ad").ToString();
            txtEdtPersonelSoyad.Text = gridView2.GetFocusedRowCellValue("Soyad").ToString();
            mskdTxtBoxTelefon.Text = gridView2.GetFocusedRowCellValue("Telefon").ToString();
            txtEdtDepartman.Text = gridView2.GetFocusedRowCellValue("Departman").ToString();
            txtEdtCovidDurum.Text = gridView2.GetFocusedRowCellValue("CovidDurum").ToString();
            txtBoxAdres.Text = gridView2.GetFocusedRowCellValue("Adres").ToString();
        }
    }
}