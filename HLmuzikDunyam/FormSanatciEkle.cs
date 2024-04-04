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
    public partial class FormSanatciEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormSanatciEkle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormSanatciEkle_Load(object sender, EventArgs e)
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

            var illerim = c.iller.Select(x => new {
                x.illerID,
                x.sehir
            }).ToList();
            lookUpEditSehir.Properties.DataSource = illerim;
        }

        private void smplBtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEdtSanatciAd.Text != "" && txtEdtEtkinYillar.Text != "" && lookUpEditSehir.Text != "")
            {
                sanatcilar s = new sanatcilar();
                s.sanatciAdi = txtEdtSanatciAd.Text;
                s.etkinYillari = txtEdtEtkinYillar.Text;
                s.dogduguSehir = lookUpEditSehir.Text;
                c.sanatcilar.Add(s);
                c.SaveChanges();
                MessageBox.Show("Sanatçı Kaydedildi..\nSanatçılar Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEdtID.Text = "";
                txtEdtSanatciAd.Text = "";
                txtEdtEtkinYillar.Text = "";
                lookUpEditSehir.EditValue = null;

            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var sanatciListem = c.sanatcilar.Select(x => new
            {
                SanatçıId = x.sanatciID,
                SanatçıAdı = x.sanatciAdi,
                EtkinYıllar = x.etkinYillari,
                DoğduğuŞehir = x.dogduguSehir,
            }).ToList();
            gridControl1.DataSource = sanatciListem;
        }
    }
}