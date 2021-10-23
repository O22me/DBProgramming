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

namespace StudentManagement_Binary
{
    public partial class FormDBPTraining : Form
    {
        public FormDBPTraining()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            #region comboBox Initialization
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
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            //bool형 변수 AutoLoad를 생성하여 체크여부를 확인
            bool AutoLoad = br.ReadBoolean();
            int numberOfStudents = 0;
            for (int i = 0; i < 3; i++)
            {
                //파일 존재 확인 후 개수많큼 증가
                if (br.ReadBoolean())
                {
                    numberOfStudents++;
                }
            }
            //labelSettingInfo 수정
            labelSettingInfo.Text = "현재 저장된 학생 수 : " + numberOfStudents.ToString();
            br.Close();
            //checkBoxSettingInfo_CheckedChanged() 이벤트를 활성화 해두었음(단순 저장)
            checkBoxSettingInfo.Checked = AutoLoad;
            //그 후 체크되어 있다면 자동으로 학생정보 로드
            if (checkBoxSettingInfo.Checked)
            {
                LoadStudentInfo();
            }
        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            for (int i = 0; i < 4; i++)
            {
                br.ReadBoolean(); //체크박스, 학생정보 여부(3명)
            }
            //텍스트 박스 및 콤보박스에 정보 반영
            textBoxStudent1Name.Text = br.ReadString();
            textBoxStudent1ID.Text = br.ReadString();
            comboBoxStudent1Gender.SelectedIndex = br.ReadInt32();
            textBoxStudent1Memo.Text = br.ReadString();
            textBoxStudent2Name.Text = br.ReadString();
            textBoxStudent2ID.Text = br.ReadString();
            comboBoxStudent2Gender.SelectedIndex = br.ReadInt32();
            textBoxStudent2Memo.Text = br.ReadString();
            textBoxStudent3Name.Text = br.ReadString();
            textBoxStudent3ID.Text = br.ReadString();
            comboBoxStudent3Gender.SelectedIndex = br.ReadInt32();
            textBoxStudent3Memo.Text = br.ReadString();
            br.Close();
        }

