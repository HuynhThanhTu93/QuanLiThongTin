
using Microsoft.Data.SqlClient;

namespace QuanLiThongTin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=19-LAB402\SQLEXPRESS;Initial Catalog=QuanLiThongTin;Integrated Security=True;Encrypt=False");
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
