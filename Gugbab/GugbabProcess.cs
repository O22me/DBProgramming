using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gugbab
{
    public partial class FormGugbab : Form
    {
        public FormGugbab(string accessor_ = "")
        {
            accessor = accessor_;
            InitializeComponent();
            InitializeVariables();
        }

        //UPDATE `s5414057`.`GugbabType` SET `GUGBAB` = 'aa' WHERE (`GUGBAB` = '김치');


        private void InitializeVariables()
        {
            comboBoxGugbabChoiceSell.Items.Clear();
            comboBoxGugbab_typeDateSell.SelectedIndex = 0;
            comboBoxGugbab_typeMonthSell.SelectedIndex = 0;
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT GUGBAB FROM s5414057.GugbabType;";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxGugbabChoiceSell.Items.Add(reader["GUGBAB"]);
                }

                reader.Close();
                connection.Close();
            }
        }

        //서버접속 connection설정
        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";
        string accessor = "";

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "INSERT INTO `s5414057`.`ConnectionRecord` (`ACCESSOR`, `SIGNINOUT`, `ACCESS_TIME`) VALUES ('" + accessor + "', 'OUT', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            FormSignIn newformSignIn = new FormSignIn();
            newformSignIn.Show();
            this.Close();
        }

        private void buttonManagerTotal_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();
                string query = "SELECT * FROM s5414057.Gugbab_Sell;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewTotal.DataSource = dt;
                connection.Close();
            }
        }

        private void buttonUser1DateSell_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();
                string query = "SELECT DATE_FORMAT(SALES_TIME, '%Y-%m-%d') AS DATE, sum(QUANTITY), sum(TOTAL) FROM s5414057.Gugbab_Sell  WHERE SELLER = 'User1' GROUP BY DATE_FORMAT(SALES_TIME, '%Y-%m-%d');";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewUser1DateSell.DataSource = dt;
                connection.Close();
            }
        }

        private void buttonUser2DateSell_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();
                string query = "SELECT DATE_FORMAT(SALES_TIME, '%Y-%m-%d') AS DATE, sum(QUANTITY), sum(TOTAL) FROM s5414057.Gugbab_Sell  WHERE SELLER = 'User2' GROUP BY DATE_FORMAT(SALES_TIME, '%Y-%m-%d');";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewUser2DateSell.DataSource = dt;
                connection.Close();
            }
        }

        private void buttonGugbab_type_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();
                string query = "SELECT DATE_FORMAT(SALES_TIME, '%Y-%m-%d') AS DATE, sum(QUANTITY), sum(TOTAL) FROM s5414057.Gugbab_Sell  WHERE GUGBAB_TYPE = '" + comboBoxGugbab_typeDateSell.Text + "' GROUP BY DATE_FORMAT(SALES_TIME, '%Y-%m-%d');";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewGugbab_typeDateSell.DataSource = dt;
                connection.Close();
            }
        }

        private void buttonGugbab_typeMonthSell_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();
                string query = "SELECT DATE_FORMAT(SALES_TIME, '%Y-%m') AS DATE, sum(QUANTITY), sum(TOTAL) FROM s5414057.Gugbab_Sell  WHERE GUGBAB_TYPE = '" + comboBoxGugbab_typeMonthSell.Text + "' GROUP BY DATE_FORMAT(SALES_TIME, '%Y-%m');";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewGugbab_typeMonthSell.DataSource = dt;
                connection.Close();
            }
        }

        //SELECT PRICE FROM s5414057.GugbabType WHERE GUGBAB = '돼지';

        private void buttonGugbabSell_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT PRICE FROM s5414057.GugbabType WHERE GUGBAB = '" + comboBoxGugbabChoiceSell.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                string price = "";
                while (reader.Read())
                {
                    price = string.Format("{0}", reader["PRICE"]);
                }
                reader.Close();

                query = "INSERT INTO `s5414057`.`Gugbab_Sell` (`SELLER`, `GUGBAB_TYPE`, `QUANTITY`, `PRICE`, `TOTAL`, `SALES_TIME`) " +
                    "VALUES ('" + accessor + "', '" + comboBoxGugbabChoiceSell.Text + "', '1', '" + price + "', '" + Convert.ToString(1 * Convert.ToInt32(price)) + "', '" + dateTimePickerCasher.Text + "');";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        //INSERT INTO `s5414057`.`GugbabType` (`GUGBAB`, `PRICE`) VALUES ('돼지', '6000');

        private void buttonNewGugbabAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "INSERT INTO `s5414057`.`GugbabType` (`GUGBAB`, `PRICE`) VALUES ('" + textBoxNewGugbabName.Text + "', '" + textBoxNewGugbabPrice.Text + "');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void buttonMenuChange_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "UPDATE `s5414057`.`GugbabType` SET `GUGBAB` = '" + textBoxChangeAfter.Text + "' WHERE (`GUGBAB` = '" + textBoxChangeBefore.Text + "');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
