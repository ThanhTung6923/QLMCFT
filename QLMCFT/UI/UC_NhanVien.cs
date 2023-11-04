using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMCFT.UI
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvNhanVien.AddNewRow();
            gvNhanVien.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            loadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnDong.Enabled = true;
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            gvNhanVien.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            gcNhanVien.DataSource = Functions.GetDataToTable("SELECT *FROM NhanVien");
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnDong.Enabled = false;
        }
        void loadData()
        {
            gcNhanVien.DataSource = Functions.GetDataToTable("SELECT * FROM NhanVien");
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            gvNhanVien.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnDong.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gvNhanVien.GetFocusedDataRow();
                if (dr != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + dr["TenNhanVien"] + " ra khỏi danh sách không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Functions.execQuery("DELETE NhanVien WHERE MaNhanVien=" + dr["MaNhanVien"]);
                    }
                }
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr;
                for (int i = 0; i < gvNhanVien.RowCount; i++)
                {
                    dr = gvNhanVien.GetDataRow(i);
                    if (dr != null)
                    {
                        if (dr.RowState == DataRowState.Modified)
                        {
                            Functions.execQuery("UPDATE NhanVien SET MaNhanVien = " + gvNhanVien.GetRowCellValue(i, "MaNhanVien") + ", " +
                                "TenNhanVien = N'" + gvNhanVien.GetRowCellValue(i, "TenNhanVien") + "', " +
                                "ChucVu = N'" + gvNhanVien.GetRowCellValue(i, "ChucVu") + "', " +
                                "NgaySinh = '" + ((DateTime)gvNhanVien.GetRowCellValue(i, "NgaySinh")).ToString("yyyy-MM-dd") + "', " +
                                "SoDienThoai = '" + gvNhanVien.GetRowCellValue(i, "SoDienThoai") + "', " +
                                "GioiTinh = N'" + gvNhanVien.GetRowCellValue(i, "GioiTinh") + "', " +
                                "DiaChi = N'" + gvNhanVien.GetRowCellValue(i, "DiaChi") + "' WHERE MaNhanVien = " +
                                gvNhanVien.GetRowCellValue(i, "MaNhanVien"));
                        }
                        if (dr.RowState == DataRowState.Added)
                        {
                            Functions.execQuery("INSERT INTO [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [NgaySinh], [SoDienThoai], [GioiTinh], [DiaChi]) " +
                                "VALUES (" + gvNhanVien.GetRowCellValue(i, "MaNhanVien") + ", N'" + gvNhanVien.GetRowCellValue(i, "TenNhanVien") + "', N'" +
                                gvNhanVien.GetRowCellValue(i, "ChucVu") + "', '" + ((DateTime)gvNhanVien.GetRowCellValue(i, "NgaySinh")).ToString("yyyy-MM-dd") + "' , '" +
                                gvNhanVien.GetRowCellValue(i, "SoDienThoai") + "', '" + gvNhanVien.GetRowCellValue(i, "GioiTinh") + "', N'" +
                                gvNhanVien.GetRowCellValue(i, "DiaChi") + "')");
                        }
                    }
                }
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private bool isEditing = false;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                try
                {
                    DataRow dr = gvNhanVien.GetFocusedDataRow();
                    if (dr != null)
                    {
                        DateTime ngaySinh = (DateTime)dr["NgaySinh"];
                        string ngaySinhFormatted = ngaySinh.ToString("yyyy-MM-dd");

                        Functions.execQuery("UPDATE NhanVien SET TenNhanVien = N'" + dr["TenNhanVien"] + "', " +
                            "ChucVu = N'" + dr["ChucVu"] + "', " +
                            "NgaySinh = '" + ngaySinhFormatted + "', " +
                            "SoDienThoai = '" + dr["SoDienThoai"] + "', " +
                            "GioiTinh = N'" + dr["GioiTinh"] + "', " +
                            "DiaChi = N'" + dr["DiaChi"] + "' WHERE MaNhanVien = " + dr["MaNhanVien"]);
                    }

                    isEditing = false;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    btnDong.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                isEditing = true;
            }
        }

    }
}
