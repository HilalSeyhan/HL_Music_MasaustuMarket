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
    public partial class FormAdmin : DevExpress.XtraEditors.XtraForm
    {
        public FormAdmin()
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

        FormDepartmanlar frmDepartmanlar2;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDepartmanlar2 == null || frmDepartmanlar2.IsDisposed)
            {
                frmDepartmanlar2 = new FormDepartmanlar();
                frmDepartmanlar2.MdiParent = this;
                frmDepartmanlar2.Show();
            }
        }

        FormDepartmanEkle frmDepartmanEkle;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDepartmanEkle == null || frmDepartmanEkle.IsDisposed)
            {
                frmDepartmanEkle = new FormDepartmanEkle();
                frmDepartmanEkle.MdiParent = this;
                frmDepartmanEkle.Show();
            }
        }

        FormDepartmanGuncelle frmDepartmanGuncelle;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDepartmanGuncelle == null || frmDepartmanGuncelle.IsDisposed)
            {
                frmDepartmanGuncelle = new FormDepartmanGuncelle();
                frmDepartmanGuncelle.MdiParent = this;
                frmDepartmanGuncelle.Show();
            }
        }

        FormDepartmanSil frmDepartmanSil;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDepartmanSil == null || frmDepartmanSil.IsDisposed)
            {
                frmDepartmanSil = new FormDepartmanSil();
                frmDepartmanSil.MdiParent = this;
                frmDepartmanSil.Show();
            }
        }

        FormCovidListesi frmCovidListesi2;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCovidListesi2 == null || frmCovidListesi2.IsDisposed)
            {
                frmCovidListesi2 = new FormCovidListesi();
                frmCovidListesi2.MdiParent = this;
                frmCovidListesi2.Show();
            }
        }

        FormCovidPozitif frmCovidPozitif;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCovidPozitif == null || frmCovidPozitif.IsDisposed)
            {
                frmCovidPozitif = new FormCovidPozitif();
                frmCovidPozitif.MdiParent = this;
                frmCovidPozitif.Show();
            }
        }

        FormCovidNegatif frmCovidNegatif;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCovidNegatif == null || frmCovidNegatif.IsDisposed)
            {
                frmCovidNegatif = new FormCovidNegatif();
                frmCovidNegatif.MdiParent = this;
                frmCovidNegatif.Show();
            }
        }

        FormCovidDepartman frmCovidDepartman;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCovidDepartman == null || frmCovidDepartman.IsDisposed)
            {
                frmCovidDepartman = new FormCovidDepartman();
                frmCovidDepartman.MdiParent = this;
                frmCovidDepartman.Show();
            }
        }

        FormPersoneller frmPersoneller2;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersoneller2 == null || frmPersoneller2.IsDisposed)
            {
                frmPersoneller2 = new FormPersoneller();
                frmPersoneller2.MdiParent = this;
                frmPersoneller2.Show();
            }
        }

        FormPersonelEkle frmPersonelEkle;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelEkle == null || frmPersonelEkle.IsDisposed)
            {
                frmPersonelEkle = new FormPersonelEkle();
                frmPersonelEkle.MdiParent = this;
                frmPersonelEkle.Show();
            }
        }

        FormPersonelGuncelle frmPersonelGuncelle;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelGuncelle == null || frmPersonelGuncelle.IsDisposed)
            {
                frmPersonelGuncelle = new FormPersonelGuncelle();
                frmPersonelGuncelle.MdiParent = this;
                frmPersonelGuncelle.Show();
            }
        }

        FormPersonelSil frmPersonelSil;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelSil == null || frmPersonelSil.IsDisposed)
            {
                frmPersonelSil = new FormPersonelSil();
                frmPersonelSil.MdiParent = this;
                frmPersonelSil.Show();
            }
        }

    }
}