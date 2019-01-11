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
    public partial class newType : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ITypeOfWaybillService _serviceT;

        public newType(ITypeOfWaybillService serviceT)
        {
            _serviceT = serviceT;
            InitializeComponent();
        }

        private void F_OK_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceT.CreateType(new TypeBM
                {
                    Type = F_Type.Text
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
    }
}