        private void checkBoxSettingInfo_CheckedChanged(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            br.ReadBoolean();
            bool student1InfoExist = br.ReadBoolean();
            bool student2InfoExist = br.ReadBoolean();
            bool student3InfoExist = br.ReadBoolean();
            string textBoxStudent1Name = br.ReadString();
            string textBoxStudent1ID = br.ReadString();
            int comboBoxStudent1Gender = br.ReadInt32();
            string textBoxStudent1Memo = br.ReadString();
            string textBoxStudent2Name = br.ReadString();
            string textBoxStudent2ID = br.ReadString();
            int comboBoxStudent2Gender = br.ReadInt32();
            string textBoxStudent2Memo = br.ReadString();
            string textBoxStudent3Name = br.ReadString();
            string textBoxStudent3ID = br.ReadString();
            int comboBoxStudent3Gender = br.ReadInt32();
            string textBoxStudent3Memo = br.ReadString();
            br.Close();

            BinaryWriter bw = new BinaryWriter(new FileStream("StudentInfo.stu", FileMode.Create));
            bw.Write(checkBoxSettingInfo.Checked);
            bw.Write(student1InfoExist);
            bw.Write(student2InfoExist);
            bw.Write(student3InfoExist);
            bw.Write(textBoxStudent1Name);
            bw.Write(textBoxStudent1ID);
            bw.Write(comboBoxStudent1Gender);
            bw.Write(textBoxStudent1Memo);
            bw.Write(textBoxStudent2Name);
            bw.Write(textBoxStudent2ID);
            bw.Write(comboBoxStudent2Gender);
            bw.Write(textBoxStudent2Memo);
            bw.Write(textBoxStudent3Name);
            bw.Write(textBoxStudent3ID);
            bw.Write(comboBoxStudent3Gender);
            bw.Write(textBoxStudent3Memo);
            bw.Close();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            //학생 1과 관련되지 않은 정보는 변수를 두어 저장(하나의 파일에 두개의 FileStream 불가)
            br.ReadBoolean();
            br.ReadBoolean();
            bool student2InfoExist = br.ReadBoolean();
            bool student3InfoExist = br.ReadBoolean();
            br.ReadString();
            br.ReadString();
            br.ReadInt32();
            br.ReadString();
            string textBoxStudent2Name = br.ReadString();
            string textBoxStudent2ID = br.ReadString();
            int comboBoxStudent2Gender = br.ReadInt32();
            string textBoxStudent2Memo = br.ReadString();
            string textBoxStudent3Name = br.ReadString();
            string textBoxStudent3ID = br.ReadString();
            int comboBoxStudent3Gender = br.ReadInt32();
            string textBoxStudent3Memo = br.ReadString();
            br.Close();

            BinaryWriter bw = new BinaryWriter(new FileStream("StudentInfo.stu", FileMode.Create));
            //학생 1의 정보만 수정하기 위해 현재 입력한 것을 파일에 저장. 그 외의 것은 위 변수통해 그대로 옮김.
            bw.Write(checkBoxSettingInfo.Checked);
            bw.Write(true);
            bw.Write(student2InfoExist);
            bw.Write(student3InfoExist);
            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.SelectedIndex);
            bw.Write(textBoxStudent1Memo.Text);
            bw.Write(textBoxStudent2Name);
            bw.Write(textBoxStudent2ID);
            bw.Write(comboBoxStudent2Gender);
            bw.Write(textBoxStudent2Memo);
            bw.Write(textBoxStudent3Name);
            bw.Write(textBoxStudent3ID);
            bw.Write(comboBoxStudent3Gender);
            bw.Write(textBoxStudent3Memo);
            bw.Close();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            br.ReadBoolean();
            bool student1InfoExist = br.ReadBoolean();
            br.ReadBoolean();
            bool student3InfoExist = br.ReadBoolean();
            string textBoxStudent1Name = br.ReadString();
            string textBoxStudent1ID = br.ReadString();
            int comboBoxStudent1Gender = br.ReadInt32();
            string textBoxStudent1Memo = br.ReadString();
            br.ReadString();
            br.ReadString();
            br.ReadInt32();
            br.ReadString();
            string textBoxStudent3Name = br.ReadString();
            string textBoxStudent3ID = br.ReadString();
            int comboBoxStudent3Gender = br.ReadInt32();
            string textBoxStudent3Memo = br.ReadString();
            br.Close();

