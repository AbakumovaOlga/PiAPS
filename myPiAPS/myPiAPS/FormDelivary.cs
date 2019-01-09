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
    public partial class FormDelivary : Form
    {
        public FormDelivary()
        {
            InitializeComponent();
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
        }

        private void F_SavePrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save: Success");
            //отчет расходная накладная
        }

        private void F_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
