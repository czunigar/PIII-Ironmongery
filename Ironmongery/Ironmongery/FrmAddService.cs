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
    public partial class FrmAddService : Form
    {
        private EService service;
        private ServiceBO sbo;
        private Messages message;

        public FrmAddService(EService serv)
        {
            InitializeComponent();
            service = serv;
            sbo = new ServiceBO();
            message = new Messages();
            lblTitle.Text = "EDIT SERVICE";
            LoadData();
        }

        public FrmAddService()
        {
            InitializeComponent();
            service = new EService();
            sbo = new ServiceBO();
            message = new Messages();
            lblTitle.Text = "NEW SERVICE";
            lblId.Visible = false;
            txtId.Visible = false;
        }

        /*Method to load all the services' data*/
        private void LoadData()
        {
            try
            {
                txtId.Text = service.Id.ToString();
                txtName.Text = service.Name;
                txtDesc.Text = service.Description;
                txtPrice.Text = service.Price.ToString();
                cboCat.SelectedValue = service.Category;

            }
            catch (Exception)
            {
                message.notification("Imposible to retrieve the information");
            }
        }

        private static FrmAddService Instance = null;
        public static FrmAddService AddInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new FrmAddService();
                    Instance.Disposed += new EventHandler(AddServiceDispose);
                }
                return Instance;
            }
        }

        /*Method to create a new window which will receive a user*/
        public static FrmAddService EditInstance(EService serv)
        {

            if (Instance == null)
            {
                Instance = new FrmAddService(serv);
                Instance.Disposed += new EventHandler(AddServiceDispose);
            }
            return Instance;

        }

        public static void AddServiceDispose(object sender, EventArgs e)
        {
            Instance = null;
        }

        /*Method to save the service*/
        private void Save()
        {
            try
            {
                service.Name = txtName.Text;
                service.Category = (string)cboCat.SelectedValue;
                service.Description = txtDesc.Text;
                service.Price = decimal.Parse(txtPrice.Text);
                sbo.Save(service);

            }
            catch (Exception)
            {

                message.notification("Imposible to save the data");
            }
        }

        /*Method to clean up the data*/
        private void Clean()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            cboCat.SelectedItem = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                eName.SetError(txtName, "Name is missing");
            }
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                eDesc.SetError(txtDesc, "Description is missing");
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                ePrice.SetError(txtPrice, "Price is missing");
            }
            if (cboCat.SelectedItem == null)
            {
                eCat.SetError(cboCat, "Category is missing");
            }
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtDesc.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text) && cboCat.SelectedItem != null)
            {
                Save();
                Clean();
                message.notification("Service save successfully");
            }
        }
    }
}
