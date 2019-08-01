using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace QLVT.BaoCao
{
    public partial class ReportTKPN : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTKPN(DateTime start, DateTime end, int ct)
        {
            InitializeComponent();
            sP_TKPNTableAdapter1.Connection = Program._ketNoiDB.sqlConnection;

            string startDate = $"{start.Day}-{start.Month}-{start.Year}";
            string endDate = $"{end.Day}-{end.Month}-{end.Year}";

            xrLabelDate.Text = $"Từ ngày: {startDate} đến ngày {endDate}";

            sP_TKPNTableAdapter1.Fill(qlvT_CN_DataSet1.SP_TKPN,startDate, endDate, ct);
            if (qlvT_CN_DataSet1.SP_TKPN.Count == 0)
                MessageBox.Show($"Không có kết quả từ ngày {startDate} đến ngày {endDate}.");
            else
                this.ShowPreview();
        }

    }
}
