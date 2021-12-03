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
    public partial class FormManager_Option : Form
    {
        public FormManager_Option()
        {
            InitializeComponent();
        }

        //서버접속 connection설정
        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";

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
