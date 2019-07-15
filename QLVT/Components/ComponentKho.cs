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
    public partial class ComponentKho : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentKho()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            chiNhanhBindingSource.DataSource = Program.QLVT_CN_DataSet;
            chiNhanhTableAdapter.Fill(Program.QLVT_CN_DataSet.ChiNhanh);
            if (Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnAddKho.Dispose();
                btnDeleteItemKho.Dispose();
            }
        }

        private void btnAddKho_Click(object sender, EventArgs e)
        {
            btnAddKho.Enabled = false;
        }

        private void gridViewKho_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddKho.Enabled = true;
            Program.updateAll();
        }

        private void gridViewKho_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddKho.Enabled = true;
        }
    }
}
