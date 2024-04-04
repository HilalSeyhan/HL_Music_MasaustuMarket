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
    public partial class FormFaturaKalemEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormFaturaKalemEkle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        int secilenUrun;

        private void FormFaturaKalemEkle_Load(object sender, EventArgs e)
        {
            nUpDownAdet.Maximum = 10;
            var faturaKalemListem = c.faturaIcerik.Select(x => new
            {
                FaturaKalemId = x.faturaIcerikID,
                ÜrünAdı = x.urunler.urunAd,
                BirimFiyatı = x.birimFiyat,
                Adet = x.miktar,
                ToplamTutar = x.tutar,
                FaturaNumarası = x.faturaBilgi.SeriSiraNo
            }).ToList();
            gridControl2.DataSource = faturaKalemListem;

            txtEdtSatisFiyat.ReadOnly = true;
            txtEdtToplamTutar.ReadOnly = true;

            var urunlerim = c.urunler.Where(x => x.urunDurum == true).Select(x => new
            {
                ÜrünId = x.urunID,
                ÜrünAdı = x.urunAd
            }).ToList();
            lookUpEditUrun.Properties.DataSource = urunlerim;

            var faturalarim = c.faturaBilgi.Where(x => x.faturaBilgiDurum == true).Select(x => new
            {
                FaturaId = x.faturaBilgiID,
                FaturaSeriNo = x.SeriSiraNo
            }).ToList();
            lookUpEditFatura.Properties.DataSource = faturalarim;
        }

        private void lookUpEditUrun_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditUrun.EditValue != null)
            {
                secilenUrun = int.Parse(lookUpEditUrun.EditValue.ToString());

                var sorgu = c.urunler.SingleOrDefault(r => r.urunID == secilenUrun);

                if (sorgu != null)
                {
                    txtEdtSatisFiyat.Text = sorgu.satisFiyat.ToString();
                }
            }
        }

        private void nUpDownAdet_ValueChanged(object sender, EventArgs e)
        {
            if (nUpDownAdet.Value != 0)
            {
                txtEdtToplamTutar.Text = (decimal.Parse(txtEdtSatisFiyat.Text) * (nUpDownAdet.Value)).ToString();
            }
            else
            {
                txtEdtToplamTutar.Text = " ";
            }
        }

        private void smplBtnIptalEt_Click(object sender, EventArgs e)
        {
            lookUpEditUrun.EditValue = null;
            lookUpEditUrun.Enabled = true;
            txtEdtSatisFiyat.Text = " ";
            nUpDownAdet.Value = 0;
            nUpDownAdet.Enabled = true;
            txtEdtToplamTutar.Text = " ";
            lookUpEditFatura.EditValue = null;
            lookUpEditFatura.Enabled = true;
        }

        private void smplBtnOnayla_Click(object sender, EventArgs e)
        {
            if (lookUpEditUrun.EditValue != null && txtEdtSatisFiyat.Text != "" && nUpDownAdet.Value != 0 && txtEdtToplamTutar.Text != "" && lookUpEditFatura.EditValue != null)
            {
                faturaIcerik fi = new faturaIcerik();
                fi.urunAdi = int.Parse(lookUpEditUrun.EditValue.ToString());
                fi.birimFiyat = decimal.Parse(txtEdtSatisFiyat.Text);
                fi.miktar = short.Parse(nUpDownAdet.Value.ToString());
                fi.tutar = decimal.Parse(txtEdtToplamTutar.Text);
                fi.faturaBilgiId = int.Parse(lookUpEditFatura.EditValue.ToString());
                c.faturaIcerik.Add(fi);
                c.SaveChanges();
                MessageBox.Show("Fatura Kalemi Başarıyla Tamamlandı..\n\nFaturalar Sayfasında İlgili Faturaya Çift Tıklayarak ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lookUpEditUrun.EditValue = null;
                lookUpEditUrun.Enabled = true;
                txtEdtSatisFiyat.Text = " ";
                nUpDownAdet.Value = 0;
                nUpDownAdet.Enabled = true;
                txtEdtToplamTutar.Text = " ";
                lookUpEditFatura.EditValue = null;
                lookUpEditFatura.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var faturaKalemListem = c.faturaIcerik.Select(x => new
            {
                FaturaKalemId = x.faturaIcerikID,
                ÜrünAdı = x.urunler.urunAd,
                BirimFiyatı = x.birimFiyat,
                Adet = x.miktar,
                ToplamTutar = x.tutar,
                FaturaSeriNo = x.faturaBilgi.SeriSiraNo
            }).ToList();
            gridControl2.DataSource = faturaKalemListem;
        }

    }
}