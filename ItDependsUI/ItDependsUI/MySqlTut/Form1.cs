using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* steps to run
 * run the executable
 * 
 * User Page
 * press Load all Users to populate the table with all users from the database
 * Fill in the fields with valid data that is not already in the database and press Insert
 * To change to Games Page press the Games Page button
 * 
 * Games Page
 * press Load all Games to populate the table with all games from the database
 * Click on a game in the table to select it
 * Fill in the fields with valid user that is not already in the database and press Buy
 * 
 * Clubs Page
 * press Load all Clubs to populate the table with all Clubs from the database
 * Click on a club in the table to select it
 * Fill in the fields with valid user that is not already in the database and press Insert
 * 
 * Reviews Page only accessable through User Page and Games Page
 * press Load all Reviews to populate the table with all Reviews from the database
 * Fill in the fields with valid data and press Insert 
 * 
 * Press Exit instead of close button to close windows
 */


namespace GameReviewsUI
{
    public partial class UsersPage : Form
    {

        private User currUser;

        public UsersPage()
        {
            InitializeComponent();
            User.InitializeDB();
        }

        private void LoadAll()
        {
            ClearAndAddColumns(new string[] { "Username", "Password", "Reviewer", "Admin", "Banned", "Balance" });

            List<User> users = User.GetUsers();

            listView1.Items.Clear();

            int[] columnWidths = new int[listView1.Columns.Count];
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                columnWidths[i] = listView1.Columns[i].Width;
            }

            foreach (User u in users)
            {
                ListViewItem item = new ListViewItem(new string[] { u.Username, u.Password, u.Reviewer, u.Admin, u.Banned, u.Balance });
                item.Tag = u;

                listView1.Items.Add(item);
            }

            for (int i = 0; i < columnWidths.Length; i++)
            {
                listView1.Columns[i].Width = -1;
                listView1.Columns[i].Width = listView1.Columns[i].Width > columnWidths[i] ? listView1.Columns[i].Width : columnWidths[i];
            }
        }

        private void ClearAndAddColumns(string[] clmNames)
        {
            listView1.Columns.Clear();

            foreach (var clmName in clmNames)
            {
                listView1.Columns.Add(clmName, -2, HorizontalAlignment.Left);
            }
        }

        private void btnLoadAllUsers_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                currUser = (User)item.Tag;

                //int id = currUser.Id;
                string u = currUser.Username;
                string p = currUser.Password;

                txtUsername.Text = u;
                //txtId.Text = id.ToString();
                txtPassword.Text = p;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;
            string b = txtBalance.Text; 

            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p))
            {
                MessageBox.Show("It's empty");
                return;
            }

            currUser = User.Insert(u, p, b);

            LoadAll();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;

            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p))
            {
                MessageBox.Show("It's empty");
                return;
            }

            currUser.Update(u, p);

            LoadAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currUser == null)
            {
                MessageBox.Show("No user selected!");
                return;
            }

            currUser.Delete();

            LoadAll();
        }


        private void btnOpenGamesPage_Click(object sender, EventArgs e)
        {
            var frm = new FormGame();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormClub();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadReviewsPage_Click(object sender, EventArgs e)
        {
            var frm = new FormReviews();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
