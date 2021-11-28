using gridManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DBManger
{
    private static DBManger instance = new DBManger();

    string strconn = "Server=27.96.130.41;Database=s5727844;Uid=s5727844;Pwd=s5727844;Charset=utf8";
    string query = "";

    public static DBManger GetInstance()
    {
        return instance;
    }

    public int selectUser(string nm, string id) {

        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select * from food_user";
         
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if(nm.Equals((string)rdr["user_name"]) || id.Equals((string)rdr["user_id"])) {
                    return 2;
                }
            }
            rdr.Close();   
        }
        return 1;
    }

    public void insertUser(string nm, string id, string pw) {
        int check = selectUser(nm, id);
        if(check != 1) {
            return;
        }
        Encrypt encrypt = new Encrypt();
        string encryptPw = encrypt.AES_Enc(pw);

        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "insert into food_user (user_name, user_id, user_pw) values ('"+nm+"', '"+id+"', '"+ encryptPw + "'); ";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }

    public void insert_food(int i_user, string food_menu, int food_price)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "insert into food_sale (i_user, food_menu, food_price) values (" + i_user + ",'" + food_menu + "', '" + food_price + "')";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

        }
    }
    public void update_food(string nowName, string changeName, int price) {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "update food_menu set food_name = '"+changeName+"' , food_price = "+price+" where food_name = '"+nowName+"'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

        }
    }

    public void insert_newMenu(string name, int price) {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "insert into food_menu (food_name, food_price) values ('" + name + "', " + price + ")";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
    public class menuInfo {
        public string food_name;
        public int food_price;
    }

    public List<menuInfo> select_menu() {
        List<menuInfo> list = new List<menuInfo>();
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select * from food_menu";
         
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                menuInfo menu = new menuInfo();
                menu.food_name = (string)rdr["food_name"];
                menu.food_price = (int)rdr["food_price"];
                list.Add(menu);
            }
            rdr.Close();
            
        }
        return list;
    }

    public void loginTimeRecord(int i_user)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "update food_user set loginTime = now() where i_user = " + i_user;

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
    public void logoutTimeRecord(int i_user)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "update food_user set logoutTime = now() where i_user = " + i_user;

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }

    public string Login_check(string id, string pw)
    {
        string user_name = "";
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select * from food_user";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Encrypt encrypt = new Encrypt();
            string encryptPw = encrypt.AES_Enc(pw);

            while (rdr.Read())
            {
                if (id.Equals((string)rdr["user_id"]) && encryptPw.Equals((string)rdr["user_pw"]))
                {
                    int i_user = (int)rdr["i_user"];
                    user_name = (string)rdr["user_name"];
                    gridManager.Properties.Settings.Default.login_check = true;
                    gridManager.Properties.Settings.Default.Save();
                    gridManager.Properties.Settings.Default.login_user = i_user;
                    gridManager.Properties.Settings.Default.Save();
                    loginTimeRecord(i_user);
                }
            }
            rdr.Close();
        }
        return user_name;
    }

    public DataTable dateList(int check, int year, int month, int day)
    {
        List<DataTable> list = new List<DataTable>();
        MySqlCommand cmd;
        MySqlDataReader rdr;
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            DataTable dt = new DataTable();
            conn.Open();

            if (check == 1)
            {
                query = "select a.i_user, b.user_name as 판매자, count(i_sale) as 일일판매량, sum(food_price) as 일일판매액"
                    + " from food_sale a left join food_user b on a.i_user = b.i_user where extract(year from r_dt) = " + year + " and extract(month from r_dt) = " + month
                    + " and extract(day from r_dt) = " + day + " group by i_user";
            }
            else if (check == 2)
            {
                query = "select food_menu as 메뉴, count(i_sale) as 일일판매량, sum(food_price) as 일일판매액"
                    + " from food_sale where extract(year from r_dt) = " + year + " and extract(month from r_dt) = " + month
                    + " and extract(day from r_dt) = " + day + " group by food_menu";
            }
            else if (check == 3)
            {
                query = "select food_menu as 메뉴, count(i_sale) as 월간판매량, sum(food_price) as 월간판매액"
                    + " from food_sale where extract(year from r_dt) =" + year + " and extract(month from r_dt) =" + month
                    + " group by food_menu";
            }

            cmd = new MySqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            return dt;
        }
    }

    public DataTable logList()
    {
        List<DataTable> list = new List<DataTable>();
        MySqlCommand cmd;
        MySqlDataReader rdr;

        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            DataTable dt = new DataTable();
            conn.Open();

            query = "select user_name as 판매자, loginTime as 로그인시간, logoutTime as 로그아웃시간 from food_user where i_user != 1";

            cmd = new MySqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            return dt;
        }
    }


}


