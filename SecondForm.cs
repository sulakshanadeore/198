using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
//2 versions---- 2.0,4.0
namespace WindowsFormsApp1
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopCn"].ConnectionString);

        private void button1_Click(object sender, EventArgs e)
        {
                          



            SqlCommand cmd_child = new SqlCommand("select * from products where catid=" + comboBox1.SelectedItem,cn);

            cn.Open();
            SqlDataReader dr1=cmd_child.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            cn.Close();


        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd_parent = new SqlCommand("select id from categories",cn);
            cn.Open();

            SqlDataReader dr = cmd_parent.ExecuteReader();
            //dr.Read();---3
            //    dr.Read();---4
            //    dr.Read();---8
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            cn.Close();
        }
    }
}
