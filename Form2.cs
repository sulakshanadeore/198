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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsDAL dal = new ProductsDAL();
            bool ans=dal.SearchDataUsingDataView("B's Beverages In pune");
            if (ans)
            {
                MessageBox.Show("found");
            }
            else
            {
                MessageBox.Show("not found");
            }

        }
    }
}
