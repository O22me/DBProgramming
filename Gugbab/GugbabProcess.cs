using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gugbab
{
    public partial class FormGugbab : Form
    {
        public FormGugbab()
        {
            InitializeComponent();
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            buttonCasher_Sundae.Enabled = false;
            buttonCasher_Pig.Enabled = false;
            buttonCasher_Mix.Enabled = false;
            buttonSignOut.Enabled = false;
            dateTimePickerCasher.Enabled = false;
            buttonManagerTotal.Enabled = false;
            buttonUser1DateSell.Enabled = false;
            buttonUser2DateSell.Enabled = false;
            buttonGugbab_typeDateSell.Enabled = false;
            buttonGugbab_typeMonthSell.Enabled = false;
            comboBoxGugbab_typeDateSell.SelectedIndex = 0;
            comboBoxGugbab_typeMonthSell.SelectedIndex = 0;
        }

        //서버접속 connection설정
        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";
        //국밥가격 결정
        string pig_price = "6000";
        string mix_price = "6500";
        string sundae_price = "7000";
        string accessor = "";

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT ID, PW FROM s5414057.GugbabManager;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                //DB에 저장된 ID, PW 읽어오기 <ID(키), PW(값)>으로 사용.
                Dictionary<string, string> DB_idpw = new Dictionary<string, string>();
                while (reader.Read())
                {
                    DB_idpw.Add(string.Format("{0}", reader["ID"]), string.Format("{0}", reader["PW"]));
                }
                reader.Close();

                //일치하는 ID포함.
                if (DB_idpw.ContainsKey(textBoxID.Text))
                {
                    string db_pw = DB_idpw[textBoxID.Text];
                    //해당ID의 PW확인
                    if (db_pw == textBoxPW.Text)
                    {
                        query = "SELECT NAME FROM s5414057.GugbabManager WHERE ID = '" + textBoxID.Text + "';";
                        cmd.CommandText = query;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            accessor = string.Format("{0}", reader["NAME"]);
                        }
                        labelSignStatement.Text = string.Format("환영합니다. {0}님.", accessor);
                    }
                    else
                    {
                        labelSignStatement.Text = "ERROR : 잘못된 PW입니다.";
                        return;
                    }
                }
                else
                {
                    labelSignStatement.Text = "ERROR : 잘못된 ID입니다.";
                    return;
                }
                reader.Close();
                connection.Close();
            }
            buttonCasher_Pig.Enabled = true;
            buttonCasher_Mix.Enabled = true;
            buttonCasher_Sundae.Enabled = true;
            textBoxID.Enabled = false;
            textBoxPW.Enabled = false;
            buttonSignIn.Enabled = false;
            buttonSignOut.Enabled = true;
            dateTimePickerCasher.Enabled = true;
            buttonManagerTotal.Enabled = true;
            buttonUser1DateSell.Enabled = true;
            buttonUser2DateSell.Enabled = true;
            buttonGugbab_typeDateSell.Enabled = true;
            buttonGugbab_typeMonthSell.Enabled = true;
        }

        private void textBoxPW_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignIn_Click(sender, e);
            }
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            buttonCasher_Pig.Enabled = false;
            buttonCasher_Mix.Enabled = false;
            buttonCasher_Sundae.Enabled = false;
            textBoxID.Enabled = true;
            textBoxPW.Enabled = true;
            buttonSignIn.Enabled = true;
            buttonSignOut.Enabled = false;
            dateTimePickerCasher.Enabled = false;
            buttonManagerTotal.Enabled = false;
            buttonUser1DateSell.Enabled = false;
            buttonUser2DateSell.Enabled = false;
            buttonGugbab_typeDateSell.Enabled = false;
            buttonGugbab_typeMonthSell.Enabled = false;
            textBoxID.Clear();
            textBoxPW.Clear();
            labelSignStatement.Text = "로그아웃 되었습니다. 다시 로그인 해주세요.";
        }

        private void buttonCasher_Pig_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "INSERT INTO `s5414057`.`Gugbab_Sell` (`SELLER`, `GUGBAB_TYPE`, `QUANTITY`, `PRICE`, `TOTAL`, `SALES_TIME`) " +
                    "VALUES ('" + accessor + "', '돼지', '1', '" + pig_price + "', '" + Convert.ToString(1*Convert.ToInt32(pig_price)) + "', '" + dateTimePickerCasher.Text + "');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void buttonCasher_Mix_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "INSERT INTO `s5414057`.`Gugbab_Sell` (`SELLER`, `GUGBAB_TYPE`, `QUANTITY`, `PRICE`, `TOTAL`, `SALES_TIME`) " +
                    "VALUES ('" + accessor + "', '섞어', '1', '" + mix_price + "', '" + Convert.ToString(1 * Convert.ToInt32(mix_price)) + "', '" + dateTimePickerCasher.Text + "');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                
                connection.Close();
            }
        }

        private void buttonCasher_Sundae_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "INSERT INTO `s5414057`.`Gugbab_Sell` (`SELLER`, `GUGBAB_TYPE`, `QUANTITY`, `PRICE`, `TOTAL`, `SALES_TIME`) " +
                    "VALUES ('" + accessor + "', '순대', '1', '" + sundae_price + "', '" + Convert.ToString(1 * Convert.ToInt32(sundae_price)) + "', '" + dateTimePickerCasher.Text + "');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
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
    }
}
