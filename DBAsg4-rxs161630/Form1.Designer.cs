namespace DBAsg4_rxs161630
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_mi = new System.Windows.Forms.TextBox();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label_dob = new System.Windows.Forms.Label();
            this.textBox_dob = new System.Windows.Forms.TextBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.textBox_apt = new System.Windows.Forms.TextBox();
            this.label_apt = new System.Windows.Forms.Label();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label_street = new System.Windows.Forms.Label();
            this.textBox_locality = new System.Windows.Forms.TextBox();
            this.label_locality = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.textBox_zipcode = new System.Windows.Forms.TextBox();
            this.label_zipcode = new System.Windows.Forms.Label();
            this.textBox_state = new System.Windows.Forms.TextBox();
            this.label_state = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.label_country = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_DateMet = new System.Windows.Forms.TextBox();
            this.label_dateMet = new System.Windows.Forms.Label();
            this.textBox_placeMet = new System.Windows.Forms.TextBox();
            this.label_placeMet = new System.Windows.Forms.Label();
            this.radioButton_fno = new System.Windows.Forms.RadioButton();
            this.radioButton_fyes = new System.Windows.Forms.RadioButton();
            this.label_family = new System.Windows.Forms.Label();
            this.textBox_familyName = new System.Windows.Forms.TextBox();
            this.label_familyName = new System.Windows.Forms.Label();
            this.panel_friendDetails = new System.Windows.Forms.Panel();
            this.button_discard = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel_start = new System.Windows.Forms.Panel();
            this.textBox_appointments = new System.Windows.Forms.TextBox();
            this.button_add_friend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_appointment = new System.Windows.Forms.TextBox();
            this.textBox_appointment_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_appointment_date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_appointment_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_appointment_location = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_save_appointment = new System.Windows.Forms.Button();
            this.button_new_appointment = new System.Windows.Forms.Button();
            this.textBox_appointment_contact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_discard_appointment = new System.Windows.Forms.Button();
            this.panel_friendDetails.SuspendLayout();
            this.panel_start.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 709);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MI";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            this.columnHeader4.Width = 75;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(57, 52);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(89, 17);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Friend Name";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(169, 49);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(127, 22);
            this.textBox_fname.TabIndex = 2;
            // 
            // textBox_mi
            // 
            this.textBox_mi.Location = new System.Drawing.Point(313, 49);
            this.textBox_mi.Name = "textBox_mi";
            this.textBox_mi.Size = new System.Drawing.Size(37, 22);
            this.textBox_mi.TabIndex = 3;
            // 
            // textBox_lname
            // 
            this.textBox_lname.Location = new System.Drawing.Point(368, 49);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(128, 22);
            this.textBox_lname.TabIndex = 4;
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(59, 171);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(87, 17);
            this.label_dob.TabIndex = 5;
            this.label_dob.Text = "Date of Birth";
            // 
            // textBox_dob
            // 
            this.textBox_dob.Location = new System.Drawing.Point(169, 168);
            this.textBox_dob.Name = "textBox_dob";
            this.textBox_dob.Size = new System.Drawing.Size(127, 22);
            this.textBox_dob.TabIndex = 6;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(90, 208);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(56, 17);
            this.label_gender.TabIndex = 7;
            this.label_gender.Text = "Gender";
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(7, 8);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(59, 21);
            this.radioButton_male.TabIndex = 8;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(72, 8);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(75, 21);
            this.radioButton_female.TabIndex = 9;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // textBox_apt
            // 
            this.textBox_apt.Location = new System.Drawing.Point(169, 242);
            this.textBox_apt.Name = "textBox_apt";
            this.textBox_apt.Size = new System.Drawing.Size(127, 22);
            this.textBox_apt.TabIndex = 11;
            // 
            // label_apt
            // 
            this.label_apt.AutoSize = true;
            this.label_apt.Location = new System.Drawing.Point(19, 245);
            this.label_apt.Name = "label_apt";
            this.label_apt.Size = new System.Drawing.Size(127, 17);
            this.label_apt.TabIndex = 10;
            this.label_apt.Text = "Apartment Number";
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(169, 281);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(127, 22);
            this.textBox_street.TabIndex = 13;
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Location = new System.Drawing.Point(57, 284);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(87, 17);
            this.label_street.TabIndex = 12;
            this.label_street.Text = "Street Name";
            // 
            // textBox_locality
            // 
            this.textBox_locality.Location = new System.Drawing.Point(169, 321);
            this.textBox_locality.Name = "textBox_locality";
            this.textBox_locality.Size = new System.Drawing.Size(127, 22);
            this.textBox_locality.TabIndex = 15;
            // 
            // label_locality
            // 
            this.label_locality.AutoSize = true;
            this.label_locality.Location = new System.Drawing.Point(54, 324);
            this.label_locality.Name = "label_locality";
            this.label_locality.Size = new System.Drawing.Size(90, 17);
            this.label_locality.TabIndex = 14;
            this.label_locality.Text = "Area Locality";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(169, 360);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(127, 22);
            this.textBox_city.TabIndex = 17;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(113, 363);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(31, 17);
            this.label_city.TabIndex = 16;
            this.label_city.Text = "City";
            // 
            // textBox_zipcode
            // 
            this.textBox_zipcode.Location = new System.Drawing.Point(169, 399);
            this.textBox_zipcode.Name = "textBox_zipcode";
            this.textBox_zipcode.Size = new System.Drawing.Size(127, 22);
            this.textBox_zipcode.TabIndex = 19;
            // 
            // label_zipcode
            // 
            this.label_zipcode.AutoSize = true;
            this.label_zipcode.Location = new System.Drawing.Point(79, 402);
            this.label_zipcode.Name = "label_zipcode";
            this.label_zipcode.Size = new System.Drawing.Size(65, 17);
            this.label_zipcode.TabIndex = 18;
            this.label_zipcode.Text = "Zip Code";
            // 
            // textBox_state
            // 
            this.textBox_state.Location = new System.Drawing.Point(169, 438);
            this.textBox_state.Name = "textBox_state";
            this.textBox_state.Size = new System.Drawing.Size(127, 22);
            this.textBox_state.TabIndex = 21;
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(105, 441);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(41, 17);
            this.label_state.TabIndex = 20;
            this.label_state.Text = "State";
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(169, 476);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(127, 22);
            this.textBox_country.TabIndex = 23;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(87, 476);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(57, 17);
            this.label_country.TabIndex = 22;
            this.label_country.Text = "Country";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(169, 514);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(127, 22);
            this.textBox_email.TabIndex = 25;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(87, 517);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(59, 17);
            this.label_email.TabIndex = 24;
            this.label_email.Text = "Email ID";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(169, 552);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(127, 22);
            this.textBox_phone.TabIndex = 29;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(43, 555);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(103, 17);
            this.label_phone.TabIndex = 28;
            this.label_phone.Text = "Phone Number";
            // 
            // textBox_DateMet
            // 
            this.textBox_DateMet.Location = new System.Drawing.Point(169, 87);
            this.textBox_DateMet.Name = "textBox_DateMet";
            this.textBox_DateMet.Size = new System.Drawing.Size(127, 22);
            this.textBox_DateMet.TabIndex = 31;
            // 
            // label_dateMet
            // 
            this.label_dateMet.AutoSize = true;
            this.label_dateMet.Location = new System.Drawing.Point(79, 90);
            this.label_dateMet.Name = "label_dateMet";
            this.label_dateMet.Size = new System.Drawing.Size(65, 17);
            this.label_dateMet.TabIndex = 30;
            this.label_dateMet.Text = "Date Met";
            // 
            // textBox_placeMet
            // 
            this.textBox_placeMet.Location = new System.Drawing.Point(169, 129);
            this.textBox_placeMet.Name = "textBox_placeMet";
            this.textBox_placeMet.Size = new System.Drawing.Size(127, 22);
            this.textBox_placeMet.TabIndex = 33;
            // 
            // label_placeMet
            // 
            this.label_placeMet.AutoSize = true;
            this.label_placeMet.Location = new System.Drawing.Point(74, 132);
            this.label_placeMet.Name = "label_placeMet";
            this.label_placeMet.Size = new System.Drawing.Size(70, 17);
            this.label_placeMet.TabIndex = 32;
            this.label_placeMet.Text = "Place Met";
            // 
            // radioButton_fno
            // 
            this.radioButton_fno.AutoSize = true;
            this.radioButton_fno.Location = new System.Drawing.Point(234, 590);
            this.radioButton_fno.Name = "radioButton_fno";
            this.radioButton_fno.Size = new System.Drawing.Size(47, 21);
            this.radioButton_fno.TabIndex = 36;
            this.radioButton_fno.Text = "No";
            this.radioButton_fno.UseVisualStyleBackColor = true;
            // 
            // radioButton_fyes
            // 
            this.radioButton_fyes.AutoSize = true;
            this.radioButton_fyes.Location = new System.Drawing.Point(169, 590);
            this.radioButton_fyes.Name = "radioButton_fyes";
            this.radioButton_fyes.Size = new System.Drawing.Size(53, 21);
            this.radioButton_fyes.TabIndex = 35;
            this.radioButton_fyes.Text = "Yes";
            this.radioButton_fyes.UseVisualStyleBackColor = true;
            // 
            // label_family
            // 
            this.label_family.AutoSize = true;
            this.label_family.Location = new System.Drawing.Point(46, 592);
            this.label_family.Name = "label_family";
            this.label_family.Size = new System.Drawing.Size(100, 17);
            this.label_family.TabIndex = 34;
            this.label_family.Text = "Family Friend?";
            // 
            // textBox_familyName
            // 
            this.textBox_familyName.Location = new System.Drawing.Point(169, 626);
            this.textBox_familyName.Name = "textBox_familyName";
            this.textBox_familyName.Size = new System.Drawing.Size(127, 22);
            this.textBox_familyName.TabIndex = 38;
            // 
            // label_familyName
            // 
            this.label_familyName.AutoSize = true;
            this.label_familyName.Location = new System.Drawing.Point(57, 629);
            this.label_familyName.Name = "label_familyName";
            this.label_familyName.Size = new System.Drawing.Size(89, 17);
            this.label_familyName.TabIndex = 37;
            this.label_familyName.Text = "Family Name";
            // 
            // panel_friendDetails
            // 
            this.panel_friendDetails.Controls.Add(this.groupBox1);
            this.panel_friendDetails.Controls.Add(this.button_discard);
            this.panel_friendDetails.Controls.Add(this.button_delete);
            this.panel_friendDetails.Controls.Add(this.button_save);
            this.panel_friendDetails.Controls.Add(this.label1);
            this.panel_friendDetails.Controls.Add(this.textBox_zipcode);
            this.panel_friendDetails.Controls.Add(this.textBox_familyName);
            this.panel_friendDetails.Controls.Add(this.label_name);
            this.panel_friendDetails.Controls.Add(this.label_familyName);
            this.panel_friendDetails.Controls.Add(this.textBox_fname);
            this.panel_friendDetails.Controls.Add(this.radioButton_fno);
            this.panel_friendDetails.Controls.Add(this.textBox_mi);
            this.panel_friendDetails.Controls.Add(this.radioButton_fyes);
            this.panel_friendDetails.Controls.Add(this.textBox_lname);
            this.panel_friendDetails.Controls.Add(this.label_family);
            this.panel_friendDetails.Controls.Add(this.label_dob);
            this.panel_friendDetails.Controls.Add(this.textBox_placeMet);
            this.panel_friendDetails.Controls.Add(this.textBox_dob);
            this.panel_friendDetails.Controls.Add(this.label_placeMet);
            this.panel_friendDetails.Controls.Add(this.label_gender);
            this.panel_friendDetails.Controls.Add(this.textBox_DateMet);
            this.panel_friendDetails.Controls.Add(this.label_dateMet);
            this.panel_friendDetails.Controls.Add(this.textBox_phone);
            this.panel_friendDetails.Controls.Add(this.label_apt);
            this.panel_friendDetails.Controls.Add(this.label_phone);
            this.panel_friendDetails.Controls.Add(this.textBox_apt);
            this.panel_friendDetails.Controls.Add(this.textBox_email);
            this.panel_friendDetails.Controls.Add(this.label_street);
            this.panel_friendDetails.Controls.Add(this.label_email);
            this.panel_friendDetails.Controls.Add(this.textBox_street);
            this.panel_friendDetails.Controls.Add(this.textBox_country);
            this.panel_friendDetails.Controls.Add(this.label_locality);
            this.panel_friendDetails.Controls.Add(this.label_country);
            this.panel_friendDetails.Controls.Add(this.textBox_locality);
            this.panel_friendDetails.Controls.Add(this.textBox_state);
            this.panel_friendDetails.Controls.Add(this.label_city);
            this.panel_friendDetails.Controls.Add(this.label_state);
            this.panel_friendDetails.Controls.Add(this.textBox_city);
            this.panel_friendDetails.Controls.Add(this.label_zipcode);
            this.panel_friendDetails.Location = new System.Drawing.Point(455, 12);
            this.panel_friendDetails.Name = "panel_friendDetails";
            this.panel_friendDetails.Size = new System.Drawing.Size(510, 709);
            this.panel_friendDetails.TabIndex = 39;
            this.panel_friendDetails.Visible = false;
            // 
            // button_discard
            // 
            this.button_discard.Location = new System.Drawing.Point(291, 667);
            this.button_discard.Name = "button_discard";
            this.button_discard.Size = new System.Drawing.Size(69, 34);
            this.button_discard.TabIndex = 42;
            this.button_discard.Text = "Discard";
            this.button_discard.UseVisualStyleBackColor = true;
            this.button_discard.Click += new System.EventHandler(this.button_discard_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(194, 667);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(70, 34);
            this.button_delete.TabIndex = 41;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(99, 667);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(69, 34);
            this.button_save.TabIndex = 40;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Enter\\Update Details";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 746);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel_start
            // 
            this.panel_start.Controls.Add(this.button_discard_appointment);
            this.panel_start.Controls.Add(this.textBox_appointment_contact);
            this.panel_start.Controls.Add(this.label8);
            this.panel_start.Controls.Add(this.button_new_appointment);
            this.panel_start.Controls.Add(this.button_save_appointment);
            this.panel_start.Controls.Add(this.textBox_appointment_location);
            this.panel_start.Controls.Add(this.label7);
            this.panel_start.Controls.Add(this.textBox_appointment_time);
            this.panel_start.Controls.Add(this.label6);
            this.panel_start.Controls.Add(this.textBox_appointment_date);
            this.panel_start.Controls.Add(this.label5);
            this.panel_start.Controls.Add(this.textBox_appointment_type);
            this.panel_start.Controls.Add(this.label4);
            this.panel_start.Controls.Add(this.textBox_appointment);
            this.panel_start.Controls.Add(this.label3);
            this.panel_start.Controls.Add(this.label2);
            this.panel_start.Controls.Add(this.textBox_appointments);
            this.panel_start.Controls.Add(this.button_add_friend);
            this.panel_start.Location = new System.Drawing.Point(410, 12);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(555, 709);
            this.panel_start.TabIndex = 41;
            // 
            // textBox_appointments
            // 
            this.textBox_appointments.Location = new System.Drawing.Point(45, 91);
            this.textBox_appointments.Multiline = true;
            this.textBox_appointments.Name = "textBox_appointments";
            this.textBox_appointments.ReadOnly = true;
            this.textBox_appointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_appointments.Size = new System.Drawing.Size(468, 190);
            this.textBox_appointments.TabIndex = 1;
            this.textBox_appointments.Text = "No Appointments to show.";
            // 
            // button_add_friend
            // 
            this.button_add_friend.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_friend.Location = new System.Drawing.Point(45, 16);
            this.button_add_friend.Name = "button_add_friend";
            this.button_add_friend.Size = new System.Drawing.Size(468, 44);
            this.button_add_friend.TabIndex = 0;
            this.button_add_friend.Text = "Add New Contact";
            this.button_add_friend.UseVisualStyleBackColor = true;
            this.button_add_friend.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_male);
            this.groupBox1.Controls.Add(this.radioButton_female);
            this.groupBox1.Location = new System.Drawing.Point(162, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 36);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create an Appointment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Appointment Name";
            // 
            // textBox_appointment
            // 
            this.textBox_appointment.Location = new System.Drawing.Point(241, 357);
            this.textBox_appointment.Name = "textBox_appointment";
            this.textBox_appointment.Size = new System.Drawing.Size(231, 22);
            this.textBox_appointment.TabIndex = 4;
            // 
            // textBox_appointment_type
            // 
            this.textBox_appointment_type.Location = new System.Drawing.Point(242, 396);
            this.textBox_appointment_type.Name = "textBox_appointment_type";
            this.textBox_appointment_type.Size = new System.Drawing.Size(231, 22);
            this.textBox_appointment_type.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Appointment Type";
            // 
            // textBox_appointment_date
            // 
            this.textBox_appointment_date.Location = new System.Drawing.Point(242, 435);
            this.textBox_appointment_date.Name = "textBox_appointment_date";
            this.textBox_appointment_date.Size = new System.Drawing.Size(231, 22);
            this.textBox_appointment_date.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Appointment Date";
            // 
            // textBox_appointment_time
            // 
            this.textBox_appointment_time.Location = new System.Drawing.Point(242, 475);
            this.textBox_appointment_time.Name = "textBox_appointment_time";
            this.textBox_appointment_time.Size = new System.Drawing.Size(231, 22);
            this.textBox_appointment_time.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Appointment Time";
            // 
            // textBox_appointment_location
            // 
            this.textBox_appointment_location.Location = new System.Drawing.Point(242, 515);
            this.textBox_appointment_location.Name = "textBox_appointment_location";
            this.textBox_appointment_location.Size = new System.Drawing.Size(231, 22);
            this.textBox_appointment_location.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Appointment Location";
            // 
            // button_save_appointment
            // 
            this.button_save_appointment.Enabled = false;
            this.button_save_appointment.Location = new System.Drawing.Point(217, 616);
            this.button_save_appointment.Name = "button_save_appointment";
            this.button_save_appointment.Size = new System.Drawing.Size(154, 35);
            this.button_save_appointment.TabIndex = 13;
            this.button_save_appointment.Text = "Save Appointment";
            this.button_save_appointment.UseVisualStyleBackColor = true;
            this.button_save_appointment.Click += new System.EventHandler(this.button_save_appointment_Click);
            // 
            // button_new_appointment
            // 
            this.button_new_appointment.Location = new System.Drawing.Point(48, 616);
            this.button_new_appointment.Name = "button_new_appointment";
            this.button_new_appointment.Size = new System.Drawing.Size(147, 35);
            this.button_new_appointment.TabIndex = 14;
            this.button_new_appointment.Text = "New Appointment";
            this.button_new_appointment.UseVisualStyleBackColor = true;
            this.button_new_appointment.Click += new System.EventHandler(this.button_new_appointment_Click);
            // 
            // textBox_appointment_contact
            // 
            this.textBox_appointment_contact.Location = new System.Drawing.Point(242, 556);
            this.textBox_appointment_contact.Name = "textBox_appointment_contact";
            this.textBox_appointment_contact.Size = new System.Drawing.Size(231, 22);
            this.textBox_appointment_contact.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contact Number";
            // 
            // button_discard_appointment
            // 
            this.button_discard_appointment.Enabled = false;
            this.button_discard_appointment.Location = new System.Drawing.Point(397, 616);
            this.button_discard_appointment.Name = "button_discard_appointment";
            this.button_discard_appointment.Size = new System.Drawing.Size(84, 35);
            this.button_discard_appointment.TabIndex = 17;
            this.button_discard_appointment.Text = "Discard";
            this.button_discard_appointment.UseVisualStyleBackColor = true;
            this.button_discard_appointment.Click += new System.EventHandler(this.button_discard_appointment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 768);
            this.Controls.Add(this.panel_start);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_friendDetails);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.panel_friendDetails.ResumeLayout(false);
            this.panel_friendDetails.PerformLayout();
            this.panel_start.ResumeLayout(false);
            this.panel_start.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_mi;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.TextBox textBox_dob;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.TextBox textBox_apt;
        private System.Windows.Forms.Label label_apt;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.TextBox textBox_locality;
        private System.Windows.Forms.Label label_locality;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.TextBox textBox_zipcode;
        private System.Windows.Forms.Label label_zipcode;
        private System.Windows.Forms.TextBox textBox_state;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_DateMet;
        private System.Windows.Forms.Label label_dateMet;
        private System.Windows.Forms.TextBox textBox_placeMet;
        private System.Windows.Forms.Label label_placeMet;
        private System.Windows.Forms.RadioButton radioButton_fno;
        private System.Windows.Forms.RadioButton radioButton_fyes;
        private System.Windows.Forms.Label label_family;
        private System.Windows.Forms.TextBox textBox_familyName;
        private System.Windows.Forms.Label label_familyName;
        private System.Windows.Forms.Panel panel_friendDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.Button button_add_friend;
        private System.Windows.Forms.TextBox textBox_appointments;
        private System.Windows.Forms.Button button_discard;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_appointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_appointment_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_appointment_location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_appointment_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_appointment_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_new_appointment;
        private System.Windows.Forms.Button button_save_appointment;
        private System.Windows.Forms.TextBox textBox_appointment_contact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_discard_appointment;
    }
}

