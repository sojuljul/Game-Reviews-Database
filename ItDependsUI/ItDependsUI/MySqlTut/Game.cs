using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GameReviewsUI
{
    public class Game
    {
        //database stuff
        private const string SERVER = "css475.cqgnlgyii9c9.us-west-2.rds.amazonaws.com";
        private const string DATABASE = "Reviews475";
        private const string UID = "tkd8";
        private const string PASSWORD = "Test1234";
        private static MySqlConnection dbConn;

        // User class stuff
        public string Game_name { get; private set; }

        public string Game_description { get; private set; }

        public string Game_score_average { get; private set; }

        public string Genre { get; private set; }

        public string Price { get; private set; }

        private Game(string name, string desc, string score, string genre, string price)
        {
            Game_name = name;
            Game_description = desc;
            Game_score_average = score;
            Genre = genre;
            Price = price;
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

        public static List<Game> GetGames()
        {
            List<Game> games = new List<Game>();

            string query = "SELECT * FROM GAME";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

           
            dbConn.Open();

            
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["Game_name"].ToString();
                string desc = reader["Game_Description"].ToString();
                string score = reader["Game_score_average"].ToString();
                string genre = reader["Genre"].ToString();
                string price = reader["Price"].ToString();

                Game g = new Game(name, desc, score, genre, price);

                games.Add(g);
            }

            reader.Close();

            dbConn.Close();

            return games;
        }

        public static Game Insert(string g, string p, string u)
        {
            string balance, final;
            dbConn.Open();
            decimal price, bal, total;
            price = System.Convert.ToDecimal(p);
            string query2 = string.Format("SELECT Balance FROM USER where Username='{0}'", u);
            MySqlCommand cmd2 = new MySqlCommand(query2, dbConn);
            balance = cmd2.ExecuteScalar().ToString();
            bal = System.Convert.ToDecimal(balance);
            total = bal - price;
            final = total.ToString();
            string query = string.Format("UPDATE USER SET balance='{0}' WHERE Username='{1}'", final, u);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            cmd.ExecuteNonQuery(); 

            dbConn.Close();
            Console.WriteLine(balance);
            Console.WriteLine(price);
            Console.WriteLine(total);

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
