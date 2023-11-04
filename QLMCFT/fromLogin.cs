using DevExpress.Utils;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
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


namespace QLMCFT
{
    public partial class fromLogin : DevExpress.XtraEditors.XtraForm
    {
        public fromLogin()
        {
            InitializeComponent();
        }

        Functions fc = new Functions();
        String query;


        private void fromLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            query = "select TenDangNhap, MatKhau from DangNhap where TenDangNhap = '" + txtDangNhap.Text + "' and MatKhau = '" + txtMatKhau.Text + "'";
            DataSet ds = Functions.GetDataSet(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                frmMain db = new frmMain();
                db.Show();
                this.Hide();
            }
            else
            {
                labelError.Visible = true;
                txtMatKhau.Clear();
            }
        }

        private void fromLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}