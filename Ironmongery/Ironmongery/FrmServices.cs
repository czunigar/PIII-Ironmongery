using BoLayer;
using EntityLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ironmongery
{
    public partial class FrmServices : Form
    {
        private ServiceBO sbo;
        private Messages message;
        private FrmAddService editService;
        private Form parent;

        public FrmServices(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            sbo = new ServiceBO();
            message = new Messages();
            btnCancel.Visible = false;
        }
        public FrmServices()
        {
            InitializeComponent();
            sbo = new ServiceBO();
            message = new Messages();
            btnCancel.Visible = false;
        }

        /*Method to load all the services*/
        public void LoadServices()
        {
            dgvServices.DataSource = null;
            dgvServices.DataSource = sbo.loadServices(txtSearch.Text.ToUpper());
        }

        /*Method to pick up the select service*/
        private EService selected()
        {
            EService serv = new EService();
            int row = dgvServices.CurrentCell.RowIndex;
            if (row < 0)
            {
                return null;
            }
            serv = sbo.GetServiceById((int)dgvServices.Rows[row].Cells["Id"].Value);
            return serv;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddService.AddInstance.MdiParent = this;
            this.scServices.Panel2.Controls.Add(FrmAddService.AddInstance);
            FrmAddService.AddInstance.Show();
            dgvServices.Visible = false;
            btnCancel.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServices.CurrentCell.Value != null)
                {
                    this.editService = FrmAddService.EditInstance(selected());
                    editService.MdiParent = this;
                    this.scServices.Panel2.Controls.Add(this.editService);
                    this.editService.Show();
                    dgvServices.Visible = false;
                    btnCancel.Visible = true;
                }
                else
                {
                    message.notification("Please choose a service");
                }
            }
            catch (Exception)
            {

                message.notification("Imposible to proceed");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServices.CurrentCell.Value != null)
                {
                    Question.notification($"Do you want to delete the service: {selected().Name}?");
                    if (Question.Answer == 1)
                    {
                        sbo.Delete(selected().Id);
                        message.notification("Service deleted");
                        LoadServices();
                    }
                }
                else
                {
                    message.notification("Please choose a service");
                }
            }
            catch (Exception)
            {

                message.notification("Imposible to proceed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmAddService.AddInstance.Close();
            dgvServices.Visible = true;
            btnCancel.Visible = false;
            LoadServices();
        }

        private static FrmServices Instance = null;
        public static FrmServices AddInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new FrmServices();
                    Instance.Disposed += new EventHandler(ServiceDispose);
                }
                return Instance;
            }
        }

        public static void ServiceDispose(object sender, EventArgs e)
        {
            Instance = null;
        }

        private void FrmServices_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            frm.Visible = true;
            this.Visible = false;
        }
    }
}
