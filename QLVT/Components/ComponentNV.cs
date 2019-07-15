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
using QLVT.BaoCao;

namespace QLVT.Components
{
    public partial class ComponentNV : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentNV()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            chiNhanhBindingSource.DataSource = Program.QLVT_CN_DataSet;
            if (Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnAddNewItemNV.Dispose();
                btnDeleteItemNV.Dispose();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnAddNewItemNV.Enabled = false;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewItemNV.Enabled = true;
            Program.updateAll();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewItemNV.Enabled = true;
        }

        private void btnInDSNV_Click(object sender, EventArgs e)
        {
            new ReportDSNV();
        }
    }
}
