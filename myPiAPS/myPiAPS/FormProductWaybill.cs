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
    public partial class FormProductWaybill : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IProductService _serviceP;
        public ProductWaybillBM model { set; get; }
        public FormProductWaybill(IProductService serviceP)
        {
            _serviceP = serviceP;
            InitializeComponent();
        }

        private void FormProductWaybillBM_Load(object sender, EventArgs e)
        {
            try
            {
                List<ProductBM> list = _serviceP.GetList();
                if (list != null)
                {
                    F_Product.DisplayMember = "Name";
                    F_Product.ValueMember = "Id";
                    F_Product.DataSource = list;
                    F_Product.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*if (model != null)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedValue = model.IngredientId;
                FCINumber.Text = model.Count.ToString();
            }*/
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(F_Count.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (F_Product.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                model = new ProductWaybillBM
                {
                    ProductId = Convert.ToInt32(F_Product.SelectedValue),
                    Count = Convert.ToInt32(F_Count.Text)
                };

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
