using myPiAPS_Service.BindingModels;
using myPiAPS_Service.Interfaces;
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
    public partial class newShopHall : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IShopHallService _serviceSH;
        public newShopHall(IShopHallService serviceSH)
        {
            InitializeComponent();
            _serviceSH = serviceSH;
        }

        private void F_OK_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceSH.CreateShopHall(new ShopHallBM
                {
                    Name = F_Name.Text
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newShopHall_Load(object sender, EventArgs e)
        {

        }
    }
}
