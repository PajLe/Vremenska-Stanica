namespace PomocneForme
{
    partial class ListaUnetihVrednosti
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
            this.vParametarListBox = new System.Windows.Forms.ListBox();
            this.vParametarLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vParametarListBox
            // 
            this.vParametarListBox.FormattingEnabled = true;
            this.vParametarListBox.Location = new System.Drawing.Point(2, 51);
            this.vParametarListBox.Name = "vParametarListBox";
            this.vParametarListBox.Size = new System.Drawing.Size(304, 420);
            this.vParametarListBox.TabIndex = 0;
            // 
            // vParametarLab
            // 
            this.vParametarLab.AutoSize = true;
            this.vParametarLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vParametarLab.Location = new System.Drawing.Point(115, 9);
            this.vParametarLab.Name = "vParametarLab";
            this.vParametarLab.Size = new System.Drawing.Size(66, 24);
            this.vParametarLab.TabIndex = 1;
            this.vParametarLab.Text = "label1";
            // 
            // ListaUnetihVrednosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 475);
            this.Controls.Add(this.vParametarLab);
            this.Controls.Add(this.vParametarListBox);
            this.Name = "ListaUnetihVrednosti";
            this.Text = "ListaUnetihVrednosti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vParametarListBox;
        private System.Windows.Forms.Label vParametarLab;
    }
}