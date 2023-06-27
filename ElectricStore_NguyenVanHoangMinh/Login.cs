using LibraryRepo.Models;
using LibraryRepo.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_NguyenVanHoangMinh
{
    public partial class Login : Form
    {
        private UserRepo userRepo = new UserRepo();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username can not empty", "Error", MessageBoxButtons.OK);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can not empty", "Error", MessageBoxButtons.OK);
            }
            else
            {
                List<User> users;
                users = userRepo.GetAll();
                User user = new User();
                try
                {
                    user = users.First(x => x.UserName == txtUsername.Text);
                    if (user.UserRole == 1)
                    {
                        this.Hide();
                        Form fmManagement = new ProductManagement();
                        fmManagement.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("You are't allow to access to this management", "Error", MessageBoxButtons.OK);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("username not exist in system", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
