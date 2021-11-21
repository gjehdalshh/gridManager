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


    public void insert_food(int i_user, string food_menu, int food_price)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "insert into food_sale (i_user, food_menu, food_price) values ("+i_user+",'"+food_menu+"', '"+food_price+"')";

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

            while(rdr.Read())
            {
                if(id.Equals((string)rdr["user_id"]) && pw.Equals((string)rdr["user_pw"]))
                {
                    int i_user = (int)rdr["i_user"];
                    user_name = (string)rdr["user_name"];
                    gridManager.Properties.Settings.Default.login_check = true;
                    gridManager.Properties.Settings.Default.Save();
                    gridManager.Properties.Settings.Default.login_user = i_user;
                    gridManager.Properties.Settings.Default.Save();
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

            if (check == 1) {
                query = "select a.i_user, b.user_name as 판매자, count(i_sale) as 일일판매량, sum(food_price) as 일일판매액"
                    + " from food_sale a left join food_user b on a.i_user = b.i_user where extract(year from r_dt) = " + year + " and extract(month from r_dt) = " + month
                    + " and extract(day from r_dt) = " + day + " group by i_user";
            } else if(check == 2) {
                query = "select food_menu as 메뉴, count(i_sale) as 일일판매량, sum(food_price) as 일일판매액"
                    + " from food_sale where extract(year from r_dt) = " + year + " and extract(month from r_dt) = " + month
                    + " and extract(day from r_dt) = " + day + " group by food_menu";
            } else if(check == 3) {
                query = "select food_menu as 메뉴, count(i_sale) as 월간판매량, sum(food_price) as 월간판매액"
                    + " from food_sale where extract(year from r_dt) =" +year + " and extract(month from r_dt) ="+ month
                    +" group by food_menu";
            }

            cmd = new MySqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            return dt;
        }
    }
}


