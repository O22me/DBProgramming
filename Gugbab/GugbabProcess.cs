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
    public partial class FormGugbab : Form
    {
        public FormGugbab()
        {
            InitializeComponent();
        }

        string strconnection = "Server=27.96.130.41;Database=s5414057;Uid=s5414057;Pwd=s5414057;Charset=utf8";

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strconnection))
            {

            }
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {

        }
    }
}
