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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string id = user_id.Text;
            string pw = user_pw.Text;

            string user_name = DBManger.GetInstance().Login_check(id, pw);

            if (gridManager.Properties.Settings.Default.login_check == true) {
                MessageBox.Show(user_name + "님 환영합니다.");


                table table = new table();
                
                this.Close();
                table.Show();
            }

        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            string nm = join_nm.Text;
            string id = join_id.Text;
            string pw = join_pw.Text;

            DBManger.GetInstance().insertUser(nm, id, pw);
        }
    }
}
