
namespace PrwSg_WinForms
{
    partial class Form3
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
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.FontSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAddText = new System.Windows.Forms.GroupBox();
            this.RightradioButtonAT = new System.Windows.Forms.RadioButton();
            this.CenterradioButtonTA = new System.Windows.Forms.RadioButton();
            this.LeftradioButtonTA = new System.Windows.Forms.RadioButton();
            this.AdditionalText = new System.Windows.Forms.TextBox();
            this.CancelButTA = new System.Windows.Forms.Button();
            this.OKButTA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeNumeric)).BeginInit();
            this.groupBoxAddText.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Location = new System.Drawing.Point(21, 55);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(69, 20);
            this.FontSizeLabel.TabIndex = 0;
            this.FontSizeLabel.Text = "Font Size";
            // 
            // FontSizeNumeric
            // 
            this.FontSizeNumeric.Location = new System.Drawing.Point(107, 53);
            this.FontSizeNumeric.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.FontSizeNumeric.Name = "FontSizeNumeric";
            this.FontSizeNumeric.Size = new System.Drawing.Size(106, 27);
            this.FontSizeNumeric.TabIndex = 1;
            this.FontSizeNumeric.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // groupBoxAddText
            // 
            this.groupBoxAddText.Controls.Add(this.RightradioButtonAT);
            this.groupBoxAddText.Controls.Add(this.CenterradioButtonTA);
            this.groupBoxAddText.Controls.Add(this.LeftradioButtonTA);
            this.groupBoxAddText.Location = new System.Drawing.Point(227, 6);
            this.groupBoxAddText.Name = "groupBoxAddText";
            this.groupBoxAddText.Size = new System.Drawing.Size(243, 123);
            this.groupBoxAddText.TabIndex = 2;
            this.groupBoxAddText.TabStop = false;
            this.groupBoxAddText.Text = "Text Aligment";
            // 
            // RightradioButtonAT
            // 
            this.RightradioButtonAT.AutoSize = true;
            this.RightradioButtonAT.Location = new System.Drawing.Point(19, 87);
            this.RightradioButtonAT.Name = "RightradioButtonAT";
            this.RightradioButtonAT.Size = new System.Drawing.Size(65, 24);
            this.RightradioButtonAT.TabIndex = 2;
            this.RightradioButtonAT.Text = "Right";
            this.RightradioButtonAT.UseVisualStyleBackColor = true;
            this.RightradioButtonAT.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // CenterradioButtonTA
            // 
            this.CenterradioButtonTA.AutoSize = true;
            this.CenterradioButtonTA.Location = new System.Drawing.Point(19, 57);
            this.CenterradioButtonTA.Name = "CenterradioButtonTA";
            this.CenterradioButtonTA.Size = new System.Drawing.Size(73, 24);
            this.CenterradioButtonTA.TabIndex = 1;
            this.CenterradioButtonTA.Text = "Center";
            this.CenterradioButtonTA.UseVisualStyleBackColor = true;
            this.CenterradioButtonTA.CheckedChanged += new System.EventHandler(this.CenterradioButtonTA_CheckedChanged);
            // 
            // LeftradioButtonTA
            // 
            this.LeftradioButtonTA.AutoSize = true;
            this.LeftradioButtonTA.Checked = true;
            this.LeftradioButtonTA.Location = new System.Drawing.Point(19, 27);
            this.LeftradioButtonTA.Name = "LeftradioButtonTA";
            this.LeftradioButtonTA.Size = new System.Drawing.Size(55, 24);
            this.LeftradioButtonTA.TabIndex = 0;
            this.LeftradioButtonTA.TabStop = true;
            this.LeftradioButtonTA.Text = "Left";
            this.LeftradioButtonTA.UseVisualStyleBackColor = true;
            this.LeftradioButtonTA.CheckedChanged += new System.EventHandler(this.LeftradioButtonTA_CheckedChanged);
            // 
            // AdditionalText
            // 
            this.AdditionalText.Location = new System.Drawing.Point(2, 135);
            this.AdditionalText.Multiline = true;
            this.AdditionalText.Name = "AdditionalText";
            this.AdditionalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AdditionalText.Size = new System.Drawing.Size(478, 151);
            this.AdditionalText.TabIndex = 3;
            // 
            // CancelButTA
            // 
            this.CancelButTA.Location = new System.Drawing.Point(52, 312);
            this.CancelButTA.Name = "CancelButTA";
            this.CancelButTA.Size = new System.Drawing.Size(94, 29);
            this.CancelButTA.TabIndex = 4;
            this.CancelButTA.Text = "Cancel";
            this.CancelButTA.UseVisualStyleBackColor = true;
            this.CancelButTA.Click += new System.EventHandler(this.CancelButTA_Click);
            // 
            // OKButTA
            // 
            this.OKButTA.Location = new System.Drawing.Point(330, 312);
            this.OKButTA.Name = "OKButTA";
            this.OKButTA.Size = new System.Drawing.Size(94, 29);
            this.OKButTA.TabIndex = 5;
            this.OKButTA.Text = "OK";
            this.OKButTA.UseVisualStyleBackColor = true;
            this.OKButTA.Click += new System.EventHandler(this.OKButTA_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.OKButTA);
            this.Controls.Add(this.CancelButTA);
            this.Controls.Add(this.AdditionalText);
            this.Controls.Add(this.groupBoxAddText);
            this.Controls.Add(this.FontSizeNumeric);
            this.Controls.Add(this.FontSizeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeNumeric)).EndInit();
            this.groupBoxAddText.ResumeLayout(false);
            this.groupBoxAddText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.NumericUpDown FontSizeNumeric;
        private System.Windows.Forms.GroupBox groupBoxAddText;
        private System.Windows.Forms.RadioButton RightradioButtonAT;
        private System.Windows.Forms.RadioButton CenterradioButtonTA;
        private System.Windows.Forms.RadioButton LeftradioButtonTA;
        private System.Windows.Forms.TextBox AdditionalText;
        private System.Windows.Forms.Button CancelButTA;
        private System.Windows.Forms.Button OKButTA;
    }
}