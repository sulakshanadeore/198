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
            CategoryDAL dal = new CategoryDAL();

            string s=dal.DeleteCategory(Convert.ToInt32(txtcatid.Text));
            if (s!=null)
            {
                MessageBox.Show("Deleted successfully....");
            }
            
            btnClear_Click(sender, e);
            CategoryForm_Load(sender, e);
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
            if (s!=null)
            {
                MessageBox.Show("Record added successfully");
                    CategoryForm_Load(sender, e);

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
                CategoryDAL dal = new CategoryDAL();
                CategoryBAL bal = new CategoryBAL();
                bal.CategoryID = Convert.ToInt32(txtcatid.Text);
                bal=dal.FindCategory(bal.CategoryID);
                txtcatname.Text = bal.CatName;
                txtcatdesc.Text = bal.CatDesc;

                DialogResult dr = MessageBox.Show("Do u want to edit this record", "User Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    btnEdit.Text = "Update";
                    txtcatname.Focus();
                    
                }
                
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoryDAL dal = new CategoryDAL();
            DataTable dt = new DataTable();
            dt=dal.showall();
            dataGridView1.DataSource = dt;
          //  dataGridView1.DataMember = "categories";
        }

        private void txtcatdesc_Leave(object sender, EventArgs e)
        {
            try
            {
                CategoryDAL dal = new CategoryDAL();
                CategoryBAL bal = new CategoryBAL();
                bal.CategoryID = Convert.ToInt32(txtcatid.Text);
                bal.CatName = txtcatname.Text;
                bal.CatDesc = txtcatdesc.Text;
               string s= dal.UpdateCategoryData(bal);
                if (s == "Modified")
                {
                    MessageBox.Show("Updated the row successfully ");
                }
                
                

                
                CategoryForm_Load(sender, e);
            }
            catch (FormatException ex)
            {

                btnInsert_Click(sender, e);
            }
            
        }

        private void txtcatdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryDAL dal = new CategoryDAL();
            CategoryBAL baldata=dal.FindCategory(Convert.ToInt32(txtcatid.Text),out string rowstate);
            txtcatdesc.Text = baldata.CatDesc;
            txtcatname.Text = baldata.CatName;

            if (rowstate!=null)
            {
                MessageBox.Show("Just finding......");
            }

        }
    }
}
