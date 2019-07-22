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
using QLVT.BaoCao;

namespace QLVT.Components
{
    public partial class ComponentVT : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentVT()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
            vattuTableAdapter.Fill(Program.QLVT_CN_DataSet.Vattu);
            if (Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnAddNewVT.Dispose();
                btnDeleteItemVT.Dispose();

            }
        }

        private void gridViewVatTu_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewVT.Enabled = true;
            Program.updateAll();
        }

        private void btnAddNewVT_Click(object sender, EventArgs e)
        {
            btnAddNewVT.Enabled = false;
        }

        private void gridViewVatTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewVT.Enabled = true;
        }

        private void btnDSVT_Click(object sender, EventArgs e)
        {
           new ReportDSVT();
        }
    }
}
