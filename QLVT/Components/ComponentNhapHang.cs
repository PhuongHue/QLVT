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
        }
        
        private void pNBindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ((DataRowView)phieuNhapBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
            ((DataRowView)phieuNhapBindingSource.Current)["MAKHO"]
                = ((DataRowView)datHangBindingSource.Current)["MAKHO"];
        }

        private void cTPNBindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ((DataRowView)cTPNBindingSource.Current)["MAVT"]
                = ((DataRowView)cTDDHbindingSource.Current)["MAVT"];
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "SOLUONG")
            {

            }
        }
    }
}
