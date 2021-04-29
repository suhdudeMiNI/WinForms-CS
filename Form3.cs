using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrwSg_WinForms
{
    public partial class Form3 : Form
    {
        public int FSize;
        public string ADDtxt;
        public int align;


        public Form3()
        {
            InitializeComponent();
        }
        public void SetText(string tekst)
        {
            AdditionalText.Text = tekst;
        }

        public void SetFont(int font)
        {
            FontSizeNumeric.Value = font;
        }
        public void SetAlign(int align1)
        {
            align = align1;
            if (align1 == 0)
                LeftradioButtonTA.Checked = true;
            else if (align1 == 1)
                CenterradioButtonTA.Checked = true;
            else
                RightradioButtonAT.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            AdditionalText.TextAlign = HorizontalAlignment.Right;
            align = 2;
        }

        private void CancelButTA_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKButTA_Click(object sender, EventArgs e)
        {
            FSize = (int)FontSizeNumeric.Value;
            ADDtxt = AdditionalText.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LeftradioButtonTA_CheckedChanged(object sender, EventArgs e)
        {
            AdditionalText.TextAlign = HorizontalAlignment.Left;
            align = 0;
        }

        private void CenterradioButtonTA_CheckedChanged(object sender, EventArgs e)
        {
            AdditionalText.TextAlign = HorizontalAlignment.Center;
            align = 1;
        }
    }
}
