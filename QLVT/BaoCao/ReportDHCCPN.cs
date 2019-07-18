using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.BaoCao
{
    public partial class ReportDHCCPN : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDHCCPN()
        {
            InitializeComponent();
            sP_DDH_CHUA_NHAPTableAdapter1.Connection = Program._ketNoiDB.sqlConnection;
            sP_DDH_CHUA_NHAPTableAdapter1.Fill(qlvT_CN_DataSet1.SP_DDH_CHUA_NHAP);
            this.ShowPreview();
        }

    }
}
