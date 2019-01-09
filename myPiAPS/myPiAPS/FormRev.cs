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
    public partial class FormRev : Form
    {
        public FormRev()
        {
            InitializeComponent();
        }

        private void F_Rev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
        }

        private void F_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_RevGroup_Click(object sender, EventArgs e)
        {
            var form = new FormRevGroup();
            form.Show();
        }
    }
}
