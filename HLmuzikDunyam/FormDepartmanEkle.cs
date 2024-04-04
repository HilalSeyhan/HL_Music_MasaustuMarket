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
    public partial class FormDepartmanEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormDepartmanEkle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormDepartmanEkle_Load(object sender, EventArgs e)
        {
            var departmanListem = c.departmanlar.Where(x => x.departmanDurum == true).Select(x => new
            {
                DepartmanId = x.departmanID,
                DepartmanAdı = x.departmanAdi,
                DepartmanTelefonu = x.departmanTelefonu,
            }).ToList();
            gridControl1.DataSource = departmanListem;

            txtEdtID.ReadOnly = true;
        }

        private void smplBtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEdtDepartmanAd.Text != "" && mskdTxtBoxTelefon.Text != "")
            {
                departmanlar d = new departmanlar();
                d.departmanAdi = txtEdtDepartmanAd.Text;
                d.departmanTelefonu = mskdTxtBoxTelefon.Text;
                d.departmanDurum = true;
                c.departmanlar.Add(d);
                c.SaveChanges();
                MessageBox.Show("Departman Kaydedildi..\nDepartmanlar Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smplBtnListele_Click(object sender, EventArgs e)
        {
            var departmanListem = c.departmanlar.Where(x => x.departmanDurum == true).Select(x => new
            {
                DepartmanId = x.departmanID,
                DepartmanAdı = x.departmanAdi,
                DepartmanTelefonu = x.departmanTelefonu,
            }).ToList();
            gridControl1.DataSource = departmanListem;
        }
    }
}