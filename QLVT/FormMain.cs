﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLVT.Components;

namespace QLVT
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
            SetInfoDangNhap();
            Program.FillAllTable();
        }

        void SetInfoDangNhap()
        {
            tSLabelMNV.Text += Program._ketNoiDB.UserName;
            tSLabelName.Text += Program._ketNoiDB.FullName;
            tSLabelNhom.Text += Program._ketNoiDB.GroupId;

            if (Program._ketNoiDB.GroupId != "CONGTY")
            {
                v_DSPMComboBox.Enabled = false;
            }
            else
            if (Program._ketNoiDB.GroupId != "USER")
            {
                pageTaiKhoan.PageVisible = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_MASTER_DataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_MASTER_DataSet.V_DSPM);
            if (Program._ketNoiDB.GroupId == "CONGTY")
                while (v_DSPMBindingSource.Position < v_DSPMBindingSource.Count - 1)
                {
                    if (((DataRowView)v_DSPMBindingSource.Current)["subscriber_server"] == Program._ketNoiDB.Server) break;
                    v_DSPMBindingSource.MoveNext();
                }
        }

        private void v_DSPMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program._ketNoiDB.Server = v_DSPMComboBox.SelectedValue.ToString();
                Program._ketNoiDB.NewSqlConnection();
                Program.ChangeConnection(Program._ketNoiDB.sqlConnection);
                Program.FillAllTable();
            }
            catch { }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            Program.updateAll();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Program.FillAllTable();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program._ketNoiDB.Ready = false;
            Program._ketNoiDB.sqlConnection.Close();
        }
    }
}