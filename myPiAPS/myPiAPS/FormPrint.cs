using myPiAPS_Model;
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
    public partial class FormPrint : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ITypeOfWaybillService _serviceT;
        private readonly IWaybillService _serviceW;
        public FormPrint(ITypeOfWaybillService serviceT, IWaybillService serviceW)
        {
            _serviceT= serviceT;
            _serviceW = serviceW;
            InitializeComponent();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            try
            {
                List<TypeBM> list = _serviceT.GetList();
                if (list != null)
                {
                    F_Type.DisplayMember = "Type";
                    F_Type.ValueMember = "Id";
                    F_Type.DataSource = list;
                    F_Type.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                List<WaybillBM> list = _serviceW.GetList();
                if (list != null)
                {
                    F_DocList.DataSource = list;
                   // F_DocList.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Find_Click(object sender, EventArgs e)
        {
            if (F_Number.Text == "") return;
            try
            {
                List<WaybillBM> list = _serviceW.FindWaybill(Convert.ToInt32(F_Number.Text));
                if (list != null)
                {
                    F_DocList.DataSource = list;
                   // F_DocList.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Sort_Click(object sender, EventArgs e)
        {
            if (F_Type.SelectedValue == null) return;
            try
            {
                List<WaybillBM> list = _serviceW.Sort(Convert.ToInt32(F_Type.SelectedValue));
                if (list != null)
                {
                    F_DocList.DataSource = list;
                   // F_DocList.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_All_Click(object sender, EventArgs e)
        {
            try
            {
                List<WaybillBM> list = _serviceW.GetList();
                if (list != null)
                {
                    F_DocList.DataSource = list;
                    // F_DocList.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            F_Number.Text = "";
            F_Type.SelectedItem = null;
        }

        private void F_DocList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (F_DocList.SelectedRows.Count != 1)
            {
                return;
            }
            int id = Convert.ToInt32(F_DocList.SelectedRows[0].Cells[0].Value);
            PrintDoc(id);
        }

        private void PrintDoc(int id)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "doc|*.doc|docx|*.docx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //CreateDoc(sfd.FileName);

                    if (_serviceW.PrintWaybill(sfd.FileName,id))
                    {
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("не удалось сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
