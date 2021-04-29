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
    public partial class Form2 : Form
    {
        public int newWidth;
        public int newHeight;
        public int newSpWidth;

        public Form2()
        {
            InitializeComponent();
        }

        private void CancelButtom_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKButtom_Click(object sender, EventArgs e)
        {
            newWidth  =  (int)numericUpDownWidth.Value;
            newHeight = (int)numericUpDownHeight.Value;
            newSpWidth = (int)numericUpDownSpineWidth.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
