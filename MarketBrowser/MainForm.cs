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

        private List<List<string>> MakeRowbasedDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);

            var line = sr.ReadLine();

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

        private void printRowData_Rowbased(List<List<string>> data)
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
            textBoxCSVViewer.Text = str;
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

        private void ButtonCSVViewer_Click(object sender, EventArgs e)
        {
            /*
             */
            List<List<string>> data = MakeRowbasedDataStructure();
            printRowData_Rowbased(data);
            /*
            printColumnData_Rowbased(data, 1);
            List<List<string>> data = MakeColumnarDataStructure();
            printColumnsData_columnbased(data, 1);
            printRowData_columnbased(data, 5);
             */
        }
    }
}
