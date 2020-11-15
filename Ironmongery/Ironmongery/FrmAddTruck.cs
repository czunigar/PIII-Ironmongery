using BoLayer;
using ServiceLayer;
using EntityLayer;
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
    public partial class FrmAddTruck : Form
    {
        private const int TRUCKNUM = 6;
        private ELogistic logistic;
        private LogisticBO lbo;
        private UserBO ubo;
        private Messages message;

        public FrmAddTruck()
        {
            InitializeComponent();
            logistic = new ELogistic();
            lbo = new LogisticBO();
            ubo = new UserBO();
            message = new Messages();
            lblTitle.Text = "ASSIGN TRUCK";
            lblId.Visible = false;
            txtId.Visible = false;
        }

        public FrmAddTruck(ELogistic logistic)
        {
            InitializeComponent();
            this.logistic = logistic;
            lbo = new LogisticBO();
            ubo = new UserBO();
            message = new Messages();
            lblTitle.Text = "EDIT ASSIGNED TRUCK";
            LoadData();
        }

        /*Method to load the number of trucks to a combobox*/
        private void LoadTruckNum()
        {
            List<int> trucks = new List<int>();
            for (int i = 0; i <= TRUCKNUM; i++)
            {
                trucks.Add(i);
            }

            foreach (var truck in lbo.loadTravels(""))
            {
                if (truck.Status.Equals("Busy"))
                {
                    trucks.Remove(Convert.ToInt32(truck.VehicleNumber));
                }
            }

            cboTruck.DataSource = trucks;
        }

        /*Method to load the drivers to a combobox*/
        private void LoadDrivers()
        {
            List<EUser> drivers = new List<EUser>();
            foreach (var driver in ubo.LoadUsers(""))
            {
                if (driver.Type.Equals("Driver"))
                {
                    drivers.Add(driver);
                }
            }

            foreach (var driver in lbo.loadTravels(""))
            {
                if (driver.Status.Equals("Busy"))
                {
                    drivers.Remove(driver.Driver);
                }
            }
            cboDriver.DataSource = drivers;
        }

        /*Method to load all the trucks' data*/
        private void LoadData()
        {
            try
            {
                txtId.Text = logistic.Id.ToString();
                cboTruck.SelectedValue = logistic.VehicleNumber;
                cboDriver.SelectedItem = logistic.Driver;
                cboStatus.SelectedValue = logistic.Status;
            }
            catch (Exception)
            {
                message.notification("Imposible to retrieve the information");
            }
        }

        private static FrmAddTruck Instance = null;
        public static FrmAddTruck AddInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new FrmAddTruck();
                    Instance.Disposed += new EventHandler(AddTruckDispose);
                }
                return Instance;
            }
        }

        /*Method to create a new window which will receive a truck*/
        public static FrmAddTruck EditInstance(ELogistic logistic)
        {

            if (Instance == null)
            {
                Instance = new FrmAddTruck(logistic);
                Instance.Disposed += new EventHandler(AddTruckDispose);
            }
            return Instance;

        }

        public static void AddTruckDispose(object sender, EventArgs e)
        {
            Instance = null;
        }

        /*Method to save the truck*/
        private void Save()
        {
            try
            {
                logistic.VehicleNumber = Convert.ToInt32(cboTruck.SelectedValue);
                EUser driver = (EUser)cboDriver.SelectedItem;
                logistic.DriverId = driver.Id;
                logistic.Driver = driver;
                logistic.Status = cboStatus.SelectedValue.ToString();
                lbo.Save(logistic);
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
            cboTruck.SelectedItem = null;
            cboDriver.SelectedItem = null;
            cboStatus.SelectedItem = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboTruck.SelectedItem == null)
            {
                eTruck.SetError(cboTruck, "Truck number is missing");
            }
            if (cboDriver.SelectedItem == null)
            {
                eDriver.SetError(cboDriver, "Driver is missing");
            }
            if (cboStatus.SelectedItem == null)
            {
                eStatus.SetError(cboStatus, "Status is missing");
            }
            if (cboTruck.SelectedItem != null && cboDriver.SelectedItem != null  &&
                cboStatus.SelectedItem != null)
            {
                Save();
                Clean();
                message.notification("Logistic save successfully");
            }
        }

        private void FrmAddTruck_Load(object sender, EventArgs e)
        {
            LoadTruckNum();
            LoadDrivers();
        }
    }
}
