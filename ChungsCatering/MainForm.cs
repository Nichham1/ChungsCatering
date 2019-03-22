using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungsCatering
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Boolean isloggedin = false;
        Boolean isadmin = false;
        Boolean iscustomer = false;

        public void Adminloginshow()
        {
            AdminLoginForm adminlog = new AdminLoginForm();
            adminlog.MdiParent = this;
            adminlog.Show();
            isloggedin = true;
            isadmin = true;
        }

        public void Userloginshow()
        {
            UserLoginForm userlog = new UserLoginForm();
            userlog.MdiParent = this;
            userlog.Show();
            isloggedin = true;
            iscustomer = true;
        }


        private void Order_Click(object sender, EventArgs e)
        {
            if (iscustomer == false){

                Userloginshow();
            }
            else{ 

                OrderForm order = new OrderForm();
                order.MdiParent = this;
                order.Show();
            }


        }
    }
}
