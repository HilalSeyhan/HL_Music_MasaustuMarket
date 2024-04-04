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
    public partial class FormKategoriSil : DevExpress.XtraEditors.XtraForm
    {
        public FormKategoriSil()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormKategoriSil_Load(object sender, EventArgs e)
        {
            var kategoriListem = c.kategoriler.Where(x => x.kategoriDurum == true).Select(x => new
            {
                KategoriId = x.kategoriID,
                KategoriAdı = x.kategoriAd,
            }).ToList();
            gridControl1.DataSource = kategoriListem;

            txtEdtID.ReadOnly = true;
            txtEdtKategoriAd.ReadOnly = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView1.GetFocusedRowCellValue("KategoriId").ToString();
            txtEdtKategoriAd.Text = gridView1.GetFocusedRowCellValue("KategoriAdı").ToString();
        }

        private void smplBtnSil_Click(object sender, EventArgs e)
        {
            int secilenId = int.Parse(txtEdtID.Text);
            var bul = c.kategoriler.Find(secilenId);
            bul.kategoriDurum = false;
            c.SaveChanges();
            MessageBox.Show("Kategori Silindi..\nKategoriler Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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