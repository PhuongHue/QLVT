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

        private void btnTKPN_Click(object sender, EventArgs e)
        {
            new FormReportTKPN().Show();
        }

        private void gridViewPN_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "MAPN":
                    error = Validation.validateCode("Mã phiếu nhập", e.Value.ToString());
                    break;
                case "MasoDDH":
                    error = Validation.validateCode("Mã số đơn đặt hàng", e.Value.ToString());
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewPN_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                e.Valid = false;
                e.ErrorText = "Nhập liệu có lỗi tại bảng phiếu nhập.";
                return;
            }
        }

        private void gridViewCTPN_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "SOLUONG":
                    if (Int32.Parse(e.Value.ToString()) <= 0) error += "Số lượng không được âm";
                    break;
                case "DONGIA":
                    if (Int32.Parse(e.Value.ToString()) <= 0) error += "Đơn giá không được âm";
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewCTPN_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                e.Valid = false;
                e.ErrorText = "Nhập liệu có lỗi tại bảng.";
                return;
            }
        }
    }
}
