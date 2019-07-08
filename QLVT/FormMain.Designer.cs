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
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.pageNV = new DevExpress.XtraTab.XtraTabPage();
            this.pageVT = new DevExpress.XtraTab.XtraTabPage();
            this.pageKho = new DevExpress.XtraTab.XtraTabPage();
            this.pageDH = new DevExpress.XtraTab.XtraTabPage();
            this.pageNhap = new DevExpress.XtraTab.XtraTabPage();
            this.pageXH = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.pageNV;
            this.tabControl.Size = new System.Drawing.Size(938, 451);
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
            this.pageNV.Name = "pageNV";
            this.pageNV.Size = new System.Drawing.Size(932, 423);
            this.pageNV.Text = "Nhân viên";
            // 
            // pageVT
            // 
            this.pageVT.Name = "pageVT";
            this.pageVT.Size = new System.Drawing.Size(932, 423);
            this.pageVT.Text = "Vật tư";
            // 
            // pageKho
            // 
            this.pageKho.Name = "pageKho";
            this.pageKho.Size = new System.Drawing.Size(932, 423);
            this.pageKho.Text = "DS Kho";
            // 
            // pageDH
            // 
            this.pageDH.Name = "pageDH";
            this.pageDH.Size = new System.Drawing.Size(932, 423);
            this.pageDH.Text = "Đơn đặt hàng";
            // 
            // pageNhap
            // 
            this.pageNhap.Name = "pageNhap";
            this.pageNhap.Size = new System.Drawing.Size(932, 423);
            this.pageNhap.Text = "Nhập hàng";
            // 
            // pageXH
            // 
            this.pageXH.Name = "pageXH";
            this.pageXH.Size = new System.Drawing.Size(932, 423);
            this.pageXH.Text = "Xuất hàng";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 451);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage pageNV;
        private DevExpress.XtraTab.XtraTabPage pageVT;
        private DevExpress.XtraTab.XtraTabPage pageKho;
        private DevExpress.XtraTab.XtraTabPage pageDH;
        private DevExpress.XtraTab.XtraTabPage pageNhap;
        private DevExpress.XtraTab.XtraTabPage pageXH;
    }
}