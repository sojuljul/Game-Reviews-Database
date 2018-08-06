using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameReviewsUI
{
    public partial class FormReviews : Form
    {
        private Review currReview;

        public FormReviews()
        {
            InitializeComponent();
            Review.InitializeDB();
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

        private void btnOpenUsersPage_Click(object sender, EventArgs e)
        {
            var frm = new UsersPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void btnLoadAllReviews_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void LoadAll()
        {
            ClearAndAddColumns(new string[] { "Review Id", "Username", "Game", "Score", "Description" });

            List<Review> reviews = Review.GetReviews();

            lvReviews.Items.Clear();

            int[] columnWidths = new int[lvReviews.Columns.Count];
            for (int i = 0; i < lvReviews.Columns.Count; i++)
            {
                columnWidths[i] = lvReviews.Columns[i].Width;
            }

            foreach (Review r in reviews)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Review_ID, r.Rusername, r.RGame_name, r.Review_score, r.Review_description });
                item.Tag = r;

                lvReviews.Items.Add(item);
            }

            for (int i = 0; i < columnWidths.Length; i++)
            {
                lvReviews.Columns[i].Width = -1;
                lvReviews.Columns[i].Width = lvReviews.Columns[i].Width > columnWidths[i] ? lvReviews.Columns[i].Width : columnWidths[i];
            }
        }

        private void ClearAndAddColumns(string[] clmNames)
        {
            lvReviews.Columns.Clear();

            foreach (var clmName in clmNames)
            {
                lvReviews.Columns.Add(clmName, -2, HorizontalAlignment.Left);
            }
        }

        private void btnOpenClubsPage_Click(object sender, EventArgs e)
        {
            var frm = new FormClub();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var u = txtUsername.Text;
            var g = txtGame.Text;
            var score = txtScore.Text;
            var desc = txtDescription.Text;

            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(g) || string.IsNullOrEmpty(score) || string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("It's empty");
                return;
            }

            currReview = Review.Insert(u, g, score, desc);

            LoadAll();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
