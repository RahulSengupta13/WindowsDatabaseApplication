using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace DBAsg4_rxs161630
{
    class DBUtils
    {
        static public MySqlConnection connection = null;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public DBUtils()
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "*";
            builder.Database = "asg3-rxs161630";
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection = new MySqlConnection(builder.ToString());
                connection.Open();
                Console.WriteLine("Connection Established!");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        break;
                    case 1045:
                        break;
                    default:
                        Console.WriteLine(ex.StackTrace);
                        break;
                }
                return false;
            }
        }
        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        public static int insert(string fname, string mi, string lname, string DateMet, string placeMet, string dob, string apt, string street, string locality, string city, string zipcode, string state, string country, string email, string phone, string gender, string familyFriend, string familyName)
        {
            DateTime dateMet, birthday;
            DateTime.TryParse(DateMet, out dateMet);
            DateMet = dateMet.ToString("yyyy-MM-dd");

            DateTime.TryParse(dob, out birthday);
            dob = birthday.ToString("yyyy-MM-dd");

            MySqlCommand cmd = new MySqlCommand("insert_contact", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("fname", fname));
            cmd.Parameters.Add(new MySqlParameter("lname", lname));
            cmd.Parameters.Add(new MySqlParameter("mi", mi));
            cmd.Parameters.Add(new MySqlParameter("dob", dob));
            cmd.Parameters.Add(new MySqlParameter("datemet", DateMet));
            cmd.Parameters.Add(new MySqlParameter("placeMet", placeMet));
            cmd.Parameters.Add(new MySqlParameter("gender", gender));
            cmd.Parameters.Add(new MySqlParameter("email", email));
            cmd.Parameters.Add(new MySqlParameter("phone", phone));
            cmd.Parameters.Add(new MySqlParameter("familyFriend", familyFriend));
            cmd.Parameters.Add(new MySqlParameter("familyName", familyName));
            cmd.Parameters.Add(new MySqlParameter("apartmentNumber", apt));
            cmd.Parameters.Add(new MySqlParameter("streetName", street));
            cmd.Parameters.Add(new MySqlParameter("areaLocality", locality));
            cmd.Parameters.Add(new MySqlParameter("city", city));
            cmd.Parameters.Add(new MySqlParameter("zipcode", zipcode));
            cmd.Parameters.Add(new MySqlParameter("state", state));
            cmd.Parameters.Add(new MySqlParameter("country", country));
            

            return cmd.ExecuteNonQuery();
        }

        public static List<Model> getListViewData()
        {
            List<Model> listViewItems = new List<Model>();
            MySqlCommand cmd = new MySqlCommand("getFriends", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Model model = new Model();
                model.firstName = Convert.ToString(dr["firstName"]);
                model.lastName = Convert.ToString(dr["lastName"]);
                model.middleInitial = Convert.ToString(dr["middleInitial"]);
                model.phone = Convert.ToString(dr["phoneNumber"]);
                listViewItems.Add(model);
            }
            dr.Close();
            return listViewItems;
        }

        public static Model getContactInfo(String phone)
        {
            Model model = new Model();
            MySqlCommand cmd = new MySqlCommand("getContact", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("phone", phone));
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                model.firstName = Convert.ToString(dr["firstName"]);
                model.lastName = Convert.ToString(dr["lastName"]);
                model.middleInitial = Convert.ToString(dr["middleInitial"]);
                model.phone = Convert.ToString(dr["phoneNumber"]);
                model.DateMet = Convert.ToString(dr["date_met"]);
                model.PlaceMet = Convert.ToString(dr["place_met"]);
                model.dob = Convert.ToString(dr["dateOfBirth"]);
                model.apt = Convert.ToString(dr["apartmentNumber"]);
                model.street = Convert.ToString(dr["streetName"]);
                model.locality = Convert.ToString(dr["areaLocality"]);
                model.city = Convert.ToString(dr["city"]);
                model.state = Convert.ToString(dr["state"]);
                model.zipcode = Convert.ToString(dr["zipcode"]);
                model.country = Convert.ToString(dr["country"]);
                model.email = Convert.ToString(dr["emailId"]);
                model.gender = Convert.ToString(dr["gender"]);
            }
            dr.Close();
            return model;
        }

        public static int deleteContact(String phone)
        {
            MySqlCommand cmd = new MySqlCommand("deleteContact", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("phone", phone));
            return cmd.ExecuteNonQuery();
        }

        public static int createAppointment(String name, String type, String date, String time, String location, String contact)
        {
            DateTime dateApt, timeApt;
            MySqlCommand cmd = new MySqlCommand("createAppointment", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("phone", contact));
            cmd.Parameters.Add(new MySqlParameter("appointmentType", type));
            cmd.Parameters.Add(new MySqlParameter("appointmentDescription", location));
            DateTime.TryParse(date, out dateApt);
            date = dateApt.ToString("yyyy-MM-dd");
            timeApt = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
            time = timeApt.ToString("HH:mm:ss");
            cmd.Parameters.Add(new MySqlParameter("appointmentDate", date));
            cmd.Parameters.Add(new MySqlParameter("appointmentTime", time));
            return cmd.ExecuteNonQuery();
        }

        public static List<AppointmentModel> getAppointments()
        {
            List<AppointmentModel> appointments = new List<AppointmentModel>();
            MySqlCommand cmd = new MySqlCommand("showAppointments", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AppointmentModel model = new AppointmentModel();
                model.firstName = Convert.ToString(dr["firstName"]);
                model.lastName = Convert.ToString(dr["lastName"]);
                model.appointmentType = Convert.ToString(dr["appointmentType"]);
                model.appointmentTime = Convert.ToString(dr["appointmentTime"]);
                model.appointmentDescription = Convert.ToString(dr["appointmentDescription"]);

                DateTime date;
                DateTime.TryParse(Convert.ToString(dr["appointmentDate"]), out date);

                model.appointmentDate = date.ToString("yyyy-MM-dd");
                appointments.Add(model);
            }
            dr.Close();
            return appointments;
        }
    }
}
