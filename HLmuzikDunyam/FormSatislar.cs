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
    public partial class FormSatislar : DevExpress.XtraEditors.XtraForm
    {
        public FormSatislar()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormSatislar_Load(object sender, EventArgs e)
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

            txtEdtUrun.ReadOnly = true;
            txtEdtSatisFiyat.ReadOnly = true;
            txtEdtAdet.ReadOnly = true;
            txtEdtToplamTutar.ReadOnly = true;
            txtEdtPersonel.ReadOnly = true;
            txtEdtMusteri.ReadOnly = true;
            txtEditTarih.ReadOnly = true;
            txtEditSatisNo.ReadOnly = true;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtUrun.Text = gridView2.GetFocusedRowCellValue("ÜrünAdı").ToString();
            txtEdtSatisFiyat.Text = gridView2.GetFocusedRowCellValue("SatışFiyatı").ToString();
            txtEdtAdet.Text = gridView2.GetFocusedRowCellValue("Adet").ToString();
            txtEdtToplamTutar.Text = gridView2.GetFocusedRowCellValue("ToplamTutar").ToString();
            txtEdtPersonel.Text = gridView2.GetFocusedRowCellValue("Personel").ToString();
            txtEdtMusteri.Text = gridView2.GetFocusedRowCellValue("Müşteri").ToString();
            txtEditTarih.Text = gridView2.GetFocusedRowCellValue("Tarih").ToString();
            txtEditSatisNo.Text = gridView2.GetFocusedRowCellValue("SatışNumarası").ToString();
        }
    }
}