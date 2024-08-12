
using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLiThongTin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=19-LAB402\SQLEXPRESS;Initial Catalog=QuanLiThongTin;Integrated Security=True;Encrypt=False");
        private void openCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            } 
                
        }
        private void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
