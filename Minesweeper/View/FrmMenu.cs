using Minesweeper.Model;
using Minesweeper.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Minesweeper
{
    public partial class FrmMenu : Form
    {
        public int difficulty;
        public bool applicationRun;
        public bool signOut;

        public User currentUser;

        public FrmMenu()
        {
            InitializeComponent();
            applicationRun = true;
        }

        private void BtnEasy_Click(object sender, EventArgs e)
        {
            difficulty = 423;
            this.Close();
        }

        private void BtnMedium_Click(object sender, EventArgs e)
        {
            difficulty = 517;
            this.Close();
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            difficulty = 611;
            this.Close();

        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?",
                                  "Warning",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                applicationRun = false;
                Application.Exit();

            }

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblCup.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Cup.png");
            lblCup.BackgroundImageLayout = ImageLayout.Stretch;

            BtnClose.BringToFront();
            BtnClose.BackgroundImage = Image.FromFile(Application.StartupPath + @"\close.png");
            BtnClose.BackgroundImageLayout = ImageLayout.Stretch;
            BtnClose.Cursor = Cursors.Hand;
            BtnEasy.Cursor = Cursors.Hand;
            BtnHard.Cursor = Cursors.Hand;
            BtnMedium.Cursor = Cursors.Hand;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.pageId = 3;
            frmLogin.currentUser = currentUser;
            frmLogin.ShowDialog();
        }

        private void lblCup_Click(object sender, EventArgs e)
        {
            FrmRecords frm = new FrmRecords();
            frm.ShowDialog();
        }

        private void btnSingout_Click(object sender, EventArgs e)
        {
             signOut = true;
             Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            applicationRun = false;
            Application.Exit();
        }


    }
}
