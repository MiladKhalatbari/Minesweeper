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
    public partial class FrmRecords : Form
    {
        IUserRepository userRepository;
        public FrmRecords()
        {
            InitializeComponent();
        }

        private void FrmRecords_Load(object sender, EventArgs e)
        {
            userRepository= new UserRepository();
            IEnumerable<User> users = userRepository.GetAll().OrderByDescending(x=> x.Record).Take(10).ToList();
            dgvRecords.AutoGenerateColumns = false;
            dgvRecords.ChangeDataGridViewColor(Color.Gold, Color.LightGoldenrodYellow);
            dgvRecords.DataSource= users;

        }
    }
}
