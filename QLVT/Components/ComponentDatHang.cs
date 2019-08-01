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
    public partial class ComponentDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentDatHang()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            khoBindingSource.DataSource = Program.QLVT_CN_DataSet;
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
            if(Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnAddNewDH.Dispose();
                btnDeleteItemDDH.Dispose();
                btnAddNewCTDDH.Dispose();
                btnDeleteItemCTDDH.Dispose();

            }
        }

        private void btnAddNewDH_Click(object sender, EventArgs e)
        {
            btnAddNewDH.Enabled = false;
            ((DataRowView)datHangBindingSource.Current)["MANV"] = Program._ketNoiDB.UserName;
        }

        private void gridViewDatHang_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewDH.Enabled = true;
            Program.updateAll();
        }

        private void gridViewDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewDH.Enabled = true;
        }

        private void btnAddNewCTDDH_Click(object sender, EventArgs e)
        {
            btnAddNewCTDDH.Enabled = false;
            ((DataRowView)cTDDHBindingSource.Current)["MAVT"] =
                ((DataRowView)vattuBindingSource.Current)["MAVT"];
        }

        private void gridViewCTDDH_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewCTDDH.Enabled = true;
        }

        private void gridViewCTDDH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewCTDDH.Enabled = true;
        }

        private void btnInDHCCPN_Click(object sender, EventArgs e)
        {
            new ReportDHCCPN();
        }

        private void gridViewDatHang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "MasoDDH":
                    error = Validation.validateCode("Mã số đơn đặt hàng", e.Value.ToString());
                    break;
                case "NhaCC":
                    error = Validation.validateName("Nhà cung cấp", e.Value.ToString());
                    break;
                case "DIACHI":
                    error = Validation.validateCommonText("Địa chỉ", e.Value.ToString());
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewDatHang_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                e.Valid = false;
                e.ErrorText = "Nhập liệu có lỗi tại bảng đơn đặt hàng.";
                return;
            }
        }

        private void gridViewCTDDH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "SOLUONG":
                    if ((int)e.Value <= 0) error += "Số lượng không được nhỏ hơn 0";
                    break;
                case "DONGIA":
                    if ((int)e.Value <= 0) error += "Đơn giá không được nhỏ hơn 0";
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewCTDDH_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                e.Valid = false;
                e.ErrorText = "Nhập liệu có lỗi tại bảng Chi tiết phiếu nhập.";
                return;
            }
        }
    }
}
