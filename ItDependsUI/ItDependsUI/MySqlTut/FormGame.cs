using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReviewsUI
{
    public partial class FormGame : Form
    {

        private Game currUser; 
        public FormGame()
        {
            InitializeComponent();
            Game.InitializeDB();
        }

        private void LoadAll()
        {
            ClearAndAddColumns(new string[] { "Game_name", "Game_description", "Game_score_average", "Genre", "Price" });

            List<Game> games = Game.GetGames();

            listView1.Items.Clear();

            int[] columnWidths = new int[listView1.Columns.Count];
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                columnWidths[i] = listView1.Columns[i].Width;
            }

            foreach (Game g in games)
            {
                ListViewItem item = new ListViewItem(new string[] { g.Game_name, g.Game_description, g.Game_score_average, g.Genre, g.Price });
                item.Tag = g;

                listView1.Items.Add(item);
            }

            for (int i = 0; i < columnWidths.Length; i++)
            {
                listView1.Columns[i].Width = -1;
                listView1.Columns[i].Width = listView1.Columns[i].Width > columnWidths[i] ? listView1.Columns[i].Width : columnWidths[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenGamesPage_Click(object sender, EventArgs e)
        {
            var frm = new UsersPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var frm = new FormClub();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                currUser = (Game)item.Tag;

                //int id = currUser.Id;
                string g = currUser.Game_name;
                string p = currUser.Price;

                txtGame.Text = g;
                //txtId.Text = id.ToString();
                txtPrice.Text = p;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string g = txtGame.Text;
            string p = txtPrice.Text;
            string u = txtUsername.Text;

            if (string.IsNullOrEmpty(g))
            {
                MessageBox.Show("It's empty");
                return;
            }

            currUser = Game.Insert(g, p, u);

            LoadAll();
        }

        private void btnOpenReviewsPage_Click(object sender, EventArgs e)
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
