namespace CSC479_A1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.tsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbSizes = new System.Windows.Forms.ToolStripComboBox();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabCurrent = new System.Windows.Forms.TabPage();
            this.tblCurrent = new System.Windows.Forms.TableLayoutPanel();
            this.tabInitial = new System.Windows.Forms.TabPage();
            this.tblInitial = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbDelay = new System.Windows.Forms.ToolStripComboBox();
            this.lblDelay = new System.Windows.Forms.ToolStripLabel();
            this.tsMain.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.tabCurrent.SuspendLayout();
            this.tabInitial.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 445);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(500, 120);
            this.txtLog.TabIndex = 0;
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRun,
            this.btnReset,
            this.tsSep1,
            this.cbSizes,
            this.toolStripSeparator1,
            this.lblDelay,
            this.cbDelay});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(500, 25);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(48, 22);
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 22);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tsSep1
            // 
            this.tsSep1.Name = "tsSep1";
            this.tsSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // cbSizes
            // 
            this.cbSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSizes.DropDownWidth = 121;
            this.cbSizes.Items.AddRange(new object[] {
            "2x2",
            "3x3",
            "4x4"});
            this.cbSizes.Name = "cbSizes";
            this.cbSizes.Size = new System.Drawing.Size(75, 25);
            this.cbSizes.SelectedIndexChanged += new System.EventHandler(this.cbSizes_SelectedIndexChanged);
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabCurrent);
            this.tabPages.Controls.Add(this.tabInitial);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Location = new System.Drawing.Point(0, 25);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(500, 420);
            this.tabPages.TabIndex = 3;
            // 
            // tabCurrent
            // 
            this.tabCurrent.Controls.Add(this.tblCurrent);
            this.tabCurrent.Location = new System.Drawing.Point(4, 22);
            this.tabCurrent.Name = "tabCurrent";
            this.tabCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrent.Size = new System.Drawing.Size(492, 394);
            this.tabCurrent.TabIndex = 1;
            this.tabCurrent.Text = "Current State";
            this.tabCurrent.UseVisualStyleBackColor = true;
            // 
            // tblCurrent
            // 
            this.tblCurrent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCurrent.ColumnCount = 2;
            this.tblCurrent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCurrent.Location = new System.Drawing.Point(3, 3);
            this.tblCurrent.Name = "tblCurrent";
            this.tblCurrent.RowCount = 2;
            this.tblCurrent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrent.Size = new System.Drawing.Size(486, 388);
            this.tblCurrent.TabIndex = 0;
            // 
            // tabInitial
            // 
            this.tabInitial.Controls.Add(this.tblInitial);
            this.tabInitial.Location = new System.Drawing.Point(4, 22);
            this.tabInitial.Name = "tabInitial";
            this.tabInitial.Padding = new System.Windows.Forms.Padding(3);
            this.tabInitial.Size = new System.Drawing.Size(492, 394);
            this.tabInitial.TabIndex = 0;
            this.tabInitial.Text = "Initial State";
            this.tabInitial.UseVisualStyleBackColor = true;
            // 
            // tblInitial
            // 
            this.tblInitial.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblInitial.ColumnCount = 2;
            this.tblInitial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInitial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInitial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInitial.Location = new System.Drawing.Point(3, 3);
            this.tblInitial.Name = "tblInitial";
            this.tblInitial.RowCount = 2;
            this.tblInitial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInitial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInitial.Size = new System.Drawing.Size(486, 388);
            this.tblInitial.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cbDelay
            // 
            this.cbDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelay.Items.AddRange(new object[] {
            "No Delay",
            "0.1 Seconds",
            "0.5 Seconds",
            "1 Second",
            "2 Seconds"});
            this.cbDelay.Name = "cbDelay";
            this.cbDelay.Size = new System.Drawing.Size(90, 25);
            this.cbDelay.SelectedIndexChanged += new System.EventHandler(this.cbDelay_SelectedIndexChanged);
            // 
            // lblDelay
            // 
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(80, 22);
            this.lblDelay.Text = "Update Delay:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 565);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.txtLog);
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CSC 479A Assignment #1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tabPages.ResumeLayout(false);
            this.tabCurrent.ResumeLayout(false);
            this.tabInitial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripComboBox cbSizes;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabCurrent;
        private System.Windows.Forms.TableLayoutPanel tblCurrent;
        private System.Windows.Forms.TabPage tabInitial;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripSeparator tsSep1;
        private System.Windows.Forms.TableLayoutPanel tblInitial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cbDelay;
        private System.Windows.Forms.ToolStripLabel lblDelay;
    }
}

