using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gridManager
{
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }

        ForUser user = new ForUser();

        private void table1_Click(object sender, EventArgs e)
        {
            user.Show();
            user.loadBtn(1);
            this.Close();
            
        }

        private void table2_Click(object sender, EventArgs e)
        {
            user.Show();
            user.loadBtn(2);
            this.Close();
        }

        private void table3_Click(object sender, EventArgs e)
        {
            user.Show();
            user.loadBtn(3);
            this.Close();
        }

        private void table4_Click(object sender, EventArgs e)
        {
            user.Show();
            user.loadBtn(4);
            this.Close();
        }

        private void table5_Click(object sender, EventArgs e)
        {
            user.Show();
            user.loadBtn(5);
            this.Close();
        }

        private void table6_Click(object sender, EventArgs e)
        {
            user.Show();
            user.loadBtn(6);
            this.Close();
        }
    }
}
