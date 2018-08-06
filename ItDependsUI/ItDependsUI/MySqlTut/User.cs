using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GameReviewsUI
{
    public class User
    {
        //database stuff
        private const string SERVER = "css475.cqgnlgyii9c9.us-west-2.rds.amazonaws.com";
        private const string DATABASE = "Reviews475";
        private const string UID = "tkd8";
        private const string PASSWORD = "Test1234";
        private static MySqlConnection dbConn;
        
        // User class stuff
        public string Username { get; private set; }

        public string Password { get; private set; }

        public string Date_Joined { get; private set; }

        public string Reviewer { get; private set; }

        public string Admin { get;  private set; }

        public string Banned { get; private set; }

        public string Balance { get; private set; }

        private User(string usr, string pass, string rev, string adm, string ban, string bal)
        {
            Username = usr;
            Password = pass;
            
            Reviewer = rev;
            Admin = adm;
            Banned = ban;
            Balance = bal;
        }

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            string connString = builder.ToString();

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

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            string query = "SELECT * FROM USER";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string username = reader["Username"].ToString();
                string password = reader["Password"].ToString();
                
                string reviewer = reader["Reviewer"].ToString();
                string admin = reader["Admin"].ToString();
                string banned = reader["Banned"].ToString();
                string balance = reader["Balance"].ToString();


                User u = new User(username, password, reviewer, admin, banned, balance);

                users.Add(u);
            }

            reader.Close();

            dbConn.Close();

            return users;
        }

        public static User Insert(string u, string p, string b)
        {
            

            string query = string.Format("INSERT INTO USER(Username, Password, Balance) VALUES ('{0}', '{1}', '{2}')", u, p, b);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
       
            dbConn.Open();

            cmd.ExecuteNonQuery();
         

            User user = new User(u, p, null, null, null, b);

            dbConn.Close();

            return user;

        }
        public void Update(string u, string p)
        {
            return;

            
            //string query = string.Format("UPDATE users SET username='{0}', password='{1}' WHERE ID={2}", u, p, Id);

            //MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            //cmd.ExecuteNonQuery();

            dbConn.Close();
        }

        public void Delete()
        {
            return;

            //string query = string.Format("DELETE FROM users WHERE ID={0}", Id);

            //MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            //cmd.ExecuteNonQuery();

            dbConn.Close();
        }
    }
}
