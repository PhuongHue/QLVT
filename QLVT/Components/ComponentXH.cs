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
            eventListener();
        }

        private void load()
        {
            khoBindingSource.DataSource = Program.QLVT_CN_DataSet;
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
        }

        private void eventListener()
        {
            phieuXuatBindingSource.AddingNew += new AddingNewEventHandler(Event_phieuXuatBindingSourceAddNewItem);
            cTPXBindingSource.AddingNew += new AddingNewEventHandler(Event_cTPXBindingSourceAddNewItem);

        }

        public void Event_phieuXuatBindingSourceAddNewItem(object sender, AddingNewEventArgs e)
        {
            try
            {
                Program.QLVT_CN_DataSet.EnforceConstraints = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(SqlMessageResolver.SqlMessageResolve(ex.Message));
                phieuXuatBindingSource.RemoveCurrent();
            }
            finally
            {
                Program.QLVT_CN_DataSet.EnforceConstraints = false;
            }
        }

        public void Event_cTPXBindingSourceAddNewItem(object sender, AddingNewEventArgs e)
        {
            try
            {
                Program.QLVT_CN_DataSet.EnforceConstraints = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(SqlMessageResolver.SqlMessageResolve(ex.Message));
                cTPXBindingSource.RemoveCurrent();
            }
            finally
            {
                Program.QLVT_CN_DataSet.EnforceConstraints = false;
            }
        }

        private void phieuXuatNewItem_Click(object sender, EventArgs e)
        {
            phieuXuatNewItem.Enabled = false;
            ((DataRowView)phieuXuatBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
        }

        private void gridViewPX_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            phieuXuatNewItem.Enabled = true;
        }

        private void gridViewPX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            phieuXuatNewItem.Enabled = true;
        }

        private void cTPXNewItem_Click(object sender, EventArgs e)
        {
            cTPXNewItem.Enabled = false;
            ((DataRowView)cTPXBindingSource.Current)["MAVT"]
                = ((DataRowView)vattuBindingSource.Current)["MAVT"];
        }

        private void gridViewCTPX_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            cTPXNewItem.Enabled = true;
        }

        private void gridViewCTPX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cTPXNewItem.Enabled = true;
        }
    }
}
