namespace QLVT
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.pageNV = new DevExpress.XtraTab.XtraTabPage();
            this.componentNV1 = new QLVT.Components.ComponentNV();
            this.pageVT = new DevExpress.XtraTab.XtraTabPage();
            this.componentVT2 = new QLVT.Components.ComponentVT();
            this.pageKho = new DevExpress.XtraTab.XtraTabPage();
            this.componentVT1 = new QLVT.Components.ComponentKho();
            this.pageDH = new DevExpress.XtraTab.XtraTabPage();
            this.componentDatHang1 = new QLVT.Components.ComponentDatHang();
            this.pageNhap = new DevExpress.XtraTab.XtraTabPage();
            this.pageXH = new DevExpress.XtraTab.XtraTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSLabelMNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLabelName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLabelNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.qLVT_MASTER_DataSet = new QLVT.QLVT_MASTER_DataSet();
            this.tableAdapterManager = new QLVT.QLVT_MASTER_DataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLVT.QLVT_MASTER_DataSetTableAdapters.V_DSPMTableAdapter();
            this.v_DSPMComboBox = new System.Windows.Forms.ComboBox();
            this.btnSaveAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pageNV.SuspendLayout();
            this.pageVT.SuspendLayout();
            this.pageKho.SuspendLayout();
            this.pageDH.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_MASTER_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(0, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.pageNV;
            this.tabControl.Size = new System.Drawing.Size(978, 427);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageNV,
            this.pageVT,
            this.pageKho,
            this.pageDH,
            this.pageNhap,
            this.pageXH});
            // 
            // pageNV
            // 
            this.pageNV.Controls.Add(this.componentNV1);
            this.pageNV.Name = "pageNV";
            this.pageNV.Size = new System.Drawing.Size(972, 399);
            this.pageNV.Text = "Nhân viên";
            // 
            // componentNV1
            // 
            this.componentNV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentNV1.Location = new System.Drawing.Point(0, 0);
            this.componentNV1.Name = "componentNV1";
            this.componentNV1.Size = new System.Drawing.Size(972, 399);
            this.componentNV1.TabIndex = 0;
            // 
            // pageVT
            // 
            this.pageVT.Controls.Add(this.componentVT2);
            this.pageVT.Name = "pageVT";
            this.pageVT.Size = new System.Drawing.Size(972, 399);
            this.pageVT.Text = "Vật tư";
            // 
            // componentVT2
            // 
            this.componentVT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentVT2.Location = new System.Drawing.Point(0, 0);
            this.componentVT2.Margin = new System.Windows.Forms.Padding(5);
            this.componentVT2.Name = "componentVT2";
            this.componentVT2.Size = new System.Drawing.Size(972, 399);
            this.componentVT2.TabIndex = 0;
            // 
            // pageKho
            // 
            this.pageKho.Controls.Add(this.componentVT1);
            this.pageKho.Name = "pageKho";
            this.pageKho.Size = new System.Drawing.Size(972, 399);
            this.pageKho.Text = "DS Kho";
            // 
            // componentVT1
            // 
            this.componentVT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentVT1.Location = new System.Drawing.Point(0, 0);
            this.componentVT1.Name = "componentVT1";
            this.componentVT1.Size = new System.Drawing.Size(972, 399);
            this.componentVT1.TabIndex = 1;
            // 
            // pageDH
            // 
            this.pageDH.Controls.Add(this.componentDatHang1);
            this.pageDH.Name = "pageDH";
            this.pageDH.Size = new System.Drawing.Size(972, 399);
            this.pageDH.Text = "Đơn đặt hàng";
            // 
            // componentDatHang1
            // 
            this.componentDatHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentDatHang1.Location = new System.Drawing.Point(0, 0);
            this.componentDatHang1.Name = "componentDatHang1";
            this.componentDatHang1.Size = new System.Drawing.Size(972, 399);
            this.componentDatHang1.TabIndex = 0;
            // 
            // pageNhap
            // 
            this.pageNhap.Name = "pageNhap";
            this.pageNhap.Size = new System.Drawing.Size(972, 399);
            this.pageNhap.Text = "Nhập hàng";
            // 
            // pageXH
            // 
            this.pageXH.Name = "pageXH";
            this.pageXH.Size = new System.Drawing.Size(972, 399);
            this.pageXH.Text = "Xuất hàng";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLabelMNV,
            this.tSLabelName,
            this.tSLabelNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSLabelMNV
            // 
            this.tSLabelMNV.BackColor = System.Drawing.Color.MistyRose;
            this.tSLabelMNV.Margin = new System.Windows.Forms.Padding(5);
            this.tSLabelMNV.Name = "tSLabelMNV";
            this.tSLabelMNV.Size = new System.Drawing.Size(49, 15);
            this.tSLabelMNV.Text = "Mã NV: ";
            // 
            // tSLabelName
            // 
            this.tSLabelName.BackColor = System.Drawing.Color.MistyRose;
            this.tSLabelName.Margin = new System.Windows.Forms.Padding(5);
            this.tSLabelName.Name = "tSLabelName";
            this.tSLabelName.Size = new System.Drawing.Size(32, 15);
            this.tSLabelName.Text = "Tên: ";
            // 
            // tSLabelNhom
            // 
            this.tSLabelNhom.BackColor = System.Drawing.Color.MistyRose;
            this.tSLabelNhom.Margin = new System.Windows.Forms.Padding(5);
            this.tSLabelNhom.Name = "tSLabelNhom";
            this.tSLabelNhom.Size = new System.Drawing.Size(47, 15);
            this.tSLabelNhom.Text = "Nhóm: ";
            // 
            // qLVT_MASTER_DataSet
            // 
            this.qLVT_MASTER_DataSet.DataSetName = "QLVT_MASTER_DataSet";
            this.qLVT_MASTER_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_MASTER_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi nhánh";
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.qLVT_MASTER_DataSet;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // v_DSPMComboBox
            // 
            this.v_DSPMComboBox.DataSource = this.v_DSPMBindingSource;
            this.v_DSPMComboBox.DisplayMember = "description";
            this.v_DSPMComboBox.FormattingEnabled = true;
            this.v_DSPMComboBox.Location = new System.Drawing.Point(80, 12);
            this.v_DSPMComboBox.Name = "v_DSPMComboBox";
            this.v_DSPMComboBox.Size = new System.Drawing.Size(300, 21);
            this.v_DSPMComboBox.TabIndex = 3;
            this.v_DSPMComboBox.ValueMember = "subscriber_server";
            this.v_DSPMComboBox.SelectedIndexChanged += new System.EventHandler(this.v_DSPMComboBox_SelectedIndexChanged);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSaveAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSaveAll.Location = new System.Drawing.Point(910, 12);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(56, 44);
            this.btnSaveAll.TabIndex = 4;
            this.btnSaveAll.Text = "Save";
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 491);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.v_DSPMComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pageNV.ResumeLayout(false);
            this.pageVT.ResumeLayout(false);
            this.pageKho.ResumeLayout(false);
            this.pageDH.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_MASTER_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage pageNV;
        private DevExpress.XtraTab.XtraTabPage pageVT;
        private DevExpress.XtraTab.XtraTabPage pageKho;
        private DevExpress.XtraTab.XtraTabPage pageDH;
        private DevExpress.XtraTab.XtraTabPage pageNhap;
        private DevExpress.XtraTab.XtraTabPage pageXH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSLabelMNV;
        private System.Windows.Forms.ToolStripStatusLabel tSLabelName;
        private System.Windows.Forms.ToolStripStatusLabel tSLabelNhom;
        private Components.ComponentNV componentNV1;
        private Components.ComponentKho componentVT1;
        private Components.ComponentVT componentVT2;
        private Components.ComponentDatHang componentDatHang1;
        private QLVT_MASTER_DataSet qLVT_MASTER_DataSet;
        private QLVT_MASTER_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLVT_MASTER_DataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.ComboBox v_DSPMComboBox;
        private DevExpress.XtraEditors.SimpleButton btnSaveAll;
    }
}