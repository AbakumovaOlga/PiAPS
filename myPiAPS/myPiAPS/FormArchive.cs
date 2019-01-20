using myPiAPS_Service;
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
    public partial class FormArchive : Form
    {
        ///  private readonly IUserService _service;
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ISerializeMYService _serviceS;

        public int userId { get; set; }

        private Logger logger = new Logger();
        private int termArchive = 2;
        private DateTime now = DateTime.Now.Date;

        public FormArchive(ISerializeMYService serviceS)
        {
            _serviceS = serviceS;
            InitializeComponent();
           
           
        }

        private void FormArchive_Load(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Сделать резервную копию?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog { Filter = "Json files (*.json)|*.json|Word files (*.doc)|*.doc" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamWriter writer = new StreamWriter(sfd.FileName);
                        writer.WriteLine(_serviceS.GetDataFromStookKeeper(now.AddDays(-termArchive)));
                        writer.Dispose();

                        logger.Log("Архивирование данных кладовщиком id="+userId+". Файл: " + Path.GetFileName(sfd.FileName));

                        MessageBox.Show("Данные сохранены успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }
    }
}
