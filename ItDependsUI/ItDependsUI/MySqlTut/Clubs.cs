using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GameReviewsUI
{
    public class Clubs
    {
        //database stuff
        private const string SERVER = "css475.cqgnlgyii9c9.us-west-2.rds.amazonaws.com";
        private const string DATABASE = "Reviews475";
        private const string UID = "tkd8";
        private const string PASSWORD = "Test1234";
        private static MySqlConnection dbConn;

        // User class stuff
        public string CMUsername { get; private set; }

        public string CMClub_Name { get; private set; }



        private Clubs(string user, string club)
        {
            CMUsername = user;
            CMClub_Name = club; 
        }

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            var connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) => {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }

        public static List<Clubs> GetClubs()
        {
            List<Clubs> clubs = new List<Clubs>();

            var query = "SELECT * FROM CLUB_MEMBERS";

            var cmd = new MySqlCommand(query, dbConn);


            dbConn.Open();


            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var name = reader["CMUsername"].ToString();
                var club = reader["CMClub_name"].ToString();

                var g = new Clubs(name, club);

                clubs.Add(g);
            }

            reader.Close();

            dbConn.Close();

            return clubs;
        }

        public static Clubs Insert(string u, string c)
        {
            dbConn.Open();
            var query = string.Format("INSERT INTO CLUB_MEMBERS (CMUsername, CMClub_name) VALUES ('{0}', '{1}')", u, c); 
            var cmd = new MySqlCommand(query, dbConn);
            cmd.ExecuteNonQuery();

            dbConn.Close();

            //string query = string.Format("UPDATE USER SET balance='{0}' WHERE Username={1}", );

            //MySqlCommand cmd = new MySqlCommand(query, dbConn);


            //cmd.ExecuteNonQuery();
            // int id = (int)cmd.LastInsertedId;

            //User user = new User(id, u, p);

            // dbConn.Close();

            return null;

        }
        public void Update(string u, string p)
        {
            return;

            //string query = string.Format("UPDATE users SET username='{0}', password='{1}' WHERE ID={2}", u, p, Id);

            //MySqlCommand cmd = new MySqlCommand(query, dbConn);

            //dbConn.Open();

            //cmd.ExecuteNonQuery();

            //dbConn.Close();
        }

        public void Delete()
        {
            return;

            //string query = string.Format("DELETE FROM users WHERE ID={0}", Id);

            //MySqlCommand cmd = new MySqlCommand(query, dbConn);

            //dbConn.Open();

            //cmd.ExecuteNonQuery();

            //dbConn.Close();
        }
    }
}
