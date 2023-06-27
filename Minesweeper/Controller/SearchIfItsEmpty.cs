using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Minesweeper.Controller
{
    public class Check
    {
        MyButton[,] btngrid;

        int tableRow; int tableColumn;
        public Check(int tableRow, int tableColumn, MyButton[,] btngrid)
        {
            this.tableRow = tableRow;
            this.tableColumn = tableColumn;
            this.btngrid = btngrid;
        }

        public void IsEmpty(int row, int column)
        {
            if (IsValid(row, column) == true && btngrid[row, column].BackgroundImage == null)
            {
                //When we enter the body of this if, it means The shell is empty so it means the 8 shells of
                //Around this shel is empty too, then we can remove the photos of them and show them to the player
                btngrid[row, column].BackgroundImage = Image.FromFile(Application.StartupPath + @"\Empty.jpg");
                btngrid[row, column].Image = null;
                if (IsValid(row - 1, column)) btngrid[row - 1, column].Image = null;
                if (IsValid(row - 1, column - 1)) btngrid[row - 1, column - 1].Image = null;
                if (IsValid(row - 1, column + 1)) btngrid[row - 1, column + 1].Image = null;
                if (IsValid(row + 1, column - 1)) btngrid[row + 1, column - 1].Image = null;
                if (IsValid(row + 1, column + 1)) btngrid[row + 1, column + 1].Image = null;
                if (IsValid(row + 1, column)) btngrid[row + 1, column].Image = null;
                if (IsValid(row, column + 1)) btngrid[row, column + 1].Image = null;
                if (IsValid(row, column - 1)) btngrid[row, column - 1].Image = null;
                //and in this part i check if that shells we removed photos are empty,
                //if they were they also will enter of this sycle and so on
                IsEmpty(row - 1, column);
                IsEmpty(row - 1, column - 1);
                IsEmpty(row - 1, column + 1);
                IsEmpty(row + 1, column - 1);
                IsEmpty(row + 1, column + 1);
                IsEmpty(row + 1, column);
                IsEmpty(row, column + 1);
                IsEmpty(row, column - 1);
            }
        }

        public bool IsValid(int btnrow, int btncolumn)
        {

            if (btnrow >= 0 && btnrow < tableRow && btncolumn >= 0 && btncolumn < tableColumn)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public void CreateBomb(ref int Bombs)
        {
            Random Rand = new Random();
            int r = Rand.Next(1, tableRow);
            int c = Rand.Next(1, tableColumn);
            //crate random point and then check its not a bomb already
            if (btngrid[r, c].NearbyBombs != 9)
            {
                //i increase the nearbybomb value of btns that are not bombs
                if (IsValid(r + 1, c + 1)) if (btngrid[r + 1, c + 1].NearbyBombs != 9) btngrid[r + 1, c + 1].NearbyBombs += 1;
                if (IsValid(r, c - 1)) if (btngrid[r, c - 1].NearbyBombs != 9) btngrid[r, c - 1].NearbyBombs += 1;
                if (IsValid(r, c + 1)) if (btngrid[r, c + 1].NearbyBombs != 9) btngrid[r, c + 1].NearbyBombs += 1;
                if (IsValid(r - 1, c + 1)) if (btngrid[r - 1, c + 1].NearbyBombs != 9) btngrid[r - 1, c + 1].NearbyBombs += 1;
                if (IsValid(r - 1, c - 1)) if (btngrid[r - 1, c - 1].NearbyBombs != 9) btngrid[r - 1, c - 1].NearbyBombs += 1;
                if (IsValid(r - 1, c)) if (btngrid[r - 1, c].NearbyBombs != 9) btngrid[r - 1, c].NearbyBombs += 1;
                if (IsValid(r + 1, c)) if (btngrid[r + 1, c].NearbyBombs != 9) btngrid[r + 1, c].NearbyBombs += 1;
                if (IsValid(r + 1, c - 1)) if (btngrid[r + 1, c - 1].NearbyBombs != 9) btngrid[r + 1, c - 1].NearbyBombs += 1;
                //and at the end i will make that point to a bomb and increase number of bombs
                btngrid[r, c].NearbyBombs = 9;
                Bombs++;
            }
        }
    }
}
