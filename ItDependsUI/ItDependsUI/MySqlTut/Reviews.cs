using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GameReviewsUI
{
    public class Review
    {
        //database stuff
        private const string SERVER = "css475.cqgnlgyii9c9.us-west-2.rds.amazonaws.com";
        private const string DATABASE = "Reviews475";
        private const string UID = "tkd8";
        private const string PASSWORD = "Test1234";
        private static MySqlConnection dbConn;
        
        // User class stuff
        public string Review_ID { get; private set; }

        public string Rusername { get; private set; }

        public string RGame_name { get; private set; }

        public string Review_score { get; private set; }

        public string Review_description { get; private set; }

        private Review(string id, string uname, string gname, string score, string desc )
        {
            Review_ID = id;
            Rusername = uname;
            RGame_name = gname;
            Review_score = score;
            Review_description = desc;
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

        public static List<Review> GetReviews()
        {
            var reviews = new List<Review>();

            var query = "SELECT * FROM REVIEW";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var id = reader["Review_ID"].ToString();
                var uname = reader["Rusername"].ToString();
                var gname = reader["RGame_name"].ToString();
                var score = reader["Review_score"].ToString();
                var desc = reader["Review_description"].ToString();

                var r = new Review(id, uname, gname, score, desc );

                reviews.Add(r);
            }

            reader.Close();

            dbConn.Close();

            return reviews;
        }

        public static Review Insert(string uname, string gname, string score, string desc)
        {

            dbConn.Open();

            var query1 = string.Format("SELECT MAX(Review_ID) From REVIEW");

            MySqlCommand cmd1 = new MySqlCommand(query1, dbConn);
            var id = cmd1.ExecuteScalar().ToString();
            var idDecimal = decimal.Parse(id) + 1;
            

            var query2 = string.Format("INSERT REVIEW (Review_ID, RUsername, RGame_name, Review_Score, Review_description)"
                + "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", idDecimal.ToString(), uname, gname, score, desc);
            MySqlCommand cmd2 = new MySqlCommand(query2, dbConn);
            cmd2.ExecuteNonQuery();
         

            var review = new Review(idDecimal.ToString(), uname, gname, score, desc);

            dbConn.Close();

            return review;

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
