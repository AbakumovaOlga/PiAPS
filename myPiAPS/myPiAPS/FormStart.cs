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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void F_AsStorekeeper_Click(object sender, EventArgs e)
        {
            var form = new FormMainK();
            form.Show();
        }

        private void F_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
