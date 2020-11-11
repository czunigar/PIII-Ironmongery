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
    public partial class FrmUsers : Form
    {
        private UserBO ubo;
        private Messages message;
        private AddUser editUser;
        private Question question;
        public FrmUsers()
        {
            InitializeComponent();
            ubo = new UserBO();
            message = new Messages();
            question = new Question();
            btnCancel.Visible = false;
        }

        /*Method to load all the users*/
        public void LoadUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = ubo.LoadUsers(txtSearch.Text.ToUpper());
        }

        /*Method to pick up the select user*/
        private EUser selected()
        {
            EUser user = new EUser();
            int row = dgvUsers.CurrentCell.RowIndex;
            if (row < 0)
            {
                return null;
            }
            user = ubo.GetUserById((int)dgvUsers.Rows[row].Cells["Id"].Value);
            return user;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.CurrentCell.Value != null)
                {
                    this.editUser = AddUser.EditInstance(selected());
                    editUser.MdiParent = this;
                    this.scUsers.Panel2.Controls.Add(this.editUser);
                    this.editUser.Show();
                    dgvUsers.Visible = false;
                    btnCancel.Visible = true;
                }
                else
                {
                    message.notification("Please choose a user");
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
                if (dgvUsers.CurrentCell.Value != null)
                {
                    question.notification($"Do you want to delete the user: {selected().Code}?");
                    if(question.Answer == 1)
                    {
                        ubo.Delete(selected().Id);
                        message.notification("User deleted");
                    }
                }
                else
                {
                    message.notification("Please choose a user");
                }
            }
            catch (Exception)
            {

                message.notification("Imposible to proceed");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser.AddInstance.MdiParent = this;
            this.scUsers.Panel2.Controls.Add(AddUser.AddInstance);
            AddUser.AddInstance.Show();
            dgvUsers.Visible = false;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddUser.AddInstance.Close();
            dgvUsers.Visible = true;
            btnCancel.Visible = false;
            LoadUsers();
        }
    }
}
