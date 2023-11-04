namespace QLMCFT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnDanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnMonAn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnHangTon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lblTieuDe = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(318, 46);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1238, 989);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnDanhMuc,
            this.mnBaoCao});
            this.accordionControl1.Location = new System.Drawing.Point(0, 46);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(318, 989);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnDanhMuc
            // 
            this.mnDanhMuc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnMonAn,
            this.mnNhanVien,
            this.mnKhachHang,
            this.mnHoaDon});
            this.mnDanhMuc.Expanded = true;
            this.mnDanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnDanhMuc.ImageOptions.Image")));
            this.mnDanhMuc.Name = "mnDanhMuc";
            this.mnDanhMuc.Text = "Danh Mục ";
            // 
            // mnMonAn
            // 
            this.mnMonAn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnMonAn.ImageOptions.Image")));
            this.mnMonAn.Name = "mnMonAn";
            this.mnMonAn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnMonAn.Text = "Món Ăn ";
            this.mnMonAn.Click += new System.EventHandler(this.mnMonAn_Click);
            // 
            // mnNhanVien
            // 
            this.mnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnNhanVien.ImageOptions.Image")));
            this.mnNhanVien.Name = "mnNhanVien";
            this.mnNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnNhanVien.Text = "Nhân Viên ";
            this.mnNhanVien.Click += new System.EventHandler(this.mnNhanVien_Click);
            // 
            // mnKhachHang
            // 
            this.mnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnKhachHang.ImageOptions.Image")));
            this.mnKhachHang.Name = "mnKhachHang";
            this.mnKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnKhachHang.Text = "Khách Hàng ";
            this.mnKhachHang.Click += new System.EventHandler(this.mnKhachHang_Click);
            // 
            // mnHoaDon
            // 
            this.mnHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnHoaDon.ImageOptions.Image")));
            this.mnHoaDon.Name = "mnHoaDon";
            this.mnHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnHoaDon.Text = "Hóa Đơn";
            this.mnHoaDon.Click += new System.EventHandler(this.mnHoaDon_Click);
            // 
            // mnBaoCao
            // 
            this.mnBaoCao.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnDoanhThu,
            this.mnHangTon});
            this.mnBaoCao.Expanded = true;
            this.mnBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnBaoCao.ImageOptions.Image")));
            this.mnBaoCao.Name = "mnBaoCao";
            this.mnBaoCao.Text = "Báo Cáo ";
            // 
            // mnDoanhThu
            // 
            this.mnDoanhThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnDoanhThu.ImageOptions.Image")));
            this.mnDoanhThu.Name = "mnDoanhThu";
            this.mnDoanhThu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDoanhThu.Text = "Doanh Thu";
            // 
            // mnHangTon
            // 
            this.mnHangTon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnHangTon.ImageOptions.Image")));
            this.mnHangTon.Name = "mnHangTon";
            this.mnHangTon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnHangTon.Text = "Hàng Tồn";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieuDe});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1556, 46);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieuDe);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Caption = "Trang Chủ";
            this.lblTieuDe.Id = 0;
            this.lblTieuDe.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTieuDe.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieuDe});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1035);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Quản lý mì cay FourT";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDanhMuc;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnMonAn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnHoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnBaoCao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDoanhThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnHangTon;
        private DevExpress.XtraBars.BarStaticItem lblTieuDe;
    }
}

