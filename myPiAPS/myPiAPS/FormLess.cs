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
    public partial class FormLess : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IProductService _serviceP;
        private readonly IProdGroupService _servicePG;
        private readonly IMainService _serviceM;
        private readonly IWaybillService _serviceW;

        public FormLess(IMainService serviceM, IWaybillService serviceW)
        {
            _serviceM = serviceM;
            _serviceW = serviceW;
            InitializeComponent();
        }

        private void FormLess_Load(object sender, EventArgs e)
        {
            try
            {
                List<ProductBM> list = _serviceM.Less();
                if (list != null)
                {
                    F_Products.DataSource = list;
                    //F_TodayList.Columns[0].Visible = false;
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
