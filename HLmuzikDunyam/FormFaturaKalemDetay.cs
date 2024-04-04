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
    public partial class FormFaturaKalemDetay : DevExpress.XtraEditors.XtraForm
    {
        public FormFaturaKalemDetay()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        public int id;

        private void FormFaturaKalemDetay_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = c.faturaIcerik.Where(x => x.faturaBilgiId == id).Select(x => new
            {
                FaturaKalemId = x.faturaIcerikID,
                ÜrünAdı = x.urunler.urunAd,
                BirimFiyatı = x.birimFiyat,
                Adet = x.miktar,
                ToplamTutar = x.tutar,
                FaturaSeriNo = x.faturaBilgi.SeriSiraNo
            }).ToList();
        }
    }
}