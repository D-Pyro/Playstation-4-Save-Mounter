namespace PS4Saves
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.setupButton = new System.Windows.Forms.Button();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.dirsComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mountButton = new System.Windows.Forms.Button();
            this.unmountButton = new System.Windows.Forms.Button();
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.getGamesButton = new System.Windows.Forms.Button();
            this.gamesComboBox = new System.Windows.Forms.ComboBox();
            this.payloadButton = new System.Windows.Forms.Button();
            this.ipLabel = new System.Windows.Forms.Label();
            this.createGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.mountGroupBox = new System.Windows.Forms.GroupBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.subtitleTextBox = new System.Windows.Forms.TextBox();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sizeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.connectionGroupBox.SuspendLayout();
            this.createGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.mountGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(140, 37);
            this.ipTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(230, 31);
            this.ipTextBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(568, 37);
            this.connectButton.Margin = new System.Windows.Forms.Padding(6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(180, 38);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // setupButton
            // 
            this.setupButton.Enabled = false;
            this.setupButton.Location = new System.Drawing.Point(14, 87);
            this.setupButton.Margin = new System.Windows.Forms.Padding(6);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(362, 40);
            this.setupButton.TabIndex = 3;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.Enabled = false;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(386, 87);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(358, 33);
            this.userComboBox.TabIndex = 4;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // dirsComboBox
            // 
            this.dirsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dirsComboBox.Enabled = false;
            this.dirsComboBox.FormattingEnabled = true;
            this.dirsComboBox.Location = new System.Drawing.Point(386, 37);
            this.dirsComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.dirsComboBox.Name = "dirsComboBox";
            this.dirsComboBox.Size = new System.Drawing.Size(356, 33);
            this.dirsComboBox.TabIndex = 1;
            this.dirsComboBox.SelectedIndexChanged += new System.EventHandler(this.dirsComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(12, 37);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(362, 40);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mountButton
            // 
            this.mountButton.Enabled = false;
            this.mountButton.Location = new System.Drawing.Point(12, 92);
            this.mountButton.Margin = new System.Windows.Forms.Padding(6);
            this.mountButton.Name = "mountButton";
            this.mountButton.Size = new System.Drawing.Size(362, 44);
            this.mountButton.TabIndex = 2;
            this.mountButton.Text = "Mount";
            this.mountButton.UseVisualStyleBackColor = true;
            this.mountButton.Click += new System.EventHandler(this.mountButton_Click);
            // 
            // unmountButton
            // 
            this.unmountButton.Enabled = false;
            this.unmountButton.Location = new System.Drawing.Point(384, 92);
            this.unmountButton.Margin = new System.Windows.Forms.Padding(6);
            this.unmountButton.Name = "unmountButton";
            this.unmountButton.Size = new System.Drawing.Size(362, 44);
            this.unmountButton.TabIndex = 3;
            this.unmountButton.Text = "Unmount";
            this.unmountButton.UseVisualStyleBackColor = true;
            this.unmountButton.Click += new System.EventHandler(this.unmountButton_Click);
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.getGamesButton);
            this.connectionGroupBox.Controls.Add(this.gamesComboBox);
            this.connectionGroupBox.Controls.Add(this.payloadButton);
            this.connectionGroupBox.Controls.Add(this.ipLabel);
            this.connectionGroupBox.Controls.Add(this.ipTextBox);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Controls.Add(this.setupButton);
            this.connectionGroupBox.Controls.Add(this.userComboBox);
            this.connectionGroupBox.Location = new System.Drawing.Point(14, 23);
            this.connectionGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.connectionGroupBox.Size = new System.Drawing.Size(758, 202);
            this.connectionGroupBox.TabIndex = 0;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // getGamesButton
            // 
            this.getGamesButton.Enabled = false;
            this.getGamesButton.Location = new System.Drawing.Point(12, 138);
            this.getGamesButton.Margin = new System.Windows.Forms.Padding(6);
            this.getGamesButton.Name = "getGamesButton";
            this.getGamesButton.Size = new System.Drawing.Size(362, 40);
            this.getGamesButton.TabIndex = 5;
            this.getGamesButton.Text = "Get Games";
            this.getGamesButton.UseVisualStyleBackColor = true;
            this.getGamesButton.Click += new System.EventHandler(this.getGamesButton_Click);
            // 
            // gamesComboBox
            // 
            this.gamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamesComboBox.Enabled = false;
            this.gamesComboBox.FormattingEnabled = true;
            this.gamesComboBox.Location = new System.Drawing.Point(384, 138);
            this.gamesComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.gamesComboBox.Name = "gamesComboBox";
            this.gamesComboBox.Size = new System.Drawing.Size(358, 33);
            this.gamesComboBox.TabIndex = 6;
            this.gamesComboBox.SelectedIndexChanged += new System.EventHandler(this.gamesComboBox_SelectedIndexChanged);
            // 
            // payloadButton
            // 
            this.payloadButton.Location = new System.Drawing.Point(384, 37);
            this.payloadButton.Margin = new System.Windows.Forms.Padding(6);
            this.payloadButton.Name = "payloadButton";
            this.payloadButton.Size = new System.Drawing.Size(180, 38);
            this.payloadButton.TabIndex = 1;
            this.payloadButton.Text = "Send Payload";
            this.payloadButton.UseVisualStyleBackColor = true;
            this.payloadButton.Click += new System.EventHandler(this.payloadButton_Click);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(12, 42);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(122, 25);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "IP Address:";
            // 
            // createGroupBox
            // 
            this.createGroupBox.Controls.Add(this.sizeLabel);
            this.createGroupBox.Controls.Add(this.sizeTrackBar);
            this.createGroupBox.Controls.Add(this.nameLabel);
            this.createGroupBox.Controls.Add(this.nameTextBox);
            this.createGroupBox.Controls.Add(this.createButton);
            this.createGroupBox.Location = new System.Drawing.Point(14, 404);
            this.createGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.createGroupBox.Name = "createGroupBox";
            this.createGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.createGroupBox.Size = new System.Drawing.Size(758, 248);
            this.createGroupBox.TabIndex = 2;
            this.createGroupBox.TabStop = false;
            this.createGroupBox.Text = "Create New Saves";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 92);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(156, 25);
            this.sizeLabel.TabIndex = 9;
            this.sizeLabel.Text = "Max save size:";
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.Location = new System.Drawing.Point(234, 92);
            this.sizeTrackBar.Margin = new System.Windows.Forms.Padding(6);
            this.sizeTrackBar.Maximum = 32768;
            this.sizeTrackBar.Minimum = 96;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(514, 90);
            this.sizeTrackBar.TabIndex = 1;
            this.sizeTrackBar.Value = 96;
            this.sizeTrackBar.Scroll += new System.EventHandler(this.sizeTrackBar_Scroll);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 48);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(215, 25);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Save directory name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(234, 42);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.MaxLength = 31;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(508, 31);
            this.nameTextBox.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(10, 190);
            this.createButton.Margin = new System.Windows.Forms.Padding(6);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(734, 44);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create Save";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // mountGroupBox
            // 
            this.mountGroupBox.Controls.Add(this.searchButton);
            this.mountGroupBox.Controls.Add(this.dirsComboBox);
            this.mountGroupBox.Controls.Add(this.mountButton);
            this.mountGroupBox.Controls.Add(this.unmountButton);
            this.mountGroupBox.Location = new System.Drawing.Point(14, 237);
            this.mountGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.mountGroupBox.Name = "mountGroupBox";
            this.mountGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.mountGroupBox.Size = new System.Drawing.Size(758, 156);
            this.mountGroupBox.TabIndex = 1;
            this.mountGroupBox.TabStop = false;
            this.mountGroupBox.Text = "Mount Existing Saves";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.dateTextBox);
            this.infoGroupBox.Controls.Add(this.dateLabel);
            this.infoGroupBox.Controls.Add(this.detailsTextBox);
            this.infoGroupBox.Controls.Add(this.detailsLabel);
            this.infoGroupBox.Controls.Add(this.subtitleTextBox);
            this.infoGroupBox.Controls.Add(this.subtitleLabel);
            this.infoGroupBox.Controls.Add(this.titleTextBox);
            this.infoGroupBox.Controls.Add(this.titleLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(784, 23);
            this.infoGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.infoGroupBox.Size = new System.Drawing.Size(792, 629);
            this.infoGroupBox.TabIndex = 3;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Save Info";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(18, 565);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(758, 31);
            this.dateTextBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 535);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(63, 25);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date:";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(18, 319);
            this.detailsTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.ReadOnly = true;
            this.detailsTextBox.Size = new System.Drawing.Size(758, 206);
            this.detailsTextBox.TabIndex = 2;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(12, 288);
            this.detailsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(84, 25);
            this.detailsLabel.TabIndex = 4;
            this.detailsLabel.Text = "Details:";
            // 
            // subtitleTextBox
            // 
            this.subtitleTextBox.Location = new System.Drawing.Point(18, 194);
            this.subtitleTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.subtitleTextBox.Multiline = true;
            this.subtitleTextBox.Name = "subtitleTextBox";
            this.subtitleTextBox.ReadOnly = true;
            this.subtitleTextBox.Size = new System.Drawing.Size(758, 85);
            this.subtitleTextBox.TabIndex = 1;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Location = new System.Drawing.Point(12, 163);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(90, 25);
            this.subtitleLabel.TabIndex = 2;
            this.subtitleLabel.Text = "Subtitle:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(18, 67);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(758, 87);
            this.titleTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 37);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(8, 658);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(79, 25);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Status:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1594, 696);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.mountGroupBox);
            this.Controls.Add(this.createGroupBox);
            this.Controls.Add(this.connectionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PlayStation 4 Save Mounter 1.5 [ps4debug] [fw build 6.72]";
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.createGroupBox.ResumeLayout(false);
            this.createGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.mountGroupBox.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ComboBox dirsComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button mountButton;
        private System.Windows.Forms.Button unmountButton;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.GroupBox createGroupBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox mountGroupBox;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ToolTip sizeToolTip;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox subtitleTextBox;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button payloadButton;
        private System.Windows.Forms.Button getGamesButton;
        private System.Windows.Forms.ComboBox gamesComboBox;
    }
}

