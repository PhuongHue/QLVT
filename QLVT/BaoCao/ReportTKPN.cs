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
            
            sP_TKPNTableAdapter1.Fill(qlvT_CN_DataSet1.SP_TKPN,startDate, endDate, ct);
            this.ShowPreview();
        }

    }
}
