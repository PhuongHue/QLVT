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
using DevExpress.XtraGrid.Views.Grid;

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

        private void gridViewVatTu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "MAVT":
                    error = Validation.validateNumber("Mã vật tư", e.Value.ToString());
                    break;
                case "TENVT":
                    error = Validation.validateName("Tên vật tư", e.Value.ToString());
                    break;
                case "DVT":
                    error = Validation.validateCommonText("Đơn vị tính", e.Value.ToString());
                    break;
                case "SOLUONGTON":
                    if (Int32.Parse(e.Value.ToString()) < 0) error += "Số lượng tồm không được nhỏ hơn 0";
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewVatTu_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                e.Valid = false;
                e.ErrorText = "Nhập liệu có lỗi.";
                return;
            }
        }
    }
}
