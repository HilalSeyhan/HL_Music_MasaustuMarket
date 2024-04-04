namespace HLmuzikDunyam
{
    partial class FormKategoriEkle
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
            this.txtEdtKategoriAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grpBoxKategoriBilgi = new System.Windows.Forms.GroupBox();
            this.smplBtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtKategoriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtID.Properties)).BeginInit();
            this.grpBoxKategoriBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdtKategoriAd
            // 
            this.txtEdtKategoriAd.Location = new System.Drawing.Point(160, 93);
            this.txtEdtKategoriAd.Name = "txtEdtKategoriAd";
            this.txtEdtKategoriAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtKategoriAd.Properties.Appearance.Options.UseFont = true;
            this.txtEdtKategoriAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdtKategoriAd.Size = new System.Drawing.Size(251, 26);
            this.txtEdtKategoriAd.TabIndex = 68;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 19);
            this.labelControl2.TabIndex = 67;
            this.labelControl2.Text = "Kategori Adı :";
            // 
            // txtEdtID
            // 
            this.txtEdtID.Location = new System.Drawing.Point(160, 38);
            this.txtEdtID.Name = "txtEdtID";
            this.txtEdtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtID.Properties.Appearance.Options.UseFont = true;
            this.txtEdtID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEdtID.Size = new System.Drawing.Size(251, 26);
            this.txtEdtID.TabIndex = 65;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(114, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 19);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "ID :";
            // 
            // grpBoxKategoriBilgi
            // 
            this.grpBoxKategoriBilgi.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxKategoriBilgi.Controls.Add(this.smplBtnListele);
            this.grpBoxKategoriBilgi.Controls.Add(this.smplBtnKaydet);
            this.grpBoxKategoriBilgi.Controls.Add(this.txtEdtKategoriAd);
            this.grpBoxKategoriBilgi.Controls.Add(this.labelControl2);
            this.grpBoxKategoriBilgi.Controls.Add(this.txtEdtID);
            this.grpBoxKategoriBilgi.Controls.Add(this.labelControl1);
            this.grpBoxKategoriBilgi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxKategoriBilgi.ForeColor = System.Drawing.Color.Black;
            this.grpBoxKategoriBilgi.Location = new System.Drawing.Point(1442, 13);
            this.grpBoxKategoriBilgi.Name = "grpBoxKategoriBilgi";
            this.grpBoxKategoriBilgi.Size = new System.Drawing.Size(426, 314);
            this.grpBoxKategoriBilgi.TabIndex = 7;
            this.grpBoxKategoriBilgi.TabStop = false;
            this.grpBoxKategoriBilgi.Text = "KATEGORİ BİLGİLERİ";
            // 
            // smplBtnListele
            // 
            this.smplBtnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnListele.Appearance.Options.UseFont = true;
            this.smplBtnListele.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnListele.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.smplBtnListele.AppearanceHovered.Options.UseBackColor = true;
            this.smplBtnListele.AppearanceHovered.Options.UseForeColor = true;
            this.smplBtnListele.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnListele.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.smplBtnListele.AppearancePressed.Options.UseBackColor = true;
            this.smplBtnListele.AppearancePressed.Options.UseForeColor = true;
            this.smplBtnListele.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.smplBtnListele.ImageOptions.Image = global::HLmuzikDunyam.Properties.Resources.listele;
            this.smplBtnListele.Location = new System.Drawing.Point(285, 214);
            this.smplBtnListele.Name = "smplBtnListele";
            this.smplBtnListele.Size = new System.Drawing.Size(126, 45);
            this.smplBtnListele.TabIndex = 89;
            this.smplBtnListele.Text = "Listele";
            this.smplBtnListele.Click += new System.EventHandler(this.smplBtnListele_Click);
            // 
            // smplBtnKaydet
            // 
            this.smplBtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnKaydet.Appearance.Options.UseFont = true;
            this.smplBtnKaydet.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnKaydet.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.smplBtnKaydet.AppearanceHovered.Options.UseBackColor = true;
            this.smplBtnKaydet.AppearanceHovered.Options.UseForeColor = true;
            this.smplBtnKaydet.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(65)))));
            this.smplBtnKaydet.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.smplBtnKaydet.AppearancePressed.Options.UseBackColor = true;
            this.smplBtnKaydet.AppearancePressed.Options.UseForeColor = true;
            this.smplBtnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.smplBtnKaydet.ImageOptions.Image = global::HLmuzikDunyam.Properties.Resources.kategoriEkleButton;
            this.smplBtnKaydet.Location = new System.Drawing.Point(285, 152);
            this.smplBtnKaydet.Name = "smplBtnKaydet";
            this.smplBtnKaydet.Size = new System.Drawing.Size(126, 45);
            this.smplBtnKaydet.TabIndex = 88;
            this.smplBtnKaydet.Text = "Kaydet";
            this.smplBtnKaydet.Click += new System.EventHandler(this.smplBtnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(13, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1410, 314);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(132)))), ((int)(((byte)(241)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(159)))));
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
            // FormKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::HLmuzikDunyam.Properties.Resources.KategorilerArka;
            this.ClientSize = new System.Drawing.Size(1880, 800);
            this.Controls.Add(this.grpBoxKategoriBilgi);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~~ Kategori Ekle ~~";
            this.Load += new System.EventHandler(this.FormKategoriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtKategoriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtID.Properties)).EndInit();
            this.grpBoxKategoriBilgi.ResumeLayout(false);
            this.grpBoxKategoriBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtEdtKategoriAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox grpBoxKategoriBilgi;
        private DevExpress.XtraEditors.SimpleButton smplBtnListele;
        private DevExpress.XtraEditors.SimpleButton smplBtnKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}