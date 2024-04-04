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
    public partial class FormCovidNegatif : DevExpress.XtraEditors.XtraForm
    {
        public FormCovidNegatif()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormCovidNegatif_Load(object sender, EventArgs e)
        {
            var covidListem = c.personeller.Where(x => x.personelDurum == true && x.covidDurum == true).Select(x => new
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
            //txtEdtCovidDurum.ReadOnly = true;
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
            //txtEdtCovidDurum.Text = gridView2.GetFocusedRowCellValue("CovidDurum").ToString();
            txtBoxAdres.Text = gridView2.GetFocusedRowCellValue("Adres").ToString();
        }

        private void smplBtnBildir_Click(object sender, EventArgs e)
        {
            if (txtEdtCovidDurum.Text != "" && (txtEdtCovidDurum.Text == "NEGATİF" || txtEdtCovidDurum.Text == "negatif"))
            {
                int secilenId = int.Parse(txtEdtID.Text);
                var bul = c.personeller.Find(secilenId);
                bul.covidDurum = false;
                bul.departmanlar.departmanCovidDurum = false;
                c.SaveChanges();
                MessageBox.Show("Covid-19 Durumu Negatif (-) Olarak Güncellendi..\n\nPersonelin Dahil Olduğu Departman İçin Süreç Göz Önüne Alınacaktır..\n\nCovid-19 Listesi Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanı Uygun Şekilde Doldurunuz..!\nCovid-19 Pozitif Vaka için 'NEGATİF' ya da 'negatif' yazmanız yeterlidir.", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var covidListem = c.personeller.Where(x => x.personelDurum == true && x.covidDurum == true).Select(x => new
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
        }
    }
}