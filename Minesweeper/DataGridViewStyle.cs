using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public static class DataGridViewStyle
    {
        public static void ChangeDataGridViewColor(this DataGridView dataGridView, Color headerColor, Color AlternatingRowsColor)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(137, 136, 138);
            dataGridView.RowHeadersVisible = false;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = AlternatingRowsColor;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 23,FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 25, FontStyle.Bold);

        }
    }
}
