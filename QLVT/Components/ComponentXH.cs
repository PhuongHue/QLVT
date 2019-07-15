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
using QLVT.BatLoi;

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
            if (Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnNewItemPX.Dispose();
                btnDeleteItemPX.Dispose();
                btnAddNewCTPX.Dispose();
                btnDeleteItemCTPX.Dispose();

            }
        }

        private void phieuXuatNewItem_Click(object sender, EventArgs e)
        {
            btnNewItemPX.Enabled = false;
            ((DataRowView)phieuXuatBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
        }

        private void gridViewPX_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnNewItemPX.Enabled = true;
            Program.updateAll();
        }

        private void gridViewPX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnNewItemPX.Enabled = true;
        }

        private void cTPXNewItem_Click(object sender, EventArgs e)
        {
            btnAddNewCTPX.Enabled = false;
            ((DataRowView)cTPXBindingSource.Current)["MAVT"]
                = ((DataRowView)vattuBindingSource.Current)["MAVT"];
        }

        private void gridViewCTPX_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewCTPX.Enabled = true;
            Program.updateAll();
        }

        private void gridViewCTPX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewCTPX.Enabled = true;
        }
    }
}
