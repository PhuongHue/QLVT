using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.BaoCao
{
    public partial class ReportDSVT : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSVT()
        {
            InitializeComponent();
            vattuTableAdapter.Connection = Program._ketNoiDB.sqlConnection;
            vattuTableAdapter.Fill(qlvT_CN_DataSet1.Vattu);
            this.ShowPreview();
        }

    }
}
