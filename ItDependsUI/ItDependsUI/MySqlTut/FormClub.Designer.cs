namespace GameReviewsUI
{
    partial class FormClub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadAllUsers = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOpenGamesPage = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(17, 64);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(804, 259);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 207;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Club_Name";
            this.columnHeader2.Width = 253;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Club Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // btnLoadAllUsers
            // 
            this.btnLoadAllUsers.Location = new System.Drawing.Point(14, 504);
            this.btnLoadAllUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadAllUsers.Name = "btnLoadAllUsers";
            this.btnLoadAllUsers.Size = new System.Drawing.Size(249, 35);
            this.btnLoadAllUsers.TabIndex = 4;
            this.btnLoadAllUsers.Text = "Load all clubs";
            this.btnLoadAllUsers.UseVisualStyleBackColor = true;
            this.btnLoadAllUsers.Click += new System.EventHandler(this.btnLoadAllUsers_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(271, 504);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 35);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(112, 375);
            this.txtClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClub.MaxLength = 20;
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(346, 26);
            this.txtClub.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 415);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(346, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // btnOpenGamesPage
            // 
            this.btnOpenGamesPage.Location = new System.Drawing.Point(17, 12);
            this.btnOpenGamesPage.Name = "btnOpenGamesPage";
            this.btnOpenGamesPage.Size = new System.Drawing.Size(120, 44);
            this.btnOpenGamesPage.TabIndex = 14;
            this.btnOpenGamesPage.Text = "Games Page";
            this.btnOpenGamesPage.UseVisualStyleBackColor = true;
            this.btnOpenGamesPage.Click += new System.EventHandler(this.btnOpenGamesPage_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(17, 549);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 35);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 29;
            this.button1.Text = "Users Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnOpenGamesPage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtClub);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoadAllUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormClub";
            this.Text = "Form Clubs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadAllUsers;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOpenGamesPage;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
    }
}

