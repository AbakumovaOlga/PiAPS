﻿using myPiAPS_Service.BindingModels;
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
    public partial class FormWrite : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IProductService _serviceP;
        private readonly IProdGroupService _servicePG;
        private readonly IStockService _serviceS;

        private readonly IShopHallService _serviceSH;
        private readonly IWriteOffService _serviceW;
        public int Id { set { id = value; } }
        private int? id;

        private List<ProductWaybillBM> ProductWaybills;



        public FormWrite(IStockService serviceS, IProductService serviceP, IWriteOffService serviceW, IProdGroupService servicePG, IShopHallService serviceSH)
        {
            _serviceS = serviceS;
            _serviceP = serviceP;
            _servicePG = servicePG;
            _serviceW = serviceW;
            _serviceSH = serviceSH;
            InitializeComponent();
        }

        private void F_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
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
                    //   int k = Convert.ToInt32(F_Stock.SelectedValue);
                    _serviceW.CreateWriteOff(new WaybillBM
                    {
                        ///////////////
                        Date = F_Date.Value,
                        Summa = Convert.ToDouble(F_Summa.Text.Replace(",", ".")),
                        StockId = Convert.ToInt32(F_Stock.SelectedValue),
                        Customer = F_Customer.Text,
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
            s = s.Replace(",", ".");
            int k = s.IndexOf(".");
            Regex regexSumma = new Regex(@"^[0-9]{0,10}(?:[.,][0-9]{0,2})?\z");
            if (F_Summa.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля");
                return false;
            }
            else if (s.IndexOf(".") != -1)
            {
                if (s.Substring(0, s.LastIndexOf('.')).Length > 11)
                {
                    MessageBox.Show("Слишком длинное число. Не более 11 символов");
                    return false;
                }
                else
                {
                    if (regexSumma.IsMatch(F_Summa.Text))
                    {
                        summa = F_Summa.Text.Replace(",", ".");
                    }
                    else
                    {
                        MessageBox.Show("Несоответсвие формату Сумма");
                        return false;
                    }
                }
            }

            if (F_Customer.Text == "")
            {

                MessageBox.Show("Заполните покупателя");
                return false;
            }

            if (F_Stock.SelectedValue == null)
            {
                MessageBox.Show("Выберите Склад");
                return false;
            }


            return true;
        }

        private void F_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_SavePrint_Click(object sender, EventArgs e)
        {
            
        }

        private void FormWrite_Load(object sender, EventArgs e)
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

               /* List<ShopHallBM> listSH = _serviceSH.GetList();
                if (listSH != null)
                {
                    F_Stock.DisplayMember = "Name";
                    F_Stock.ValueMember = "Id";
                    F_Stock.DataSource = list;
                    F_Stock.SelectedItem = null;
                }

    */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (id.HasValue)
            {
                try
                {
                    WaybillBM view = _serviceW.GetElement(id.Value);
                    if (view != null)
                    {
                        ///////////////////
                        F_Date.Value = view.Date;
                        F_Stock.SelectedValue = view.StockId;
                        F_Customer.Text = view.Customer;
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

        private void F_Save_Click_1(object sender, EventArgs e)
        {

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
    }
}
