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
    public partial class FormSanatcilar : DevExpress.XtraEditors.XtraForm
    {
        public FormSanatcilar()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormSanatcilar_Load(object sender, EventArgs e)
        {
            var sanatciListem = c.sanatcilar.Select(x => new
            {
                SanatçıId = x.sanatciID,
                SanatçıAdı = x.sanatciAdi,
                EtkinYıllar = x.etkinYillari,
                DoğduğuŞehir = x.dogduguSehir,
            }).ToList();
            gridControl1.DataSource = sanatciListem;

            txtEdtID.ReadOnly = true;
            txtEdtSanatciAd.ReadOnly = true;
            txtEdtEtkinYillar.ReadOnly = true;
            txtEditDogumYeri.ReadOnly = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView1.GetFocusedRowCellValue("SanatçıId").ToString();
            txtEdtSanatciAd.Text = gridView1.GetFocusedRowCellValue("SanatçıAdı").ToString();
            txtEdtEtkinYillar.Text = gridView1.GetFocusedRowCellValue("EtkinYıllar").ToString();
            txtEditDogumYeri.Text = gridView1.GetFocusedRowCellValue("DoğduğuŞehir").ToString();
        }
    }
}