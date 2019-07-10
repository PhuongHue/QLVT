using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
            SetInfoDangNhap();
            Program.FillAllTable();
        }

        void SetInfoDangNhap()
        {
            tSLabelMNV.Text += Program._ketNoiDB.UserName;
            tSLabelName.Text += Program._ketNoiDB.FullName;
            tSLabelNhom.Text += Program._ketNoiDB.GroupId;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_MASTER_DataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_MASTER_DataSet.V_DSPM);
        }

        private void v_DSPMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program._ketNoiDB.Server = v_DSPMComboBox.SelectedValue.ToString();
                Program._ketNoiDB.NewSqlConnection();
                Program.ChangeConnection(Program._ketNoiDB.sqlConnection);
                Program.FillAllTable();
            }
            catch { }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            Program.updateAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Program.FillAllTable();
        }
    }
}