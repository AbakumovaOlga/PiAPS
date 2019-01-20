using myPiAPS_Service.BindingModels;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace myPiAPS
{
    public partial class FormReceipt : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IProductService _serviceP;
        private readonly IProdGroupService _servicePG;
        private readonly IStockService _serviceS;
        private readonly IRecieptService _serviceR;
        public int Id { set { id = value; } }
        private int? id;

        private List<ProductWaybillBM> ProductWaybills;

        public FormReceipt(IStockService serviceS, IProductService serviceP, IRecieptService serviceR,IProdGroupService servicePG)
        {
            _serviceS = serviceS;
            _serviceP = serviceP;
            _servicePG = servicePG;
            _serviceR = serviceR;
            InitializeComponent();
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                /* if (string.IsNullOrEmpty(.Text))
                 {
                     MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
                 if (string.IsNullOrEmpty(FCakePrice.Text))
                 {
                     MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
                 if (CakeIngredients == null || CakeIngredients.Count == 0)
                 {
                     MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }*/
                try
                {
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
                    /*if (id.HasValue)
                    {
                        service.UpdElement(new CakeBindingModel
                        {
                            Id = id.Value,
                            CakeName = FCakeName.Text,
                            Price = Convert.ToInt32(FCakePrice.Text),
                            CakeIngredients = CakeIngredientBM
                        });
                    }
                    else
                    {*/
                    if (ProductWaybillBM.Count == 0)
                    {
                        MessageBox.Show("Список продуктов пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int k = Convert.ToInt32(F_Stock.SelectedValue);
                    _serviceR.CreateReciept(new WaybillBM
                    {
                        ///////////////
                        Date = F_Date.Value,
                        Summa = Convert.ToDouble(F_Summa.Text.Replace(".", ",")),
                        StockId = Convert.ToInt32(F_Stock.SelectedValue),
                        ProductWaybills = ProductWaybillBM
                    });
                    //  }
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

        private bool CheckForm()
        {
            //sum
            string summa;
            string s = F_Summa.Text;
            s = s.Replace(".", ",");
            int kk = s.IndexOf(",");
            Regex regexSumma = new Regex(@"^[0-9]{0,10}(?:[.,][0-9]{0,2})?\z");
            if (F_Summa.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля");
                return false;
            }
            if (F_Summa.Text.Length > 11)
            {
                MessageBox.Show("Слишком длинное число. Не более 11 символов");
                return false;
            }
            else if (s.IndexOf(",") != -1)
            {
                if (s.Substring(0, s.LastIndexOf(',')).Length > 8)
                {
                    MessageBox.Show("Слишком длинное число. Не более 8 знаков до запятой");
                    return false;
                }
            }
            if (regexSumma.IsMatch(F_Summa.Text))
            {
                summa = F_Summa.Text.Replace(".", ",");
            }
            else
            {
                MessageBox.Show("Несоответсвие формату Сумма");
                return false;
            }

            if (F_Stock.SelectedValue == null)
            {
                MessageBox.Show("Выберите Склад");
                return false;
            }
           

            return true;
        }

        private void LoadData()
        {
            try
            {
                if (ProductWaybills != null)
                {
                    F_Products.DataSource = null;
                    F_Products.DataSource = ProductWaybills;
                    //F_Products.Columns[0].Visible = false;
                    //  F_Products.Columns[1].Visible = false;
                    //   F_Products.Columns[2].Visible = false;
                    // F_Products.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    double sum = 0;
                    foreach (ProductWaybillBM prW in ProductWaybills)
                    {
                        sum += _serviceP.GetElement(prW.ProductId).Price * prW.Count;
                    }
                    F_Summa.Text = sum + "";
                }
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

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                List<StockBM> list = _serviceS.GetList();
                if (list != null)
                {
                    F_Stock.DisplayMember = "Name";
                    F_Stock.ValueMember = "Id";
                    F_Stock.DataSource = list;
                    F_Stock.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (id.HasValue)
            {
                try
                {
                    WaybillBM view = _serviceR.GetElement(id.Value);
                    if (view != null)
                    {
                        ///////////////////
                        F_Date.Value = view.Date;
                        F_Stock.SelectedValue = view.StockId;
                        // FCakePrice.Text = view.Price.ToString();
                        ProductWaybills = view.ProductWaybills;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ProductWaybills = new List<ProductWaybillBM>();
            }
        }

        private void F_Add_Click(object sender, EventArgs e)
        {
          //  F_NewGroup.Text = "";
        }

        private void F_AddProd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormProductWaybill>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.model != null)
                {
                    if (id.HasValue)
                    {
                        form.model.Id = id.Value;
                    }
                    ProductWaybills.Add(form.model);
                }
                LoadData();
            }
        }

        private void FCakeDel_Click(object sender, EventArgs e)
        {
            if (F_Products.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ProductWaybills.RemoveAt(F_Products.SelectedRows[0].Cells[0].RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
    }
}
