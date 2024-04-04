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
    public partial class FormDepartmanlar : DevExpress.XtraEditors.XtraForm
    {
        public FormDepartmanlar()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormDepartmanlar_Load(object sender, EventArgs e)
        {
            var departmanListem = c.departmanlar.Where(x => x.departmanDurum == true).Select(x => new
            {
                DepartmanId = x.departmanID,
                DepartmanAdı = x.departmanAdi,
                DepartmanTelefonu = x.departmanTelefonu,
            }).ToList();
            gridControl1.DataSource = departmanListem;

            txtEdtID.ReadOnly = true;
            txtEdtDepartmanAd.ReadOnly = true;
            mskdTxtBoxTelefon.ReadOnly = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView1.GetFocusedRowCellValue("DepartmanId").ToString();
            txtEdtDepartmanAd.Text = gridView1.GetFocusedRowCellValue("DepartmanAdı").ToString();
            mskdTxtBoxTelefon.Text = gridView1.GetFocusedRowCellValue("DepartmanTelefonu").ToString();
        }
    }
}