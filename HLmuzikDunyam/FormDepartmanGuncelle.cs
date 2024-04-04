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
    public partial class FormDepartmanGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public FormDepartmanGuncelle()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void FormDepartmanGuncelle_Load(object sender, EventArgs e)
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtID.Text = gridView1.GetFocusedRowCellValue("DepartmanId").ToString();
            txtEdtDepartmanAd.Text = gridView1.GetFocusedRowCellValue("DepartmanAdı").ToString();
            mskdTxtBoxTelefon.Text = gridView1.GetFocusedRowCellValue("DepartmanTelefonu").ToString();
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtEdtDepartmanAd.Text != "" && mskdTxtBoxTelefon.Text != "")
            {
                int secilenId = int.Parse(txtEdtID.Text);
                var bul = c.departmanlar.Find(secilenId);
                bul.departmanAdi = txtEdtDepartmanAd.Text;
                bul.departmanTelefonu = mskdTxtBoxTelefon.Text;
                c.SaveChanges();
                MessageBox.Show("Departman Güncellendi..\nDepartmanlar Sayfasını Ziyaret Ederek ya da Listele Buttonunu Kullanarak Teyit Edebilirsiniz..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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