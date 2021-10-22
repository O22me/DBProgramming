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

namespace MarketBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<List<string>> MakeColumnarDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);

            //string str = "";

            var line = sr.ReadLine();
            var headers = line.Split(',');

            List<List<string>> data = new List<List<string>>();
            foreach (string header in headers)
            {
                List<string> list = new List<string>();
                list.Add(header);

                data.Add(list);
            }
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = line.Split(','); //string[] values

                for (int i = 0; i < values.Length; i++)
                {
                    if (i == 10) break; //실제 컬럼수는 12지만 오류방지를 위해 10개로 제한.
                    data[i].Add(values[i]);
                }
            }

            sr.Close();

            return data;
        }

        #region print by Columnbased
        private void printColumnsData_columnbased(List<List<string>> data, int columnIdx)
        {
            string str = "";
            textBoxCSVViewer.Text = "";
            foreach (string value in data[columnIdx])
            {
                str += value + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private void printRowData_columnbased(List<List<string>> data, int rowIdx)
        {
            string str = "";
            textBoxCSVViewer.Text = "";
            for (int i = 0; i < 10; i++)
            {
                str += data[i][rowIdx] + ",";
            }
            textBoxCSVViewer.Text = str;
        }
        #endregion

        private string[] parseCSVLine(string line)
        {
            string[] parsedByComma = line.Split(',');
            string[] parsedCSV = new string[parsedByComma.Length];
            for (int i = 0; i < parsedByComma.Length; i++)
            {
                if (parsedByComma[i].Contains('\"'))
                {
                    parsedCSV[i] = string.Join("", (parsedByComma[i] + ',' + parsedByComma[i + 1]).Split('\"'));
                    i++;
                }
                else
                {
                    parsedCSV[i] = parsedByComma[i];
                }
            }
            parsedCSV = parsedCSV.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return parsedCSV;
        }

        Dictionary<string, int> headerIndexDict = new Dictionary<string, int>();

        private void SetHeaderList(string header)
        {
            var values = parseCSVLine(header);
            listBoxHeader.Items.Clear();
            for (int i = 0; i < values.Length; i++)
            {
                string column = values[i];
                listBoxHeader.Items.Add(column);
                headerIndexDict[column] = i;
            }
        }

        private List<List<string>> MakeRowbasedDataStructure(string filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.Default);

            var line = sr.ReadLine();

            SetHeaderList(line);

            List<List<string>> data = new List<List<string>>();

            int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();

                var values = parseCSVLine(line);

                data.Add(values.ToList());

                if (row++ == 40) break; //row 개수 제한
            }

            sr.Close();

            return data;
        }
        #region print by Rowbased

        private void printRowData_Rowbased(List<List<string>> data, TextBox textBox)
        {
            string str = "";
            foreach (List<string> rowList in data)
            {
                foreach (string value in rowList)
                {
                    str += value + "\t";
                }
                str += "\r\n";
            }
            textBox.Text = str;
        }

        private void printColumnData_Rowbased(List<List<string>> data, int colIdx)
        {
            string str = "";
            textBoxCSVViewer.Text = "";
            foreach (List<string> rowlist in data)
            {
                str += rowlist[colIdx] + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }
        #endregion

        //ButtonCSVViewer_Click() 에 해당하는 data.
        List<List<string>> data;

        private void ButtonCSVViewer_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            DialogResult dResult = FD.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                string filename = FD.FileName;

                data = MakeRowbasedDataStructure(filename);
                printRowData_Rowbased(data, textBoxCSVViewer);
            }

            /*
            printColumnData_Rowbased(data, 1);
            List<List<string>> data = MakeColumnarDataStructure();
            printColumnsData_columnbased(data, 1);
            printRowData_columnbased(data, 5);
             */
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearchKeyword.Text;

            if (keyword == "")
            {
                MessageBox.Show("검색 키워드를 입력하세요.", "확인");
                return;
            }
            
            if (listBoxHeader.SelectedItem == null)
            {
                MessageBox.Show("검색 대상 컬럼을 선택하세요.", "확인");
                return;
            }

            string column = listBoxHeader.SelectedItem.ToString();
            if (column == "")
            {
                MessageBox.Show("검색 대상 컬럼을 선택하세요.", "확인");
                return;
            }

            MessageBox.Show("키워드 = " + keyword + " 컬럼 = " + column, "확인");

            DoSearch(keyword, column);
        }

        private void DoSearch(string keyword, string column)
        {
            // 1. 대상컬럼 확인
            // targetColumnIndex = listBoxHeader.SelectedIndex;\
            if (headerIndexDict.ContainsKey(column) == false)
            {
                MessageBox.Show("검색 대상 컬럼을 선택하세요.", "확인");
                return;
            }
            int targetColumnIndex = headerIndexDict[column];    //O(Log(n))시간에 인덱스 가능.

            // 2. 대상 컬럼 키워드를 포함하는지 확인
            List<List<string>> resultData = new List<List<string>>();
            foreach (List<string> row in data)
            {
                string value = row[targetColumnIndex];
                if (value.Contains(keyword))
                {
                    resultData.Add(row);
                }
            }
            printRowData_Rowbased(resultData, textBoxSearchResult);
        }

        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "INSERT INTO `s5414057`.`student` (`name`, `Contact`) VALUES ('dfasd', '1111');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {
                connection.Open();

                string query = "select * from student";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string str = string.Format(rdr["Sid"] + " " + rdr["name"] + " " + rdr["Contact"]);
                    textBoxSearchResult.Text += str;
                }
                rdr.Close();
            }
        }
    }
}
