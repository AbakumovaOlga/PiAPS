using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPiAPS
{
    public partial class FormRevGroup : Form
    {
        public FormRevGroup()
        {
            InitializeComponent();
        }

        private void F_RevAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
        }

        private void F_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
