using Minesweeper.Controller;
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
using WMPLib;
namespace Minesweeper
{
    public partial class Form1:Form
    {
        Random Rand = new Random();
        IUserRepository userRepository;

        public User currentUser;
        private int _difficulty;
        Check check;
        private MyButton[,] btngrid;
        private int _Bombs;
        private int _numberOfButtons;
        private int _numberOfBombs;
        private int rows, cols;
        WindowsMediaPlayer wmp;
        public Form1(int difficulty)
        {
            _difficulty=difficulty;
            InitializeComponent();
            Create(difficulty);
            check = new Check(rows, cols, btngrid);
            userRepository= new UserRepository();
        }
        void EndGame(string musicPath,string picturePath)
        {
            wmp = new WindowsMediaPlayer();
            Form frmEndGame = new Form();
            wmp.controls.stop();
            wmp.URL = (musicPath);
            wmp.controls.play();
            frmEndGame.BackgroundImage = Image.FromFile(Application.StartupPath + picturePath);
            frmEndGame.BackgroundImageLayout = ImageLayout.Stretch;
            frmEndGame.Width = frmEndGame.Height = 712;
            frmEndGame.ShowDialog();
            wmp.close();

        }
        void Lose()
        {
            foreach (var button in panel1.Controls.Cast<MyButton>())
            {
                button.Image = null;
            }
            LblTimer.Text = "000";
            timer1.Stop();
            
            EndGame("gameover.wav",@"\EndGame\" + Rand.Next(1, 15).ToString() + ".jpg");
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ChangeSize(int _difficulty)
        {
            panel1.Width = panel1.Height = _difficulty;
            rows = panel1.Width / MyButton.BtnSize;
            cols = panel1.Height / MyButton.BtnSize;
            switch (_difficulty)
            {
                case 423:
                    panel1.Location = new Point(42, 210);
                    this.Width = 524;
                    this.Height = 712;
                    BtnHelp.Font = new Font("Andalus", 12, FontStyle.Bold);
                    BtnReset.Font = new Font("Andalus", 12, FontStyle.Bold);
                    LblBombs.Font = new Font("DS-Digital", 65, FontStyle.Bold);
                    LblBombs.Location = new Point(54, 78);
                    LblTimer.Font = new Font("DS-Digital", 60, FontStyle.Bold);
                    LblTimer.Location = new Point(302, 82);
                    LblTimer.Text = "300";


                    break;
                case 517:
                    panel1.Location = new Point(50, 255);
                    this.Width = 634;
                    this.Height = 860;
                    BtnHelp.Font = new Font("Andalus", 14, FontStyle.Bold);
                    BtnReset.Font = new Font("Andalus", 14, FontStyle.Bold);
                    LblBombs.Font = new Font("DS-Digital", 80, FontStyle.Bold);
                    LblBombs.Location = new Point(65, 94);
                    LblTimer.Font = new Font("DS-Digital", 75, FontStyle.Bold);
                    LblTimer.Location = new Point(369, 98);
                    LblTimer.Text = "360";

                    break;
                case 611:

                    panel1.Location = new Point(57, 297);
                    this.Width = 745;
                    this.Height = 1005;
                    BtnHelp.Font = new Font("Andalus", 16, FontStyle.Bold);
                    BtnReset.Font = new Font("Andalus", 16, FontStyle.Bold);
                    LblBombs.Font = new Font("DS-Digital", 95, FontStyle.Bold);
                    LblBombs.Location = new Point(75, 108);
                    LblTimer.Font = new Font("DS-Digital", 90, FontStyle.Bold);
                    LblTimer.Location = new Point(430, 115);
                    LblTimer.Text = "410";
                    break;
            }
        }

        void Create(int difficulty)
        {
            timer1.Start();
            
            
            ChangeSize(difficulty);

            btngrid = new MyButton[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    btngrid[i, j] = new MyButton();
                    btngrid[i, j].InRow = i;
                    btngrid[i, j].InColumn = j;
                    btngrid[i, j].MouseUp += gridbutton_click;
                    panel1.Controls.Add(btngrid[i, j]);
                    btngrid[i, j].Location = new Point(i * MyButton.BtnSize, j * MyButton.BtnSize);
                }
            }
            _numberOfButtons = panel1.Controls.Cast<MyButton>().Count();
            _numberOfBombs = _numberOfButtons / 8;
            LblBombs.Text = $"0{_numberOfBombs}";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTimer.Text = (int.Parse(LblTimer.Text) - 1).ToString();
            if (LblTimer.Text == "0")
            {
                timer1.Stop();
                Lose();

            }
        }

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridbutton_click(object sender, MouseEventArgs e)
        {
            MyButton btn = (MyButton)sender;


            if (e.Button == MouseButtons.Right)

            {
                if (btn.Image != null)
                {
                    if (btn.Flag == true)
                    {
                        btn.Image = Image.FromFile(Application.StartupPath + @"\TopShell.png");
                        btn.Flag = false;
                    }
                    else
                    {
                        btn.Image = Image.FromFile(Application.StartupPath + @"\Flag.png");
                        btn.Flag = true;
                    }
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                btn.Image = null;

                while (_Bombs < _numberOfBombs)
                {
                    check.CreateBomb(ref _Bombs);
                }

                if (_Bombs == _numberOfBombs)
                {
                    _Bombs += 1;

                    foreach (var button in panel1.Controls.Cast<MyButton>())
                    {
                        switch (button.NearbyBombs)
                        {
                            case 1:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\1.png") ;
                                break;
                            case 2:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\2.png");
                                break;
                            case 3:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\3.png");
                                break;
                            case 4:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\4.png");
                                break;
                            case 5:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\5.png");
                                break;
                            case 6:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\6.png");
                                break;
                            case 7:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\7.png");
                                break;
                            case 8:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\8.png");
                                break;
                            case 9:
                                button.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Bomb.png");
                                break;
                            default:
                                button.NearbyBombs = 0;
                                break;
                        }

                    }
                }


                if (btn.NearbyBombs == 9)
                {
                    Lose();
                }
                else
                {

                    check.IsEmpty(btn.InRow, btn.InColumn);
                    int numberOfemtyshell = panel1.Controls.Cast<MyButton>().Where(p => p.Image == null).Count();


                    if (numberOfemtyshell == _numberOfButtons - _numberOfBombs)
                    {
                        timer1.Stop();
                        int record = Convert.ToInt32(LblTimer.Text) * _difficulty;
                        if (currentUser.Record<record)
                        {
                            currentUser.Record = record;
                            userRepository.Update(currentUser);
                            userRepository.Save();
                        }
                        userRepository.Update(currentUser);
                        EndGame("Crowd.wav",@"\EndGame\" + Rand.Next(15, 20).ToString() + ".jpg");
                    }

                }

            }

        }
    }
}
