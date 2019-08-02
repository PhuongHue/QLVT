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
    public partial class ComponentXH : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentXH()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            khoBindingSource.DataSource = Program.QLVT_CN_DataSet;
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
            if (Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnNewItemPX.Dispose();
                btnDeleteItemPX.Dispose();
                btnAddNewCTPX.Dispose();
                btnDeleteItemCTPX.Dispose();

            }
        }

        private void phieuXuatNewItem_Click(object sender, EventArgs e)
        {
            btnNewItemPX.Enabled = false;
            ((DataRowView)phieuXuatBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
        }

        private void gridViewPX_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnNewItemPX.Enabled = true;
            Program.updateAll();
        }

        private void gridViewPX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnNewItemPX.Enabled = true;
        }

        private void cTPXNewItem_Click(object sender, EventArgs e)
        {
            btnAddNewCTPX.Enabled = false;
            ((DataRowView)cTPXBindingSource.Current)["MAVT"]
                = ((DataRowView)vattuBindingSource.Current)["MAVT"];
        }

        private void gridViewCTPX_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewCTPX.Enabled = true;
            Program.updateAll();
        }

        private void gridViewCTPX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewCTPX.Enabled = true;
        }

        private void btnTKPX_Click(object sender, EventArgs e)
        {
            new FormReportTKPX().Show();
        }

        private void gridViewPX_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "MAPX":
                    error = Validation.validateCode("Mã phiếu xuất", e.Value.ToString());
                    break;
                case "HOTENKH":
                    error = Validation.validateName("Họ tên khách hàng", e.Value.ToString());
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewPX_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                e.Valid = false;
                e.ErrorText = "Nhập liệu có lỗi tại bảng Phiếu xuất.";
                return;
            }
        }

        private void gridViewCTPX_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "SOLUONG":
                    if (Int32.Parse(e.Value.ToString()) <= 0) error += "Số lượng không được nhỏ hơn hoặc bằng 0";
                    break;
                case "DONGIA":
                    if (Int32.Parse(e.Value.ToString()) <= 0) error += "Đơn giá không nhỏ hơn hoặc bằng 0";
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewCTPX_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                e.Valid = false;
                e.ErrorText = "Nhập liệu có lỗi tại bảng Chi tiết phiếu xuất.";
                return;
            }
        }
    }
}
