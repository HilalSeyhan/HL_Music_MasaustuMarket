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
    public partial class FormUrunEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormUrunEkle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormUrunEkle_Load(object sender, EventArgs e)
        {
            nUpDownAdet.Maximum = 5000;
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
            gridControl1.DataSource = urunListem;

            txtEdtID.ReadOnly = true;

            var kategorilerim = c.kategoriler.Where(x => x.kategoriDurum == true).Select(x => new {
                Id = x.kategoriID,
                Kategori = x.kategoriAd
            }).ToList();
            lookUpEdit1.Properties.DataSource = kategorilerim;

            var sanatcilarim = c.sanatcilar.Select(x => new {
                Id = x.sanatciID,
                Sanatçı = x.sanatciAdi
            }).ToList();
            lookUpEdit2.Properties.DataSource = sanatcilarim;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //txtEdtID.Text = gridView1.GetFocusedRowCellValue("ÜrünId").ToString();
            //txtEdtUrunAd.Text = gridView1.GetFocusedRowCellValue("ÜrünAdı").ToString();
            //txtEdtSanatci.Text = gridView1.GetFocusedRowCellValue("Sanatçı").ToString();
            //mskdTxtBoxCikisYili.Text = gridView1.GetFocusedRowCellValue("Yıl").ToString();
            //nUpDownAdet.Value = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Adet"));
            //txtEdtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("AlışFiyat").ToString();
            //txtEdtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatışFiyat").ToString();
            //txtBoxDetay.Text = gridView1.GetFocusedRowCellValue("Detay").ToString();
            ////txtEdtGorsel.Text = gridView1.GetFocusedRowCellValue("Görsel").ToString();
            ////lookUpEdit1.Properties.ValueMember = gridView1.GetFocusedRowCellValue("Kategori").ToString();
        }

        private void smplBtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEdtUrunAd.Text != "" && lookUpEdit2.Text != "" && mskdTxtBoxCikisYili.Text != "" && nUpDownAdet.Value != 0 && txtEdtAlisFiyat.Text != "" && txtEdtSatisFiyat.Text != "" && txtBoxDetay.Text != "" && lookUpEdit1.Text != "")
            {
                urunler u = new urunler();
                u.urunAd = txtEdtUrunAd.Text;
                u.sanatci = Convert.ToByte(lookUpEdit2.EditValue.ToString());
                //u.sanatci = txtEdtSanatci.Text;
                u.yil = mskdTxtBoxCikisYili.Text;
                u.adet = short.Parse(nUpDownAdet.Value.ToString());
                u.alisFiyat = decimal.Parse(txtEdtAlisFiyat.Text);
                u.satisFiyat = decimal.Parse(txtEdtSatisFiyat.Text);
                u.detay = txtBoxDetay.Text;
                u.kategoriId = int.Parse(lookUpEdit1.EditValue.ToString());
                u.urunDurum = true;
                c.urunler.Add(u);
                c.SaveChanges();
                MessageBox.Show("Ürün Kaydedildi..\nÜrünler Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEdtID.Text = "";
                txtEdtUrunAd.Text = "";
                lookUpEdit2.Text = "";
                mskdTxtBoxCikisYili.Text = "";
                nUpDownAdet.Value = 0;
                txtEdtAlisFiyat.Text = "";
                txtEdtSatisFiyat.Text = "";
                txtBoxDetay.Text = "";
                //txtEdtGorsel.Text = "";
                lookUpEdit1.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
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
            gridControl1.DataSource = urunListem;
        }
    }
}