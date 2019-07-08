namespace QLVT.Components
{
    partial class ComponentKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentKho));
            this.qLVT_CN_DataSet = new QLVT.QLVT_CN_DataSet();
            this.chiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new QLVT.QLVT_CN_DataSetTableAdapters.ChiNhanhTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_CN_DataSetTableAdapters.TableAdapterManager();
            this.khoTableAdapter = new QLVT.QLVT_CN_DataSetTableAdapters.KhoTableAdapter();
            this.chiNhanhBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.fKKhoKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chiNhanhBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.chiNhanhGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_CN_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingNavigator)).BeginInit();
            this.chiNhanhBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKKhoKhoBindingSource)).BeginInit();
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
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_CN_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // chiNhanhBindingNavigator
            // 
            this.chiNhanhBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.chiNhanhBindingNavigator.BindingSource = this.fKKhoKhoBindingSource;
            this.chiNhanhBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.chiNhanhBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.chiNhanhBindingNavigatorSaveItem});
            this.chiNhanhBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.chiNhanhBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.chiNhanhBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.chiNhanhBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.chiNhanhBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.chiNhanhBindingNavigator.Name = "chiNhanhBindingNavigator";
            this.chiNhanhBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.chiNhanhBindingNavigator.Size = new System.Drawing.Size(746, 30);
            this.chiNhanhBindingNavigator.TabIndex = 0;
            this.chiNhanhBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.Color.Aqua;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Margin = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // fKKhoKhoBindingSource
            // 
            this.fKKhoKhoBindingSource.DataMember = "FK_Kho_Kho";
            this.fKKhoKhoBindingSource.DataSource = this.chiNhanhBindingSource;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 27);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.Aqua;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Margin = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // chiNhanhBindingNavigatorSaveItem
            // 
            this.chiNhanhBindingNavigatorSaveItem.BackColor = System.Drawing.Color.Aqua;
            this.chiNhanhBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("chiNhanhBindingNavigatorSaveItem.Image")));
            this.chiNhanhBindingNavigatorSaveItem.Margin = new System.Windows.Forms.Padding(5);
            this.chiNhanhBindingNavigatorSaveItem.Name = "chiNhanhBindingNavigatorSaveItem";
            this.chiNhanhBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 20);
            this.chiNhanhBindingNavigatorSaveItem.Text = "Save Data";
            this.chiNhanhBindingNavigatorSaveItem.Click += new System.EventHandler(this.chiNhanhBindingNavigatorSaveItem_Click);
            // 
            // chiNhanhGridControl
            // 
            this.chiNhanhGridControl.DataSource = this.fKKhoKhoBindingSource;
            this.chiNhanhGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chiNhanhGridControl.Location = new System.Drawing.Point(0, 30);
            this.chiNhanhGridControl.MainView = this.gridView1;
            this.chiNhanhGridControl.Name = "chiNhanhGridControl";
            this.chiNhanhGridControl.Size = new System.Drawing.Size(746, 402);
            this.chiNhanhGridControl.TabIndex = 1;
            this.chiNhanhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gridView1.GridControl = this.chiNhanhGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // ComponentKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chiNhanhGridControl);
            this.Controls.Add(this.chiNhanhBindingNavigator);
            this.Name = "ComponentKho";
            this.Size = new System.Drawing.Size(746, 432);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_CN_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingNavigator)).EndInit();
            this.chiNhanhBindingNavigator.ResumeLayout(false);
            this.chiNhanhBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKKhoKhoBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton chiNhanhBindingNavigatorSaveItem;
        private QLVT_CN_DataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraGrid.GridControl chiNhanhGridControl;
        private System.Windows.Forms.BindingSource fKKhoKhoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
    }
}
