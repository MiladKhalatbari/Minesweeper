using Minesweeper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.View
{
    public partial class FrmLogin : Form
    {

        public int pageId = 1;
        public User currentUser;
        IUserRepository userRepository;
        public FrmLogin()
        {
            userRepository = new UserRepository();
            InitializeComponent();


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            BtnClose.BringToFront();
            BtnClose.BackgroundImage = Image.FromFile(Application.StartupPath + @"\close.png");
            BtnClose.BackgroundImageLayout = ImageLayout.Stretch;
            BtnClose.Cursor = Cursors.Hand;
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";

            if (pageId == 1)
            {
                lbltitle.Text = "Sign In";
                btnSubmit.Text = "Login";
                lblSUAndSI.Text = "Don't have an account?";
                btnSUAndSI.Text = "Sign Up";

            }
            else if (pageId == 2)
            {
                lbltitle.Text = "Sign Up";
                btnSubmit.Text = "Register";
                lblSUAndSI.Text = "Already have an account?";
                btnSUAndSI.Text = "Sign In";
            }
            else
            {
                lbltitle.Text = "Change Password";
                btnSubmit.Text = "Confirm";
                lblSUAndSI.Visible = false;
                btnSUAndSI.Visible = false;
                lblUsername.Text = "new passord";
                lblPassword.Text = "Confirm password";

            }
        }
        bool IsValid()
        {
            if (txtUsername.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    return true;
                }
                else
                {
                    errpPassword.SetError(txtPassword, "Please fill this field !");
                    return false;

                }
            }
            else
            {
                errpUsername.SetError(txtUsername, "Please fill this field !");
                return false;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                switch (pageId)
                {
                    case 1:
                        if (userRepository.GetAll().Any(x => x.Name == txtUsername.Text.ToLower() && x.Password == txtPassword.Text.ToLower()))
                        {
                            currentUser = userRepository.Get(txtUsername.Text.ToLower());
                            this.Close();
                        }
                        else
                        {
                            errpUsername.SetError(txtUsername, "your username or password may be incorrect !");
                            errpPassword.SetError(txtPassword, "your username or password may be incorrect !");
                        }

                        break;
                    case 2:
                        bool isThere = userRepository.GetAll().Any(x => x.Name == txtUsername.Text.ToLower());
                        if (isThere)
                        {
                            errpUsername.SetError(txtUsername, "This username is already taken !");
                        }
                        else
                        {
                            currentUser = new User();
                            currentUser.Name = txtUsername.Text;
                            currentUser.Password = txtPassword.Text;
                            currentUser.Record = 0;
                            userRepository.Insert(currentUser);
                            userRepository.Save();
                            MessageBox.Show("Congratulations, you have registered. Login with your username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pageId = 1;
                            BindGrid();
                        }
                        break;

                    case 3:

                        if (txtUsername.Text == txtPassword.Text)
                        {
                            currentUser.Password = txtPassword.Text;
                            userRepository.Update(currentUser);
                            userRepository.Save();
                            MessageBox.Show("password changed successfully . Login with your new password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                        else
                        {
                            errpUsername.SetError(txtPassword, "your password and your confirmation password must match !");
                        }
                        break;

                }


            }
        }

        private void btnSUAndSI_Click(object sender, EventArgs e)
        {
            if (pageId == 1)
            {
                pageId = 2;
                BindGrid();
            }
            else if (pageId == 2)
            {
                pageId = 1;
                BindGrid();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?",
                                  "Warning",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
       
    }
}

