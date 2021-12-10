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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        public string[] menuInfo() {
            string[] str = new string[3];
            string name = menu_name.Text;
            string price = menu_price.Text;
            str[0] = name;
            str[1] = price;
            str[2] = imgPathText.Text;
            return str;
        }

        public string[] changeMenuInfo() {
            string[] str = new string[3];
            string nowName = nowMenuName.Text;
            string changeName = changeMenuName.Text;
            string price = changeMenuPrice.Text;
            str[0] = nowName;
            str[1] = changeName;
            str[2] = price;

            return str;
        }

        private void insertMenuBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void changeMenuBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pictureInsertBtn_Click(object sender, EventArgs e)
        {
            imgPathText.Text = DBManger.GetInstance().imgOpen();
            pictureBox1.Load(imgPathText.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