            BinaryWriter bw = new BinaryWriter(new FileStream("StudentInfo.stu", FileMode.Create));
            bw.Write(checkBoxSettingInfo.Checked);
            bw.Write(student1InfoExist);
            bw.Write(true); //파일에 정보를 입력하였으므로 존재(true)
            bw.Write(student3InfoExist);
            bw.Write(textBoxStudent1Name);
            bw.Write(textBoxStudent1ID);
            bw.Write(comboBoxStudent1Gender);
            bw.Write(textBoxStudent1Memo);
            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.SelectedIndex);
            bw.Write(textBoxStudent2Memo.Text);
            bw.Write(textBoxStudent3Name);
            bw.Write(textBoxStudent3ID);
            bw.Write(comboBoxStudent3Gender);
            bw.Write(textBoxStudent3Memo);
            bw.Close();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            br.ReadBoolean();
            bool student1InfoExist = br.ReadBoolean();
            bool student2InfoExist = br.ReadBoolean();
            br.ReadBoolean();
            string textBoxStudent1Name = br.ReadString();
            string textBoxStudent1ID = br.ReadString();
            int comboBoxStudent1Gender = br.ReadInt32();
            string textBoxStudent1Memo = br.ReadString();
            string textBoxStudent2Name = br.ReadString();
            string textBoxStudent2ID = br.ReadString();
            int comboBoxStudent2Gender = br.ReadInt32();
            string textBoxStudent2Memo = br.ReadString();
            br.ReadString();
            br.ReadString();
            br.ReadInt32();
            br.ReadString();
            br.Close();

            BinaryWriter bw = new BinaryWriter(new FileStream("StudentInfo.stu", FileMode.Create));
            bw.Write(checkBoxSettingInfo.Checked);
            bw.Write(student1InfoExist);
            bw.Write(student2InfoExist);
            bw.Write(true);
            bw.Write(textBoxStudent1Name);
            bw.Write(textBoxStudent1ID);
            bw.Write(comboBoxStudent1Gender);
            bw.Write(textBoxStudent1Memo);
            bw.Write(textBoxStudent2Name);
            bw.Write(textBoxStudent2ID);
            bw.Write(comboBoxStudent2Gender);
            bw.Write(textBoxStudent2Memo);
            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.SelectedIndex);
            bw.Write(textBoxStudent3Memo.Text);
            bw.Close();
        }

        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            //Boolean 처리를 위해 변수활용
            br.ReadBoolean();
            br.ReadBoolean();
            bool student2InfoExist = br.ReadBoolean();
            bool student3InfoExist = br.ReadBoolean();
            br.Close();
            BinaryWriter bw = new BinaryWriter(new FileStream("StudentInfo.stu", FileMode.Create));
            bw.Write(checkBoxSettingInfo.Checked);
            bw.Write(false);    //삭제하였으므로 false처리.
            bw.Write(student2InfoExist);
            bw.Write(student3InfoExist);
            bw.Write("");
            bw.Write("");
            bw.Write(0);
            bw.Write("");
            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.SelectedIndex);
            bw.Write(textBoxStudent2Memo.Text);
            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.SelectedIndex);
            bw.Write(textBoxStudent3Memo.Text);
            bw.Close();
            //삭제 후 보이는 입력칸은 초기화.
            textBoxStudent1Name.Clear();
            textBoxStudent1ID.Clear();
            comboBoxStudent1Gender.SelectedIndex = 0;
            textBoxStudent1Memo.Clear();
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            br.ReadBoolean();
            bool student1InfoExist = br.ReadBoolean();
            br.ReadBoolean();
            bool student3InfoExist = br.ReadBoolean();
            br.Close();
            BinaryWriter bw = new BinaryWriter(new FileStream("StudentInfo.stu", FileMode.Create));
            bw.Write(checkBoxSettingInfo.Checked);
            bw.Write(student1InfoExist);
            bw.Write(false);
            bw.Write(student3InfoExist);
            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.SelectedIndex);
            bw.Write(textBoxStudent1Memo.Text);
            bw.Write("");
            bw.Write("");
            bw.Write(0);
            bw.Write("");
            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.SelectedIndex);
            bw.Write(textBoxStudent3Memo.Text);
            bw.Close();
            textBoxStudent2Name.Clear();
            textBoxStudent2ID.Clear();
            comboBoxStudent2Gender.SelectedIndex = 0;
            textBoxStudent2Memo.Clear();
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("StudentInfo.stu", FileMode.Open));
            br.ReadBoolean();
            bool student1InfoExist = br.ReadBoolean();
            bool student2InfoExist = br.ReadBoolean();
            br.ReadBoolean();
            br.Close();
            BinaryWriter bw = new BinaryWriter(new FileStream("StudentInfo.stu", FileMode.Create));
            bw.Write(checkBoxSettingInfo.Checked);
            bw.Write(student1InfoExist);
            bw.Write(student2InfoExist);
            bw.Write(false);
            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.SelectedIndex);
            bw.Write(textBoxStudent1Memo.Text);
            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.SelectedIndex);
            bw.Write(textBoxStudent2Memo.Text);
            bw.Write("");
            bw.Write("");
            bw.Write(0);
            bw.Write("");
            bw.Close();
            textBoxStudent3Name.Clear();
            textBoxStudent3ID.Clear();
            comboBoxStudent3Gender.SelectedIndex = 0;
            textBoxStudent3Memo.Clear();
        }
    }
}
