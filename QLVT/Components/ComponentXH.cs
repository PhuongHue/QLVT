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
    public partial class ComponentXH : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentXH()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            khoBindingSource.DataSource = Program.QLVT_CN_DataSet;
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
        }

        private void phieuXuatNewItem_Click(object sender, EventArgs e)
        {
            ((DataRowView)phieuXuatBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
        }

        private void cTPXNewItem_Click(object sender, EventArgs e)
        {
            ((DataRowView)cTPXBindingSource.Current)["MAVT"]
                = ((DataRowView)vattuBindingSource.Current)["MAVT"];
        }
    }
}
