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
    public partial class ComponentNhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentNhapHang()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            datHangBindingSource.DataSource = Program.QLVT_CN_DataSet;
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
            if (Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnAddNewPhieuNhap.Dispose();
                btnDeleteItemPN.Dispose();
                btnAddNewCTPN.Dispose();
                btnDeleteItemCTPN.Dispose();
            }
        }

        private void addNewPhieuNhap_Click(object sender, EventArgs e)
        {
            btnAddNewPhieuNhap.Enabled = false;
            ((DataRowView)phieuNhapBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
            ((DataRowView)phieuNhapBindingSource.Current)["MAKHO"]
                = ((DataRowView)datHangBindingSource.Current)["MAKHO"];
        }

        private void gridViewDatHang_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewPhieuNhap.Enabled = true;
            Program.updateAll();
        }

        private void gridViewDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewPhieuNhap.Enabled = true;
        }

        private void addNewCTPN_Click(object sender, EventArgs e)
        {
            btnAddNewCTPN.Enabled = false;
            ((DataRowView)cTPNBindingSource.Current)["MAVT"]
                = ((DataRowView)cTDDHbindingSource.Current)["MAVT"];
        }

        private void gridViewPhieuNhap_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewCTPN.Enabled = true;
            Program.updateAll();
        }

        private void gridViewPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewCTPN.Enabled = true;
        }
    }
}
