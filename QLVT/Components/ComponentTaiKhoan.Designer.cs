namespace QLVT.Components
{
    partial class ComponentTaiKhoan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label txtRole;
            this.qLVT_CN_DataSet = new QLVT.QLVT_CN_DataSet();
            this.sP_List_LOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_List_LOGINTableAdapter = new QLVT.QLVT_CN_DataSetTableAdapters.SP_List_LOGINTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_CN_DataSetTableAdapters.TableAdapterManager();
            this.sP_List_LOGINGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.comBoxRole = new System.Windows.Forms.ComboBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxLoginName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mANVTextBox = new System.Windows.Forms.TextBox();
            mANVLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtRole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_CN_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            mANVLabel.Location = new System.Drawing.Point(27, 63);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(42, 13);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(24, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 13);
            label2.TabIndex = 0;
            label2.Text = "Login name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(24, 141);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 13);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            txtRole.Location = new System.Drawing.Point(24, 180);
            txtRole.Name = "txtRole";
            txtRole.Size = new System.Drawing.Size(32, 13);
            txtRole.TabIndex = 0;
            txtRole.Text = "Role";
            // 
            // qLVT_CN_DataSet
            // 
            this.qLVT_CN_DataSet.DataSetName = "QLVT_CN_DataSet";
            this.qLVT_CN_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_List_LOGINBindingSource
            // 
            this.sP_List_LOGINBindingSource.DataMember = "SP_List_LOGIN";
            this.sP_List_LOGINBindingSource.DataSource = this.qLVT_CN_DataSet;
            // 
            // sP_List_LOGINTableAdapter
            // 
            this.sP_List_LOGINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_CN_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // sP_List_LOGINGridControl
            // 
            this.sP_List_LOGINGridControl.DataSource = this.sP_List_LOGINBindingSource;
            this.sP_List_LOGINGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_List_LOGINGridControl.Location = new System.Drawing.Point(3, 3);
            this.sP_List_LOGINGridControl.MainView = this.gridView1;
            this.sP_List_LOGINGridControl.Name = "sP_List_LOGINGridControl";
            this.sP_List_LOGINGridControl.Size = new System.Drawing.Size(402, 420);
            this.sP_List_LOGINGridControl.TabIndex = 1;
            this.sP_List_LOGINGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colMACN});
            this.gridView1.GridControl = this.sP_List_LOGINGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.sP_List_LOGINGridControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 426);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTaoTK);
            this.panel1.Controls.Add(this.comBoxRole);
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.txtBoxLoginName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(txtRole);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(mANVLabel);
            this.panel1.Controls.Add(this.mANVTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(411, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 420);
            this.panel1.TabIndex = 2;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(153, 245);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(117, 32);
            this.btnTaoTK.TabIndex = 5;
            this.btnTaoTK.Text = "TẠO";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // comBoxRole
            // 
            this.comBoxRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxRole.FormattingEnabled = true;
            this.comBoxRole.Location = new System.Drawing.Point(113, 177);
            this.comBoxRole.Name = "comBoxRole";
            this.comBoxRole.Size = new System.Drawing.Size(232, 21);
            this.comBoxRole.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPassword.Location = new System.Drawing.Point(113, 138);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(232, 21);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // txtBoxLoginName
            // 
            this.txtBoxLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxLoginName.Location = new System.Drawing.Point(113, 99);
            this.txtBoxLoginName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtBoxLoginName.Name = "txtBoxLoginName";
            this.txtBoxLoginName.Size = new System.Drawing.Size(232, 21);
            this.txtBoxLoginName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(160, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tạo tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mANVTextBox
            // 
            this.mANVTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mANVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_List_LOGINBindingSource, "MANV", true));
            this.mANVTextBox.Location = new System.Drawing.Point(113, 60);
            this.mANVTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.mANVTextBox.Name = "mANVTextBox";
            this.mANVTextBox.ReadOnly = true;
            this.mANVTextBox.Size = new System.Drawing.Size(232, 21);
            this.mANVTextBox.TabIndex = 1;
            // 
            // ComponentTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComponentTaiKhoan";
            this.Size = new System.Drawing.Size(816, 426);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_CN_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVT_CN_DataSet qLVT_CN_DataSet;
        private System.Windows.Forms.BindingSource sP_List_LOGINBindingSource;
        private QLVT_CN_DataSetTableAdapters.SP_List_LOGINTableAdapter sP_List_LOGINTableAdapter;
        private QLVT_CN_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_List_LOGINGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mANVTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxRole;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxLoginName;
        private System.Windows.Forms.Button btnTaoTK;
    }
}
