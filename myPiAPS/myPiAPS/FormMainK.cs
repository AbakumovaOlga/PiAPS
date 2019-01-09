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
    public partial class FormMainK : Form
    {
        public FormMainK()
        {
            InitializeComponent();
        }

        private void F_Receipt_Click(object sender, EventArgs e)
        {
            var form = new FormReceipt();
            form.Show();
        }

        private void F_Less_Click(object sender, EventArgs e)
        {
            var form = new FormLess();
            form.Show();
        }

        private void F_Delivary_Click(object sender, EventArgs e)
        {
            var form = new FormDelivary();
            form.Show();
        }

        private void F_Write_Click(object sender, EventArgs e)
        {
            var form = new FormWrite();
            form.Show();
        }

        private void F_Rev_Click(object sender, EventArgs e)
        {
            var form = new FormRev();
            form.Show();
        }

        private void F_Archive_Click(object sender, EventArgs e)
        {
            var form = new FormArchive();
            form.Show();
        }

        private void F_Find_Click(object sender, EventArgs e)
        {

        }

        private void F_Sum_Click(object sender, EventArgs e)
        {
            var form = new FormSumToday();
            form.Show();
        }

        private void F_Diagram_Click(object sender, EventArgs e)
        {
            var form = new FormDiagram();
            form.Show();
        }

        private void F_SumDeliv_Click(object sender, EventArgs e)
        {
            var form = new FormSumDeliv();
            form.Show();
        }

        private void F_Print_Click(object sender, EventArgs e)
        {
            var form = new FormPrint();
            form.Show();
        }
    }
}
