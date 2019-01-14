using myPiAPS_Model;
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
    public partial class newProduct : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IProductService _serviceP;
        private readonly IProdGroupService _servicePG;

        public newProduct(IProductService serviceP, IProdGroupService servicePG)
        {
            _serviceP = serviceP;
            _servicePG = servicePG;
            InitializeComponent();
        }

        private void F_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(F_Name.Text))
                {
                    MessageBox.Show("Заполните поле mane", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (F_Group.SelectedValue == null)
                {
                    MessageBox.Show("Выберите group", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _serviceP.CreateProduct(new ProductBM
                {
                    Name = F_Name.Text,
                    Price = Convert.ToDouble(F_Price.Text),
                    ProdGroupId = Convert.ToInt32(F_Group.SelectedValue),
                    Number=F_Number.Text                    
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

        private void newProduct_Load(object sender, EventArgs e)
        {
            try
            {
                List<ProductGroupBM> list = _servicePG.GetListComboBox();
                if (list != null)
                {
                    F_Group.DisplayMember = "Name";
                    F_Group.ValueMember = "Id";
                    F_Group.DataSource = list;
                    F_Group.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           /*редактирование
            *if (model != null)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedValue = model.IngredientId;
                FCINumber.Text = model.Count.ToString();
            }*/
        }
    }
}
