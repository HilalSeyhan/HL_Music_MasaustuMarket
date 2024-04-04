﻿using System;
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
    public partial class FormUrunGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public FormUrunGuncelle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormUrunGuncelle_Load(object sender, EventArgs e)
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
            gridControl1.DataSource = urunListem;

            txtEdtID.ReadOnly = true;
            txtEdtUrunAd.ReadOnly = true;
            txtEdtSanatci.ReadOnly = true;
            mskdTxtBoxCikisYili.ReadOnly = true;
            nUpDownAdet.ReadOnly = true;
            txtBoxDetay.ReadOnly = true;
            txtEdtKategori.ReadOnly = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView1.GetFocusedRowCellValue("ÜrünId").ToString();
            txtEdtUrunAd.Text = gridView1.GetFocusedRowCellValue("ÜrünAdı").ToString();
            txtEdtSanatci.Text = gridView1.GetFocusedRowCellValue("Sanatçı").ToString();
            mskdTxtBoxCikisYili.Text = gridView1.GetFocusedRowCellValue("Yıl").ToString();
            nUpDownAdet.Value = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Adet"));
            txtEdtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("AlışFiyat").ToString();
            txtEdtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatışFiyat").ToString();
            txtBoxDetay.Text = gridView1.GetFocusedRowCellValue("Detay").ToString();
            //txtEdtGorsel.Text = gridView1.GetFocusedRowCellValue("Görsel").ToString();
            txtEdtKategori.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtEdtAlisFiyat.Text != "" && txtEdtSatisFiyat.Text != "")
            {
                int secilenId = int.Parse(txtEdtID.Text);
                var bul = c.urunler.Find(secilenId);
                bul.alisFiyat = decimal.Parse(txtEdtAlisFiyat.Text);
                bul.satisFiyat = decimal.Parse(txtEdtSatisFiyat.Text);
                c.SaveChanges();
                MessageBox.Show("Ürün Güncellendi..\nÜrünler Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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