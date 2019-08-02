using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace QLVT.BaoCao
{
    public partial class ReportTKX : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTKX(DateTime start, DateTime end)
        {
            InitializeComponent();

            sP_THONG_KE_XUATTableAdapter1.Connection = Program._ketNoiDB.sqlConnection;

            string startDate = $"{start.Day}/{start.Month}/{start.Year}";
            string endDate = $"{end.Day}/{end.Month}/{end.Year}";

            xrLabelDate.Text = $"Từ ngày: {startDate} đến ngày {endDate}";

            sP_THONG_KE_XUATTableAdapter1.Fill(qlvT_CN_DataSet1.SP_THONG_KE_XUAT, start, end);
            if (qlvT_CN_DataSet1.SP_THONG_KE_XUAT.Count == 0)
                MessageBox.Show($"Không có kết quả từ ngày {startDate} đến ngày {endDate}.");
            else
                this.ShowPreview();
        }
    }

}
