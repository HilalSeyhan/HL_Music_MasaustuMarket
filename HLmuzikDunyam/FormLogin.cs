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
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        ticariOtomasyonProjeEntities c = new ticariOtomasyonProjeEntities();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rdBtnPersonel.Checked)
            {
                var sorgu = from x in c.personeller where x.perKullaniciAdi == txtEditKullaniciAdi.Text & x.perParola == txtEditParola.Text select x;
                if (sorgu.Any())
                {
                    FormMenu frmMenuGoster = new FormMenu();
                    frmMenuGoster.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı ya da Parola Girişi Yaptınız..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rdBtnAdmin.Checked)
            {
                var sorgu2 = from y in c.adminler where y.kullaniciAdi == txtEditKullaniciAdi.Text & y.parola == txtEditParola.Text select y;
                if (sorgu2.Any())
                {
                    FormAdmin frmAdminGoster = new FormAdmin();
                    frmAdminGoster.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı ya da Parola Girişi Yaptınız..", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if((!rdBtnPersonel.Checked) && (!rdBtnAdmin.Checked))
            {
                MessageBox.Show("Lütfen Yetki Alanınızı Seçiniz..!", "♪ HL MÜZİK DÜNYASI ♪", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}