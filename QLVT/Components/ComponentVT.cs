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

namespace QLVT.Components
{
    public partial class ComponentVT : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentVT()
        {
            InitializeComponent();

            load();

        }

        private void load()
        {
            vattuBindingSource.DataSource = Program.QLVT_CN_DataSet;
            vattuTableAdapter.Fill(Program.QLVT_CN_DataSet.Vattu);
        }
    }
}
