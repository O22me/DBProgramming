using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement_DB
{
    public partial class Assignment06 : Form
    {
        public Assignment06()
        {
            InitializeComponent();
            InitializeVariables();
        }

        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";
        int student_count = 0;

        private void InitializeVariables()
        {
            #region comboBox Initialization 남자, 여자
            string[] genderData = { "남자", "여자" };
            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent3Gender.Items.Clear();

            comboBoxStudent1Gender.Items.AddRange(genderData);
            comboBoxStudent2Gender.Items.AddRange(genderData);
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;
            #endregion
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                //학생수 알아내기
                string query = "SELECT COUNT(ID) FROM s5414057.StudentInfo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                labelSettingInfo.Text = string.Format("현재 저장된 학생 수 : {0}", reader["COUNT(ID)"]);
                student_count = Convert.ToInt32(string.Format("{0}", reader["COUNT(ID)"]));
                reader.Close();
                
                //체크박스 확인
                query = "SELECT * FROM s5414057.StudentInfo_Checkbox;";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                reader.Read();
                bool AutoLoad = Convert.ToBoolean(string.Format("{0}", reader["ISCHECKED"]));
                reader.Close();
                
                //체크되어있다면
                if (AutoLoad)
                {
                    //DB에 저장된 값을 체크박스에 반영
                    checkBoxSettingInfo.Checked = true;
                    LoadStudentAllInfo();
                }
                else
                {
                    checkBoxSettingInfo.Checked = false;
                }
                connection.Close();
            }
        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudentAllInfo();
        }

        private void LoadStudentAllInfo()
        {
            //학생수가 없다면 Table은 비었으므로 반환.
            if (student_count == 0) return;
            //이하 최소 학생수 1명 이상.
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                //존재하는 학생 그룹박스 번호만 추출 예) 학생2 -> 2
                string query = "SELECT UI_NUM FROM s5414057.StudentInfo;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                //하나의 리스트에 그룹박스 번호 추가.
                List<int> UI_num = new List<int>();
                while (reader.Read())
                {
                    UI_num.Add(Convert.ToInt32(string.Format("{0}", reader["UI_NUM"])));
                }
                reader.Close();
                connection.Close();
                //UI_NUM의 값만 LoadStudent{UI_NUM}Info() 호출.
                foreach (int ui_num in UI_num)
                {
                    switch (ui_num)
                    {
                        case 1: LoadStudent1Info(); break;
                        case 2: LoadStudent2Info(); break;
                        case 3: LoadStudent3Info(); break;
                        default: MessageBox.Show("잘못된 UI_NUM"); break;
                    }
                }
            }
        }

        private void LoadStudent1Info()
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                //UI_num=1 이 조건, ID, NAME, GENDER, MEMO에 대해 테이블 호출
                string query = "SELECT ID, NAME, GENDER, MEMO FROM s5414057.StudentInfo WHERE UI_NUM = 1;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                //string형태로 받은다음 Split 후 각 텍스트박스 등에 작성.
                string str = string.Format("{0} {1} {2} {3}", reader["ID"], reader["NAME"], reader["GENDER"], reader["MEMO"]);
                string[] Info = str.Split(' ');

                textBoxStudent1ID.Text = Info[0];
                textBoxStudent1Name.Text = Info[1];
                comboBoxStudent1Gender.Text = Info[2];
                textBoxStudent1Memo.Text = Info[3];

                connection.Close();
            }
        }

        private void LoadStudent2Info()
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT ID, NAME, GENDER, MEMO FROM s5414057.StudentInfo WHERE UI_NUM = 2;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                string str = string.Format("{0} {1} {2} {3}", reader["ID"], reader["NAME"], reader["GENDER"], reader["MEMO"]);
                string[] Info = str.Split(' ');

                textBoxStudent2ID.Text = Info[0];
                textBoxStudent2Name.Text = Info[1];
                comboBoxStudent2Gender.Text = Info[2];
                textBoxStudent2Memo.Text = Info[3];

                connection.Close();
            }
        }

        private void LoadStudent3Info()
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT ID, NAME, GENDER, MEMO FROM s5414057.StudentInfo WHERE UI_NUM = 3;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                string str = string.Format("{0} {1} {2} {3}", reader["ID"], reader["NAME"], reader["GENDER"], reader["MEMO"]);
                string[] Info = str.Split(' ');

                textBoxStudent3ID.Text = Info[0];
                textBoxStudent3Name.Text = Info[1];
                comboBoxStudent3Gender.Text = Info[2];
                textBoxStudent3Memo.Text = Info[3];

                connection.Close();
            }
        }

        private void checkBoxSettingInfo_CheckedChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "";
                //체크박스의 체크가 바뀔때 마다 DB에 반영
                if (checkBoxSettingInfo.Checked)
                {
                    query = "UPDATE `s5414057`.`StudentInfo_Checkbox` SET `ISCHECKED` = '1' WHERE (`ISCHECKED` = '0');";
                }
                else
                {
                    query = "UPDATE `s5414057`.`StudentInfo_Checkbox` SET `ISCHECKED` = '0' WHERE (`ISCHECKED` = '1');";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private bool IsExistTuple(int ui_num)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "SELECT UI_NUM FROM s5414057.StudentInfo;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<int> UI_num = new List<int>();
                while (reader.Read())
                {
                    UI_num.Add(Convert.ToInt32(string.Format("{0}", reader["UI_NUM"])));
                }
                reader.Close();
                connection.Close();

                //해당 그룹박스의 내용이 존재하는지를 반환.
                return UI_num.Contains(ui_num);
            }
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (IsExistTuple(1)) //기존의 내용 업데이트
                {
                    //쿼리문을 TextBox등에 포함된 내용과 함께 작성. 이미 존재하는 경우 UPDATE문을 통해 수정
                    query = "UPDATE `s5414057`.`StudentInfo` SET `ID` = '" + textBoxStudent1ID.Text + "', `NAME` = '" + textBoxStudent1Name.Text
                        + "', `GENDER` = '" + comboBoxStudent1Gender.Text + "', `MEMO` = '" + textBoxStudent1Memo.Text + "' WHERE (`UI_NUM` = '1');";
                    //명령할 쿼리 변경
                    cmd.CommandText = query;
                    //쿼리 전달
                    cmd.ExecuteNonQuery();
                }
                else //아무것도 없을 경우 추가.
                {
                    //추가하는경우 INSERT INTO문을 작성
                    query = "INSERT INTO `s5414057`.`StudentInfo` (`ID`, `NAME`, `GENDER`, `MEMO`, `UI_NUM`) VALUES ('"
                        + textBoxStudent1ID.Text +"', '" + textBoxStudent1Name.Text + "', '" + comboBoxStudent1Gender.Text + "', '" + textBoxStudent1Memo.Text + "', '1');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    student_count++;
                }
                connection.Close();
            }
            //라벨 수정.
            labelSettingInfo.Text = string.Format("현재 저장된 학생 수 : {0}", student_count);
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (IsExistTuple(2)) 
                {
                    query = "UPDATE `s5414057`.`StudentInfo` SET `ID` = '" + textBoxStudent2ID.Text + "', `NAME` = '" + textBoxStudent2Name.Text
                        + "', `GENDER` = '" + comboBoxStudent2Gender.Text + "', `MEMO` = '" + textBoxStudent2Memo.Text + "' WHERE (`UI_NUM` = '2');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                else 
                {
                    query = "INSERT INTO `s5414057`.`StudentInfo` (`ID`, `NAME`, `GENDER`, `MEMO`, `UI_NUM`) VALUES ('"
                        + textBoxStudent2ID.Text + "', '" + textBoxStudent2Name.Text + "', '" + comboBoxStudent2Gender.Text + "', '" + textBoxStudent2Memo.Text + "', '2');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    student_count++;
                }
                connection.Close();
            }
            labelSettingInfo.Text = string.Format("현재 저장된 학생 수 : {0}", student_count);
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (IsExistTuple(3)) 
                {
                    query = "UPDATE `s5414057`.`StudentInfo` SET `ID` = '" + textBoxStudent3ID.Text + "', `NAME` = '" + textBoxStudent3Name.Text
                        + "', `GENDER` = '" + comboBoxStudent3Gender.Text + "', `MEMO` = '" + textBoxStudent3Memo.Text + "' WHERE (`UI_NUM` = '3');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                else 
                {
                    query = "INSERT INTO `s5414057`.`StudentInfo` (`ID`, `NAME`, `GENDER`, `MEMO`, `UI_NUM`) VALUES ('"
                        + textBoxStudent3ID.Text + "', '" + textBoxStudent3Name.Text + "', '" + comboBoxStudent3Gender.Text + "', '" + textBoxStudent3Memo.Text + "', '3');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    student_count++;
                }
                connection.Close();
            }
            labelSettingInfo.Text = string.Format("현재 저장된 학생 수 : {0}", student_count);
        }

        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                //DELETE문을 통해 해당 그룹박스 내용 찾아 삭제(조건 : UI_NUM을 통해 해결)
                string query = "DELETE FROM `s5414057`.`StudentInfo` WHERE (`UI_NUM` = '1');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                
                connection.Close();
            }
            //삭제 후 UI 초기화
            textBoxStudent1ID.Text = "";
            textBoxStudent1Name.Text = "";
            comboBoxStudent1Gender.SelectedIndex = 0;
            textBoxStudent1Memo.Text = "";

            student_count--;
            //라벨 수정
            labelSettingInfo.Text = string.Format("현재 저장된 학생 수 : {0}", student_count);
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "DELETE FROM `s5414057`.`StudentInfo` WHERE (`UI_NUM` = '2');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            //삭제 후 초기화
            textBoxStudent2ID.Text = "";
            textBoxStudent2Name.Text = "";
            comboBoxStudent2Gender.SelectedIndex = 0;
            textBoxStudent2Memo.Text = "";

            student_count--;
            labelSettingInfo.Text = string.Format("현재 저장된 학생 수 : {0}", student_count);
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "DELETE FROM `s5414057`.`StudentInfo` WHERE (`UI_NUM` = '3');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            //삭제 후 초기화
            textBoxStudent3ID.Text = "";
            textBoxStudent3Name.Text = "";
            comboBoxStudent3Gender.SelectedIndex = 0;
            textBoxStudent3Memo.Text = "";

            student_count--;
            labelSettingInfo.Text = string.Format("현재 저장된 학생 수 : {0}", student_count);
        }
    }
}
