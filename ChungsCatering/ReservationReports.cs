﻿using System;
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
    public partial class ReservationReports : Form
    {
        private ChungCateringDatabase2Entities rawdata;
        
        public ReservationReports()
        {
            InitializeComponent();
        }


        private void ReservationReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chungCateringDatabase2DataSet.ReservationUser' table. You can move, or remove it, as needed.
            this.reservationUserTableAdapter.Fill(this.chungCateringDatabase2DataSet.ReservationUser);
            // TODO: This line of code loads data into the 'chungCateringDatabase2DataSet.ReservationStatus' table. You can move, or remove it, as needed.
            this.reservationStatusTableAdapter.Fill(this.chungCateringDatabase2DataSet.ReservationStatus);
            // TODO: This line of code loads data into the 'chungCateringDatabase2DataSet.ReservationDescription' table. You can move, or remove it, as needed.
            this.reservationDescriptionTableAdapter.Fill(this.chungCateringDatabase2DataSet.ReservationDescription);
            // TODO: This line of code loads data into the 'chungCateringDatabase2DataSet1.ReservationStatus' table. You can move, or remove it, as needed.
            //this.reservationStatusTableAdapter.Fill(this.chungCateringDatabase2DataSet1.ReservationStatus);
            // TODO: This line of code loads data into the 'chungCateringDatabase2DataSet.ReservationDescription' table. You can move, or remove it, as needed.
            //this.reservationDescriptionTableAdapter.Fill(this.chungCateringDatabase2DataSet.ReservationDescription);
            /*
            // TODO: This line of code loads data into the 'chungCateringDatabase2DataSet2.ReservationStatus' table. You can move, or remove it, as needed.
            this.reservationStatusTableAdapter.Fill(this.chungCateringDatabase2DataSet2.ReservationStatus);
            // TODO: This line of code loads data into the 'chungCateringDatabase2DataSet1.ReservationDescription' table. You can move, or remove it, as needed.
            this.reservationDescriptionTableAdapter.Fill(this.chungCateringDatabase2DataSet1.ReservationDescription);
            // TODO: This line of code loads data into the 'chungCateringDatabase2DataSet.ReservationDescription' table. You can move, or remove it, as needed.
            this.reservationDescriptionTableAdapter.Fill(this.chungCateringDatabase2DataSet.ReservationDescription);
            // TODO: This line of code loads data into the 'chungsDatabaseDataSet.SeatStatus' table. You can move, or remove it, as needed.
            this.seatStatusTableAdapter.Fill(this.chungsDatabaseDataSet.SeatStatus);
            // TODO: This line of code loads data into the 'chungsDatabaseDataSet.ReservationStatus' table. You can move, or remove it, as needed.
            this.reservationStatusTableAdapter.Fill(this.chungsDatabaseDataSet.ReservationStatus);
            // TODO: This line of code loads data into the 'chungsDatabaseDataSet.ReservationDescription' table. You can move, or remove it, as needed.
            this.reservationDescriptionTableAdapter.Fill(this.chungsDatabaseDataSet.ReservationDescription);
            */
            try
            {
                rawdata = new ChungCateringDatabase2Entities();

                //Populate the Gender Dropdown
                //Get The Reservation Status from the database
                var restate = rawdata.ReservationStatus.ToList();
                var redescrip = rawdata.ReservationDescriptions.ToList();
                //var seat = rawdata.SeatStatus.ToList();
                //Set the datasource of the combobox to the records
                //being retrieved from the database
                cbResStatus.DataSource = restate;
                cbResDescription.DataSource = redescrip;

                //cbSeatStatus.DataSource = seat;



                //Set the data member and value member to the values
                //that correspond with the columns coming back from 
                //our data source. 
                cbResStatus.DisplayMember = "name";
                cbResStatus.ValueMember = "id";

                cbResDescription.DisplayMember = "name";
                cbResDescription.ValueMember = "id";

                cbSeatStatus.DisplayMember = "name";
                cbSeatStatus.ValueMember = "id";



                //Populate The Grid View
                RefreshGridView();

                gvUsers.Columns["FirstName"].HeaderText = "First Name";
                gvUsers.Columns["LastName"].HeaderText = "Last Name";
                gvUsers.Columns["Email"].HeaderText = "Email Address";
                gvUsers.Columns["CustomersAddress"].HeaderText = "Customer Address";
                gvUsers.Columns["ReservationDescription"].HeaderText = "Reservation Description";
                gvUsers.Columns["ReservationCreateDate"].HeaderText = "Reservation Date";
                gvUsers.Columns["ReservationStatus"].HeaderText = "Reservation Status";
                gvUsers.Columns["Telephone"].HeaderText = "Telephone";
                gvUsers.Columns["SeatStatus"].HeaderText = "Seat Status";


                //Hide columns that you do not want to display for users
                gvUsers.Columns[0].Visible = false;

                //Set the first row as selected by default
                gvUsers.Rows[0].Selected = true;
            }
            catch (Exception ex)
     
                 {

                    //throw ex;
                   }
      
        }

    
        private void BtSaveRes_Click_1(object sender, EventArgs e)
        {
            //try {...} catch {...} is how you handle exceptions. I t is always a good idea to wrap complex operations inside
            //this code block and monitor for any errors that might appear and prevent program crashes. 

            //Collect data from the form
            var fname = tbFirstName.Text;
            var lname = tbLastName.Text;
            var email = tbEmailAddress.Text;
            var cust = tbCusAddress.Text;
            var telephone = tbTelephone.Text;
            var ReservationDescription = Convert.ToInt32(cbResDescription.SelectedValue);
            var ReservationStatus = Convert.ToInt32(cbResStatus.SelectedValue);
           // var seatStatus = Convert.ToInt32(cbSeatStatus.SelectedValue);
            //var resDate = Convert.ToInt32(dtpReservation.DataBindings);


            var user = new ReservationUser
            {
                FirstName = fname,
                LastName = lname,
                              
                Email = email,
               //CustomerAddress = cust,
                Telephone = telephone,
                ReservationDescriptionID = resDescription,
                ReservationStatusID= resStatus,
               //SeatStatusID = seatStatus,
               //ReservationCreateDate = DateTime.Now,
              //  ReservationDateID = DataBindings.Equals(resDate)
            };
            
            _ = rawdata.ReservationUsers.Add(user);
            _ = rawdata.SaveChanges();

            //Functions to Reset the fields to blank and reload all the data in the GridView
            //The reload makes the changes appear near real-time.
            RefreshGridView();
            ResetForm();
        }


        
        private void BtClearRes_Click(object sender, EventArgs e)
        {
            ResetForm();
        }


          
        void RefreshGridView()
        {
            var users = rawdata.ReservationUsers. Select(q => new {
                q.Id,
                q.FirstName,
                q.LastName,
                //q.CustomerAddress,
                q.Telephone,
                q.ReservationDescriptionID,
                q.ReservationStatusID,
                q.Email
                //q.ReservationCreateDate.Date.Hour

            }).ToList();
            gvUsers.DataSource = users;
            gvUsers.Refresh();

            //rawdata.ReservationDescriptions.First(q => q.)
        }

        void ResetForm()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmailAddress.Clear();
            tbCusAddress.Clear();
            tbTelephone.Clear();
            cbSeatStatus.SelectedIndex = 0;
            cbResStatus.SelectedIndex = 0;
            cbResDescription.SelectedIndex = 0;
        }

        bool isFormInvalid()
        {
            return String.IsNullOrEmpty(tbEmailAddress.Text) || String.IsNullOrEmpty(tbTelephone.Text) || cbResStatus.SelectedItem == null;
        }

        bool CheckEmail(string email)
        {
            var emailExists = rawdata.ReservationUsers.Any(q => q.Email.Trim() == email.Trim());
            return emailExists;
        }
/*
        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservationDescriptionTableAdapter.FillBy(this.chungsDatabaseDataSet.ReservationDescription);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        */
    }

        }
