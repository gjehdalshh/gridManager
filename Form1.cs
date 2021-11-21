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
        }

        private void user_login_Click(object sender, EventArgs e)
        {
            string id = user_id.Text;
            string pw = user_pw.Text;

            string user_name = DBManger.GetInstance().Login_check(id, pw);

            if(gridManager.Properties.Settings.Default.login_check == true) {
                i_user = gridManager.Properties.Settings.Default.login_user;
                login_info.Text = user_name + "님 환영합니다.";
            }
        }

        int i_user;

        private void user_logout_Click(object sender, EventArgs e)
        {
            gridManager.Properties.Settings.Default.login_check = false;
            gridManager.Properties.Settings.Default.Save();
            gridManager.Properties.Settings.Default.login_user = 0;

            login_info.Text = "";
            user_id.Text = "";
            user_pw.Text = "";
        }

        private void pig_food_Click(object sender, EventArgs e)
        {
            if(gridManager.Properties.Settings.Default.login_user == 0) {
                return;
            }
            string pig = "돼지국밥";
            int price = 6000;

            DBManger.GetInstance().insert_food(i_user, pig, price);
        }

        private void Sundae_food_Click(object sender, EventArgs e)
        {
            if (gridManager.Properties.Settings.Default.login_user == 0)
            {
                return;
            }
            string pig = "순대국밥";
            int price = 5000;

            DBManger.GetInstance().insert_food(i_user, pig, price);
        }

        private void mint_food_Click(object sender, EventArgs e)
        {
            if (gridManager.Properties.Settings.Default.login_user == 0)
            {
                return;
            }
            string pig = "민트국밥";
            int price = 7000;

            DBManger.GetInstance().insert_food(i_user, pig, price);
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
    }


}
