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
    public partial class ComponentVT : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentVT()
        {
            InitializeComponent();
            load();
            eventListener();
        }

        private void load()
        {
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
            vattuTableAdapter.Fill(Program.QLVT_CN_DataSet.Vattu);
        }

        private void eventListener()
        {
            vattuBindingSource.AddingNew += new AddingNewEventHandler(Event_vattuBindingSourceAddNewItem);

        }

        public void Event_vattuBindingSourceAddNewItem(object sender, AddingNewEventArgs e)
        {
            try
            {
                Program.QLVT_CN_DataSet.EnforceConstraints = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(SqlMessageResolver.SqlMessageResolve(ex.Message));
                vattuBindingSource.RemoveCurrent();
            }
            finally
            {
                Program.QLVT_CN_DataSet.EnforceConstraints = false;
            }
        }

        private void gridViewVatTu_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewVT.Enabled = true;
        }

        private void btnAddNewVT_Click(object sender, EventArgs e)
        {
            btnAddNewVT.Enabled = false;
        }

        private void gridViewVatTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewVT.Enabled = true;
        }
    }
}
