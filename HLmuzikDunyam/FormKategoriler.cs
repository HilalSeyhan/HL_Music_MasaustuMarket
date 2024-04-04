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
    public partial class FormKategoriler : DevExpress.XtraEditors.XtraForm
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormKategoriler_Load(object sender, EventArgs e)
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
    }
}