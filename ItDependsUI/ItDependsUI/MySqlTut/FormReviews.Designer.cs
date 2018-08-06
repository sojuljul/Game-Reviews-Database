namespace GameReviewsUI
{
    partial class FormReviews
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
            this.btnOpenClubsPage = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btnOpenGamesPage = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLoadAllReviews = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvReviews = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenUsersPage = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOpenClubsPage
            // 
            this.btnOpenClubsPage.Location = new System.Drawing.Point(323, 44);
            this.btnOpenClubsPage.Name = "btnOpenClubsPage";
            this.btnOpenClubsPage.Size = new System.Drawing.Size(120, 44);
            this.btnOpenClubsPage.TabIndex = 41;
            this.btnOpenClubsPage.Text = "Clubs Page";
            this.btnOpenClubsPage.UseVisualStyleBackColor = true;
            this.btnOpenClubsPage.Click += new System.EventHandler(this.btnOpenClubsPage_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(68, 627);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 35);
            this.Exit.TabIndex = 40;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnOpenGamesPage
            // 
            this.btnOpenGamesPage.Location = new System.Drawing.Point(197, 44);
            this.btnOpenGamesPage.Name = "btnOpenGamesPage";
            this.btnOpenGamesPage.Size = new System.Drawing.Size(120, 44);
            this.btnOpenGamesPage.TabIndex = 39;
            this.btnOpenGamesPage.Text = "Games Page";
            this.btnOpenGamesPage.UseVisualStyleBackColor = true;
            this.btnOpenGamesPage.Click += new System.EventHandler(this.btnOpenGamesPage_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(197, 470);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScore.MaxLength = 20;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(346, 26);
            this.txtScore.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 470);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Score (0 - 100):";
            // 
            // txtGame
            // 
            this.txtGame.Location = new System.Drawing.Point(197, 429);
            this.txtGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGame.MaxLength = 20;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(346, 26);
            this.txtGame.TabIndex = 36;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(197, 386);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(346, 26);
            this.txtUsername.TabIndex = 35;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(325, 582);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 35);
            this.btnInsert.TabIndex = 34;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLoadAllReviews
            // 
            this.btnLoadAllReviews.Location = new System.Drawing.Point(68, 582);
            this.btnLoadAllReviews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadAllReviews.Name = "btnLoadAllReviews";
            this.btnLoadAllReviews.Size = new System.Drawing.Size(249, 35);
            this.btnLoadAllReviews.TabIndex = 33;
            this.btnLoadAllReviews.Text = "Load all Reviews";
            this.btnLoadAllReviews.UseVisualStyleBackColor = true;
            this.btnLoadAllReviews.Click += new System.EventHandler(this.btnLoadAllReviews_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 432);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Game:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Username:";
            // 
            // lvReviews
            // 
            this.lvReviews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvReviews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvReviews.FullRowSelect = true;
            this.lvReviews.Location = new System.Drawing.Point(71, 96);
            this.lvReviews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvReviews.MultiSelect = false;
            this.lvReviews.Name = "lvReviews";
            this.lvReviews.Size = new System.Drawing.Size(804, 259);
            this.lvReviews.TabIndex = 30;
            this.lvReviews.UseCompatibleStateImageBehavior = false;
            this.lvReviews.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Review Id";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 92;
            // 
            // btnOpenUsersPage
            // 
            this.btnOpenUsersPage.Location = new System.Drawing.Point(71, 44);
            this.btnOpenUsersPage.Name = "btnOpenUsersPage";
            this.btnOpenUsersPage.Size = new System.Drawing.Size(120, 44);
            this.btnOpenUsersPage.TabIndex = 42;
            this.btnOpenUsersPage.Text = "User Page";
            this.btnOpenUsersPage.UseVisualStyleBackColor = true;
            this.btnOpenUsersPage.Click += new System.EventHandler(this.btnOpenUsersPage_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(197, 506);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.MaxLength = 20;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(678, 26);
            this.txtDescription.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 506);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Description:";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Game";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Score";
            this.columnHeader4.Width = 54;
            // 
            // FormReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 695);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenUsersPage);
            this.Controls.Add(this.btnOpenClubsPage);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnOpenGamesPage);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoadAllReviews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvReviews);
            this.Name = "FormReviews";
            this.Text = "FormReviews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenClubsPage;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnOpenGamesPage;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLoadAllReviews;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvReviews;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnOpenUsersPage;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}