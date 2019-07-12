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
    public partial class ComponentNV : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentNV()
        {
            InitializeComponent();
            chiNhanhBindingSource.DataSource = Program.QLVT_CN_DataSet;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }
        
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }
    }
}
