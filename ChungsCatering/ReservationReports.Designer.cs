namespace ChungsCatering
{
    partial class ReservationReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbCustomerFName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.lbReservation = new System.Windows.Forms.Label();
            this.lbCusAddress = new System.Windows.Forms.Label();
            this.tbCusAddress = new System.Windows.Forms.TextBox();
            this.lbResStatus = new System.Windows.Forms.Label();
            this.lbReservationDate = new System.Windows.Forms.Label();
            this.lnTableStatus = new System.Windows.Forms.Label();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.txtSearchReservation = new System.Windows.Forms.TextBox();
            this.lbReservationSearch = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbDateSearch = new System.Windows.Forms.Label();
            this.btSaveRes = new System.Windows.Forms.Button();
            this.btDeleteRes = new System.Windows.Forms.Button();
            this.btClearRes = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.cbResDescription = new System.Windows.Forms.ComboBox();
            this.reservationDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chungsDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chungsDatabaseDataSet = new ChungsCatering.ChungsDatabaseDataSet();
            this.cbSeatStatus = new System.Windows.Forms.ComboBox();
            this.cbResStatus = new System.Windows.Forms.ComboBox();
            this.dtpReservation = new System.Windows.Forms.DateTimePicker();
            this.reservationDescriptionTableAdapter = new ChungsCatering.ChungsDatabaseDataSetTableAdapters.ReservationDescriptionTableAdapter();
            this.reservationStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationStatusTableAdapter = new ChungsCatering.ChungsDatabaseDataSetTableAdapters.ReservationStatusTableAdapter();
            this.seatStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatStatusTableAdapter = new ChungsCatering.ChungsDatabaseDataSetTableAdapters.SeatStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungsDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungsDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCustomerFName
            // 
            this.lbCustomerFName.AutoSize = true;
            this.lbCustomerFName.Location = new System.Drawing.Point(138, 27);
            this.lbCustomerFName.Name = "lbCustomerFName";
            this.lbCustomerFName.Size = new System.Drawing.Size(85, 13);
            this.lbCustomerFName.TabIndex = 27;
            this.lbCustomerFName.Text = "Customer Name ";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(16, 43);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(167, 20);
            this.tbFirstName.TabIndex = 28;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(189, 43);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(167, 20);
            this.tbLastName.TabIndex = 29;
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Location = new System.Drawing.Point(409, 27);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(98, 13);
            this.lbTelephone.TabIndex = 30;
            this.lbTelephone.Text = "Telephone Number";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(412, 43);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(167, 20);
            this.tbTelephone.TabIndex = 31;
            // 
            // lbReservation
            // 
            this.lbReservation.AutoSize = true;
            this.lbReservation.Location = new System.Drawing.Point(13, 87);
            this.lbReservation.Name = "lbReservation";
            this.lbReservation.Size = new System.Drawing.Size(120, 13);
            this.lbReservation.TabIndex = 32;
            this.lbReservation.Text = "Reservation Description";
            // 
            // lbCusAddress
            // 
            this.lbCusAddress.AutoSize = true;
            this.lbCusAddress.Location = new System.Drawing.Point(610, 27);
            this.lbCusAddress.Name = "lbCusAddress";
            this.lbCusAddress.Size = new System.Drawing.Size(92, 13);
            this.lbCusAddress.TabIndex = 34;
            this.lbCusAddress.Text = "Customer Address";
            // 
            // tbCusAddress
            // 
            this.tbCusAddress.Location = new System.Drawing.Point(613, 43);
            this.tbCusAddress.Name = "tbCusAddress";
            this.tbCusAddress.Size = new System.Drawing.Size(252, 20);
            this.tbCusAddress.TabIndex = 35;
            // 
            // lbResStatus
            // 
            this.lbResStatus.AutoSize = true;
            this.lbResStatus.Location = new System.Drawing.Point(160, 87);
            this.lbResStatus.Name = "lbResStatus";
            this.lbResStatus.Size = new System.Drawing.Size(97, 13);
            this.lbResStatus.TabIndex = 36;
            this.lbResStatus.Text = "Reservation Status";
            // 
            // lbReservationDate
            // 
            this.lbReservationDate.AutoSize = true;
            this.lbReservationDate.Location = new System.Drawing.Point(13, 145);
            this.lbReservationDate.Name = "lbReservationDate";
            this.lbReservationDate.Size = new System.Drawing.Size(90, 13);
            this.lbReservationDate.TabIndex = 38;
            this.lbReservationDate.Text = "Reservation Date";
            // 
            // lnTableStatus
            // 
            this.lnTableStatus.AutoSize = true;
            this.lnTableStatus.Location = new System.Drawing.Point(308, 87);
            this.lnTableStatus.Name = "lnTableStatus";
            this.lnTableStatus.Size = new System.Drawing.Size(62, 13);
            this.lnTableStatus.TabIndex = 40;
            this.lnTableStatus.Text = "Seat Status";
            // 
            // gvUsers
            // 
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Location = new System.Drawing.Point(371, 222);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.Size = new System.Drawing.Size(553, 392);
            this.gvUsers.TabIndex = 42;
            // 
            // txtSearchReservation
            // 
            this.txtSearchReservation.Location = new System.Drawing.Point(512, 196);
            this.txtSearchReservation.Name = "txtSearchReservation";
            this.txtSearchReservation.Size = new System.Drawing.Size(293, 20);
            this.txtSearchReservation.TabIndex = 43;
            // 
            // lbReservationSearch
            // 
            this.lbReservationSearch.AutoSize = true;
            this.lbReservationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservationSearch.Location = new System.Drawing.Point(560, 168);
            this.lbReservationSearch.Name = "lbReservationSearch";
            this.lbReservationSearch.Size = new System.Drawing.Size(201, 25);
            this.lbReservationSearch.TabIndex = 44;
            this.lbReservationSearch.Text = "Reservation Search";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(49, 269);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 45;
            // 
            // lbDateSearch
            // 
            this.lbDateSearch.AutoSize = true;
            this.lbDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateSearch.Location = new System.Drawing.Point(92, 244);
            this.lbDateSearch.Name = "lbDateSearch";
            this.lbDateSearch.Size = new System.Drawing.Size(131, 25);
            this.lbDateSearch.TabIndex = 46;
            this.lbDateSearch.Text = "Date Search";
            // 
            // btSaveRes
            // 
            this.btSaveRes.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveRes.Location = new System.Drawing.Point(29, 527);
            this.btSaveRes.Name = "btSaveRes";
            this.btSaveRes.Size = new System.Drawing.Size(122, 32);
            this.btSaveRes.TabIndex = 47;
            this.btSaveRes.Text = "Save Orders";
            this.btSaveRes.UseVisualStyleBackColor = true;
            this.btSaveRes.Click += new System.EventHandler(this.BtSaveRes_Click_1);
            // 
            // btDeleteRes
            // 
            this.btDeleteRes.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteRes.Location = new System.Drawing.Point(119, 577);
            this.btDeleteRes.Name = "btDeleteRes";
            this.btDeleteRes.Size = new System.Drawing.Size(122, 32);
            this.btDeleteRes.TabIndex = 48;
            this.btDeleteRes.Text = "Delete Orders";
            this.btDeleteRes.UseVisualStyleBackColor = true;
            // 
            // btClearRes
            // 
            this.btClearRes.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearRes.Location = new System.Drawing.Point(212, 527);
            this.btClearRes.Name = "btClearRes";
            this.btClearRes.Size = new System.Drawing.Size(122, 32);
            this.btClearRes.TabIndex = 49;
            this.btClearRes.Text = "Clear Orders";
            this.btClearRes.UseVisualStyleBackColor = true;
            this.btClearRes.Click += new System.EventHandler(this.BtClearRes_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(610, 85);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 13);
            this.lbEmail.TabIndex = 50;
            this.lbEmail.Text = "Email Address";
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(613, 100);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(167, 20);
            this.tbEmailAddress.TabIndex = 51;
            // 
            // cbResDescription
            // 
            this.cbResDescription.DataSource = this.reservationDescriptionBindingSource;
            this.cbResDescription.DisplayMember = "Name";
            this.cbResDescription.FormattingEnabled = true;
            this.cbResDescription.Location = new System.Drawing.Point(16, 100);
            this.cbResDescription.Name = "cbResDescription";
            this.cbResDescription.Size = new System.Drawing.Size(121, 21);
            this.cbResDescription.TabIndex = 52;
            this.cbResDescription.ValueMember = "Id";
            // 
            // reservationDescriptionBindingSource
            // 
            this.reservationDescriptionBindingSource.DataMember = "ReservationDescription";
            this.reservationDescriptionBindingSource.DataSource = this.chungsDatabaseDataSetBindingSource;
            // 
            // chungsDatabaseDataSetBindingSource
            // 
            this.chungsDatabaseDataSetBindingSource.DataSource = this.chungsDatabaseDataSet;
            this.chungsDatabaseDataSetBindingSource.Position = 0;
            // 
            // chungsDatabaseDataSet
            // 
            this.chungsDatabaseDataSet.DataSetName = "ChungsDatabaseDataSet";
            this.chungsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbSeatStatus
            // 
            this.cbSeatStatus.DataSource = this.seatStatusBindingSource;
            this.cbSeatStatus.DisplayMember = "Name";
            this.cbSeatStatus.FormattingEnabled = true;
            this.cbSeatStatus.Location = new System.Drawing.Point(302, 100);
            this.cbSeatStatus.Name = "cbSeatStatus";
            this.cbSeatStatus.Size = new System.Drawing.Size(121, 21);
            this.cbSeatStatus.TabIndex = 53;
            this.cbSeatStatus.ValueMember = "Id";
            // 
            // cbResStatus
            // 
            this.cbResStatus.DataSource = this.reservationStatusBindingSource;
            this.cbResStatus.DisplayMember = "Name";
            this.cbResStatus.FormattingEnabled = true;
            this.cbResStatus.Location = new System.Drawing.Point(163, 100);
            this.cbResStatus.Name = "cbResStatus";
            this.cbResStatus.Size = new System.Drawing.Size(121, 21);
            this.cbResStatus.TabIndex = 54;
            this.cbResStatus.ValueMember = "Id";
            // 
            // dtpReservation
            // 
            this.dtpReservation.Location = new System.Drawing.Point(12, 161);
            this.dtpReservation.Name = "dtpReservation";
            this.dtpReservation.Size = new System.Drawing.Size(200, 20);
            this.dtpReservation.TabIndex = 55;
            // 
            // reservationDescriptionTableAdapter
            // 
            this.reservationDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // reservationStatusBindingSource
            // 
            this.reservationStatusBindingSource.DataMember = "ReservationStatus";
            this.reservationStatusBindingSource.DataSource = this.chungsDatabaseDataSetBindingSource;
            // 
            // reservationStatusTableAdapter
            // 
            this.reservationStatusTableAdapter.ClearBeforeFill = true;
            // 
            // seatStatusBindingSource
            // 
            this.seatStatusBindingSource.DataMember = "SeatStatus";
            this.seatStatusBindingSource.DataSource = this.chungsDatabaseDataSetBindingSource;
            // 
            // seatStatusTableAdapter
            // 
            this.seatStatusTableAdapter.ClearBeforeFill = true;
            // 
            // ReservationReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 634);
            this.Controls.Add(this.dtpReservation);
            this.Controls.Add(this.cbResStatus);
            this.Controls.Add(this.cbSeatStatus);
            this.Controls.Add(this.cbResDescription);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btClearRes);
            this.Controls.Add(this.btDeleteRes);
            this.Controls.Add(this.btSaveRes);
            this.Controls.Add(this.lbDateSearch);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbReservationSearch);
            this.Controls.Add(this.txtSearchReservation);
            this.Controls.Add(this.gvUsers);
            this.Controls.Add(this.lnTableStatus);
            this.Controls.Add(this.lbReservationDate);
            this.Controls.Add(this.lbResStatus);
            this.Controls.Add(this.tbCusAddress);
            this.Controls.Add(this.lbCusAddress);
            this.Controls.Add(this.lbReservation);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.lbTelephone);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbCustomerFName);
            this.Name = "ReservationReports";
            this.Text = "ReservationReports";
            this.Load += new System.EventHandler(this.ReservationReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungsDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungsDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustomerFName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label lbReservation;
        private System.Windows.Forms.Label lbCusAddress;
        private System.Windows.Forms.TextBox tbCusAddress;
        private System.Windows.Forms.Label lbResStatus;
        private System.Windows.Forms.Label lbReservationDate;
        private System.Windows.Forms.Label lnTableStatus;
        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.TextBox txtSearchReservation;
        private System.Windows.Forms.Label lbReservationSearch;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbDateSearch;
        private System.Windows.Forms.Button btSaveRes;
        private System.Windows.Forms.Button btDeleteRes;
        private System.Windows.Forms.Button btClearRes;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.ComboBox cbResDescription;
        private System.Windows.Forms.ComboBox cbSeatStatus;
        private System.Windows.Forms.ComboBox cbResStatus;
        private System.Windows.Forms.DateTimePicker dtpReservation;
        private System.Windows.Forms.BindingSource chungsDatabaseDataSetBindingSource;
        private ChungsDatabaseDataSet chungsDatabaseDataSet;
        private System.Windows.Forms.BindingSource reservationDescriptionBindingSource;
        private ChungsDatabaseDataSetTableAdapters.ReservationDescriptionTableAdapter reservationDescriptionTableAdapter;
        private System.Windows.Forms.BindingSource reservationStatusBindingSource;
        private ChungsDatabaseDataSetTableAdapters.ReservationStatusTableAdapter reservationStatusTableAdapter;
        private System.Windows.Forms.BindingSource seatStatusBindingSource;
        private ChungsDatabaseDataSetTableAdapters.SeatStatusTableAdapter seatStatusTableAdapter;
    }
}