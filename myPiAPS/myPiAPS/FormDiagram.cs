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
    public partial class FormDiagram : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IProductService _serviceP;
        private readonly IProdGroupService _servicePG;

        private readonly IDiagrService _serviceD;
        public FormDiagram(IProdGroupService servicePG, IProductService serviceP, IDiagrService serviceD)
        {
            _serviceP = serviceP;
            _servicePG = servicePG;
            _serviceD = serviceD;
            InitializeComponent();
        }

        private void FormDiagram_Load(object sender, EventArgs e)
        {
            chart.Series.Clear();
            List<ProductGroupBM> groups = _servicePG.GetList();

            foreach(ProductGroupBM gr in groups)
            {
                chart.Series.Add(gr.Name);
                chart.Series[gr.Name].Points.AddY(_serviceD.CountProdGrop(gr.Id));
            }
            
        }
    }
}
