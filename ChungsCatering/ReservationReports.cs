using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungsUserManagement
{
    public partial class ReservationReports : Form
    {
        public ReservationReports()
        {
            InitializeComponent();
        }

        
        private void ReservationReports_Load(object sender, EventArgs e)
        {
            try
            {


                gvUsers.Columns["FirstName"].HeaderText = "First Name";

            gvUsers.Columns["LastName"].HeaderText = "Last Name";

            gvUsers.Columns["Email"].HeaderText = "Email Address";

            gvUsers.Columns["Telephone"].HeaderText = "Telephone";
            gvUsers.Columns["CustomersAddress"].HeaderText = "Customer Address";
            gvUsers.Columns["ReservationDescription"].HeaderText = "Reservation Description";
            gvUsers.Columns["ReservationDate"].HeaderText = "Reservation Date";

                //Hide columns that you do not want to display for users
                gvUsers.Columns[0].Visible = false;

                //Set the first row as selected by default
                gvUsers.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

        private void BtClearRes_Click(object sender, EventArgs e)
        {
            ResetForm();
        }







        void ResetForm()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmailAddress.Clear();
            tbEmailAddress.Clear();
            cbResDescription.SelectedIndex = 0;
        }

        private void BtSaveRes_Click(object sender, EventArgs e)
        {

        }
    }
}
