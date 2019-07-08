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
    }
}