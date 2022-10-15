
namespace InstagramBot
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelect = new System.Windows.Forms.LinkLabel();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFollowTargetCommenters = new System.Windows.Forms.RadioButton();
            this.rbFollowCommenters = new System.Windows.Forms.RadioButton();
            this.rbLikeByLocations = new System.Windows.Forms.RadioButton();
            this.rbLikeByFeeds = new System.Windows.Forms.RadioButton();
            this.rbFollowByTags = new System.Windows.Forms.RadioButton();
            this.rbFollowTargetLikers = new System.Windows.Forms.RadioButton();
            this.rbFollowTargetFollowings = new System.Windows.Forms.RadioButton();
            this.rbUnfollow = new System.Windows.Forms.RadioButton();
            this.rbFollowByLocations = new System.Windows.Forms.RadioButton();
            this.rbLikeByTags = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSkipTopPosts = new System.Windows.Forms.CheckBox();
            this.cbUseRandomTags = new System.Windows.Forms.CheckBox();
            this.cbRandomize = new System.Windows.Forms.CheckBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbInteraction = new System.Windows.Forms.CheckBox();
            this.rbFollowByList = new System.Windows.Forms.RadioButton();
            this.rbWatchStory = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelect);
            this.groupBox1.Controls.Add(this.txtTarget);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(9, 124);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(66, 13);
            this.lblSelect.TabIndex = 7;
            this.lblSelect.TabStop = true;
            this.lblSelect.Text = "Select A List";
            this.lblSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelect_LinkClicked);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(94, 85);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(100, 20);
            this.txtTarget.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(94, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbWatchStory);
            this.groupBox2.Controls.Add(this.rbFollowByList);
            this.groupBox2.Controls.Add(this.rbFollowTargetCommenters);
            this.groupBox2.Controls.Add(this.rbFollowCommenters);
            this.groupBox2.Controls.Add(this.rbLikeByLocations);
            this.groupBox2.Controls.Add(this.rbLikeByFeeds);
            this.groupBox2.Controls.Add(this.rbFollowByTags);
            this.groupBox2.Controls.Add(this.rbFollowTargetLikers);
            this.groupBox2.Controls.Add(this.rbFollowTargetFollowings);
            this.groupBox2.Controls.Add(this.rbUnfollow);
            this.groupBox2.Controls.Add(this.rbFollowByLocations);
            this.groupBox2.Controls.Add(this.rbLikeByTags);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // rbFollowTargetCommenters
            // 
            this.rbFollowTargetCommenters.AutoSize = true;
            this.rbFollowTargetCommenters.Location = new System.Drawing.Point(30, 165);
            this.rbFollowTargetCommenters.Name = "rbFollowTargetCommenters";
            this.rbFollowTargetCommenters.Size = new System.Drawing.Size(136, 17);
            this.rbFollowTargetCommenters.TabIndex = 9;
            this.rbFollowTargetCommenters.TabStop = true;
            this.rbFollowTargetCommenters.Text = "Follow Target Followers";
            this.rbFollowTargetCommenters.UseVisualStyleBackColor = true;
            this.rbFollowTargetCommenters.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbFollowCommenters
            // 
            this.rbFollowCommenters.AutoSize = true;
            this.rbFollowCommenters.Location = new System.Drawing.Point(30, 235);
            this.rbFollowCommenters.Name = "rbFollowCommenters";
            this.rbFollowCommenters.Size = new System.Drawing.Size(150, 17);
            this.rbFollowCommenters.TabIndex = 8;
            this.rbFollowCommenters.TabStop = true;
            this.rbFollowCommenters.Text = "Follow Target Commenters";
            this.rbFollowCommenters.UseVisualStyleBackColor = true;
            this.rbFollowCommenters.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbLikeByLocations
            // 
            this.rbLikeByLocations.AutoSize = true;
            this.rbLikeByLocations.Location = new System.Drawing.Point(30, 49);
            this.rbLikeByLocations.Name = "rbLikeByLocations";
            this.rbLikeByLocations.Size = new System.Drawing.Size(104, 17);
            this.rbLikeByLocations.TabIndex = 7;
            this.rbLikeByLocations.TabStop = true;
            this.rbLikeByLocations.Text = "Like By Location";
            this.rbLikeByLocations.UseVisualStyleBackColor = true;
            this.rbLikeByLocations.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbLikeByFeeds
            // 
            this.rbLikeByFeeds.AutoSize = true;
            this.rbLikeByFeeds.Location = new System.Drawing.Point(30, 72);
            this.rbLikeByFeeds.Name = "rbLikeByFeeds";
            this.rbLikeByFeeds.Size = new System.Drawing.Size(92, 17);
            this.rbLikeByFeeds.TabIndex = 6;
            this.rbLikeByFeeds.TabStop = true;
            this.rbLikeByFeeds.Text = "Like By Feeds";
            this.rbLikeByFeeds.UseVisualStyleBackColor = true;
            this.rbLikeByFeeds.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbFollowByTags
            // 
            this.rbFollowByTags.AutoSize = true;
            this.rbFollowByTags.Location = new System.Drawing.Point(30, 119);
            this.rbFollowByTags.Name = "rbFollowByTags";
            this.rbFollowByTags.Size = new System.Drawing.Size(97, 17);
            this.rbFollowByTags.TabIndex = 5;
            this.rbFollowByTags.TabStop = true;
            this.rbFollowByTags.Text = "Follow By Tags";
            this.rbFollowByTags.UseVisualStyleBackColor = true;
            this.rbFollowByTags.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbFollowTargetLikers
            // 
            this.rbFollowTargetLikers.AutoSize = true;
            this.rbFollowTargetLikers.Location = new System.Drawing.Point(30, 211);
            this.rbFollowTargetLikers.Name = "rbFollowTargetLikers";
            this.rbFollowTargetLikers.Size = new System.Drawing.Size(120, 17);
            this.rbFollowTargetLikers.TabIndex = 4;
            this.rbFollowTargetLikers.TabStop = true;
            this.rbFollowTargetLikers.Text = "Follow Target Likers";
            this.rbFollowTargetLikers.UseVisualStyleBackColor = true;
            this.rbFollowTargetLikers.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbFollowTargetFollowings
            // 
            this.rbFollowTargetFollowings.AutoSize = true;
            this.rbFollowTargetFollowings.Location = new System.Drawing.Point(30, 188);
            this.rbFollowTargetFollowings.Name = "rbFollowTargetFollowings";
            this.rbFollowTargetFollowings.Size = new System.Drawing.Size(141, 17);
            this.rbFollowTargetFollowings.TabIndex = 3;
            this.rbFollowTargetFollowings.TabStop = true;
            this.rbFollowTargetFollowings.Text = "Follow Target Followings";
            this.rbFollowTargetFollowings.UseVisualStyleBackColor = true;
            this.rbFollowTargetFollowings.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbUnfollow
            // 
            this.rbUnfollow.AutoSize = true;
            this.rbUnfollow.Location = new System.Drawing.Point(30, 258);
            this.rbUnfollow.Name = "rbUnfollow";
            this.rbUnfollow.Size = new System.Drawing.Size(66, 17);
            this.rbUnfollow.TabIndex = 2;
            this.rbUnfollow.TabStop = true;
            this.rbUnfollow.Text = "Unfollow";
            this.rbUnfollow.UseVisualStyleBackColor = true;
            this.rbUnfollow.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbFollowByLocations
            // 
            this.rbFollowByLocations.AutoSize = true;
            this.rbFollowByLocations.Location = new System.Drawing.Point(30, 142);
            this.rbFollowByLocations.Name = "rbFollowByLocations";
            this.rbFollowByLocations.Size = new System.Drawing.Size(114, 17);
            this.rbFollowByLocations.TabIndex = 1;
            this.rbFollowByLocations.TabStop = true;
            this.rbFollowByLocations.Text = "Follow By Location";
            this.rbFollowByLocations.UseVisualStyleBackColor = true;
            this.rbFollowByLocations.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // rbLikeByTags
            // 
            this.rbLikeByTags.AutoSize = true;
            this.rbLikeByTags.Location = new System.Drawing.Point(30, 24);
            this.rbLikeByTags.Name = "rbLikeByTags";
            this.rbLikeByTags.Size = new System.Drawing.Size(87, 17);
            this.rbLikeByTags.TabIndex = 0;
            this.rbLikeByTags.TabStop = true;
            this.rbLikeByTags.Text = "Like By Tags";
            this.rbLikeByTags.UseVisualStyleBackColor = true;
            this.rbLikeByTags.CheckedChanged += new System.EventHandler(this.SelectAction);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbInteraction);
            this.groupBox3.Controls.Add(this.txtDelay);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTimes);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbSkipTopPosts);
            this.groupBox3.Controls.Add(this.cbUseRandomTags);
            this.groupBox3.Controls.Add(this.cbRandomize);
            this.groupBox3.Location = new System.Drawing.Point(425, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 273);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(84, 201);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(53, 20);
            this.txtDelay.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Delay";
            // 
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(84, 166);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(53, 20);
            this.txtTimes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Times";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(84, 134);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(53, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // cbSkipTopPosts
            // 
            this.cbSkipTopPosts.AutoSize = true;
            this.cbSkipTopPosts.Location = new System.Drawing.Point(22, 79);
            this.cbSkipTopPosts.Name = "cbSkipTopPosts";
            this.cbSkipTopPosts.Size = new System.Drawing.Size(98, 17);
            this.cbSkipTopPosts.TabIndex = 2;
            this.cbSkipTopPosts.Text = "Skip Top Posts";
            this.cbSkipTopPosts.UseVisualStyleBackColor = true;
            // 
            // cbUseRandomTags
            // 
            this.cbUseRandomTags.AutoSize = true;
            this.cbUseRandomTags.Location = new System.Drawing.Point(22, 53);
            this.cbUseRandomTags.Name = "cbUseRandomTags";
            this.cbUseRandomTags.Size = new System.Drawing.Size(115, 17);
            this.cbUseRandomTags.TabIndex = 1;
            this.cbUseRandomTags.Text = "Use Random Tags";
            this.cbUseRandomTags.UseVisualStyleBackColor = true;
            // 
            // cbRandomize
            // 
            this.cbRandomize.AutoSize = true;
            this.cbRandomize.Location = new System.Drawing.Point(22, 30);
            this.cbRandomize.Name = "cbRandomize";
            this.cbRandomize.Size = new System.Drawing.Size(79, 17);
            this.cbRandomize.TabIndex = 0;
            this.cbRandomize.Text = "Randomize";
            this.cbRandomize.UseVisualStyleBackColor = true;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(638, 17);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(92, 13);
            this.lblAction.TabIndex = 3;
            this.lblAction.Text = "Select An Action !";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(641, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 30);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbInteraction
            // 
            this.cbInteraction.AutoSize = true;
            this.cbInteraction.Location = new System.Drawing.Point(22, 102);
            this.cbInteraction.Name = "cbInteraction";
            this.cbInteraction.Size = new System.Drawing.Size(76, 17);
            this.cbInteraction.TabIndex = 13;
            this.cbInteraction.Text = "Interaction";
            this.cbInteraction.UseVisualStyleBackColor = true;
            // 
            // rbFollowByList
            // 
            this.rbFollowByList.AutoSize = true;
            this.rbFollowByList.Location = new System.Drawing.Point(30, 95);
            this.rbFollowByList.Name = "rbFollowByList";
            this.rbFollowByList.Size = new System.Drawing.Size(79, 17);
            this.rbFollowByList.TabIndex = 10;
            this.rbFollowByList.TabStop = true;
            this.rbFollowByList.Text = "Like By List";
            this.rbFollowByList.UseVisualStyleBackColor = true;
            // 
            // rbWatchStory
            // 
            this.rbWatchStory.AutoSize = true;
            this.rbWatchStory.Location = new System.Drawing.Point(30, 281);
            this.rbWatchStory.Name = "rbWatchStory";
            this.rbWatchStory.Size = new System.Drawing.Size(92, 17);
            this.rbWatchStory.TabIndex = 11;
            this.rbWatchStory.TabStop = true;
            this.rbWatchStory.Text = "Watch Stories";
            this.rbWatchStory.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 352);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstagramBot";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLikeByLocations;
        private System.Windows.Forms.RadioButton rbLikeByFeeds;
        private System.Windows.Forms.RadioButton rbFollowByTags;
        private System.Windows.Forms.RadioButton rbFollowTargetLikers;
        private System.Windows.Forms.RadioButton rbFollowTargetFollowings;
        private System.Windows.Forms.RadioButton rbUnfollow;
        private System.Windows.Forms.RadioButton rbFollowByLocations;
        private System.Windows.Forms.RadioButton rbLikeByTags;
        private System.Windows.Forms.RadioButton rbFollowCommenters;
        private System.Windows.Forms.RadioButton rbFollowTargetCommenters;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbSkipTopPosts;
        private System.Windows.Forms.CheckBox cbUseRandomTags;
        private System.Windows.Forms.CheckBox cbRandomize;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.LinkLabel lblSelect;
        private System.Windows.Forms.CheckBox cbInteraction;
        private System.Windows.Forms.RadioButton rbFollowByList;
        private System.Windows.Forms.RadioButton rbWatchStory;
    }
}