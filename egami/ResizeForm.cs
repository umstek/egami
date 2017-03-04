using System;
using System.Drawing;
using System.Windows.Forms;

namespace egami
{
    public partial class ResizeForm : Form
    {
        public ResizeForm()
        {
            InitializeComponent();
        }

        private void radioButtonScale2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxScale.Enabled = !(trackBarScale2.Enabled = radioButtonScale2.Checked);
        }

        private void radioButtonScale_CheckedChanged(object sender, EventArgs e)
        {
            trackBarScale2.Enabled = !(groupBoxScale.Enabled = radioButtonScale.Checked);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Tag = Resizer.Resize2((Image) Tag, (sbyte) trackBarScale2.Value);
            DialogResult = DialogResult.OK;
        }
    }
}