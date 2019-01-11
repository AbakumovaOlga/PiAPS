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
using myPiAPS_Model;
using myPiAPS_Service.Interfaces;
using myPiAPS_Service.BindingModels;

namespace myPiAPS
{
    public partial class newPrGroup : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IProdGroupService _servicePG;
        public newPrGroup(IProdGroupService servicePG)
        {
            _servicePG = servicePG;
            InitializeComponent();
        }

        private void F_OK_Click(object sender, EventArgs e)
        {
            try
            {
                _servicePG.CreateProdGroup(new ProductGroupBM
                {
                    Name = F_Name.Text,
                    Norm =Convert.ToInt32(F_Norm.Text)
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
    }
}
