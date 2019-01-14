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
    public partial class FormRev : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IProductService _serviceP;
        //   private readonly IProdGroupService _servicePG;
        // private readonly IStockService _serviceS;
        private readonly IRevalService _serviceRev;
        public int Id { set { id = value; } }
        private int? id;
        private List<ProductWaybillBM> ProductWaybills;

        public FormRev(IProductService serviceP, IRevalService serviceRev)
        {
            _serviceRev = serviceRev;
            _serviceP = serviceP;
            InitializeComponent();
        }

        private void F_Rev_Click(object sender, EventArgs e)
        {
            ProductWaybills = new List<ProductWaybillBM>();
            ProductWaybillBM model = new ProductWaybillBM
            {
                ProductId = Convert.ToInt32(F_Name.SelectedValue)
            };
            ProductWaybills.Add(model);
            List<ProductWaybillBM> ProductWaybillBM = new List<ProductWaybillBM>();
            for (int i = 0; i < ProductWaybills.Count; ++i)
            {
                ProductWaybillBM.Add(new ProductWaybillBM
                {
                    Id = ProductWaybills[i].Id,
                    ProductId = ProductWaybills[i].ProductId,
                    WaybillId = ProductWaybills[i].WaybillId,
                    Count = ProductWaybills[i].Count
                });
            }
            try
            {
                _serviceRev.CreateReval(new WaybillBM
                {
                    Date = F_Date.Value,
                    Summa = Convert.ToInt32(F_Summa.Text),
                    ProductWaybills = ProductWaybillBM
                }, Convert.ToDouble(F_Price.Text));

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void FormRev_Load(object sender, EventArgs e)
        {
            try
            {
                List<ProductBM> list = _serviceP.GetList();
                if (list != null)
                {
                    F_Name.DisplayMember = "Name";
                    F_Name.ValueMember = "Id";
                    F_Name.DataSource = list;
                    F_Name.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Calc_Click(object sender, EventArgs e)
        {
            ProductWaybills = new List<ProductWaybillBM>();
            ProductWaybillBM model = new ProductWaybillBM
            {
                ProductId = Convert.ToInt32(F_Name.SelectedValue)
            };
            ProductWaybills.Add(model);


            List<ProductWaybillBM> ProductWaybillBM = new List<ProductWaybillBM>();
            for (int i = 0; i < ProductWaybills.Count; ++i)
            {
                ProductWaybillBM.Add(new ProductWaybillBM
                {
                    Id = ProductWaybills[i].Id,
                    ProductId = ProductWaybills[i].ProductId,
                    WaybillId = ProductWaybills[i].WaybillId,
                    Count = ProductWaybills[i].Count
                });
            }

            F_Summa.Text = _serviceRev.CalcSum(new WaybillBM
            {
                Date = F_Date.Value,
                ProductWaybills = ProductWaybillBM
            }, Convert.ToDouble(F_Price.Text)) + "";
        }
    }
}
