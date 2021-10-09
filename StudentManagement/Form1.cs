using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            
            //또다른방법(string배열 활용) : Clear()를 하고 사용할 것.
            string[] genderData = { "남자", "여자" };
            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent1Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;
             
        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }
        #region Student SaveButton Handler
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Student1 event Handler
        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStudent1ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void SaveStudent()
        {
            StudentInfo studentInfo = new StudentInfo();

            studentInfo.name = textBoxStudent1Name.Text;
            studentInfo.sid = textBoxStudent1ID.Text;
            studentInfo.gender = comboBoxStudent1Gender.Text;

            Stream ws = new FileStream("student.stu", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(ws, studentInfo);
            ws.Close();
        }
        private void LoadStudent()
        {
            Stream rs = new FileStream("student.stu", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            StudentInfo studentInfo = (StudentInfo)deserializer.Deserialize(rs);

            rs.Close();

            textBoxStudent1Name.Text = studentInfo.name;
            textBoxStudent1ID.Text = studentInfo.sid;
            comboBoxStudent1Gender.Text = studentInfo.gender;
        }
    }
}
