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
    public partial class FormKategoriEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormKategoriEkle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormKategoriEkle_Load(object sender, EventArgs e)
        {
            var kategoriListem = c.kategoriler.Where(x => x.kategoriDurum == true).Select(x => new
            {
                KategoriId = x.kategoriID,
                KategoriAdı = x.kategoriAd,
            }).ToList();
            gridControl1.DataSource = kategoriListem;

            txtEdtID.ReadOnly = true;
        }

        private void smplBtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEdtKategoriAd.Text != "")
            {
                kategoriler k = new kategoriler();
                k.kategoriAd = txtEdtKategoriAd.Text;
                k.kategoriDurum = true;
                c.kategoriler.Add(k);
                c.SaveChanges();
                MessageBox.Show("Kategori Kaydedildi..\nKategoriler Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var kategoriListem = c.kategoriler.Where(x => x.kategoriDurum == true).Select(x => new
            {
                KategoriId = x.kategoriID,
                KategoriAdı = x.kategoriAd,
            }).ToList();
            gridControl1.DataSource = kategoriListem;
        }
    }
}