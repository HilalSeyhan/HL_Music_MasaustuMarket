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
    public partial class FormFaturalar : DevExpress.XtraEditors.XtraForm
    {
        public FormFaturalar()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormFaturalar_Load(object sender, EventArgs e)
        {
            var faturaListem = c.faturaBilgi.Where(x => x.faturaBilgiDurum == true).Select(x => new
            {
                FaturaId = x.faturaBilgiID,
                Personel = x.personeller.ad + " " + x.personeller.soyad,
                Müşteri = x.musteriler.ad + " " + x.musteriler.soyad,
                Tarih = x.tarih,
                Saat = x.saat,
                VergiDairesi = x.vergiDairsei,
                FaturaNumarası = x.SeriSiraNo
            }).ToList();
            gridControl1.DataSource = faturaListem;

            txtEdtID.ReadOnly = true;
            txtEdtPersonel.ReadOnly = true;
            txtEdtMusteri.ReadOnly = true;
            txtEditTarih.ReadOnly = true;
            txtEditSaat.ReadOnly = true;
            txtEditFaturaNo.ReadOnly = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView1.GetFocusedRowCellValue("FaturaId").ToString();
            txtEdtPersonel.Text = gridView1.GetFocusedRowCellValue("Personel").ToString();
            txtEdtMusteri.Text = gridView1.GetFocusedRowCellValue("Müşteri").ToString();
            txtEditTarih.Text = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            txtEditSaat.Text = gridView1.GetFocusedRowCellValue("Saat").ToString();
            txtEditVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
            txtEditFaturaNo.Text = gridView1.GetFocusedRowCellValue("FaturaNumarası").ToString();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormFaturaKalemDetay frmFaturaDetay = new FormFaturaKalemDetay();
            frmFaturaDetay.id = int.Parse(gridView1.GetFocusedRowCellValue("FaturaId").ToString());
            frmFaturaDetay.Show();
        }
    }
}