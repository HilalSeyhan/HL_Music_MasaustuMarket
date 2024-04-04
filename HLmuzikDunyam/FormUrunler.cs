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
    public partial class FormUrunler : DevExpress.XtraEditors.XtraForm
    {
        public FormUrunler()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            nUpDownAdet.Maximum = 5000;
            nUpDownAdet.Enabled = false;
            var urunListem = c.urunler.Where(x => x.urunDurum == true).Select(x => new
            {
                ÜrünId = x.urunID,
                ÜrünAdı = x.urunAd,
                Sanatçı = x.sanatcilar.sanatciAdi,
                Yıl = x.yil,
                Adet = x.adet,
                AlışFiyat = x.alisFiyat,
                SatışFiyat = x.satisFiyat,
                Detay = x.detay,
                //ÜrünGörsel = x.urunGorsel,
                Kategori = x.kategoriler.kategoriAd
            }).ToList();
            gridControl2.DataSource = urunListem;

            txtEdtID.ReadOnly = true;
            txtEdtUrunAd.ReadOnly = true;
            txtEdtSanatci.ReadOnly = true;
            mskdTxtBoxCikisYili.ReadOnly = true;
            nUpDownAdet.ReadOnly = true;
            txtEdtAlisFiyat.ReadOnly = true;
            txtEdtSatisFiyat.ReadOnly = true;
            txtBoxDetay.ReadOnly = true;
            txtEdtKategori.ReadOnly = true;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView2.GetFocusedRowCellValue("ÜrünId").ToString();
            txtEdtUrunAd.Text = gridView2.GetFocusedRowCellValue("ÜrünAdı").ToString();
            txtEdtSanatci.Text = gridView2.GetFocusedRowCellValue("Sanatçı").ToString();
            mskdTxtBoxCikisYili.Text = gridView2.GetFocusedRowCellValue("Yıl").ToString();
            nUpDownAdet.Value = Convert.ToInt16(gridView2.GetFocusedRowCellValue("Adet"));
            txtEdtAlisFiyat.Text = gridView2.GetFocusedRowCellValue("AlışFiyat").ToString();
            txtEdtSatisFiyat.Text = gridView2.GetFocusedRowCellValue("SatışFiyat").ToString();
            txtBoxDetay.Text = gridView2.GetFocusedRowCellValue("Detay").ToString();
            //txtEdtGorsel.Text = gridView2.GetFocusedRowCellValue("Görsel").ToString();
            txtEdtKategori.Text = gridView2.GetFocusedRowCellValue("Kategori").ToString();
        }
    }
}