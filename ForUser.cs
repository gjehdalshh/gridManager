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
    public partial class ForUser : Form
    {
        public ForUser()
        {
            InitializeComponent();
            i_user = gridManager.Properties.Settings.Default.login_user;
            loadBtn();
            pictureBox1.Load(@"C:\Users\User\Desktop\프로젝트\test.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        int i_user;

        private void user_logout_Click(object sender, EventArgs e)
        {
            gridManager.Properties.Settings.Default.login_check = false;
            gridManager.Properties.Settings.Default.Save();
            gridManager.Properties.Settings.Default.login_user = 0;
            //i_user = 0;
            DBManger.GetInstance().logoutTimeRecord(i_user);
            login login = new login();
            login.Show();

            this.Close();
        }


        private List<Button> btnList = new List<Button>();
        List<DBManger.menuInfo> list;
        public void loadBtn() {

            list = DBManger.GetInstance().select_menu();

            for(int i = 0; i < list.Count; i++) {
                Button btn = new Button();
                btnList.Add(btn);
                btnList[i].Location = new Point(150 + 80, 35 + (i * 32));
                btnList[i].Name = list[i].food_name;
                btnList[i].Size = new System.Drawing.Size(75, 30);
                btnList[i].TabIndex = 1;
                btnList[i].Tag = i;
                btnList[i].Text = list[i].food_name;
                btnList[i].UseVisualStyleBackColor = true;
                btnList[i].Click += new EventHandler(btnClick);
                this.Controls.Add(btnList[i]);
            }

        }
        void btnClick(object sender, EventArgs e) {

            if(gridManager.Properties.Settings.Default.login_user == 0) {
                return;
            }
            Button btn = sender as Button;
            int n = (int)btn.Tag;

            DBManger.GetInstance().insert_food(i_user, list[n].food_name, list[n].food_price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(i_user);
            if(i_user == 1) {
                Form1 form = new Form1();
                form.Show();

            } else {
                MessageBox.Show("관리자만 사용이 가능합니다.");
            }


        }
    }
}
