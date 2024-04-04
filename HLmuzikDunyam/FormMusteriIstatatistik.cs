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
    public partial class FormMusteriIstatatistik : DevExpress.XtraEditors.XtraForm
    {
        public FormMusteriIstatatistik()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormMusteriIstatatistik_Load(object sender, EventArgs e)
        {
            var musteriIlListem = c.musteriler.OrderBy(x => x.il).GroupBy(y => y.il).Select(z => new
            {
                İl = z.Key,
                MüşteriSayısı = z.Count()
            }).ToList();
            gridControl1.DataSource = musteriIlListem;

            lblToplamMusteriSayisi.Text = c.musteriler.Count().ToString();

            lblMusteriYogunluk.Text = c.enFazlaMusteriliIl().FirstOrDefault();

            lblToplamIlSayisi.Text = c.musteriler.Select(x => x.il).Distinct().Count().ToString();

            lblAktifMusteriSayisi.Text = c.musteriler.Where(x => x.musteriDurum == true).Count().ToString();

            lblPasifMusteriSayisi.Text = c.musteriler.Where(x => x.musteriDurum == false).Count().ToString();

            lblEnYeniMusterimiz.Text = c.musteriler.ToList().OrderByDescending(x => x.musteriID).Select(y => y.ad).FirstOrDefault();

            lblEnEskiMusterimiz.Text = c.musteriler.ToList().OrderBy(x => x.musteriID).Select(y => y.ad).FirstOrDefault();

        }
    }
}