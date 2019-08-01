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
using DevExpress.XtraGrid.Views.Grid;

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

        private void gridViewKho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "MAKHO":
                    error = Validation.validateNumber("Mã vật tư", e.Value.ToString());
                    break;
                case "TENKHO":
                    error = Validation.validateName("Tên vật tư", e.Value.ToString());
                    break;
                case "DIACHI":
                    error = Validation.validateCommonText("Đơn vị tính", e.Value.ToString());
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewKho_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
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
