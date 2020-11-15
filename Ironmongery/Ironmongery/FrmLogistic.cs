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
    public partial class FrmLogistic : Form
    {
        private LogisticBO lbo;
        private Messages message;
        private FrmAddTruck editTruck;

        public FrmLogistic()
        {
            InitializeComponent();
            lbo = new LogisticBO();
            message = new Messages();
            btnCancel.Visible = false;
        }

        /*Method to load all the trucks*/
        public void LoadTrucks()
        {
            dgvLogic.DataSource = null;
            dgvLogic.DataSource = lbo.loadTravels(txtSearch.Text.ToUpper());
        }

        /*Method to pick up the select truck*/
        private ELogistic Selected()
        {
            ELogistic truck = new ELogistic();
            int row = dgvLogic.CurrentCell.RowIndex;
            if (row < 0)
            {
                return null;
            }
            truck = lbo.GetTruck((int)dgvLogic.Rows[row].Cells["Id"].Value);
            return truck;
        }

        private void Busy()
        {
            List<ELogistic> drivers = new List<ELogistic>();
            foreach (var driver in lbo.loadTravels(""))
            {
                if (driver.Status.Equals("Busy"))
                {
                    drivers.Add(driver);
                }
            }
            if(drivers.Count == 6)
            {
                btnAdd.Enabled = false;
            }
        }

        private void FrmLogistic_Load(object sender, EventArgs e)
        {
            LoadTrucks();
            Busy();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTrucks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddTruck.AddInstance.MdiParent = this;
            this.scLogic.Panel2.Controls.Add(FrmAddTruck.AddInstance);
            FrmAddTruck.AddInstance.Show();
            dgvLogic.Visible = false;
            btnCancel.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLogic.CurrentCell.Value != null)
                {
                    this.editTruck = FrmAddTruck.EditInstance(Selected());
                    editTruck.MdiParent = this;
                    this.scLogic.Panel2.Controls.Add(this.editTruck);
                    this.editTruck.Show();
                    dgvLogic.Visible = false;
                    btnCancel.Visible = true;
                }
                else
                {
                    message.notification("Please choose a travel");
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
                if (dgvLogic.CurrentCell.Value != null)
                {
                    Question.notification($"Do you want to delete the travel for the truck: {Selected().VehicleNumber}?");
                    if (Question.Answer == 1)
                    {
                        lbo.Delete(Selected().Id);
                        message.notification("Travel deleted");
                        LoadTrucks();
                    }
                }
                else
                {
                    message.notification("Please choose a travel");
                }
            }
            catch (Exception)
            {

                message.notification("Imposible to proceed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmAddTruck.AddInstance.Close();
            dgvLogic.Visible = true;
            btnCancel.Visible = false;
            LoadTrucks();
        }
    }
}
