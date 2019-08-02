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
    public partial class FormReportTKPN : DevExpress.XtraEditors.XtraForm
    {
        public FormReportTKPN()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(
                dateTimePickerStart.Value,
                dateTimePickerEnd.Value
                ) > 0)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc");
                return;
            }
            new ReportTKN(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            
        }

       
    }
}