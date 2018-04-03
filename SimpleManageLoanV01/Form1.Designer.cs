namespace SimpleManageLoanV01
{
    partial class Form1
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
            this.gv = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pesonelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.افزودنپرسنلجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(305, 157);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(470, 150);
            this.gv.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesonelsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // pesonelsToolStripMenuItem
            // 
            this.pesonelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonelsToolStripMenuItem,
            this.افزودنپرسنلجدیدToolStripMenuItem,
            this.findToolStripMenuItem});
            this.pesonelsToolStripMenuItem.Name = "pesonelsToolStripMenuItem";
            this.pesonelsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.pesonelsToolStripMenuItem.Text = "پرسنل";
            // 
            // showPersonelsToolStripMenuItem
            // 
            this.showPersonelsToolStripMenuItem.Name = "showPersonelsToolStripMenuItem";
            this.showPersonelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPersonelsToolStripMenuItem.Text = "لیست پرسنل";
            this.showPersonelsToolStripMenuItem.Click += new System.EventHandler(this.showPersonelsToolStripMenuItem_Click);
            // 
            // افزودنپرسنلجدیدToolStripMenuItem
            // 
            this.افزودنپرسنلجدیدToolStripMenuItem.Name = "افزودنپرسنلجدیدToolStripMenuItem";
            this.افزودنپرسنلجدیدToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.افزودنپرسنلجدیدToolStripMenuItem.Text = "افزودن پرسنل جدید";
             // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem.Text = "جستجوی نام پرسنل";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Text = "MDI Tab";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Checked = true;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Text = "MDI Tab";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pesonelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem افزودنپرسنلجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
    }
}

