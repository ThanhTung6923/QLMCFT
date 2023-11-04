namespace QLMCFT.UI
{
    partial class UC_MonAn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MonAn));
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.gcMonAn = new DevExpress.XtraGrid.GridControl();
            this.gvMonAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaMonAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMonAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Anh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(280, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 50);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(606, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 50);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(443, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 50);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Location = new System.Drawing.Point(3, 740);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(997, 60);
            this.panelControl1.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(117, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 50);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(769, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 50);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // gcMonAn
            // 
            this.gcMonAn.Location = new System.Drawing.Point(3, 0);
            this.gcMonAn.MainView = this.gvMonAn;
            this.gcMonAn.Name = "gcMonAn";
            this.gcMonAn.Size = new System.Drawing.Size(994, 739);
            this.gcMonAn.TabIndex = 10;
            this.gcMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonAn});
            // 
            // gvMonAn
            // 
            this.gvMonAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.SoLuong,
            this.Anh,
            this.GhiChu});
            this.gvMonAn.GridControl = this.gcMonAn;
            this.gvMonAn.Name = "gvMonAn";
            // 
            // MaMonAn
            // 
            this.MaMonAn.Caption = "Mã Món Ăn ";
            this.MaMonAn.FieldName = "MaMonAn";
            this.MaMonAn.MinWidth = 30;
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.Visible = true;
            this.MaMonAn.VisibleIndex = 0;
            this.MaMonAn.Width = 112;
            // 
            // TenMonAn
            // 
            this.TenMonAn.Caption = "Tên Món Ăn";
            this.TenMonAn.FieldName = "TenMonAn";
            this.TenMonAn.MinWidth = 30;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Visible = true;
            this.TenMonAn.VisibleIndex = 1;
            this.TenMonAn.Width = 112;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.Caption = "Đơn Giá Nhập";
            this.DonGiaNhap.FieldName = "DonGiaNhap";
            this.DonGiaNhap.MinWidth = 30;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.Visible = true;
            this.DonGiaNhap.VisibleIndex = 2;
            this.DonGiaNhap.Width = 112;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.Caption = "Đơn Giá Bán ";
            this.DonGiaBan.FieldName = "DonGiaBan";
            this.DonGiaBan.MinWidth = 30;
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Visible = true;
            this.DonGiaBan.VisibleIndex = 3;
            this.DonGiaBan.Width = 112;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng ";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.MinWidth = 30;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            this.SoLuong.Width = 112;
            // 
            // Anh
            // 
            this.Anh.Caption = "Ảnh ";
            this.Anh.FieldName = "Anh";
            this.Anh.MinWidth = 30;
            this.Anh.Name = "Anh";
            this.Anh.Visible = true;
            this.Anh.VisibleIndex = 5;
            this.Anh.Width = 112;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú ";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.MinWidth = 30;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 6;
            this.GhiChu.Width = 112;
            // 
            // UC_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcMonAn);
            this.Name = "UC_MonAn";
            this.Size = new System.Drawing.Size(1000, 800);
            this.Load += new System.EventHandler(this.UC_MonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraGrid.GridControl gcMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonAn;
        private DevExpress.XtraGrid.Columns.GridColumn MaMonAn;
        private DevExpress.XtraGrid.Columns.GridColumn TenMonAn;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaNhap;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn Anh;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
    }
}
