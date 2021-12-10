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
        }
        int i_user;
        bool createCheck = false;


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

        List<DBManger.menuInfo> tableMenuInfoList;
        void selectTableMenu(int nowTableNumber)
        {
            tableMenuInfoList = DBManger.GetInstance().select_nowMenuList(nowTableNumber);

            for (int i = 0; i < tableMenuInfoList.Count; i++)
            {
                NowSelectMenu.Items.Add(tableMenuInfoList[i].food_name);
                NowSelectMenu.Text += NowSelectMenu.Items[i];
            }
        }

        private List<Button> btnList = new List<Button>();
        List<DBManger.menuInfo> list;

        int nowTableNumber;
        public List<List<string>> tableList;
        public void loadBtn(int tableNumber)
        {

            nowTableNumber = tableNumber;
            list = DBManger.GetInstance().select_menu();
            selectTableMenu(nowTableNumber);

            if (createCheck == false)
            {
                tableList = new List<List<string>>();
                for (int i = 0; i < list.Count; i++)
                {
                    tableList.Add(new List<string>());
                }
                createCheck = true;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i > 10)
                { // 현재는 최대 10개, 시간이 될 때 페이징 처리를 통하여 뿌림
                    return;
                }
                Button btn = new Button();
                btnList.Add(btn);
                if (i < 5)
                {
                    btnList[i].Location = new Point(20 + (i * 90), 160);
                }
                else
                {
                    btnList[i].Location = new Point(20 + ((i % 5) * 90), 300);
                }

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
        List<int> menuList = new List<int>();

        void btnClick(object sender, EventArgs e)
        {

            if (gridManager.Properties.Settings.Default.login_user == 0)
            {
                return;
            }
            Button btn = sender as Button;
            int n = (int)btn.Tag;
            menuList.Add(n);

            NowSelectMenu.Items.Add(list[n].food_name);


            tableList[nowTableNumber].Add(list[n].food_name);


            for (int i = 0; i < NowSelectMenu.Items.Count; i++)
            {
                NowSelectMenu.Text += NowSelectMenu.Items[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i_user == 1)
            {
                this.Close();
                Form1 form = new Form1();
                form.Show();

            }
            else
            {
                MessageBox.Show("관리자만 사용이 가능합니다.");
            }
        }

        private void orderBnt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableList[nowTableNumber].Count; i++)
            {
                DBManger.GetInstance().insert_order(tableList[nowTableNumber][i].ToString(), nowTableNumber, 0);
            }
            table table = new table();
            this.Close();
            table.Show();
        }

        private void payMentBtn_Click(object sender, EventArgs e)
        {
            int payment = DBManger.GetInstance().sumPayment(nowTableNumber);
            MessageBox.Show("총 결제 금액 : " + payment);
            for (int i = 0; i < tableMenuInfoList.Count; i++)
            {
                DBManger.GetInstance().insert_food(i_user, tableMenuInfoList[i].food_name, tableMenuInfoList[i].food_price, nowTableNumber);
                DBManger.GetInstance().updateSaleState(nowTableNumber);
            }
            table table = new table();
            this.Close();
            table.Show();
        }

        private void deleteMenuBtn_Click(object sender, EventArgs e)
        {
            int i_order = tableMenuInfoList[NowSelectMenu.SelectedIndex].i_order;
            NowSelectMenu.Items.RemoveAt(NowSelectMenu.SelectedIndex);
            DBManger.GetInstance().updateSaleStateCencel(i_order, nowTableNumber);
        }
    }
}