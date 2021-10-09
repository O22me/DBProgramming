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

namespace BasicFileIO
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
            textBoxDisplay.Text = "Hi, Hello, \r\nI'm under the water, plz help me?";
        }

        private void buttonBinaryWriter_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));

            bw.Write(1234);
            bw.Write("Hello World");
            bw.Close();
        }

        private void buttonBinaryReader_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

            int num1 = br.ReadInt32();
            string str = br.ReadString();
            Console.WriteLine("Read Int = " + num1);
            Console.WriteLine("Read str = " + str);

            br.Close();
        }

        private void buttonStreamWriter_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.WriteLine(int.MaxValue);
            sw.WriteLine("Good Morning");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("안녕하세요");
            sw.WriteLine(double.MaxValue);
            sw.Close();
        }

        private void buttonStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            textBoxDisplay.Text = "";
            while(sr.EndOfStream == false)
            {
                textBoxDisplay.Text += sr.ReadLine();
                textBoxDisplay.Text += "\r\n";
                //Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
