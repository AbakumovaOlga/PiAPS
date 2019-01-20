using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace myPiAPS
{
    public partial class FormMainM : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }


        public int userId { get; set; }

        public FormMainM()
        {
            InitializeComponent();
        }

        private void F_CrProduct_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<newProduct>();
            form.Show();
        }

        private void F_CrProdGr_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<newPrGroup>();
            form.Show();
        }

        private void F_CrUser_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<newUser>();
            form.Show();
        }

        private void F_CrType_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<newType>();
            form.Show();
        }

        private void F_CrStock_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<newStock>();
            form.Show();
        }

        private void F_CrSH_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<newShopHall>();
            form.Show();
        }

        private void FormMainM_Load(object sender, EventArgs e)
        {

        }
    }
}
