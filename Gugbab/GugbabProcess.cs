using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            buttonCasher_Blood.Enabled = false;
            buttonCasher_Cowhead.Enabled = false;
            buttonCasher_Mix.Enabled = false;
            buttonSignOut.Enabled = false;
        }

        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";

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
                        string name = "";
                        while (reader.Read())
                        {
                            name = string.Format("{0}", reader["NAME"]);
                        }
                        labelSignStatement.Text = string.Format("환영합니다. {0}님.", name);
                    }
                    else
                    {
                        labelSignStatement.Text = "ERROR : 잘못된 PW입니다.";
                    }
                }
                else
                {
                    labelSignStatement.Text = "ERROR : 잘못된 ID입니다.";
                }
                reader.Close();
                connection.Close();
            }
            buttonCasher_Blood.Enabled = true;
            buttonCasher_Cowhead.Enabled = true;
            buttonCasher_Mix.Enabled = true;
            textBoxID.Enabled = false;
            textBoxPW.Enabled = false;
            buttonSignIn.Enabled = false;
            buttonSignOut.Enabled = true;
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
            buttonCasher_Blood.Enabled = false;
            buttonCasher_Cowhead.Enabled = false;
            buttonCasher_Mix.Enabled = false;
            textBoxID.Enabled = true;
            textBoxPW.Enabled = true;
            buttonSignIn.Enabled = true;
            buttonSignOut.Enabled = false;
            textBoxID.Clear();
            textBoxPW.Clear();
            labelSignStatement.Text = "로그아웃 되었습니다. 다시 로그인 해주세요.";
        }
    }
}
