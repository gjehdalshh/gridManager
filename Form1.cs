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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            i_user = gridManager.Properties.Settings.Default.login_user;
        }

        int i_user;


        private void admin_logout_Click(object sender, EventArgs e)
        {
            gridManager.Properties.Settings.Default.login_check = false;
            gridManager.Properties.Settings.Default.Save();
            gridManager.Properties.Settings.Default.login_user = 0;
            
            login_info.Text = "";
            login login = new login();
            login.Show();
            this.Close();
        }           

        int year;
        int month;
        int day;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(gridManager.Properties.Settings.Default.login_user != 1) {
                return;
            }

            DateTime dt1 = dateTimePicker1.Value;

            year = dt1.Year;
            month = dt1.Month;
            day = dt1.Day;
            
        }

        private void UserSaleBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBManger.GetInstance().dateList(1, year, month, day);
            dataGridView1.Columns["i_user"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void menuSaleDayBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBManger.GetInstance().dateList(2, year, month, day);
        }

        private void menuSaleMonthBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBManger.GetInstance().dateList(3, year, month, day);
        }

        private void userLogRecord_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBManger.GetInstance().logList();
        }

        string[] str;

        private void menuManagement_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            DialogResult result = menu.ShowDialog();
            // 삽입
            if (result == DialogResult.OK)
            {
                str = menu.menuInfo();
                int price = Int32.Parse(str[1]);
                DBManger.GetInstance().insert_newMenu(str[0], price);
                DBManger.GetInstance().insert_menuChange(str[0], price);
            }

            // 변경
            if (result == DialogResult.Cancel)
            {
                str = menu.changeMenuInfo();
                int price;
                try {
                    price = Int32.Parse(str[2]);
                } catch {
                    return;
                }
                DBManger.GetInstance().select_foodState(str[0]);
                DBManger.GetInstance().update_food(str[0], str[1], price);
                DBManger.GetInstance().update_foodState(str[1], price);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ForUser user = new ForUser();
            user.Show();
            user.loadBtn(0);
        }

        private void orderSelectBtn_Click(object sender, EventArgs e)
        {
            string time = orderSelectText.Text;
            
            string[] hour = time.Split('시');
            int hourInt = Int32.Parse(hour[0]);
            string temp = hour[1];
            string[] minute = temp.Split('분');
            int minuteInt = Int32.Parse(minute[0]);

            dataGridView1.DataSource = DBManger.GetInstance().payMentList(year, month, day, hourInt, minuteInt);
        }

        private void selectCencelBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBManger.GetInstance().dateListBefore(year, month, day);
            dataGridView2.DataSource = DBManger.GetInstance().dateList(4, year, month, day);

        }

        private void menuChangePrint_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBManger.GetInstance().menuChangeListBefore();
            dataGridView2.DataSource = DBManger.GetInstance().menuChangeListAfter();
        }
    }


}
