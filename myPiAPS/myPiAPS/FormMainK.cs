using myPiAPS_Service;
using myPiAPS_Service.BindingModels;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace myPiAPS
{
    public partial class FormMainK : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IProductService _serviceP;
        private readonly IProdGroupService _servicePG;
        private readonly IMainService _serviceM;
        private readonly ISerializeMYService _serviceS;

        public int userId { get; set; }
        public Logger logger;
        private int termArchive = 2;
        private DateTime now = DateTime.Now.Date;

        public FormMainK(IProductService serviceP, IProdGroupService servicePG, IMainService serviceM, ISerializeMYService serviceS)
        {
            _serviceP = serviceP;
            _servicePG = servicePG;
            _serviceM = serviceM;
            _serviceS = serviceS;

            InitializeComponent();
        }

        private void F_Receipt_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReceipt>();
            form.Show();
        }

        private void F_Less_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormLess>();
            form.Show();
        }

        private void F_Delivary_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormDelivary>();
            form.Show();
        }

        private void F_Write_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormWrite>();
            form.Show();
        }

        private void F_Rev_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRev>();
            form.Show();
        }

        private void F_Archive_Click(object sender, EventArgs e)
        {
            /*  var form = Container.Resolve<FormArchive>();
              form.userId = userId;
              form.Show();*/
            if (MessageBox.Show("Сделать резервную копию?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog { Filter = "Json files (*.json)|*.json|Word files (*.doc)|*.doc" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamWriter writer = new StreamWriter(sfd.FileName);
                        writer.WriteLine(_serviceS.GetDataFromStookKeeper(now.AddDays(-termArchive)));
                        writer.Dispose();

                        logger.Log("Архивирование данных кладовщиком id=" + userId + ". Файл: " + Path.GetFileName(sfd.FileName));

                        MessageBox.Show("Данные сохранены успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void F_Find_Click(object sender, EventArgs e)
        {
            if (F_Number.Text == "") return;
            try
            {
                List<ProductBM> list = _serviceM.FindProd(F_Number.Text);
                if (list != null)
                {
                    F_GoodsList.DataSource = list;
                    F_GoodsList.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Sum_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSumToday>();
            form.Show();
        }

        private void F_Diagram_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormDiagram>();
            form.Show();
        }

        private void F_SumDeliv_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSumDeliv>();
            form.Show();
        }

        private void F_Print_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPrint>();
            form.Show();
        }

        private void FormMainK_Load(object sender, EventArgs e)
        {
            try
            {
                List<ProductBM> list = _serviceP.GetList();
                if (list != null)
                {
                    F_GoodsList.DataSource = list;
                    F_GoodsList.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                List<ProductGroupBM> list = _servicePG.GetListComboBox();
                if (list != null)
                {
                    F_ChooseGrop.DisplayMember = "Name";
                    F_ChooseGrop.ValueMember = "Id";
                    F_ChooseGrop.DataSource = list;
                    F_ChooseGrop.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Load_Click(object sender, EventArgs e)
        {
            try
            {
                List<ProductBM> list = _serviceP.GetList();
                if (list != null)
                {
                    F_GoodsList.DataSource = list;
                    F_GoodsList.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            F_ChooseGrop.SelectedItem = null;
            F_Number.Text = "";
        }

        private void F_GropFind_Click(object sender, EventArgs e)
        {
            if (F_ChooseGrop.SelectedValue == null) return;
            try
            {
                List<ProductBM> list = _serviceM.Sort(Convert.ToInt32(F_ChooseGrop.SelectedValue));
                if (list != null)
                {
                    F_GoodsList.DataSource = list;
                    F_GoodsList.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
