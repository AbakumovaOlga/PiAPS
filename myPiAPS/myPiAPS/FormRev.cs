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
            if (CheckForm())
            {
                ProductWaybills = new List<ProductWaybillBM>();
                ProductWaybillBM model = new ProductWaybillBM
                {
                    ProductId = Convert.ToInt32(F_Name.SelectedValue),
                    Count = _serviceRev.CalcCount(Convert.ToInt32(F_Name.SelectedValue))

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
                    }, Convert.ToDouble(F_Price.Text.Replace(",", ".")));

                    MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
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

            

            if (F_Name.SelectedValue == null)
            {
                MessageBox.Show("Выберите Товар");
                return false;
            }
            //sum
            string price;
            string p = F_Price.Text;
            p = p.Replace(".", ",");
            int kp = p.IndexOf(",");
            Regex regexPrice = new Regex(@"^[0-9]{0,10}(?:[.,][0-9]{0,2})?\z");
            if (F_Price.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля");
                return false;
            }
            if (F_Price.Text.Length>11)
            {
                MessageBox.Show("Слишком длинное число. Не более 11 символов");
                return false;
            }
            else if (p.IndexOf(",") != -1)
            {
                if (p.Substring(0, p.LastIndexOf(',')).Length > 11)
                {
                    MessageBox.Show("Слишком длинное число. Не более 11 символов");
                    return false;
                }
            }
            if (regexPrice.IsMatch(F_Price.Text))
            {
                price = F_Price.Text.Replace(".", ",");
            }
            else
            {
                MessageBox.Show("Несоответсвие формату Цена");
                return false;
            }


            return true;

        }

        private void F_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_RevGroup_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRevGroup>();
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
            if (CheckFormR())
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

                    F_Summa.Text = _serviceRev.CalcSum(new WaybillBM
                    {
                        Date = F_Date.Value,
                        ProductWaybills = ProductWaybillBM
                    }, Convert.ToDouble(F_Price.Text.Replace(".", ","))) + "";
                }
            }
        }

        private bool CheckFormR()
        {
            if (F_Name.SelectedValue == null)
            {
                MessageBox.Show("Выберите Товар");
                return false;
            }
            //sum
            string price;
            string p = F_Price.Text;
            p = p.Replace(".", ",");
            int kp = p.IndexOf(".");
            Regex regexPrice = new Regex(@"^[0-9]{0,10}(?:[.,][0-9]{0,2})?\z");
            if (F_Price.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля");
                return false;
            }
            if (F_Price.Text.Length > 11)
            {
                MessageBox.Show("Слишком длинное число. Не более 11 символов");
                return false;
            }

            if (p.IndexOf(",") != -1)
            {
                if (p.Substring(0, p.LastIndexOf(',')).Length > 11)
                {
                    MessageBox.Show("Слишком длинное число. Не более 11 символов");
                    return false;
                }
            }
            if (regexPrice.IsMatch(F_Price.Text))
            {
                price = F_Price.Text.Replace(".", ",");
            }
            else
            {
                MessageBox.Show("Несоответсвие формату Цена");
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
