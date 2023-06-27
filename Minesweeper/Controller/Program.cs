using Minesweeper.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Minesweeper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool applicationRun = true;
            bool signOut;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            while (applicationRun)
            {
                
                wmp.URL = ("Menu.wav");
                wmp.controls.play();
                using (FrmMenu frmMenu = new FrmMenu())
                {
                    frmMenu.currentUser = frmLogin.currentUser;
                    frmMenu.ShowDialog();
                    signOut = frmMenu.signOut;
                    applicationRun = frmMenu.applicationRun;
                    wmp.controls.stop();
                    if (signOut) { break;}
                    wmp.URL = ("GamePlay.mp3");
                    wmp.controls.play();
                    using (Form1 form1 = new Form1(frmMenu.difficulty))
                    {
                        form1.currentUser = frmMenu.currentUser;
                        form1.ShowDialog();
                        wmp.controls.stop();
                        wmp.close();
                    }
                }

            }
        }
    }
}
