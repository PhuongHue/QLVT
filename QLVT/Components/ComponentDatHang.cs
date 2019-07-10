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

namespace QLVT.Components
{
    public partial class ComponentDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentDatHang()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            khoBindingSource.DataSource = Program.QLVT_CN_DataSet;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ((DataRowView)datHangBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
        }

    }
}
