namespace HLmuzikDunyam
{
    partial class FormFaturaEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditVergiDairesi = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditMusteri = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.grpBoxUrunBilgi = new System.Windows.Forms.GroupBox();
            this.smplBtnIptalEt = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnFaturaNoAl = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMusteri.Properties)).BeginInit();
            this.grpBoxUrunBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(18, 343);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(146, 19);
            this.labelControl11.TabIndex = 115;
            this.labelControl11.Text = "Fatura Numarası :";
            // 
            // txtEditFaturaNo
            // 
            this.txtEditFaturaNo.Location = new System.Drawing.Point(172, 340);
            this.txtEditFaturaNo.Name = "txtEditFaturaNo";
            this.txtEditFaturaNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditFaturaNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEditFaturaNo.Properties.Appearance.Options.UseFont = true;
            this.txtEditFaturaNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtEditFaturaNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEditFaturaNo.Size = new System.Drawing.Size(251, 26);
            this.txtEditFaturaNo.TabIndex = 114;
            // 
            // lookUpEditVergiDairesi
            // 
            this.lookUpEditVergiDairesi.Location = new System.Drawing.Point(172, 240);
            this.lookUpEditVergiDairesi.Name = "lookUpEditVergiDairesi";
            this.lookUpEditVergiDairesi.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lookUpEditVergiDairesi.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEditVergiDairesi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditVergiDairesi.Properties.DisplayMember = "VergiDairesi";
            this.lookUpEditVergiDairesi.Properties.NullText = "** Vergi Dairesi Seçiniz **";
            this.lookUpEditVergiDairesi.Properties.ValueMember = "Id";
            this.lookUpEditVergiDairesi.Size = new System.Drawing.Size(251, 26);
            this.lookUpEditVergiDairesi.TabIndex = 113;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 243);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 19);
            this.labelControl3.TabIndex = 112;
            this.labelControl3.Text = "Vergi Dairesi :";
            // 
            // txtEditSaat
            // 
            this.txtEditSaat.Location = new System.Drawing.Point(172, 190);
            this.txtEditSaat.Name = "txtEditSaat";
            this.txtEditSaat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditSaat.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEditSaat.Properties.Appearance.Options.UseFont = true;
            this.txtEditSaat.Properties.Appearance.Options.UseForeColor = true;
            this.txtEditSaat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEditSaat.Size = new System.Drawing.Size(251, 26);
            this.txtEditSaat.TabIndex = 111;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(116, 193);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 110;
            this.labelControl2.Text = "Saat :";
            // 
            // txtEditTarih
            // 
            this.txtEditTarih.Location = new System.Drawing.Point(172, 140);
            this.txtEditTarih.Name = "txtEditTarih";
            this.txtEditTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEditTarih.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEditTarih.Properties.Appearance.Options.UseFont = true;
            this.txtEditTarih.Properties.Appearance.Options.UseForeColor = true;
            this.txtEditTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEditTarih.Size = new System.Drawing.Size(251, 26);
            this.txtEditTarih.TabIndex = 109;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(110, 143);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(54, 19);
            this.labelControl9.TabIndex = 108;
            this.labelControl9.Text = "Tarih :";
            // 
            // lookUpEditPersonel
            // 
            this.lookUpEditPersonel.Location = new System.Drawing.Point(172, 40);
            this.lookUpEditPersonel.Name = "lookUpEditPersonel";
            this.lookUpEditPersonel.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lookUpEditPersonel.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEditPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPersonel.Properties.DisplayMember = "AdSoyad";
            this.lookUpEditPersonel.Properties.NullText = "** Personel Seçiniz **";
            this.lookUpEditPersonel.Properties.ValueMember = "PersonelId";
            this.lookUpEditPersonel.Size = new System.Drawing.Size(251, 26);
            this.lookUpEditPersonel.TabIndex = 105;
            // 
            // lookUpEditMusteri
            // 
            this.lookUpEditMusteri.Location = new System.Drawing.Point(172, 90);
            this.lookUpEditMusteri.Name = "lookUpEditMusteri";
            this.lookUpEditMusteri.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lookUpEditMusteri.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEditMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMusteri.Properties.DisplayMember = "AdSoyad";
            this.lookUpEditMusteri.Properties.NullText = "** Müşteri Seçiniz **";
            this.lookUpEditMusteri.Properties.ValueMember = "MüşteriId";
            this.lookUpEditMusteri.Size = new System.Drawing.Size(251, 26);
            this.lookUpEditMusteri.TabIndex = 104;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(57, 93);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(107, 19);
            this.labelControl6.TabIndex = 103;
            this.labelControl6.Text = "Teslim Alan :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(54, 43);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(110, 19);
            this.labelControl5.TabIndex = 102;
            this.labelControl5.Text = "Teslim Eden :";
            // 
            // grpBoxUrunBilgi
            // 
            this.grpBoxUrunBilgi.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxUrunBilgi.Controls.Add(this.smplBtnIptalEt);
            this.grpBoxUrunBilgi.Controls.Add(this.smplBtnListele);
            this.grpBoxUrunBilgi.Controls.Add(this.smplBtnOnayla);
            this.grpBoxUrunBilgi.Controls.Add(this.smplBtnFaturaNoAl);
            this.grpBoxUrunBilgi.Controls.Add(this.labelControl11);
            this.grpBoxUrunBilgi.Controls.Add(this.txtEditFaturaNo);
            this.grpBoxUrunBilgi.Controls.Add(this.lookUpEditVergiDairesi);
            this.grpBoxUrunBilgi.Controls.Add(this.labelControl3);
            this.grpBoxUrunBilgi.Controls.Add(this.txtEditSaat);
            this.grpBoxUrunBilgi.Controls.Add(this.labelControl2);
            this.grpBoxUrunBilgi.Controls.Add(this.txtEditTarih);
            this.grpBoxUrunBilgi.Controls.Add(this.labelControl9);
            this.grpBoxUrunBilgi.Controls.Add(this.lookUpEditPersonel);
            this.grpBoxUrunBilgi.Controls.Add(this.lookUpEditMusteri);
            this.grpBoxUrunBilgi.Controls.Add(this.labelControl6);
            this.grpBoxUrunBilgi.Controls.Add(this.labelControl5);
            this.grpBoxUrunBilgi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxUrunBilgi.ForeColor = System.Drawing.Color.White;
            this.grpBoxUrunBilgi.Location = new System.Drawing.Point(1430, 7);
            this.grpBoxUrunBilgi.Name = "grpBoxUrunBilgi";
            this.grpBoxUrunBilgi.Size = new System.Drawing.Size(438, 790);
            this.grpBoxUrunBilgi.TabIndex = 9;
            this.grpBoxUrunBilgi.TabStop = false;
            this.grpBoxUrunBilgi.Text = "FATURA BİLGİLERİ";
            // 
            // smplBtnIptalEt
            // 
            this.smplBtnIptalEt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.smplBtnIptalEt.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(26)))));
            this.smplBtnIptalEt.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnIptalEt.Appearance.ForeColor = System.Drawing.Color.Black;
            this.smplBtnIptalEt.Appearance.Options.UseBackColor = true;
            this.smplBtnIptalEt.Appearance.Options.UseFont = true;
            this.smplBtnIptalEt.Appearance.Options.UseForeColor = true;
            this.smplBtnIptalEt.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnIptalEt.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.smplBtnIptalEt.AppearanceHovered.Options.UseBackColor = true;
            this.smplBtnIptalEt.AppearanceHovered.Options.UseForeColor = true;
            this.smplBtnIptalEt.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnIptalEt.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.smplBtnIptalEt.AppearancePressed.Options.UseBackColor = true;
            this.smplBtnIptalEt.AppearancePressed.Options.UseForeColor = true;
            this.smplBtnIptalEt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.smplBtnIptalEt.ImageOptions.Image = global::HLmuzikDunyam.Properties.Resources.faturaIptalButton;
            this.smplBtnIptalEt.Location = new System.Drawing.Point(238, 390);
            this.smplBtnIptalEt.Name = "smplBtnIptalEt";
            this.smplBtnIptalEt.Size = new System.Drawing.Size(185, 38);
            this.smplBtnIptalEt.TabIndex = 119;
            this.smplBtnIptalEt.Text = "Faturayı İptal Et";
            this.smplBtnIptalEt.Click += new System.EventHandler(this.smplBtnIptalEt_Click);
            // 
            // smplBtnListele
            // 
            this.smplBtnListele.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.smplBtnListele.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(26)))));
            this.smplBtnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnListele.Appearance.ForeColor = System.Drawing.Color.Black;
            this.smplBtnListele.Appearance.Options.UseBackColor = true;
            this.smplBtnListele.Appearance.Options.UseFont = true;
            this.smplBtnListele.Appearance.Options.UseForeColor = true;
            this.smplBtnListele.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnListele.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.smplBtnListele.AppearanceHovered.Options.UseBackColor = true;
            this.smplBtnListele.AppearanceHovered.Options.UseForeColor = true;
            this.smplBtnListele.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnListele.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.smplBtnListele.AppearancePressed.Options.UseBackColor = true;
            this.smplBtnListele.AppearancePressed.Options.UseForeColor = true;
            this.smplBtnListele.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.smplBtnListele.ImageOptions.Image = global::HLmuzikDunyam.Properties.Resources.listele;
            this.smplBtnListele.Location = new System.Drawing.Point(238, 490);
            this.smplBtnListele.Name = "smplBtnListele";
            this.smplBtnListele.Size = new System.Drawing.Size(185, 38);
            this.smplBtnListele.TabIndex = 118;
            this.smplBtnListele.Text = "Listele";
            this.smplBtnListele.Click += new System.EventHandler(this.smplBtnListele_Click);
            // 
            // smplBtnOnayla
            // 
            this.smplBtnOnayla.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.smplBtnOnayla.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(26)))));
            this.smplBtnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnOnayla.Appearance.ForeColor = System.Drawing.Color.Black;
            this.smplBtnOnayla.Appearance.Options.UseBackColor = true;
            this.smplBtnOnayla.Appearance.Options.UseFont = true;
            this.smplBtnOnayla.Appearance.Options.UseForeColor = true;
            this.smplBtnOnayla.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnOnayla.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.smplBtnOnayla.AppearanceHovered.Options.UseBackColor = true;
            this.smplBtnOnayla.AppearanceHovered.Options.UseForeColor = true;
            this.smplBtnOnayla.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnOnayla.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.smplBtnOnayla.AppearancePressed.Options.UseBackColor = true;
            this.smplBtnOnayla.AppearancePressed.Options.UseForeColor = true;
            this.smplBtnOnayla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.smplBtnOnayla.ImageOptions.Image = global::HLmuzikDunyam.Properties.Resources.faturaOnaylaButton;
            this.smplBtnOnayla.Location = new System.Drawing.Point(238, 440);
            this.smplBtnOnayla.Name = "smplBtnOnayla";
            this.smplBtnOnayla.Size = new System.Drawing.Size(185, 38);
            this.smplBtnOnayla.TabIndex = 117;
            this.smplBtnOnayla.Text = "Faturayı Onayla";
            this.smplBtnOnayla.Click += new System.EventHandler(this.smplBtnOnayla_Click);
            // 
            // smplBtnFaturaNoAl
            // 
            this.smplBtnFaturaNoAl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.smplBtnFaturaNoAl.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(26)))));
            this.smplBtnFaturaNoAl.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnFaturaNoAl.Appearance.ForeColor = System.Drawing.Color.Black;
            this.smplBtnFaturaNoAl.Appearance.Options.UseBackColor = true;
            this.smplBtnFaturaNoAl.Appearance.Options.UseFont = true;
            this.smplBtnFaturaNoAl.Appearance.Options.UseForeColor = true;
            this.smplBtnFaturaNoAl.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnFaturaNoAl.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.smplBtnFaturaNoAl.AppearanceHovered.Options.UseBackColor = true;
            this.smplBtnFaturaNoAl.AppearanceHovered.Options.UseForeColor = true;
            this.smplBtnFaturaNoAl.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnFaturaNoAl.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.smplBtnFaturaNoAl.AppearancePressed.Options.UseBackColor = true;
            this.smplBtnFaturaNoAl.AppearancePressed.Options.UseForeColor = true;
            this.smplBtnFaturaNoAl.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.smplBtnFaturaNoAl.ImageOptions.Image = global::HLmuzikDunyam.Properties.Resources.faturaNoAlButton;
            this.smplBtnFaturaNoAl.Location = new System.Drawing.Point(172, 290);
            this.smplBtnFaturaNoAl.Name = "smplBtnFaturaNoAl";
            this.smplBtnFaturaNoAl.Size = new System.Drawing.Size(251, 35);
            this.smplBtnFaturaNoAl.TabIndex = 116;
            this.smplBtnFaturaNoAl.Text = "Fatura Numarası Al";
            this.smplBtnFaturaNoAl.Click += new System.EventHandler(this.smplBtnFaturaNoAl_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(13, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1410, 360);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.Lines.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.Lines.Options.UseFont = true;
            this.gridView1.AppearancePrint.OddRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.DetailHeight = 571;
            this.gridView1.FixedLineWidth = 4;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FormFaturaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::HLmuzikDunyam.Properties.Resources.faturaArkaSon;
            this.ClientSize = new System.Drawing.Size(1880, 800);
            this.Controls.Add(this.grpBoxUrunBilgi);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFaturaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~~ Fatura Ekle ~~";
            this.Load += new System.EventHandler(this.FormFaturaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMusteri.Properties)).EndInit();
            this.grpBoxUrunBilgi.ResumeLayout(false);
            this.grpBoxUrunBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtEditFaturaNo;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEditSaat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEditTarih;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPersonel;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMusteri;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox grpBoxUrunBilgi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton smplBtnFaturaNoAl;
        private DevExpress.XtraEditors.SimpleButton smplBtnIptalEt;
        private DevExpress.XtraEditors.SimpleButton smplBtnListele;
        private DevExpress.XtraEditors.SimpleButton smplBtnOnayla;
    }
}