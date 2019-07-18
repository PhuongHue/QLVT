using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT.BaoCao
{
    public partial class FormReportTKPX : DevExpress.XtraEditors.XtraForm
    {
        public FormReportTKPX()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int ct = 0;
            if (Program._ketNoiDB.GroupId == "CONGTY")
                ct = 1;
            new ReportTKPX(
                    dateTimePickerStart.Value,
                    dateTimePickerEnd.Value,
                    ct
                );
        }
    }
}