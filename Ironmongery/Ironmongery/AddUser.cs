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
    public partial class AddUser : Form
    {
        private EUser user;
        private UserBO ubo;
        private Messages message;

        public AddUser(EUser user)
        {
            InitializeComponent();
            this.ubo = new UserBO();
            this.user = user;
            message = new Messages();
            txtPass.Visible = false;
            lblPass.Visible = false;
            lblTitle.Text = "EDIT USER";
            LoadData();
        }

        public AddUser()
        {
            InitializeComponent();
            this.ubo = new UserBO();
            this.user = new EUser();
            message = new Messages();
            lblTitle.Text = "NEW USER";
            lblId.Visible = false;
            txtId.Visible = false;
        }

        /*Method to load all the user's data*/
        private void LoadData()
        {
            try
            {
                txtId.Text = user.Id.ToString();
                txtCid.Text = user.Cid;
                txtCode.Text = user.Code;
                txtName.Text = user.Name;
                txtPass.Text = user.Password;
                cboType.SelectedItem = user.Type;
                ckAdmin.Checked = Convert.ToBoolean(user.Admin);
            }
            catch (Exception)
            {
                message.notification("Imposible to retrieve the information");
            }
        }

        private static AddUser Instance = null;
        public static AddUser AddInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new AddUser();
                    Instance.Disposed += new EventHandler(AddUserDispose);
                }
                return Instance;
            }
        }

        /*Method to create a new window which will receive a user*/
        public static AddUser EditInstance(EUser user)
        {

            if (Instance == null)
            {
                Instance = new AddUser(user);
                Instance.Disposed += new EventHandler(AddUserDispose);
            }
            return Instance;

        }

        /*Method to save the user*/
        private void Save()
        {
            try
            {
                user.Cid = txtCid.Text;
                user.Name = txtName.Text;
                user.Code = txtCode.Text;
                user.Password = ubo.GetMD5(txtPass.Text);
                user.Type = (string)cboType.SelectedItem;
                user.Admin = ckAdmin.Checked;
                ubo.Save(user);
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
            txtCid.Text = "";
            txtCode.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            cboType.SelectedItem = null;
            ckAdmin.Checked = false;
        }

        private void getCode()
        {
            try
            {
                string code = "";
                if (!string.IsNullOrEmpty(txtCid.Text) && cboType.SelectedItem != null)
                {
                    string id = txtCid.Text.Substring(6, 3);
                    string role = cboType.SelectedItem.ToString();
                    string rol = role.Substring(0, 3);
                    code = rol.ToUpper() + id;
                }
                txtCode.Text = code;
            }
            catch (Exception)
            {

                message.notification("Couldn't retrieve the information");
            }
        }

        public static void AddUserDispose(object sender, EventArgs e)
        {
            Instance = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                eCode.SetError(txtCode, "Code is missing");
            }
            if (string.IsNullOrEmpty(txtCid.Text))
            {
                eCid.SetError(txtCid, "Cid is missing");
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                eName.SetError(txtName, "Username is missing");
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                ePass.SetError(txtPass, "Password is missing");
            }
            if (txtPass.Text.Length < 12)
            {
                ePass.SetError(txtPass, "Password most have more than 12 characters");
            }
            if (cboType.SelectedItem == null)
            {
                eRole.SetError(txtPass, "Role is missing");
            }
            if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtCid.Text) &&
                !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPass.Text) &&
                cboType.SelectedItem != null && txtPass.Text.Length >= 12)
            {
                Save();
                Clean();
                message.notification("User save successfully");
            }
        }

        private void txtCid_Validated(object sender, EventArgs e)
        {
            getCode();
        }

        private void cboType_Validated(object sender, EventArgs e)
        {
            getCode();
        }
    }

}
