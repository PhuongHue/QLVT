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
using QLVT.BaoCao;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using QLVT.BatLoi;

namespace QLVT.Components
{
    public partial class ComponentNV : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentNV()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            chiNhanhBindingSource.DataSource = Program.QLVT_CN_DataSet;
            if (Program._ketNoiDB.GroupId == "CONGTY")
            {
                btnAddNewItemNV.Dispose();
                btnDeleteItemNV.Dispose();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnAddNewItemNV.Enabled = false;
            ((DataRowView)fKNhanVienChiNhanhBindingSource.Current)["TrangThaiXoa"] = 0;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnAddNewItemNV.Enabled = true;
            Program.updateAll();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnAddNewItemNV.Enabled = true;
        }

        private void btnInDSNV_Click(object sender, EventArgs e)
        {
            new ReportDSNV();
        }

        private void btnDeleteItemNV_Click(object sender, EventArgs e)
        {
            ((DataRowView)fKNhanVienChiNhanhBindingSource.Current)["TrangThaiXoa"] = 1;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string error = "";
            switch (e.Column.FieldName)
            {
                case "MANV":
                    error = Validation.validateNumber("Mã nhân viên", e.Value.ToString());
                    break;
                case "HO":
                    error = Validation.validateName("Họ nhân viên", e.Value.ToString());
                    break;
                case "TEN":
                    error = Validation.validateName("Tên nhân viên", e.Value.ToString());
                    break;
                case "DIACHI":
                    error = Validation.validateCommonText("Địa chỉ nhân viên", e.Value.ToString());
                    break;
                case "LUONG":
                    error = Validation.validateNumber("Lương nhân viên", e.Value.ToString());
                    break;
            }

            gridView1.SetColumnError(gridView1.Columns[e.Column.FieldName], error);

        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                e.Valid = false;

                e.ErrorText = "Nhập liệu có lỗi.";
                return;
            }
            string MANV = ((DataRowView)e.Row)["MANV"].ToString();
            if(MANV == "")
            {
                e.Valid = false;
                e.ErrorText = "Mã nhân viên không được trống.";
                return;
            }
            SqlDataReader reader = Program._ketNoiDB.excuteSP($"SP_CHECK_MANV @MANV = {MANV}");
            int res = reader.GetInt32(0);
            reader.Close();
            if (res == 1)
            {
                e.ErrorText = "Mã nhân viên đã tồn tại.";
                e.Valid = false;
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.WindowCaption = "Lỗi";
        }

        private void btnChuyenCN_Click(object sender, EventArgs e)
        {
            string tenNV = ((DataRowView)fKNhanVienChiNhanhBindingSource.Current)["HO"].ToString()
                + " " + ((DataRowView)fKNhanVienChiNhanhBindingSource.Current)["TEN"].ToString();
            if (XtraMessageBox.Show($"Chuyển chi nhánh cho nhân viên {tenNV}", "Thông báo", MessageBoxButtons.OK) 
                == System.Windows.Forms.DialogResult.OK)
            {
                string MANV = ((DataRowView)fKNhanVienChiNhanhBindingSource.Current)["MANV"].ToString();
                SqlDataReader reader = Program._ketNoiDB.excuteSP($"SP_CHUYEN_CHI_NHANH @MANV = {MANV}");
                int res = reader.GetInt32(0);
                reader.Close();
            }
        }
    }
}
