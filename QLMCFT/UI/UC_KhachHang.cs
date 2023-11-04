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
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvKhachHang.AddNewRow();
            gvKhachHang.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            loadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnDong.Enabled = true;
        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            gvKhachHang.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            gcKhachHang.DataSource = Functions.GetDataToTable("SELECT *FROM KhachHang");
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnDong.Enabled = false;
        }
        void loadData()
        {
            gcKhachHang.DataSource = Functions.GetDataToTable("SELECT * FROM KhachHang");
        }



        private void btnDong_Click(object sender, EventArgs e)
        {
            gvKhachHang.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
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
                DataRow dr = gvKhachHang.GetFocusedDataRow();
                if (dr != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + dr["TenKhachHang"] + " ra khỏi danh sách không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Functions.execQuery("DELETE FROM KhachHang WHERE MaKhachHang=" + dr["MaKhachHang"]);
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


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr;
                for (int i = 0; i < gvKhachHang.RowCount; i++)
                {
                    dr = gvKhachHang.GetDataRow(i);
                    if (dr != null)
                    {
                        if (dr.RowState == DataRowState.Modified)
                        {
                            Functions.execQuery("UPDATE KhachHang SET MaKhachHang = " + gvKhachHang.GetRowCellValue(i, "MaKhachHang") + ", " +
                                "TenKhachHang = N'" + gvKhachHang.GetRowCellValue(i, "TenKhachHang") + "', " +
                                "DiaChi = N'" + gvKhachHang.GetRowCellValue(i, "DiaChi") + "', " +
                                "SoDienThoai = '" + gvKhachHang.GetRowCellValue(i, "SoDienThoai") + "' WHERE MaKhachHang = " +
                                gvKhachHang.GetRowCellValue(i, "MaKhachHang"));
                        }
                        if (dr.RowState == DataRowState.Added)
                        {
                            Functions.execQuery("INSERT INTO [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) " +
                                "VALUES (" + gvKhachHang.GetRowCellValue(i, "MaKhachHang") + ", N'" + gvKhachHang.GetRowCellValue(i, "TenKhachHang") + "', " +
                                "N'" + gvKhachHang.GetRowCellValue(i, "DiaChi") + "', '" + gvKhachHang.GetRowCellValue(i, "SoDienThoai") + "')");
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                try
                {
                    DataRow dr = gvKhachHang.GetFocusedDataRow();
                    if (dr != null)
                    {
                        Functions.execQuery("UPDATE KhachHang SET TenKhachHang = N'" + dr["TenKhachHang"] + "', " +
                            "DiaChi = N'" + dr["DiaChi"] + "', " + "SoDienThoai = '" + dr["SoDienThoai"] + "' WHERE MaKhachHang = " + dr["MaKhachHang"]);
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
