namespace CalculateFlooringCosts
{
    partial class frmParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.stripCarpeting = new System.Windows.Forms.ToolStripMenuItem();
            this.stripHardwood = new System.Windows.Forms.ToolStripMenuItem();
            this.stripClose = new System.Windows.Forms.ToolStripMenuItem();
            this.stripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stripWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.stripCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.stripVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.stripHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stripButtonCarpeting = new System.Windows.Forms.ToolStripButton();
            this.stripButtonHardwood = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripFile,
            this.stripWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.stripWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripFile
            // 
            this.stripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripCarpeting,
            this.stripHardwood,
            this.toolStripSeparator1,
            this.stripClose,
            this.toolStripSeparator2,
            this.stripExit});
            this.stripFile.Name = "stripFile";
            this.stripFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.stripFile.Size = new System.Drawing.Size(46, 24);
            this.stripFile.Text = "File";
            // 
            // stripCarpeting
            // 
            this.stripCarpeting.Name = "stripCarpeting";
            this.stripCarpeting.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.stripCarpeting.Size = new System.Drawing.Size(224, 26);
            this.stripCarpeting.Text = "Carpeting Cost";
            this.stripCarpeting.Click += new System.EventHandler(this.stripCarpeting_Click);
            // 
            // stripHardwood
            // 
            this.stripHardwood.Name = "stripHardwood";
            this.stripHardwood.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.stripHardwood.Size = new System.Drawing.Size(224, 26);
            this.stripHardwood.Text = "Hardwood Cost";
            this.stripHardwood.Click += new System.EventHandler(this.stripHardwood_Click);
            // 
            // stripClose
            // 
            this.stripClose.Name = "stripClose";
            this.stripClose.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.stripClose.Size = new System.Drawing.Size(224, 26);
            this.stripClose.Text = "Close";
            this.stripClose.Click += new System.EventHandler(this.stripClose_Click);
            // 
            // stripExit
            // 
            this.stripExit.Name = "stripExit";
            this.stripExit.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.stripExit.Size = new System.Drawing.Size(224, 26);
            this.stripExit.Text = "Exit";
            this.stripExit.Click += new System.EventHandler(this.stripExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // stripWindow
            // 
            this.stripWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripCascade,
            this.stripVertical,
            this.stripHorizontal});
            this.stripWindow.Name = "stripWindow";
            this.stripWindow.Size = new System.Drawing.Size(78, 24);
            this.stripWindow.Text = "Window";
            // 
            // stripCascade
            // 
            this.stripCascade.Name = "stripCascade";
            this.stripCascade.Size = new System.Drawing.Size(224, 26);
            this.stripCascade.Text = "Cascade";
            this.stripCascade.Click += new System.EventHandler(this.stripCascade_Click);
            // 
            // stripVertical
            // 
            this.stripVertical.Name = "stripVertical";
            this.stripVertical.Size = new System.Drawing.Size(224, 26);
            this.stripVertical.Text = "Vertical";
            this.stripVertical.Click += new System.EventHandler(this.stripVertical_Click);
            // 
            // stripHorizontal
            // 
            this.stripHorizontal.Name = "stripHorizontal";
            this.stripHorizontal.Size = new System.Drawing.Size(224, 26);
            this.stripHorizontal.Text = "Horizontal";
            this.stripHorizontal.Click += new System.EventHandler(this.stripHorizontal_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripButtonCarpeting,
            this.stripButtonHardwood});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1208, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stripButtonCarpeting
            // 
            this.stripButtonCarpeting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripButtonCarpeting.Image = ((System.Drawing.Image)(resources.GetObject("stripButtonCarpeting.Image")));
            this.stripButtonCarpeting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripButtonCarpeting.Name = "stripButtonCarpeting";
            this.stripButtonCarpeting.Size = new System.Drawing.Size(117, 24);
            this.stripButtonCarpeting.Text = "Carpeting Costs";
            this.stripButtonCarpeting.Click += new System.EventHandler(this.stripButtonCarpeting_Click);
            // 
            // stripButtonHardwood
            // 
            this.stripButtonHardwood.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripButtonHardwood.Image = ((System.Drawing.Image)(resources.GetObject("stripButtonHardwood.Image")));
            this.stripButtonHardwood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripButtonHardwood.Name = "stripButtonHardwood";
            this.stripButtonHardwood.Size = new System.Drawing.Size(123, 24);
            this.stripButtonHardwood.Text = "Hardwood Costs";
            this.stripButtonHardwood.Click += new System.EventHandler(this.stripButtonHardwood_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 846);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmParent";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripFile;
        private System.Windows.Forms.ToolStripMenuItem stripCarpeting;
        private System.Windows.Forms.ToolStripMenuItem stripHardwood;
        private System.Windows.Forms.ToolStripMenuItem stripClose;
        private System.Windows.Forms.ToolStripMenuItem stripExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stripWindow;
        private System.Windows.Forms.ToolStripMenuItem stripCascade;
        private System.Windows.Forms.ToolStripMenuItem stripVertical;
        private System.Windows.Forms.ToolStripMenuItem stripHorizontal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stripButtonCarpeting;
        private System.Windows.Forms.ToolStripButton stripButtonHardwood;
    }
}