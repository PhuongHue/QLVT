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
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
            if(Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnAddNewDH.Dispose();
                btnDeleteItemDDH.Dispose();
                btnAddNewCTDDH.Dispose();
                btnDeleteItemCTDDH.Dispose();

            }
        }

        private void btnAddNewDH_Click(object sender, EventArgs e)
        {
            btnAddNewDH.Enabled = false;
            ((DataRowView)datHangBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
        }

        private void gridViewDatHang_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewDH.Enabled = true;
            Program.updateAll();
        }

        private void gridViewDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewDH.Enabled = true;
        }

        private void btnAddNewCTDDH_Click(object sender, EventArgs e)
        {
            btnAddNewCTDDH.Enabled = false;
            ((DataRowView)cTDDHBindingSource.Current)["MAVT"] =
                ((DataRowView)vattuBindingSource.Current)["MAVT"];
        }

        private void gridViewCTDDH_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewCTDDH.Enabled = true;
        }

        private void gridViewCTDDH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewCTDDH.Enabled = true;
        }
    }
}
