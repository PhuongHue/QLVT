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
using QLVT.KetNoi;

namespace QLVT
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        KetNoiDB _dataRepository;

        public FormLogin()
        {
            InitializeComponent();
            _dataRepository = Program._ketNoiDB;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_MASTER_DataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_MASTER_DataSet.V_DSPM);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _dataRepository.Server = v_DSPMComboBox.SelectedValue.ToString();
            _dataRepository.DataBase = "QLVT_DATHANG";
            _dataRepository.UserId = LoginUserTextBox.Text;
            _dataRepository.Password = LoginPasswordTextBox.Text;
            _dataRepository.NewSqlConnection();
            MessageBox.Show(_dataRepository.ConnectServer());
            if (_dataRepository.Ready) this.Close();
        }
    }
}