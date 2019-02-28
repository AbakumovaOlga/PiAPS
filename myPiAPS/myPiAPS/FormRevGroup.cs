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
    public partial class FormRevGroup : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IRevalService _serviceRV;
        private readonly IProdGroupService _servicePG;
        private readonly IMainService _serviceM;


        private List<ProductWaybillBM> ProductWaybills;


        public FormRevGroup(IProdGroupService servicePG, IMainService serviceM, IRevalService serviceRV)
        {
            _serviceRV = serviceRV;
            _servicePG = servicePG;
            _serviceM = serviceM;
            InitializeComponent();
        }

        private void F_RevAll_Click(object sender, EventArgs e)
        {
            //  ProductWaybills = new List<ProductWaybillBM>();
            /*  ProductWaybillBM model = new ProductWaybillBM
              {
                  ProductId = Convert.ToInt32(F_Name.SelectedValue)
              };

              ProductWaybills.Add(model);*/

            List<ProductBM> list = _serviceM.Sort(Convert.ToInt32(F_Group.SelectedValue));
            ProductWaybills.Clear();
            foreach (ProductBM p in list)
            {
                ProductWaybills.Add(new ProductWaybillBM
                {
                    ProductId = p.Id,
                    Count = _serviceRV.CalcCount(p.Id)
                });
            }
            if (ProductWaybills.Count == 0)
            {
                MessageBox.Show("Список продуктов пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                _serviceRV.CreateRevalGroup(new WaybillBM
                {
                    Date = F_Date.Value,
                    Summa = Convert.ToInt32(F_Summa.Text.Replace(".", ",")),
                    Koef = Convert.ToDouble(F_Coeff.Text.Replace(".", ",")),
                    ProductWaybills = ProductWaybillBM
                }, Convert.ToDouble(F_Coeff.Text.Replace(".", ",")));

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
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

        private void FormRevGroup_Load(object sender, EventArgs e)
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

            ProductWaybills = new List<ProductWaybillBM>();


        }

        private void F_Show_Click(object sender, EventArgs e)
        {
            if (F_Group.SelectedValue == null) return;
            try
            {
                List<ProductBM> list = _serviceM.Sort(Convert.ToInt32(F_Group.SelectedValue));
                if (list != null)
                {
                    F_ListProd.DataSource = list;

                    //  F_ListProd.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Calc_Click(object sender, EventArgs e)
        {
            if (CheckFormR())
            {
                ProductWaybills = new List<ProductWaybillBM>();
                List<ProductBM> list = _serviceM.Sort(Convert.ToInt32(F_Group.SelectedValue));

                foreach (ProductBM p in list)
                {
                    ProductWaybills.Add(new ProductWaybillBM
                    {
                        ProductId = p.Id
                    });
                }


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


                F_Summa.Text = _serviceRV.CalcSumGroup(new WaybillBM
                {
                    Date = F_Date.Value,
                    ProductWaybills = ProductWaybillBM
                }, Convert.ToDouble(F_Coeff.Text.Replace(".", ","))) + "";
            }
        }

        private bool CheckFormR()
        {
            if (F_Group.SelectedValue == null)
            {
                MessageBox.Show("Выберите грппу");
                return false;
            }

            //koef
            string koef;
            string ko = F_Coeff.Text;
            ko = ko.Replace(".", ",");
            int k2 = ko.IndexOf(",");
            Regex regexCoef = new Regex(@"^[0-9]{0,10}(?:[.,][0-9]{0,2})?\z");
            if (F_Coeff.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля");
                return false;
            }
            if (F_Coeff.Text.Length > 8)
            {
                MessageBox.Show("Слишком длинное число. Не более 5 знаков до запятой");
                return false;
            }
            else if (ko.IndexOf(",") != -1)
            {
                if (ko.Substring(0, ko.LastIndexOf(',')).Length > 5)
                {
                    MessageBox.Show("Слишком длинное число. Не более 5 знаков до запятой");
                    return false;
                }
            }
            if (regexCoef.IsMatch(F_Coeff.Text))
            {
                koef = F_Coeff.Text.Replace(".", ",");
            }
            else
            {
                MessageBox.Show("Несоответсвие формату коэф");
                return false;
            }


            return true;
        }

        private bool CheckForm()
        {
            //sum
            string summa;
            string s = F_Summa.Text;
            s = s.Replace(".", ",");
            int k = s.IndexOf(",");
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

            if (F_Group.SelectedValue == null)
            {
                MessageBox.Show("Выберите грппу");
                return false;
            }

            //koef
            string koef;
            string ko = F_Coeff.Text;
            ko =ko.Replace(".", ",");
            int k2 = ko.IndexOf(",");
            Regex regexCoef = new Regex(@"^[0-9]{0,10}(?:[.,][0-9]{0,2})?\z");
            if (F_Coeff.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля");
                return false;
            }
            if (F_Coeff.Text.Length > 8)
            {
                MessageBox.Show("Слишком длинное число. Не более 5 знаков до запятой");
                return false;
            }
            else if (ko.IndexOf(",") != -1)
            {
                if (ko.Substring(0, ko.LastIndexOf(',')).Length > 5)
                {
                    MessageBox.Show("Слишком длинное число. Не более 5 знаков до запятой");
                    return false;
                }
            }
            if (regexCoef.IsMatch(F_Coeff.Text))
            {
                koef = F_Coeff.Text.Replace(".", ",");
            }
            else
            {
                MessageBox.Show("Несоответсвие формату коэф");
                return false;
            }


            return true;
        }

        private void F_Print_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPrint>();
            form.Show();
        }
    }
}
