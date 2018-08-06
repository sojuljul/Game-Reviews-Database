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
    public partial class FormClub : Form
    {

        private Clubs currUser;

        public FormClub()
        {
            InitializeComponent();
            Clubs.InitializeDB();
        }

        private void LoadAll()
        {
            ClearAndAddColumns(new string[] { "CMUsername", "CMClub_name" });

            List<Clubs> users = Clubs.GetClubs();

            listView1.Items.Clear();

            int[] columnWidths = new int[listView1.Columns.Count];
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                columnWidths[i] = listView1.Columns[i].Width;
            }

            foreach (Clubs u in users)
            {
                ListViewItem item = new ListViewItem(new string[] { u.CMUsername, u.CMClub_Name });
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
                currUser = (Clubs)item.Tag;

                //int id = currUser.Id;
                string u = currUser.CMClub_Name;


                txtClub.Text = u;
                //txtId.Text = id.ToString();

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string u = txtClub.Text;
            string c = txtPassword.Text;

            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(c))
            {
                MessageBox.Show("It's empty");
                return;
            }

            currUser = Clubs.Insert(c,u);

            LoadAll();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string u = txtClub.Text;
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

            var frm = new UsersPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
