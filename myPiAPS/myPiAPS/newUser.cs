using myPiAPS_Model;
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
    public partial class newUser : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IUserService _serviceU;
        public newUser(IUserService serviceU)
        {
            _serviceU = serviceU;
            InitializeComponent();
        }

        private void F_OK_Click(object sender, EventArgs e)
        {
            try
            {
                    _serviceU.CreateUser(new User
                    {
                        Login = F_Login.Text,
                        Password = F_Rassword.Text,
                        FIO = F_FIO.Text,
                        Role=F_Role.Text
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
