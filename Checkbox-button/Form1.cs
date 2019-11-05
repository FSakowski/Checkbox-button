using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxBtn1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = $"Checkbox (1) changed to {checkBoxBtn1.Checked}";
        }

        private void checkBoxBtn2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = $"Checkbox (2) changed to {checkBoxBtn2.Checked}";
        }
    }
}
