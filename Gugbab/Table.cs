using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gugbab
{
    public partial class FormTable : Form
    {
        public FormTable(string table_number_ = "0", string accessor_ = "")
        {
            table_number = table_number_;
            accessor = accessor_;
            InitializeComponent();
            InitializeVariables();
        }

        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";
        string table_number;
        string accessor = "";

        private void InitializeVariables()
        {
            listBoxMenuList.Items.Clear();
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT GUGBAB FROM s5414057.GugbabType;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBoxMenuList.Items.Add(string.Format("{0}", reader["GUGBAB"]));
                }
                reader.Close();
                connection.Close();
            }
            listBoxMenuList.SelectedIndex = 0;
            labelTableNumber.Text = table_number + "번 테이블";
        }

        private void buttonAddMenu_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT PRICE FROM s5414057.GugbabType WHERE GUGBAB = '" + listBoxMenuList.SelectedItem + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                string price = "";
                while (reader.Read())
                {
                    price = string.Format("{0}", reader["PRICE"]);
                }
                reader.Close();
                query = "INSERT INTO `s5414057`.`GugbabOrderInfo` (`TIME`, `GUGBAB`, `QUANTITY`, `PRICE`, `TOTAL`, `TABLE_NO`) " +
                    "VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + listBoxMenuList.SelectedItem + "', '1', '" + price + "', '" + Convert.ToString(1 * Convert.ToInt32(price)) + "', '" + table_number + "');";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                query = "SELECT TIME, GUGBAB, QUANTITY, PRICE, TOTAL FROM s5414057.GugbabOrderInfo WHERE TABLE_NO = " + table_number + ";";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewOrdered.DataSource = dt;

                connection.Close();
            }
        }

        private void buttonCancelMenu_Click(object sender, EventArgs e)
        {

        }

        //INSERT INTO `s5414057`.`Gugbab_Sell` (`SELLER`, `GUGBAB_TYPE`, `QUANTITY`, `PRICE`, `TOTAL`, `SALES_TIME`) VALUES('Admin', '돼지', '1', '6000', '6000', '2021-12-24 01:21:33');


        private void buttonPaymentComplete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                List<string> order_no = new List<string>();

                string query = "SELECT ORDER_NO FROM s5414057.GugbabOrderInfo WHERE TABLE_NO = '" + table_number + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                //해당테이블번호인 주문번호 가져오기 1->1, 2, 3, 6
                while (reader.Read())
                {
                    order_no.Add(string.Format("{0}", reader["ORDER_NO"]));
                }
                reader.Close();

                foreach (string order in order_no)
                {
                    query = "INSERT INTO `s5414057`.`Gugbab_Sell` (`SELLER`, `GUGBAB_TYPE`, `QUANTITY`, `PRICE`, `TOTAL`, `SALES_TIME`) " +
                        "VALUES('Admin'" +
                        ", (SELECT GUGBAB AS GUGBAB_TYPE FROM s5414057.GugbabOrderInfo WHERE ORDER_NO = '" + order + "')" +
                        ", (SELECT QUANTITY FROM s5414057.GugbabOrderInfo WHERE ORDER_NO = '" + order + "')" +
                        ", (SELECT PRICE FROM s5414057.GugbabOrderInfo WHERE ORDER_NO = '" + order + "')" +
                        ", (SELECT TOTAL FROM s5414057.GugbabOrderInfo WHERE ORDER_NO = '" + order + "')" +
                        ", (SELECT TIME AS SALES_TIME FROM s5414057.GugbabOrderInfo WHERE ORDER_NO = '" + order + "'));";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    query = "DELETE FROM `s5414057`.`GugbabOrderInfo` WHERE (`ORDER_NO` = '" + order + "');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
