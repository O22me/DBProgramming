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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            InitializeVariables();
        }

        private void InitializeVariables()
        {

        }

        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";
        string accessor = "";
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT EXISTS(SELECT ID FROM s5414057.GugbabManager WHERE ID = '" + textBoxSignInID.Text + "' AND PW = '" + textBoxSignInPW.Text + "') AS SUCCESS;";
                string matchIDPW = "";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                //ID, PW일치여부 DB에서 확인
                while (reader.Read())
                {
                    matchIDPW = string.Format("{0}", reader["SUCCESS"]);
                }
                reader.Close();

                if (matchIDPW == "1")
                {
                    query = "SELECT NAME FROM s5414057.GugbabManager WHERE ID = '" + textBoxSignInID.Text + "';";
                    cmd.CommandText = query;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        accessor = string.Format("{0}", reader["NAME"]);
                    }
                    reader.Close();

                    query = "INSERT INTO `s5414057`.`ConnectionRecord` (`ACCESSOR`, `SIGNINOUT`, `ACCESS_TIME`) VALUES ('" + accessor + "', 'IN', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    this.Hide();
                    FormGugbab newformGugbab = new FormGugbab(accessor);
                    newformGugbab.Show();
                }
                else
                {
                    labelSignStatement.Text = "ID, PW가 일치하지 않습니다. 다시 시도해 주세요.";
                }
                connection.Close();
            }
        }

        private void textBoxSignInID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignIn_Click(sender, e);
            }
        }

        private void textBoxSignInPW_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignIn_Click(sender, e);
            }
        }

        private void FormSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
