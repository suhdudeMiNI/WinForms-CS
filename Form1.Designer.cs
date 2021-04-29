
namespace PrwSg_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BackColLable = new System.Windows.Forms.Label();
            this.TxtColLable = new System.Windows.Forms.Label();
            this.BackgroundColButton = new System.Windows.Forms.Button();
            this.TxtColButton = new System.Windows.Forms.Button();
            this.ColorSetLable = new System.Windows.Forms.Label();
            this.AddTextButton = new System.Windows.Forms.Button();
            this.AdditionalLable = new System.Windows.Forms.Label();
            this.AuthorLable = new System.Windows.Forms.Label();
            this.TitleLable = new System.Windows.Forms.Label();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LangSetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngLang = new System.Windows.Forms.ToolStripMenuItem();
            this.PolLang = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.ColorSetLable);
            this.splitContainer1.Panel2.Controls.Add(this.AddTextButton);
            this.splitContainer1.Panel2.Controls.Add(this.AdditionalLable);
            this.splitContainer1.Panel2.Controls.Add(this.AuthorLable);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLable);
            this.splitContainer1.Panel2.Controls.Add(this.AuthorBox);
            this.splitContainer1.Panel2.Controls.Add(this.TitleBox);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(1382, 825);
            this.splitContainer1.SplitterDistance = 1100;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 825);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BackColLable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtColLable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BackgroundColButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtColButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 350);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 100);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // BackColLable
            // 
            this.BackColLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackColLable.AutoSize = true;
            this.BackColLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackColLable.Location = new System.Drawing.Point(7, 12);
            this.BackColLable.Name = "BackColLable";
            this.BackColLable.Size = new System.Drawing.Size(111, 25);
            this.BackColLable.TabIndex = 0;
            this.BackColLable.Text = "Background";
            // 
            // TxtColLable
            // 
            this.TxtColLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtColLable.AutoSize = true;
            this.TxtColLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtColLable.Location = new System.Drawing.Point(39, 62);
            this.TxtColLable.Name = "TxtColLable";
            this.TxtColLable.Size = new System.Drawing.Size(46, 25);
            this.TxtColLable.TabIndex = 1;
            this.TxtColLable.Text = "Text";
            // 
            // BackgroundColButton
            // 
            this.BackgroundColButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackgroundColButton.Location = new System.Drawing.Point(146, 11);
            this.BackgroundColButton.Name = "BackgroundColButton";
            this.BackgroundColButton.Size = new System.Drawing.Size(82, 27);
            this.BackgroundColButton.TabIndex = 2;
            this.BackgroundColButton.Text = "Change";
            this.BackgroundColButton.UseVisualStyleBackColor = true;
            this.BackgroundColButton.Click += new System.EventHandler(this.BackgroundColButton_Click);
            // 
            // TxtColButton
            // 
            this.TxtColButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtColButton.Location = new System.Drawing.Point(145, 61);
            this.TxtColButton.Name = "TxtColButton";
            this.TxtColButton.Size = new System.Drawing.Size(83, 27);
            this.TxtColButton.TabIndex = 3;
            this.TxtColButton.Text = "Change";
            this.TxtColButton.UseVisualStyleBackColor = true;
            this.TxtColButton.Click += new System.EventHandler(this.TxtColButton_Click);
            // 
            // ColorSetLable
            // 
            this.ColorSetLable.AutoSize = true;
            this.ColorSetLable.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorSetLable.Location = new System.Drawing.Point(34, 324);
            this.ColorSetLable.Name = "ColorSetLable";
            this.ColorSetLable.Size = new System.Drawing.Size(129, 23);
            this.ColorSetLable.TabIndex = 7;
            this.ColorSetLable.Text = "Color Settings";
            // 
            // AddTextButton
            // 
            this.AddTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTextButton.Location = new System.Drawing.Point(14, 269);
            this.AddTextButton.Name = "AddTextButton";
            this.AddTextButton.Size = new System.Drawing.Size(251, 29);
            this.AddTextButton.TabIndex = 6;
            this.AddTextButton.Text = "Add Text";
            this.AddTextButton.UseVisualStyleBackColor = true;
            this.AddTextButton.Click += new System.EventHandler(this.AddTextButton_Click);
            // 
            // AdditionalLable
            // 
            this.AdditionalLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionalLable.AutoSize = true;
            this.AdditionalLable.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdditionalLable.Location = new System.Drawing.Point(34, 243);
            this.AdditionalLable.Name = "AdditionalLable";
            this.AdditionalLable.Size = new System.Drawing.Size(143, 23);
            this.AdditionalLable.TabIndex = 5;
            this.AdditionalLable.Text = "Additional Text";
            // 
            // AuthorLable
            // 
            this.AuthorLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorLable.AutoSize = true;
            this.AuthorLable.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorLable.Location = new System.Drawing.Point(34, 163);
            this.AuthorLable.Name = "AuthorLable";
            this.AuthorLable.Size = new System.Drawing.Size(69, 23);
            this.AuthorLable.TabIndex = 4;
            this.AuthorLable.Text = "Author";
            // 
            // TitleLable
            // 
            this.TitleLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLable.Location = new System.Drawing.Point(34, 24);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(48, 23);
            this.TitleLable.TabIndex = 3;
            this.TitleLable.Text = "Title";
            // 
            // AuthorBox
            // 
            this.AuthorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorBox.Location = new System.Drawing.Point(15, 189);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(251, 27);
            this.AuthorBox.TabIndex = 1;
            this.AuthorBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TitleBox
            // 
            this.TitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBox.Location = new System.Drawing.Point(15, 50);
            this.TitleBox.Multiline = true;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(251, 90);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStrip,
            this.SettingsStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FileStrip
            // 
            this.FileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileItem,
            this.OpenFileItem,
            this.SaveFileItem});
            this.FileStrip.Name = "FileStrip";
            this.FileStrip.Size = new System.Drawing.Size(46, 24);
            this.FileStrip.Text = "File";
            // 
            // NewFileItem
            // 
            this.NewFileItem.Name = "NewFileItem";
            this.NewFileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewFileItem.Size = new System.Drawing.Size(181, 26);
            this.NewFileItem.Text = "New";
            this.NewFileItem.Click += new System.EventHandler(this.NewFileItem_Click);
            // 
            // OpenFileItem
            // 
            this.OpenFileItem.Name = "OpenFileItem";
            this.OpenFileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileItem.Size = new System.Drawing.Size(181, 26);
            this.OpenFileItem.Text = "Open";
            this.OpenFileItem.Click += new System.EventHandler(this.OpenFileItem_Click);
            // 
            // SaveFileItem
            // 
            this.SaveFileItem.Name = "SaveFileItem";
            this.SaveFileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveFileItem.Size = new System.Drawing.Size(181, 26);
            this.SaveFileItem.Text = "Save";
            this.SaveFileItem.Click += new System.EventHandler(this.SaveFileItem_Click);
            // 
            // SettingsStrip
            // 
            this.SettingsStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LangSetItem});
            this.SettingsStrip.Name = "SettingsStrip";
            this.SettingsStrip.Size = new System.Drawing.Size(76, 24);
            this.SettingsStrip.Text = "Settings";
            // 
            // LangSetItem
            // 
            this.LangSetItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EngLang,
            this.PolLang});
            this.LangSetItem.Name = "LangSetItem";
            this.LangSetItem.Size = new System.Drawing.Size(157, 26);
            this.LangSetItem.Text = "Language";
            // 
            // EngLang
            // 
            this.EngLang.Checked = true;
            this.EngLang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EngLang.Name = "EngLang";
            this.EngLang.Size = new System.Drawing.Size(139, 26);
            this.EngLang.Text = "English";
            this.EngLang.Click += new System.EventHandler(this.EngLang_Click);
            // 
            // PolLang
            // 
            this.PolLang.Name = "PolLang";
            this.PolLang.Size = new System.Drawing.Size(139, 26);
            this.PolLang.Text = "Polish";
            this.PolLang.Click += new System.EventHandler(this.PolLang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Cover Designer";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AdditionalLable;
        private System.Windows.Forms.Label AuthorLable;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Button AddTextButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStrip;
        private System.Windows.Forms.ToolStripMenuItem NewFileItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsStrip;
        private System.Windows.Forms.ToolStripMenuItem LangSetItem;
        private System.Windows.Forms.ToolStripMenuItem EngLang;
        private System.Windows.Forms.ToolStripMenuItem PolLang;
        private System.Windows.Forms.Label ColorSetLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label BackColLable;
        private System.Windows.Forms.Label TxtColLable;
        private System.Windows.Forms.Button BackgroundColButton;
        private System.Windows.Forms.Button TxtColButton;
    }
}

