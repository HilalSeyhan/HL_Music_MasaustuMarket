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
    public partial class FormMenu : DevExpress.XtraEditors.XtraForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void picEditCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picEditGeriDon_Click(object sender, EventArgs e)
        {
            FormLogin frmDonLogin = new FormLogin();
            frmDonLogin.Show();
            this.Hide();
        }

        FormUrunler frmUrunler;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunler == null || frmUrunler.IsDisposed)
            {
                frmUrunler = new FormUrunler();
                frmUrunler.MdiParent = this;
                frmUrunler.Show();
            }
        }

        FormUrunEkle frmUrunEkle;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunEkle == null || frmUrunEkle.IsDisposed)
            {
                frmUrunEkle = new FormUrunEkle();
                frmUrunEkle.MdiParent = this;
                frmUrunEkle.Show();
            }
        }

        FormUrunGuncelle frmUrunGuncelle;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunGuncelle == null || frmUrunGuncelle.IsDisposed)
            {
                frmUrunGuncelle = new FormUrunGuncelle();
                frmUrunGuncelle.MdiParent = this;
                frmUrunGuncelle.Show();
            }
        }

        FormUrunSil frmUrunSil;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunSil == null || frmUrunSil.IsDisposed)
            {
                frmUrunSil = new FormUrunSil();
                frmUrunSil.MdiParent = this;
                frmUrunSil.Show();
            }
        }

        FormUrunIstatistik frmUrunIstatistik;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunIstatistik == null || frmUrunIstatistik.IsDisposed)
            {
                frmUrunIstatistik = new FormUrunIstatistik();
                frmUrunIstatistik.MdiParent = this;
                frmUrunIstatistik.Show();
            }
        }

        FormKategoriler frmKategoriler;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKategoriler == null || frmKategoriler.IsDisposed)
            {
                frmKategoriler = new FormKategoriler();
                frmKategoriler.MdiParent = this;
                frmKategoriler.Show();
            }
        }

        FormKategoriEkle frmKategoriEkle;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKategoriEkle == null || frmKategoriEkle.IsDisposed)
            {
                frmKategoriEkle = new FormKategoriEkle();
                frmKategoriEkle.MdiParent = this;
                frmKategoriEkle.Show();
            }
        }

        FormKategoriSil frmKategoriSil;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKategoriSil == null || frmKategoriSil.IsDisposed)
            {
                frmKategoriSil = new FormKategoriSil();
                frmKategoriSil.MdiParent = this;
                frmKategoriSil.Show();
            }
        }

        FormSanatcilar frmSanatcilar;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSanatcilar == null || frmSanatcilar.IsDisposed)
            {
                frmSanatcilar = new FormSanatcilar();
                frmSanatcilar.MdiParent = this;
                frmSanatcilar.Show();
            }
        }

        FormSanatciEkle frmSanatciEkle;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSanatciEkle == null || frmSanatciEkle.IsDisposed)
            {
                frmSanatciEkle = new FormSanatciEkle();
                frmSanatciEkle.MdiParent = this;
                frmSanatciEkle.Show();
            }
        }

        FormSanatciIstatistik frmSanatciIstatistik;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSanatciIstatistik == null || frmSanatciIstatistik.IsDisposed)
            {
                frmSanatciIstatistik = new FormSanatciIstatistik();
                frmSanatciIstatistik.MdiParent = this;
                frmSanatciIstatistik.Show();
            }
        }

        FormMusteriler frmMusteriler;
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriler == null || frmMusteriler.IsDisposed)
            {
                frmMusteriler = new FormMusteriler();
                frmMusteriler.MdiParent = this;
                frmMusteriler.Show();
            }
        }

        FormMusteriEkle frmMusteriEkle;
        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriEkle == null || frmMusteriEkle.IsDisposed)
            {
                frmMusteriEkle = new FormMusteriEkle();
                frmMusteriEkle.MdiParent = this;
                frmMusteriEkle.Show();
            }
        }

        FormMusteriGuncelle frmMusteriGuncelle;
        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriGuncelle == null || frmMusteriGuncelle.IsDisposed)
            {
                frmMusteriGuncelle = new FormMusteriGuncelle();
                frmMusteriGuncelle.MdiParent = this;
                frmMusteriGuncelle.Show();
            }
        }

        FormMusteriIstatatistik frmMusteriIstatistik;
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriIstatistik == null || frmMusteriIstatistik.IsDisposed)
            {
                frmMusteriIstatistik = new FormMusteriIstatatistik();
                frmMusteriIstatistik.MdiParent = this;
                frmMusteriIstatistik.Show();
            }
        }

        FormMusteriPasifle frmMusteriPasifle;
        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriPasifle == null || frmMusteriPasifle.IsDisposed)
            {
                frmMusteriPasifle = new FormMusteriPasifle();
                frmMusteriPasifle.MdiParent = this;
                frmMusteriPasifle.Show();
            }
        }

        FormDepartmanlar frmDepartmanlar;
        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDepartmanlar == null || frmDepartmanlar.IsDisposed)
            {
                frmDepartmanlar = new FormDepartmanlar();
                frmDepartmanlar.MdiParent = this;
                frmDepartmanlar.Show();
            }
        }

        //FormDepartmanEkle frmDepartmanEkle;
        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frmDepartmanEkle == null || frmDepartmanEkle.IsDisposed)
            //{
            //    frmDepartmanEkle = new FormDepartmanEkle();
            //    frmDepartmanEkle.MdiParent = this;
            //    frmDepartmanEkle.Show();
            //}
        }

        //FormDepartmanGuncelle frmDepartmanGuncelle;
        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frmDepartmanGuncelle == null || frmDepartmanGuncelle.IsDisposed)
            //{
            //    frmDepartmanGuncelle = new FormDepartmanGuncelle();
            //    frmDepartmanGuncelle.MdiParent = this;
            //    frmDepartmanGuncelle.Show();
            //}
        }

        //FormDepartmanSil frmDepartmanSil;
        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frmDepartmanSil == null || frmDepartmanSil.IsDisposed)
            //{
            //    frmDepartmanSil = new FormDepartmanSil();
            //    frmDepartmanSil.MdiParent = this;
            //    frmDepartmanSil.Show();
            //}
        }

        FormCovidListesi frmCovidListesi;
        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCovidListesi == null || frmCovidListesi.IsDisposed)
            {
                frmCovidListesi = new FormCovidListesi();
                frmCovidListesi.MdiParent = this;
                frmCovidListesi.Show();
            }
        }

        //FormCovidPozitif frmCovidPozitif;
        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frmCovidPozitif == null || frmCovidPozitif.IsDisposed)
            //{
            //    frmCovidPozitif = new FormCovidPozitif();
            //    frmCovidPozitif.MdiParent = this;
            //    frmCovidPozitif.Show();
            //}
        }

        //FormCovidNegatif frmCovidNegatif;
        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frmCovidNegatif == null || frmCovidNegatif.IsDisposed)
            //{
            //    frmCovidNegatif = new FormCovidNegatif();
            //    frmCovidNegatif.MdiParent = this;
            //    frmCovidNegatif.Show();
            //}
        }

        FormCovidDepartman frmCovidDep;
        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCovidDep == null || frmCovidDep.IsDisposed)
            {
                frmCovidDep = new FormCovidDepartman();
                frmCovidDep.MdiParent = this;
                frmCovidDep.Show();
            }
        }

        FormPersoneller frmPersoneller;
        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersoneller == null || frmPersoneller.IsDisposed)
            {
                frmPersoneller = new FormPersoneller();
                frmPersoneller.MdiParent = this;
                frmPersoneller.Show();
            }
        }

        FormSatislar frmSatislar;
        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSatislar == null || frmSatislar.IsDisposed)
            {
                frmSatislar = new FormSatislar();
                frmSatislar.MdiParent = this;
                frmSatislar.Show();
            }
        }

        FormUrunSatis frmUrunSatis;
        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunSatis == null || frmUrunSatis.IsDisposed)
            {
                frmUrunSatis = new FormUrunSatis();
                frmUrunSatis.MdiParent = this;
                frmUrunSatis.Show();
            }
        }

        FormFaturalar frmFaturalar;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturalar == null || frmFaturalar.IsDisposed)
            {
                frmFaturalar = new FormFaturalar();
                frmFaturalar.MdiParent = this;
                frmFaturalar.Show();
            }
        }

        FormFaturaEkle frmFaturaEkle;
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturaEkle == null || frmFaturaEkle.IsDisposed)
            {
                frmFaturaEkle = new FormFaturaEkle();
                frmFaturaEkle.MdiParent = this;
                frmFaturaEkle.Show();
            }
        }

        FormFaturaKalemEkle frmKalemEkle;
        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKalemEkle == null || frmKalemEkle.IsDisposed)
            {
                frmKalemEkle = new FormFaturaKalemEkle();
                frmKalemEkle.MdiParent = this;
                frmKalemEkle.Show();
            }
        }
    }
}