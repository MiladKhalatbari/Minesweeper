using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
   public class MyButton : Button
    {
        public int NearbyBombs { get; set; }
        public bool Flag { get; set; }
        public int InRow { get; set; }
        public int InColumn { get; set; }

        public static int BtnSize = 47;

        public MyButton()
        {
            Width = Height = BtnSize;
            Cursor = Cursors.Hand;
            Image = Image.FromFile(Application.StartupPath + @"\TopShell.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.Silver;
        }



    }
}
