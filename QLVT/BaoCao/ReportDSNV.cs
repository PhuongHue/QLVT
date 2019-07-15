using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.BaoCao
{
    public partial class ReportDSNV : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSNV()
        {
            InitializeComponent();
            sP_DSNVTableAdapter1.Connection = Program._ketNoiDB.sqlConnection;
            sP_DSNVTableAdapter1.Fill(qlvT_CN_DataSet1.SP_DSNV);
            this.ShowPreview();
        }

    }
}
