using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstBALLayer;
using FirstDALLayer;
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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string userid=txtuser_id.Text;
            //string pwd = txtpassword.Text;
            //if (userid=="abc" && pwd=="abc@123")
            //{
            //    MessageBox.Show("Welcome " + userid);
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect Userid/Password");

            //}
            Login login = new Login();
            login.Username = txtuser_id.Text;
            login.Password = txtpassword.Text;
            CustomerLogin c = new CustomerLogin();
            bool ans=c.ValidateUser(login);
            if (ans)
            {
                MessageBox.Show("Welcome  "  + login.Username);
                CategoryForm category = new CategoryForm();
                category.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Userid/Password");

            }

        }
    }
}
