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

        private void InitializeVariables()
        {
            comboBoxGugbabChoiceSell.Items.Clear();
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

        private void buttonManagerOption_Click(object sender, EventArgs e)
        {
            FormManager_Option newformManager = new FormManager_Option();
            newformManager.Show();
        }

        private void buttonTable1_Click(object sender, EventArgs e)
        {
            FormTable newTable1 = new FormTable("1", accessor);
            newTable1.Show();
        }

        private void buttonTable2_Click(object sender, EventArgs e)
        {
            FormTable newTable2 = new FormTable("2", accessor);
            newTable2.Show();
        }

        private void buttonTable3_Click(object sender, EventArgs e)
        {
            FormTable newTable3 = new FormTable("3", accessor);
            newTable3.Show();
        }

        private void buttonTable4_Click(object sender, EventArgs e)
        {
            FormTable newTable4 = new FormTable("4", accessor);
            newTable4.Show();
        }

        private void buttonTable5_Click(object sender, EventArgs e)
        {
            FormTable newTable5 = new FormTable("5", accessor);
            newTable5.Show();
        }

        private void buttonTable6_Click(object sender, EventArgs e)
        {
            FormTable newTable6 = new FormTable("6", accessor);
            newTable6.Show();
        }
    }
}
