using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using DALayer;
namespace WindowsFormsApp1
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtcatid.Text = "";
            txtcatname.Text = "";
            txtcatdesc.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

            
            CategoryBAL bal = new CategoryBAL();
            bal.CatName = txtcatname.Text;
            bal.CatDesc = txtcatdesc.Text;

            CategoryDAL dal = new CategoryDAL();
            string s=dal.InsertCategory(bal);
            if (s=="Done")
            {
                MessageBox.Show("Record added successfully");

            }
            else
            {
                MessageBox.Show("Record adding failed");

            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryBAL bal = new CategoryBAL();
                bal.CategoryID =Convert.ToInt32(txtcatid.Text);
                bal.CatName = txtcatname.Text;
                bal.CatDesc = txtcatdesc.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
