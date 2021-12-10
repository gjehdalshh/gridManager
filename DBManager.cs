using gridManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    public void insert_food(int i_user, string food_menu, int food_price, int nowTableNumber)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "insert into food_sale (i_user, food_menu, food_price, food_table) values (" + i_user + ",'" + food_menu + "', '" + food_price + "', "+ nowTableNumber + ")";

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

    string nowMenuName;
    int nowI_menu;
    int changeI_menu;

    public void select_foodState(string nowName) {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select * from food_menu where food_name = '"+nowName+"'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                changeI_menu = (int)rdr["i_menu"];
                nowMenuName = (string)rdr["food_name"];
            }
            rdr.Close();
        }
    }

    public void update_foodState(string changeName, int price)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "update food_menuUpdate set food_state = 0 where food_name = '" + nowMenuName + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            query = "insert into food_menuUpdate (food_menuNumber, food_name, food_price, food_state, i_user) values" +
                "("+ changeI_menu + ",'" + changeName + "', " + price + ", 1, " + gridManager.Properties.Settings.Default.login_user + ")";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

        }
    }



    public void insert_order(string name, int tableNumber, int state)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "insert into food_order (order_name, order_table, order_state) values ('"+name+"', "+tableNumber+", "+state+")";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            query = "insert into food_order (order_name, order_table, order_state) values ('" + name + "', " + tableNumber + ", 4)";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }

    public List<menuInfo> select_nowMenuList(int nowTableNumber) {
        List<menuInfo> list = new List<menuInfo>();

        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select a.i_order, a.order_name, a.order_state, a.order_table ,b.food_price from food_order a left join food_menu b on a.order_name = b.food_name " +
                "where order_table = "+ nowTableNumber + " and order_state = 0;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                menuInfo menu = new menuInfo();
                menu.i_order = (int)rdr["i_order"];
                menu.food_name = (string)rdr["order_name"];
                menu.food_price = (int)rdr["food_price"];
                menu.state = (int)rdr["order_state"];
                menu.table = (int)rdr["order_table"];
                list.Add(menu);
            }
            rdr.Close();

        }
        return list;
    }

    public int sumPayment(int nowTableNumber) {
        int price = 0;
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select food_price from food_order a left join food_menu b on a.order_name = b.food_name where order_table = "+ nowTableNumber + " and order_state = 0";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                price += (int)rdr["food_price"];
            }
            rdr.Close();
        }

        return price;
    }

    public void updateSaleState(int nowTableNumber) {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "update food_order set order_state = 1, m_dt = now() where order_state = 0 and order_table = "+ nowTableNumber + "";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

        }
    }

    public void updateSaleStateCencel(int i_order,int nowTableNumber)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "update food_order set order_state = 2, m_dt = now() where order_state = 0 and i_order = "+i_order+" and order_table = " + nowTableNumber + "";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

        }
    }

    public void selectI_menu(string name) {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select * from food_menu where food_name = '"+name+"'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                nowI_menu = (int)rdr["i_menu"];
            }
            rdr.Close();

        }
    }

    public void insert_newMenu(string name, int price) {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        { 
     
            conn.Open();
            query = "insert into food_menu (food_name, food_price) values ('" + name + "', " + price + ")";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            selectI_menu(name);
        }
    }
    public void insert_menuChange(string name, int price)
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "insert into food_menuUpdate (food_MenuNumber, food_name, food_price, food_state, i_user) values ("+ nowI_menu + ",'" + name + "', " + price + ", 1, " + gridManager.Properties.Settings.Default.login_user + ")";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public string imgOpen() {
        try
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); // 파일 탐색기 열림
            openFileDialog1.Filter = "Image files(*.jpg) | *.jpg |" + // jpg와 png만 선택가능
                                     "이미지 파일(*.png) | *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName; // 선택한 파일명 텍스트박스에 저장
            }
        }
        catch (Exception ex)
        {
        }
        return "";
    }


    public class menuInfo {
        public int i_order;
        public string food_name;
        public int food_price;
        public int state;
        public int table;
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

    public DataTable dateListBefore(int year, int month, int day) {
        List<DataTable> list = new List<DataTable>();
        MySqlCommand cmd;
        MySqlDataReader rdr;
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            DataTable dt = new DataTable();
            conn.Open();

            query = "select order_name as 메뉴, order_state as 메뉴변경전, order_table as 테이블, r_dt as 주문시간 from food_order where order_state = 4 " +
                "and extract(year from r_dt) = " + year + " and extract(month from r_dt) = " + month
                    + " and extract(day from r_dt) = " + day + "";

            cmd = new MySqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            return dt;
        }
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
            } else if(check == 4) 
            {
                query = "select order_name as 메뉴, order_state as 메뉴변경후,order_table as 테이블, r_dt as 주문시간, m_dt as 취소시간" +
                    "from food_order where order_state = 2 and extract(year from r_dt) = " + year + " and extract(month from r_dt) = " + month
                    + " and extract(day from r_dt) = " + day + "";
            }

            cmd = new MySqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            return dt;
        }
    }

    public DataTable payMentList(int year, int month, int day, int hour, int minute)
    {
        List<DataTable> list = new List<DataTable>();
        MySqlCommand cmd;
        MySqlDataReader rdr;
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            DataTable dt = new DataTable();
            conn.Open();

            query = "select order_name, order_table from food_order where order_state = 1 and extract(year from r_dt) = " + year + " and extract(month from r_dt) = " + month
                    + " and extract(day from r_dt) = " + day + " and extract(hour from r_dt) = "+hour+ " and extract(minute from r_dt) = "+minute+"";

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

    public DataTable menuChangeListBefore()
    {
        MySqlCommand cmd;
        MySqlDataReader rdr;
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            DataTable dt = new DataTable();
            conn.Open();

            query = "SELECT food_menuNumber as 메뉴번호, food_name as 음식명, food_price as 가격,food_state as 변경전상태, r_dt as 시간 from food_menuUpdate where food_state = 0";

            cmd = new MySqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            return dt;
        }
    }

    public DataTable menuChangeListAfter()
    {
        MySqlCommand cmd;
        MySqlDataReader rdr;
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            DataTable dt = new DataTable();
            conn.Open();

            query = "SELECT food_menuNumber as 메뉴번호, food_name as 음식명, food_price as 가격, food_state as 변경후상태, r_dt as 시간  from food_menuUpdate where food_state = 1";

            cmd = new MySqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            return dt;
        }
    }
}


