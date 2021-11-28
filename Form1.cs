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
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
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

                ForUser forUser = new ForUser();
                Button btn = new Button();
                btn.Name = str[0];
                btn.Text = str[0];
                btn.Location = new Point(50 + 25, 50 + 25);
                btn.UseVisualStyleBackColor = true;
                btn.Tag = 0;
                this.Controls.Add(btn);
            }

            // 변경
            if (result == DialogResult.Cancel)
            {
                str = menu.changeMenuInfo();
                int price = Int32.Parse(str[2]);
                DBManger.GetInstance().update_food(str[0], str[1], price);
            }
        }
    }


}
