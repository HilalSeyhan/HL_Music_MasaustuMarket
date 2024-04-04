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
using System.Data.SqlClient;

namespace HLmuzikDunyam
{
    public partial class FormSanatciIstatistik : DevExpress.XtraEditors.XtraForm
    {
        public FormSanatciIstatistik()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormSanatciIstatistik_Load(object sender, EventArgs e)
        {
            var sanatciIstatistik = c.urunler.OrderBy(x => x.sanatcilar.sanatciAdi).GroupBy(y => y.sanatcilar.sanatciAdi).Select(z => new
            {
                Sanatçı = z.Key,
                ToplamÜrünSayısı = z.Count()
            }).ToList();
            gridControl1.DataSource = sanatciIstatistik;

            lblToplamSanatciSayisi.Text = c.sanatcilar.Distinct().Count().ToString();

            lblEnFazlaUrunuOlanSanatci.Text = c.enFazlaUrunluSanatci().FirstOrDefault();

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BK845UE;Initial Catalog=ticariOtomasyonProje;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT sanatcilar.sanatciAdi, count(*) FROM urunler INNER JOIN sanatcilar ON sanatcilar.sanatciID = urunler.sanatci GROUP BY sanatcilar.sanatciAdi", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), Convert.ToInt32(dr[1].ToString()));
            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT sanatcilar.dogduguSehir, count(*) FROM iller INNER JOIN sanatcilar ON sanatcilar.dogduguSehir = iller.sehir GROUP BY sanatcilar.dogduguSehir", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Şehirler"].Points.AddPoint(Convert.ToString(dr2[0]), Convert.ToInt32(dr2[1].ToString()));
            }
            baglanti.Close();



        }
    }
}