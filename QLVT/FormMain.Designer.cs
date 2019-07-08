﻿namespace QLVT
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
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.pageNV = new DevExpress.XtraTab.XtraTabPage();
            this.componentNV1 = new QLVT.Components.ComponentNV();
            this.pageVT = new DevExpress.XtraTab.XtraTabPage();
            this.pageKho = new DevExpress.XtraTab.XtraTabPage();
            this.componentVT1 = new QLVT.Components.ComponentKho();
            this.khoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pageDH = new DevExpress.XtraTab.XtraTabPage();
            this.pageNhap = new DevExpress.XtraTab.XtraTabPage();
            this.pageXH = new DevExpress.XtraTab.XtraTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSLabelMNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLabelName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLabelNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.componentVT2 = new QLVT.Components.ComponentVT();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pageNV.SuspendLayout();
            this.pageVT.SuspendLayout();
            this.pageKho.SuspendLayout();
            this.componentVT1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingNavigator)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.pageNV;
            this.tabControl.Size = new System.Drawing.Size(938, 426);
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
            this.pageNV.Size = new System.Drawing.Size(932, 398);
            this.pageNV.Text = "Nhân viên";
            // 
            // componentNV1
            // 
            this.componentNV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentNV1.Location = new System.Drawing.Point(0, 0);
            this.componentNV1.Name = "componentNV1";
            this.componentNV1.Size = new System.Drawing.Size(932, 398);
            this.componentNV1.TabIndex = 0;
            // 
            // pageVT
            // 
            this.pageVT.Controls.Add(this.componentVT2);
            this.pageVT.Name = "pageVT";
            this.pageVT.Size = new System.Drawing.Size(932, 398);
            this.pageVT.Text = "Vật tư";
            // 
            // pageKho
            // 
            this.pageKho.Controls.Add(this.componentVT1);
            this.pageKho.Name = "pageKho";
            this.pageKho.Size = new System.Drawing.Size(932, 398);
            this.pageKho.Text = "DS Kho";
            // 
            // componentVT1
            // 
            this.componentVT1.Controls.Add(this.khoBindingNavigator);
            this.componentVT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentVT1.Location = new System.Drawing.Point(0, 0);
            this.componentVT1.Name = "componentVT1";
            this.componentVT1.Size = new System.Drawing.Size(932, 398);
            this.componentVT1.TabIndex = 1;
            // 
            // khoBindingNavigator
            // 
            this.khoBindingNavigator.AddNewItem = null;
            this.khoBindingNavigator.CountItem = null;
            this.khoBindingNavigator.DeleteItem = null;
            this.khoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.khoBindingNavigator.MoveFirstItem = null;
            this.khoBindingNavigator.MoveLastItem = null;
            this.khoBindingNavigator.MoveNextItem = null;
            this.khoBindingNavigator.MovePreviousItem = null;
            this.khoBindingNavigator.Name = "khoBindingNavigator";
            this.khoBindingNavigator.PositionItem = null;
            this.khoBindingNavigator.Size = new System.Drawing.Size(932, 398);
            this.khoBindingNavigator.TabIndex = 0;
            this.khoBindingNavigator.Text = "bindingNavigator1";
            // 
            // pageDH
            // 
            this.pageDH.Name = "pageDH";
            this.pageDH.Size = new System.Drawing.Size(932, 398);
            this.pageDH.Text = "Đơn đặt hàng";
            // 
            // pageNhap
            // 
            this.pageNhap.Name = "pageNhap";
            this.pageNhap.Size = new System.Drawing.Size(932, 398);
            this.pageNhap.Text = "Nhập hàng";
            // 
            // pageXH
            // 
            this.pageXH.Name = "pageXH";
            this.pageXH.Size = new System.Drawing.Size(932, 398);
            this.pageXH.Text = "Xuất hàng";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLabelMNV,
            this.tSLabelName,
            this.tSLabelNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 25);
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
            // componentVT2
            // 
            this.componentVT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentVT2.Location = new System.Drawing.Point(0, 0);
            this.componentVT2.Name = "componentVT2";
            this.componentVT2.Size = new System.Drawing.Size(932, 398);
            this.componentVT2.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 451);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pageNV.ResumeLayout(false);
            this.pageVT.ResumeLayout(false);
            this.pageKho.ResumeLayout(false);
            this.componentVT1.ResumeLayout(false);
            this.componentVT1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingNavigator)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator khoBindingNavigator;
        private Components.ComponentVT componentVT2;
    }
}