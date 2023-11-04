using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMCFT.UI
{
    public partial class UC_MonAn : UserControl
    {
        public UC_MonAn()
        {
            InitializeComponent();
        }

        private void UC_MonAn_Load(object sender, EventArgs e)
        {
            gvMonAn.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            gcMonAn.DataSource = Functions.GetDataToTable("SELECT *FROM MonAn");
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnDong.Enabled = false;
        }
        void loadData()
        {
            gcMonAn.DataSource = Functions.GetDataToTable("SELECT * FROM MonAn");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            gvMonAn.AddNewRow();
            gvMonAn.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            loadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnDong.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            gvMonAn.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnDong.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr;
                for (int i = 0; i < gvMonAn.RowCount; i++)
                {
                    dr = gvMonAn.GetDataRow(i);
                    if (dr != null)
                    {
                        if (dr.RowState == DataRowState.Modified)
                        {
                            Functions.execQuery("UPDATE MonAn SET MaMonAn = " + gvMonAn.GetRowCellValue(i, "MaMonAn") + ", " +
                                "TenMonAn = N'" + gvMonAn.GetRowCellValue(i, "TenMonAn") + "', " +
                                "DonGiaNhap = " + gvMonAn.GetRowCellValue(i, "DonGiaNhap") + ", " +
                                "DonGiaBan = " + gvMonAn.GetRowCellValue(i, "DonGiaBan") + ", " +
                                "SoLuong = " + gvMonAn.GetRowCellValue(i, "SoLuong") + ", " +
                                "Anh = N'" + gvMonAn.GetRowCellValue(i, "Anh") + "', " +
                                "GhiChu = N'" + gvMonAn.GetRowCellValue(i, "GhiChu") + "' WHERE MaMonAn = " +
                                gvMonAn.GetRowCellValue(i, "MaMonAn"));
                        }
                        if (dr.RowState == DataRowState.Added)
                        {
                            Functions.execQuery("INSERT INTO [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonGiaNhap], [DonGiaBan], [SoLuong], [Anh], [GhiChu]) " +
                                "VALUES (" + gvMonAn.GetRowCellValue(i, "MaMonAn") + ", N'" + gvMonAn.GetRowCellValue(i, "TenMonAn") + "', " +
                                gvMonAn.GetRowCellValue(i, "DonGiaNhap") + ", " + gvMonAn.GetRowCellValue(i, "DonGiaBan") + ", " +
                                gvMonAn.GetRowCellValue(i, "SoLuong") + ", N'" + gvMonAn.GetRowCellValue(i, "Anh") + "', N'" +
                                gvMonAn.GetRowCellValue(i, "GhiChu") + "')");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
            DataRow dr = gvMonAn.GetFocusedDataRow();
                if (dr != null)
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa " + dr["TenMonAn"] + " ra khỏi danh sách không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Functions.execQuery("DELETE MonAn WHERE MaMonAn=" + dr["MaMonAn"]);
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
                    DataRow dr = gvMonAn.GetFocusedDataRow();
                    if (dr != null)
                    {
                        Functions.execQuery("UPDATE MonAn SET TenMonAn = N'" + dr["TenMonAn"] + "', " +
                            "DonGiaNhap = " + dr["DonGiaNhap"] + ", " +
                            "DonGiaBan = " + dr["DonGiaBan"] + ", " +
                            "SoLuong = " + dr["SoLuong"] + ", " +
                            "Anh = N'" + dr["Anh"] + "', " +
                            "GhiChu = N'" + dr["GhiChu"] + "' WHERE MaMonAn = " + dr["MaMonAn"]);
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
