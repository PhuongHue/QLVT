namespace QLVT.Components
{
    partial class ComponentNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentNV));
            this.qLVT_CN_DataSet = new QLVT.QLVT_CN_DataSet();
            this.chiNhanhBindingSource = new System.Windows.Forms.BindingSource();
            this.chiNhanhTableAdapter = new QLVT.QLVT_CN_DataSetTableAdapters.ChiNhanhTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_CN_DataSetTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new QLVT.QLVT_CN_DataSetTableAdapters.NhanVienTableAdapter();
            this.chiNhanhBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.btnAddNewItemNV = new System.Windows.Forms.ToolStripButton();
            this.fKNhanVienChiNhanhBindingSource = new System.Windows.Forms.BindingSource();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnDeleteItemNV = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInDSNV = new System.Windows.Forms.ToolStripButton();
            this.chiNhanhGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_CN_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingNavigator)).BeginInit();
            this.chiNhanhBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKNhanVienChiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVT_CN_DataSet
            // 
            this.qLVT_CN_DataSet.DataSetName = "QLVT_CN_DataSet";
            this.qLVT_CN_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiNhanhBindingSource
            // 
            this.chiNhanhBindingSource.DataMember = "ChiNhanh";
            this.chiNhanhBindingSource.DataSource = this.qLVT_CN_DataSet;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = this.chiNhanhTableAdapter;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_CN_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // chiNhanhBindingNavigator
            // 
            this.chiNhanhBindingNavigator.AddNewItem = this.btnAddNewItemNV;
            this.chiNhanhBindingNavigator.BindingSource = this.fKNhanVienChiNhanhBindingSource;
            this.chiNhanhBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.chiNhanhBindingNavigator.DeleteItem = null;
            this.chiNhanhBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAddNewItemNV,
            this.btnDeleteItemNV,
            this.btnInDSNV});
            this.chiNhanhBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.chiNhanhBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.chiNhanhBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.chiNhanhBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.chiNhanhBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.chiNhanhBindingNavigator.Name = "chiNhanhBindingNavigator";
            this.chiNhanhBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.chiNhanhBindingNavigator.Size = new System.Drawing.Size(642, 30);
            this.chiNhanhBindingNavigator.TabIndex = 0;
            this.chiNhanhBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnAddNewItemNV
            // 
            this.btnAddNewItemNV.BackColor = System.Drawing.Color.Aqua;
            this.btnAddNewItemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewItemNV.Image")));
            this.btnAddNewItemNV.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNewItemNV.Name = "btnAddNewItemNV";
            this.btnAddNewItemNV.RightToLeftAutoMirrorImage = true;
            this.btnAddNewItemNV.Size = new System.Drawing.Size(74, 20);
            this.btnAddNewItemNV.Text = "Add new";
            this.btnAddNewItemNV.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // fKNhanVienChiNhanhBindingSource
            // 
            this.fKNhanVienChiNhanhBindingSource.DataMember = "FK_NhanVien_ChiNhanh";
            this.fKNhanVienChiNhanhBindingSource.DataSource = this.chiNhanhBindingSource;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 27);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // btnDeleteItemNV
            // 
            this.btnDeleteItemNV.BackColor = System.Drawing.Color.Aqua;
            this.btnDeleteItemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItemNV.Image")));
            this.btnDeleteItemNV.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteItemNV.Name = "btnDeleteItemNV";
            this.btnDeleteItemNV.RightToLeftAutoMirrorImage = true;
            this.btnDeleteItemNV.Size = new System.Drawing.Size(60, 20);
            this.btnDeleteItemNV.Text = "Delete";
            this.btnDeleteItemNV.Click += new System.EventHandler(this.btnDeleteItemNV_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // btnInDSNV
            // 
            this.btnInDSNV.BackColor = System.Drawing.Color.Aqua;
            this.btnInDSNV.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSNV.Image")));
            this.btnInDSNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInDSNV.Margin = new System.Windows.Forms.Padding(5);
            this.btnInDSNV.Name = "btnInDSNV";
            this.btnInDSNV.Size = new System.Drawing.Size(70, 20);
            this.btnInDSNV.Text = "In DSNV";
            this.btnInDSNV.Click += new System.EventHandler(this.btnInDSNV_Click);
            // 
            // chiNhanhGridControl
            // 
            this.chiNhanhGridControl.DataSource = this.fKNhanVienChiNhanhBindingSource;
            this.chiNhanhGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chiNhanhGridControl.Location = new System.Drawing.Point(0, 30);
            this.chiNhanhGridControl.MainView = this.gridView1;
            this.chiNhanhGridControl.Name = "chiNhanhGridControl";
            this.chiNhanhGridControl.Size = new System.Drawing.Size(642, 424);
            this.chiNhanhGridControl.TabIndex = 1;
            this.chiNhanhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.chiNhanhGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
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
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.AllowEdit = false;
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // ComponentNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chiNhanhGridControl);
            this.Controls.Add(this.chiNhanhBindingNavigator);
            this.Name = "ComponentNV";
            this.Size = new System.Drawing.Size(642, 454);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_CN_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingNavigator)).EndInit();
            this.chiNhanhBindingNavigator.ResumeLayout(false);
            this.chiNhanhBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKNhanVienChiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVT_CN_DataSet qLVT_CN_DataSet;
        private System.Windows.Forms.BindingSource chiNhanhBindingSource;
        private QLVT_CN_DataSetTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private QLVT_CN_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator chiNhanhBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAddNewItemNV;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnDeleteItemNV;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraGrid.GridControl chiNhanhGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVT_CN_DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource fKNhanVienChiNhanhBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.ToolStripButton btnInDSNV;
    }
}
