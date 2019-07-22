using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLVT.Components
{
    public partial class ComponentTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentTaiKhoan()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            sP_List_LOGINBindingSource.DataSource = Program.QLVT_CN_DataSet;

            comBoxRole.DisplayMember = "Text";
            comBoxRole.ValueMember = "Value";

            if (Program._ketNoiDB.GroupId == "CONGTY")
            {
                comBoxRole.Items.Add(new { Text = "Công ty", Value = "CONGTY" });
            }
            if (Program._ketNoiDB.GroupId == "CHINHANH")
            {
                comBoxRole.Items.Add(new { Text = "Chi nhánh", Value = "CHINHANH" });
                comBoxRole.Items.Add(new { Text = "User", Value = "USER" });
            }

        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            string SP_name = "SP_TAOLOGIN";
           
            SqlDataReader res =  Program._ketNoiDB.excuteSP(
                    SP_name +
                    $" @LGNAME = '{txtBoxLoginName.Text}', " +
                    $" @PASS = '{txtBoxPassword.Text}'," +
                    $" @USERNAME = '{mANVTextBox.Text}'," +
                    $" @ROLE = '{(comBoxRole.SelectedItem as dynamic).Value}'"
                );
            int resCode = res.GetInt32(0);
            switch (resCode)
            {
                case 1:
                    MessageBox.Show("Login name bị trùng.");
                    break;
                case 2:
                    MessageBox.Show("Nhân viên đã có tài khoản.");
                    Program.FillAllTable();
                    break;
                case 0:
                    MessageBox.Show("Tạo thành công.");
                    Program.FillAllTable();
                    break;
                default:
                    break;
            }
        }
    }
}
