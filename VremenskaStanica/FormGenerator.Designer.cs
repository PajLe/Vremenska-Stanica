namespace VremenskaStanica
{
    partial class FormGenerator
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
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.pritisakTextBox = new System.Windows.Forms.TextBox();
            this.vlaznostTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.temperaturaStandardSetButton = new System.Windows.Forms.Button();
            this.proslediButton = new System.Windows.Forms.Button();
            this.cbIgnorisiGranice = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.vlaznostStandardSetButton = new System.Windows.Forms.Button();
            this.pritisakStandardSetButton = new System.Windows.Forms.Button();
            this.tempErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pritisakErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vlaznostErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tempErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pritisakErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlaznostErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.Enabled = false;
            this.temperaturaTextBox.Location = new System.Drawing.Point(169, 13);
            this.temperaturaTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(274, 29);
            this.temperaturaTextBox.TabIndex = 0;
            this.temperaturaTextBox.Enter += new System.EventHandler(this.temperaturaTextBox_Enter);
            this.temperaturaTextBox.Leave += new System.EventHandler(this.temperaturaTextBox_Leave);
            // 
            // pritisakTextBox
            // 
            this.pritisakTextBox.Enabled = false;
            this.pritisakTextBox.Location = new System.Drawing.Point(169, 78);
            this.pritisakTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.pritisakTextBox.Name = "pritisakTextBox";
            this.pritisakTextBox.Size = new System.Drawing.Size(274, 29);
            this.pritisakTextBox.TabIndex = 1;
            this.pritisakTextBox.Enter += new System.EventHandler(this.pritisakTextBox_Enter);
            this.pritisakTextBox.Leave += new System.EventHandler(this.pritisakTextBox_Leave);
            // 
            // vlaznostTextBox
            // 
            this.vlaznostTextBox.Enabled = false;
            this.vlaznostTextBox.Location = new System.Drawing.Point(169, 150);
            this.vlaznostTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.vlaznostTextBox.Name = "vlaznostTextBox";
            this.vlaznostTextBox.Size = new System.Drawing.Size(274, 29);
            this.vlaznostTextBox.TabIndex = 2;
            this.vlaznostTextBox.Enter += new System.EventHandler(this.vlaznostTextBox_Enter);
            this.vlaznostTextBox.Leave += new System.EventHandler(this.vlaznostTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pritisak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vlažnost";
            // 
            // temperaturaStandardSetButton
            // 
            this.temperaturaStandardSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperaturaStandardSetButton.Location = new System.Drawing.Point(469, 13);
            this.temperaturaStandardSetButton.Margin = new System.Windows.Forms.Padding(6);
            this.temperaturaStandardSetButton.Name = "temperaturaStandardSetButton";
            this.temperaturaStandardSetButton.Size = new System.Drawing.Size(32, 27);
            this.temperaturaStandardSetButton.TabIndex = 6;
            this.temperaturaStandardSetButton.Text = "*";
            this.temperaturaStandardSetButton.UseVisualStyleBackColor = true;
            this.temperaturaStandardSetButton.Click += new System.EventHandler(this.temperaturaStandardSetButton_Click);
            // 
            // proslediButton
            // 
            this.proslediButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proslediButton.Location = new System.Drawing.Point(274, 207);
            this.proslediButton.Margin = new System.Windows.Forms.Padding(6);
            this.proslediButton.Name = "proslediButton";
            this.proslediButton.Size = new System.Drawing.Size(169, 47);
            this.proslediButton.TabIndex = 9;
            this.proslediButton.Text = "Prosledi";
            this.proslediButton.UseVisualStyleBackColor = true;
            this.proslediButton.Click += new System.EventHandler(this.proslediButton_Click);
            // 
            // cbIgnorisiGranice
            // 
            this.cbIgnorisiGranice.AutoSize = true;
            this.cbIgnorisiGranice.Location = new System.Drawing.Point(15, 257);
            this.cbIgnorisiGranice.Margin = new System.Windows.Forms.Padding(6);
            this.cbIgnorisiGranice.Name = "cbIgnorisiGranice";
            this.cbIgnorisiGranice.Size = new System.Drawing.Size(157, 28);
            this.cbIgnorisiGranice.TabIndex = 10;
            this.cbIgnorisiGranice.Text = "ignoriši granice";
            this.cbIgnorisiGranice.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 297);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(502, 28);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "automatsko generisanje podataka. interval u sekundama:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(523, 296);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 29);
            this.textBox4.TabIndex = 12;
            // 
            // vlaznostStandardSetButton
            // 
            this.vlaznostStandardSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlaznostStandardSetButton.Location = new System.Drawing.Point(469, 152);
            this.vlaznostStandardSetButton.Margin = new System.Windows.Forms.Padding(6);
            this.vlaznostStandardSetButton.Name = "vlaznostStandardSetButton";
            this.vlaznostStandardSetButton.Size = new System.Drawing.Size(32, 27);
            this.vlaznostStandardSetButton.TabIndex = 13;
            this.vlaznostStandardSetButton.Text = "*";
            this.vlaznostStandardSetButton.UseVisualStyleBackColor = true;
            this.vlaznostStandardSetButton.Click += new System.EventHandler(this.vlaznostStandardSetButton_Click);
            // 
            // pritisakStandardSetButton
            // 
            this.pritisakStandardSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pritisakStandardSetButton.Location = new System.Drawing.Point(469, 83);
            this.pritisakStandardSetButton.Margin = new System.Windows.Forms.Padding(6);
            this.pritisakStandardSetButton.Name = "pritisakStandardSetButton";
            this.pritisakStandardSetButton.Size = new System.Drawing.Size(32, 27);
            this.pritisakStandardSetButton.TabIndex = 14;
            this.pritisakStandardSetButton.Text = "*";
            this.pritisakStandardSetButton.UseVisualStyleBackColor = true;
            this.pritisakStandardSetButton.Click += new System.EventHandler(this.pritisakStandardSetButton_Click);
            // 
            // tempErrorProvider
            // 
            this.tempErrorProvider.ContainerControl = this;
            // 
            // pritisakErrorProvider
            // 
            this.pritisakErrorProvider.ContainerControl = this;
            // 
            // vlaznostErrorProvider
            // 
            this.vlaznostErrorProvider.ContainerControl = this;
            // 
            // FormGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 349);
            this.Controls.Add(this.pritisakStandardSetButton);
            this.Controls.Add(this.vlaznostStandardSetButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.cbIgnorisiGranice);
            this.Controls.Add(this.proslediButton);
            this.Controls.Add(this.temperaturaStandardSetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vlaznostTextBox);
            this.Controls.Add(this.pritisakTextBox);
            this.Controls.Add(this.temperaturaTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(605, 388);
            this.MinimumSize = new System.Drawing.Size(605, 388);
            this.Name = "FormGenerator";
            this.Text = "FormGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGenerator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tempErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pritisakErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlaznostErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox temperaturaTextBox;
        private System.Windows.Forms.TextBox pritisakTextBox;
        private System.Windows.Forms.TextBox vlaznostTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button temperaturaStandardSetButton;
        private System.Windows.Forms.Button proslediButton;
        private System.Windows.Forms.CheckBox cbIgnorisiGranice;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button vlaznostStandardSetButton;
        private System.Windows.Forms.Button pritisakStandardSetButton;
        private System.Windows.Forms.ErrorProvider tempErrorProvider;
        private System.Windows.Forms.ErrorProvider pritisakErrorProvider;
        private System.Windows.Forms.ErrorProvider vlaznostErrorProvider;
    }
}