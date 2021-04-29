
namespace PrwSg_WinForms
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WidthLable = new System.Windows.Forms.Label();
            this.HeightLable = new System.Windows.Forms.Label();
            this.SpWidthLable = new System.Windows.Forms.Label();
            this.CancelButtom = new System.Windows.Forms.Button();
            this.OKButtom = new System.Windows.Forms.Button();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpineWidth = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.8F));
            this.tableLayoutPanel1.Controls.Add(this.WidthLable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightLable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SpWidthLable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CancelButtom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.OKButtom, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownWidth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHeight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSpineWidth, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.40741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.59259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WidthLable
            // 
            this.WidthLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WidthLable.AutoSize = true;
            this.WidthLable.Location = new System.Drawing.Point(68, 19);
            this.WidthLable.Name = "WidthLable";
            this.WidthLable.Size = new System.Drawing.Size(49, 20);
            this.WidthLable.TabIndex = 0;
            this.WidthLable.Text = "Width";
            // 
            // HeightLable
            // 
            this.HeightLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightLable.AutoSize = true;
            this.HeightLable.Location = new System.Drawing.Point(66, 82);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(54, 20);
            this.HeightLable.TabIndex = 1;
            this.HeightLable.Text = "Height";
            // 
            // SpWidthLable
            // 
            this.SpWidthLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpWidthLable.AutoSize = true;
            this.SpWidthLable.Location = new System.Drawing.Point(48, 146);
            this.SpWidthLable.Name = "SpWidthLable";
            this.SpWidthLable.Size = new System.Drawing.Size(90, 20);
            this.SpWidthLable.TabIndex = 2;
            this.SpWidthLable.Text = "Spine Width";
            // 
            // CancelButtom
            // 
            this.CancelButtom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButtom.Location = new System.Drawing.Point(46, 204);
            this.CancelButtom.Name = "CancelButtom";
            this.CancelButtom.Size = new System.Drawing.Size(94, 29);
            this.CancelButtom.TabIndex = 3;
            this.CancelButtom.Text = "Cancel";
            this.CancelButtom.UseVisualStyleBackColor = true;
            this.CancelButtom.Click += new System.EventHandler(this.CancelButtom_Click);
            // 
            // OKButtom
            // 
            this.OKButtom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKButtom.Location = new System.Drawing.Point(236, 204);
            this.OKButtom.Name = "OKButtom";
            this.OKButtom.Size = new System.Drawing.Size(94, 29);
            this.OKButtom.TabIndex = 4;
            this.OKButtom.Text = "OK";
            this.OKButtom.UseVisualStyleBackColor = true;
            this.OKButtom.Click += new System.EventHandler(this.OKButtom_Click);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownWidth.Location = new System.Drawing.Point(208, 16);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownWidth.TabIndex = 5;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownHeight.Location = new System.Drawing.Point(208, 78);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownHeight.TabIndex = 6;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numericUpDownSpineWidth
            // 
            this.numericUpDownSpineWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownSpineWidth.Location = new System.Drawing.Point(208, 142);
            this.numericUpDownSpineWidth.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numericUpDownSpineWidth.Name = "numericUpDownSpineWidth";
            this.numericUpDownSpineWidth.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownSpineWidth.TabIndex = 7;
            this.numericUpDownSpineWidth.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 255);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Cover...";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label WidthLable;
        private System.Windows.Forms.Label HeightLable;
        private System.Windows.Forms.Label SpWidthLable;
        private System.Windows.Forms.Button CancelButtom;
        private System.Windows.Forms.Button OKButtom;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpineWidth;
    }
}