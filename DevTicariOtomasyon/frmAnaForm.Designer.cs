
namespace DevTicariOtomasyon
{
    partial class frmAnaForm
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketler = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAnasayfa,
            this.btnUrunler,
            this.btnStoklar,
            this.btnMusteriler,
            this.btnFirmalar,
            this.btnPersoneller,
            this.btnGiderler,
            this.btnNotlar,
            this.btnBankalar,
            this.btnRehber,
            this.btnFaturalar,
            this.btnHareketler,
            this.btnRaporlar,
            this.btnAyarlar,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1924, 144);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Caption = "ANASAYFA";
            this.btnAnasayfa.Id = 1;
            this.btnAnasayfa.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.home_16x16;
            this.btnAnasayfa.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.home_32x32;
            this.btnAnasayfa.Name = "btnAnasayfa";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "ÜRÜNLER";
            this.btnUrunler.Id = 2;
            this.btnUrunler.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.boproductgroup_16x16;
            this.btnUrunler.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.boproductgroup_32x32;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnStoklar
            // 
            this.btnStoklar.Caption = "STOKLAR";
            this.btnStoklar.Id = 3;
            this.btnStoklar.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.openhighlowclosestock_16x16;
            this.btnStoklar.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.openhighlowclosestock_32x32;
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStoklar_ItemClick);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "MÜŞTERİLER";
            this.btnMusteriler.Id = 4;
            this.btnMusteriler.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.employee_16x16;
            this.btnMusteriler.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.employee_32x32;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // btnFirmalar
            // 
            this.btnFirmalar.Caption = "FİRMALAR";
            this.btnFirmalar.Id = 5;
            this.btnFirmalar.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.boposition_16x16;
            this.btnFirmalar.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.boposition_32x32;
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmalar_ItemClick);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Caption = "PERSONELLER";
            this.btnPersoneller.Id = 6;
            this.btnPersoneller.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.contact_16x16;
            this.btnPersoneller.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.contact_32x32;
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersoneller_ItemClick);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Caption = "GİDERLER";
            this.btnGiderler.Id = 7;
            this.btnGiderler.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.financial_16x16;
            this.btnGiderler.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.financial_32x32;
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderler_ItemClick);
            // 
            // btnNotlar
            // 
            this.btnNotlar.Caption = "NOTLAR";
            this.btnNotlar.Id = 8;
            this.btnNotlar.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.notes_16x16;
            this.btnNotlar.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.notes_32x32;
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotlar_ItemClick);
            // 
            // btnBankalar
            // 
            this.btnBankalar.Caption = "BANKALAR";
            this.btnBankalar.Id = 9;
            this.btnBankalar.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.bosale_16x16;
            this.btnBankalar.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.bosale_32x32;
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankalar_ItemClick);
            // 
            // btnRehber
            // 
            this.btnRehber.Caption = "REHBER";
            this.btnRehber.Id = 10;
            this.btnRehber.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.team_16x16;
            this.btnRehber.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.team_32x32;
            this.btnRehber.Name = "btnRehber";
            this.btnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRehber_ItemClick);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.Caption = "FATURALAR";
            this.btnFaturalar.Id = 11;
            this.btnFaturalar.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.grandtotalspivottable_16x16;
            this.btnFaturalar.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.grandtotalspivottable_32x32;
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFaturalar_ItemClick);
            // 
            // btnHareketler
            // 
            this.btnHareketler.Caption = "HAREKETLER";
            this.btnHareketler.Id = 12;
            this.btnHareketler.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.walking_16x16;
            this.btnHareketler.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.walking_32x32;
            this.btnHareketler.Name = "btnHareketler";
            this.btnHareketler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHareketler_ItemClick);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Caption = "RAPORLAR";
            this.btnRaporlar.Id = 13;
            this.btnRaporlar.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.knowledgebasearticle_16x16;
            this.btnRaporlar.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.knowledgebasearticle_32x32;
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporlar_ItemClick);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "AYARLAR";
            this.btnAyarlar.Id = 14;
            this.btnAyarlar.ImageOptions.Image = global::DevTicariOtomasyon.Properties.Resources.technology_16x16;
            this.btnAyarlar.ImageOptions.LargeImage = global::DevTicariOtomasyon.Properties.Resources.technology_32x32;
            this.btnAyarlar.Name = "btnAyarlar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "KASA";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.ImageOptions.SvgImage = global::DevTicariOtomasyon.Properties.Resources.currency;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHareketler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmAnaForm";
            this.Text = "frmAnaForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnStoklar;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnFirmalar;
        private DevExpress.XtraBars.BarButtonItem btnPersoneller;
        private DevExpress.XtraBars.BarButtonItem btnGiderler;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.BarButtonItem btnBankalar;
        private DevExpress.XtraBars.BarButtonItem btnRehber;
        private DevExpress.XtraBars.BarButtonItem btnFaturalar;
        private DevExpress.XtraBars.BarButtonItem btnHareketler;
        private DevExpress.XtraBars.BarButtonItem btnRaporlar;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}