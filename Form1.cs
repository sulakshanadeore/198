using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataViewsDemo;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            ProductsDAL dal = new ProductsDAL();
            DataView dview=dal.filterDataUsingDataView();
            dataGridView1.DataSource = dview;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsDAL dal = new ProductsDAL();
            DataView dview=dal.DataViewFilterContactName(Convert.ToInt32(textBox1.Text));
            dataGridView2.DataSource = dview;
        }
    }
}
