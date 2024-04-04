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
    public partial class FormUrunIstatistik : DevExpress.XtraEditors.XtraForm
    {
        public FormUrunIstatistik()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormUrunIstatistik_Load(object sender, EventArgs e)
        {
            lblToplamUrunSayisi.Text = c.urunler.Where(x => x.urunDurum == true).Count().ToString();

            lblToplamKategoriSayisi.Text = c.kategoriler.Where(x => x.kategoriDurum == true).Count().ToString();

            lblToplamStok.Text = c.urunler.Where(x => x.urunDurum == true).Sum(x => x.adet).ToString();

            lblKritikSeviyeUrunSayisi.Text = c.urunler.Where(x => x.adet < 100 && x.urunDurum == true).Count().ToString();

            lblEnFazlaStokluUrun.Text = (from x in c.urunler.Where(x => x.urunDurum == true)
                                         orderby x.adet descending
                                         select x.urunAd).FirstOrDefault();//adet verilerini büyükten küçüğe doğru sırala daha sonra uyuşan ilk değerin ad bilgisini getir.

            lblEnAzStokluUrun.Text = (from x in c.urunler.Where(x => x.urunDurum == true)
                                      orderby x.adet ascending
                                      select x.urunAd).FirstOrDefault();//adet verilerini küçüten büyüğe doğru sırala daha sonra uyuşan ilk değerin ad bilgisini getir.

            lblEnYuksekFıyatliUrun.Text = (from x in c.urunler.Where(x => x.urunDurum == true)
                                           orderby x.satisFiyat descending
                                           select x.urunAd).FirstOrDefault();

            lblEnDusukFiyatliUrun.Text = (from x in c.urunler.Where(x => x.urunDurum == true)
                                          orderby x.satisFiyat ascending
                                          select x.urunAd).FirstOrDefault();

            lblEnFazlaUrunluKategori.Text = c.enFazlaUrunluKategori().FirstOrDefault();

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BK845UE;Initial Catalog=ticariOtomasyonProje;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT kategoriler.kategoriAd, COUNT(*) FROM urunler INNER JOIN kategoriler ON kategoriler.kategoriID = urunler.kategoriId GROUP BY kategoriler.kategoriAd", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr[0]), Convert.ToInt32(dr[1].ToString()));
            }
            baglanti.Close();

        }
    }
}