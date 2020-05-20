using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conec = new SqlConnection(@"Data Source=SHINICHI\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conec.Open();
            if(conec.State==ConnectionState.Open)
            {
                MessageBox.Show("Ket noi thanh cong");
            }
            else
            {
                MessageBox.Show("Ket noi khong thanh cong");
            }
        }
    }
}
