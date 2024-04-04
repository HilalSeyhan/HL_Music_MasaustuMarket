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
    public partial class FormCovidDepartman : DevExpress.XtraEditors.XtraForm
    {
        public FormCovidDepartman()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormCovidDepartman_Load(object sender, EventArgs e)
        {
            var covidDepartman = c.departmanlar.Where(x => x.departmanDurum == true && x.departmanCovidDurum == true).Select(x => new
            {
                DepartmanId = x.departmanID,
                DepartmanAdı = x.departmanAdi,
                CovidDurumu = x.departmanCovidDurum.ToString(),
                DepartmanTelefonu = x.departmanTelefonu,
            }).ToList();
            gridControl2.DataSource = covidDepartman;
        }
    }
}