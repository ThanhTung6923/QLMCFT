using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QLMCFT.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLMCFT
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        UC_MonAn ucMonAn;
        UC_NhanVien ucNhanVien;
        UC_KhachHang ucKhacHang;
        UC_HoaDon ucHoaDon;
        private void mnMonAn_Click(object sender, EventArgs e)
        {
            if (ucMonAn == null)
            {
                ucMonAn = new UC_MonAn();
                ucMonAn.Dock = DockStyle.Fill;
                this.Controls.Add(ucMonAn);
                ucMonAn.BringToFront();
            }
            else
                ucMonAn.BringToFront();
            lblTieuDe.Caption = mnMonAn.Text;
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            if(ucNhanVien == null)
            {
                ucNhanVien = new UC_NhanVien();
                ucNhanVien.Dock = DockStyle.Fill;
                this.Controls.Add(ucNhanVien);
                ucNhanVien.BringToFront();
            }
            else
                ucNhanVien.BringToFront();
            lblTieuDe.Caption = mnNhanVien.Text;
        }

        private void mnKhachHang_Click(object sender, EventArgs e)
        {
            if (ucKhacHang == null)
            {
                ucKhacHang = new UC_KhachHang();
                ucKhacHang.Dock = DockStyle.Fill;
                this.Controls.Add(ucKhacHang);
                ucKhacHang.BringToFront();
            }
            else
                ucKhacHang.BringToFront();
            lblTieuDe.Caption = mnKhachHang.Text;
        }

        private void mnHoaDon_Click(object sender, EventArgs e)
        {
            if (ucHoaDon == null)
            {
                ucHoaDon = new UC_HoaDon();
                ucHoaDon.Dock = DockStyle.Fill;
                this.Controls.Add(ucHoaDon);
                ucHoaDon.BringToFront();
            }
            else
                ucHoaDon.BringToFront();
            lblTieuDe.Caption = mnHoaDon.Text;
        }

    }
}
