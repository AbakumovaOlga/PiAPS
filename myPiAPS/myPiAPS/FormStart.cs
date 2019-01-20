using myPiAPS_Model;
using myPiAPS_Service;
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
    public partial class FormStart : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMainService _serviceM;
        private readonly IUserService _serviceU;
        private User user;

        Logger logger;
        private string login;
        private string password;

        public FormStart(IMainService serviceM, IUserService serviceU)
        {
            _serviceM = serviceM;
            _serviceU = serviceU;
            InitializeComponent();
        }

        private void F_AsStorekeeper_Click(object sender, EventArgs e)
        {
            login = F_Login.Text;
            password = F_Password.Text;

            try
            {
                user = _serviceM.Author(login, password);


                var form = Container.Resolve<FormMainK>();
                form.Show();
                //this.Hide();
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

        private void F_CrUser_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<newUser>();
            form.Show();
        }

        private void F_AsManager_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormMainM>();
            form.Show();
        }

        private void F_Choose_Click(object sender, EventArgs e)
        {
            login = F_Login.Text;
            password = F_Password.Text;

            try
            {
                user = _serviceM.Author(login, password);

                if (user.Role == "кладовщик")
                {
                    var form = Container.Resolve<FormMainK>();
                    form.userId = user.Id;
                    form.logger = logger;
                    form.Show();
                }
                else
                {
                    if (user.Role == "руководитель")
                    {
                        var form = Container.Resolve<FormMainM>();
                        form.Show();
                        form.userId = user.Id;
                    }
                }
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            logger = new Logger();
        }
    }
}
