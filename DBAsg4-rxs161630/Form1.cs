﻿/*===============================================================================================
 |
 |       Author:  Rahul Sengupta 
 |     Language:  C#
 |
 +-----------------------------------------------------------------------------------------------
 |
 |  Description:  An application to perform DML Operations on the Contact Manager Database.
 |
 |        Input:  User can Add/Delete/Update/View Contacts. 
 |
 |       Output:  The Screen shows Current list of contacts stored in the Database, with the
 |                option of performing DML operations.
 |
 |    Algorithm:  -
 |   Known Bugs:  -
 |   Required Features Not Included:  -
 |
 ==============================================================================================*/
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace DBAsg4_rxs161630
{
    public partial class Form1 : Form
    {
        List<Model> listViewItems;
        bool creatingAppointment = false;
        int currentPersonId;

        //Form Constructor
        public Form1()
        {
            InitializeComponent();
            //Check and Establish Connectivity to the Database
            DBUtils dbUtils = new DBUtils();
            dbUtils.OpenConnection();
            panel_start.Visible = true;
            button_add_friend.Select();
            //Update listview with existing contacts in the DataBase
            refreshListView();
            disableAppointment();
            //Update Appointments from the database
            setAppointments();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int rowsAffected = 0;
            string fname = textBox_fname.Text;
            string mi = textBox_mi.Text;
            string lname = textBox_lname.Text;
            string DateMet = textBox_DateMet.Text;
            string placeMet = textBox_placeMet.Text;
            string dob = textBox_dob.Text;
            string apt = textBox_apt.Text;
            string street = textBox_street.Text;
            string locality = textBox_locality.Text;
            string city = textBox_city.Text;
            string zipcode = textBox_zipcode.Text;
            string state = textBox_state.Text;
            string country = textBox_country.Text;
            string email = textBox_email.Text;
            string phone = textBox_phone.Text;
            string gender = null;
            string familyFriend = null;
            string familyName = textBox_familyName.Text;
            if (radioButton_male.Checked)
                gender = "m";
            else if (radioButton_female.Checked)
                gender = "f";
            if (radioButton_fyes.Checked)
                familyFriend = "y";
            else if (radioButton_fno.Checked)
                familyFriend = "n";
            if (button_save.Text.Equals("Save"))
            {
                //Insert into Database in a new thread
                Thread insertThread = new Thread(() =>
                {
                    rowsAffected = DBUtils.insert(fname, mi, lname, DateMet, placeMet, dob, apt, street, locality, city, zipcode, state, country, email, phone, gender, familyFriend, familyName);
                });
                insertThread.Start();
                insertThread.Join();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Friend inserted into database!");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            else if(button_save.Text.Equals("Update"))
            {
                //Update Database in a new thread
                Thread updateThread = new Thread(() =>
                {
                    rowsAffected = DBUtils.update(fname, mi, lname, DateMet, placeMet, dob, apt, street, locality, city, zipcode, state, country, email, phone, gender, familyFriend, familyName,currentPersonId);
                });
                updateThread.Start();
                updateThread.Join();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Friend updated!");
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
            }
            panel_start.Visible = true;
            panel_friendDetails.Visible = false;
            clearAddControls();
            refreshListView();
            UpdateIndicator(Color.Green, "Ready");
            listView1.Enabled = true;
        }

        //Function to Update ListView from the DataBase
        private void refreshListView()
        {
            Thread loadListView = new Thread(() => {
                listViewItems = DBUtils.getListViewData();
            });
            loadListView.Start();
            loadListView.Join();
            listView1.Items.Clear();
            foreach (Model model in listViewItems)
            {
                ListViewItem item = new ListViewItem(model.firstName);
                item.SubItems.Add(model.middleInitial);
                item.SubItems.Add(model.lastName);
                item.SubItems.Add(model.phone);
                item.SubItems.Add(model.personId+"");
                listView1.Items.Add(item);
            }
            UpdateIndicator(Color.Green, "Ready");
            toolStripStatus_contacts.Text = listViewItems.Count + "";
        }

        private void UpdateIndicator(Color color, String text)
        {
            toolStripStatus_indicator.ForeColor = color;
            toolStripStatus_iText.Text = text;
        }

        //Bring up the panel to add a new contact
        private void button1_Click(object sender, EventArgs e)
        {
            panel_start.Visible = false;
            panel_friendDetails.Visible = true;
            button_delete.Enabled = false;
            button_save.Text = "Save";
            textBox_fname.Focus();
            UpdateIndicator(Color.Yellow, "Adding a Contact");
            listView1.Enabled = false;
        }

        private void button_discard_Click(object sender, EventArgs e)
        {
            panel_start.Visible = true;
            panel_friendDetails.Visible = false;
            button_add_friend.Select();
            clearAddControls();
            UpdateIndicator(Color.Green, "Ready");
            listView1.Enabled = true;
        }

        private void setValues(Model model)
        {
            textBox_fname.Text = model.firstName;
            textBox_mi.Text = model.middleInitial;
            textBox_lname.Text = model.lastName;
            textBox_DateMet.Text = model.DateMet;
            textBox_placeMet.Text = model.PlaceMet;
            textBox_dob.Text = model.dob;
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            textBox_apt.Text = model.apt;
            textBox_street.Text = model.street;
            textBox_locality.Text = model.locality;
            textBox_city.Text = model.city;
            textBox_zipcode.Text = model.zipcode;
            textBox_state.Text = model.state;
            textBox_country.Text = model.country;
            textBox_email.Text = model.email;
            textBox_phone.Text = model.phone;
            if (model.gender.Equals("m"))
                radioButton_male.Checked = true;
            else if (model.gender.Equals("f"))
                radioButton_female.Checked = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0 && !creatingAppointment)
            {
                UpdateIndicator(Color.Yellow, "Updating Contact");
                button_save.Text = "Update";
                String phone = listView1.SelectedItems[0].SubItems[3].Text;
                currentPersonId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text);
                Model model = null ;
                Thread getContact = new Thread(()=> {
                    model = DBUtils.getContactInfo(phone);
                });
                getContact.Start();
                getContact.Join();
                if(model!=null)
                {
                    setValues(model);
                    panel_start.Visible = false;
                    panel_friendDetails.Visible = true;
                    button_delete.Enabled = true;
                }
                listView1.Enabled = false;
            }
            else if(listView1.SelectedItems.Count > 0 && creatingAppointment)
            {
                textBox_appointment_contact.Text = listView1.SelectedItems[0].SubItems[3].Text; 
            }
        }

        //Function to Delete a Contact
        private void button_delete_Click(object sender, EventArgs e)
        {
            String phone = textBox_phone.Text;
            int result = DBUtils.deleteContact(currentPersonId);
            if (result > 0)
            {
                clearAddControls();
                panel_start.Visible = true;
                panel_friendDetails.Visible = false;
                refreshListView();
            }
            UpdateIndicator(Color.Green, "Ready");
            listView1.Enabled = true;
        }

        //Function to Create a New Appointment
        private void button_new_appointment_Click(object sender, EventArgs e)
        {
            creatingAppointment = true;
            textBox_appointment.Focus();
            button_discard_appointment.Enabled = true;
            button_save_appointment.Enabled = true;
            button_new_appointment.Enabled = false;
            enableAppointment();
            UpdateIndicator(Color.OrangeRed, "Creating Appointment");
            textBox_aptnote.Visible = true;
        }

        private void button_discard_appointment_Click(object sender, EventArgs e)
        {
            creatingAppointment = false;
            button_discard_appointment.Enabled = false;
            button_save_appointment.Enabled = false;
            button_new_appointment.Enabled = true;
            disableAppointment();
            UpdateIndicator(Color.Green, "Ready");
            textBox_aptnote.Visible = false;
        }

        //Function to Save the New Appointment
        private void button_save_appointment_Click(object sender, EventArgs e)
        {
            creatingAppointment = false;
            button_discard_appointment.Enabled = false;
            button_save_appointment.Enabled = false;
            button_new_appointment.Enabled = true;
            int result = DBUtils.createAppointment(textBox_appointment.Text, textBox_appointment_type.Text, textBox_appointment_date.Text, textBox_appointment_time.Text, textBox_appointment_location.Text, textBox_appointment_contact.Text);
            disableAppointment();
            if(result>0)
            {
                MessageBox.Show("Appointment Created");
            }
            setAppointments();
            UpdateIndicator(Color.Green, "Ready");
            textBox_aptnote.Visible = false;
        }


        public void clearAddControls()
        {
            textBox_fname.Clear();
            textBox_mi.Clear();
            textBox_lname.Clear();
            textBox_DateMet.Clear();
            textBox_placeMet.Clear();
            textBox_dob.Clear();
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            textBox_apt.Clear();
            textBox_street.Clear();
            textBox_locality.Clear();
            textBox_city.Clear();
            textBox_zipcode.Clear();
            textBox_state.Clear();
            textBox_country.Clear();
            textBox_email.Clear();
            textBox_phone.Clear();
            radioButton_fyes.Checked = false;
            radioButton_fno.Checked = false;
            textBox_familyName.Clear();
        }

        private void disableAppointment()
        {
            textBox_appointment_contact.Enabled = false;
            textBox_appointment.Enabled = false;
            textBox_appointment_date.Enabled = false;
            textBox_appointment_location.Enabled = false;
            textBox_appointment_time.Enabled = false;
            textBox_appointment_type.Enabled = false;
            clearAppointment();
        }

        private void enableAppointment()
        {
            textBox_appointment_contact.Enabled = true;
            textBox_appointment.Enabled = true;
            textBox_appointment_date.Enabled = true;
            textBox_appointment_location.Enabled = true;
            textBox_appointment_time.Enabled = true;
            textBox_appointment_type.Enabled = true;
            textBox_appointment_time.Text = DateTime.Now.ToString("HH:mm:ss");
            textBox_appointment_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textBox_appointment.Focus();
        }

        private void clearAppointment()
        {
            textBox_appointment_contact.Clear();
            textBox_appointment.Clear();
            textBox_appointment_date.Clear();
            textBox_appointment_location.Clear();
            textBox_appointment_time.Clear();
            textBox_appointment_type.Clear();
        }
        
        private void setAppointments()
        {
            List<AppointmentModel> appointments = DBUtils.getAppointments();
            if (appointments.Count > 0)
            {
                textBox_appointments.Text = "";
                foreach (AppointmentModel appointment in appointments)
                {
                    textBox_appointments.AppendText((appointments.IndexOf(appointment) + 1) + ". Appointment Name: " + appointment.appointmentType + "\n" + " Appointment Time: " + appointment.appointmentDate + " " + appointment.appointmentTime + "\n" + " Appointment Location: " + appointment.appointmentDescription + "\n" + " Appointment With: " + appointment.firstName + " " + appointment.lastName + "\n");
                }
            }
            else
            {
                textBox_appointments.Text = "No Appointments to show.";
            }
        }

        private void textBox_fname_TextChanged(object sender, EventArgs e)
        {
            if(textBox_fname.Text.Length < 1)
            {
                errorProvider_fname.SetError(textBox_fname, "Enter a valid First Name");
            }
            else
            {
                errorProvider_fname.Clear();
            }
        }

        private void textBox_lname_TextChanged(object sender, EventArgs e)
        {
            if (textBox_lname.Text.Length < 1)
            {
                errorProvider_lastName.SetError(textBox_lname, "Enter a valid Last Name");
            }
            else
            {
                errorProvider_lastName.Clear();
            }
        }

        private void textBox_DateMet_TextChanged(object sender, EventArgs e)
        {
            DateTime date;
            if(DateTime.TryParse(textBox_DateMet.Text, out date))
            {
                errorProvider_dateMet.Clear();
            }
            else
            {
                errorProvider_dateMet.SetError(textBox_DateMet, "Enter date in yyyy-mm-dd format.");
            }
        }

        private void textBox_dob_TextChanged(object sender, EventArgs e)
        {
            DateTime date;
            if (DateTime.TryParse(textBox_dob.Text, out date))
            {
                errorProvider_dob.Clear();
            }
            else
            {
                errorProvider_dob.SetError(textBox_dob, "Enter date in yyyy-mm-dd format.");
            }
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            if (rx.IsMatch(textBox_email.Text))
            {
                errorProvider_email.Clear();
            }
            else
            {
                errorProvider_email.SetError(textBox_email, "Enter a valid Email-id.");
            }
        }

        private void textBox_placeMet_TextChanged(object sender, EventArgs e)
        {
            if (textBox_placeMet.Text.Length < 1)
            {
                errorProvider_place.SetError(textBox_placeMet, "Where did you meet the person?");
            }
            else
            {
                errorProvider_place.Clear();
            }
        }

        
    }
}
