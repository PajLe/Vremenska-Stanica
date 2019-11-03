namespace VremenskaStanica
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlažnostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pritisakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formStatisticalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formGeneratorToolStripMenuItem,
            this.formChartToolStripMenuItem,
            this.formStatisticalDataToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // formGeneratorToolStripMenuItem
            // 
            this.formGeneratorToolStripMenuItem.Name = "formGeneratorToolStripMenuItem";
            this.formGeneratorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formGeneratorToolStripMenuItem.Text = "FormGenerator";
            this.formGeneratorToolStripMenuItem.Click += new System.EventHandler(this.formGeneratorToolStripMenuItem_Click);
            // 
            // formChartToolStripMenuItem
            // 
            this.formChartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaturaToolStripMenuItem,
            this.vlažnostToolStripMenuItem,
            this.pritisakToolStripMenuItem});
            this.formChartToolStripMenuItem.Name = "formChartToolStripMenuItem";
            this.formChartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formChartToolStripMenuItem.Text = "FormChart";
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaToolStripMenuItem_Click);
            // 
            // vlažnostToolStripMenuItem
            // 
            this.vlažnostToolStripMenuItem.Name = "vlažnostToolStripMenuItem";
            this.vlažnostToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.vlažnostToolStripMenuItem.Text = "Vlažnost";
            this.vlažnostToolStripMenuItem.Click += new System.EventHandler(this.vlažnostToolStripMenuItem_Click);
            // 
            // pritisakToolStripMenuItem
            // 
            this.pritisakToolStripMenuItem.Name = "pritisakToolStripMenuItem";
            this.pritisakToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pritisakToolStripMenuItem.Text = "Pritisak";
            this.pritisakToolStripMenuItem.Click += new System.EventHandler(this.pritisakToolStripMenuItem_Click);
            // 
            // formStatisticalDataToolStripMenuItem
            // 
            this.formStatisticalDataToolStripMenuItem.Name = "formStatisticalDataToolStripMenuItem";
            this.formStatisticalDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formStatisticalDataToolStripMenuItem.Text = "FormStatisticalData";
            this.formStatisticalDataToolStripMenuItem.Click += new System.EventHandler(this.formStatisticalDataToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 493);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Vremenska Stanica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlažnostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pritisakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formStatisticalDataToolStripMenuItem;
    }
}

