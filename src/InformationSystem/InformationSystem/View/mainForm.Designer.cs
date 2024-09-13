namespace InformationSystem
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            songsListBox = new ListBox();
            selSongGroupBox = new GroupBox();
            genreComboBox = new ComboBox();
            artistTextBox = new TextBox();
            durationTextBox = new TextBox();
            titleTextBox = new TextBox();
            genreLabel = new Label();
            durationLabel = new Label();
            artistLabel = new Label();
            titleLabel = new Label();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            selSongGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // songsListBox
            // 
            songsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            songsListBox.BorderStyle = BorderStyle.FixedSingle;
            songsListBox.FormattingEnabled = true;
            songsListBox.ItemHeight = 15;
            songsListBox.Location = new Point(12, 12);
            songsListBox.Name = "songsListBox";
            songsListBox.Size = new Size(320, 347);
            songsListBox.TabIndex = 0;
            songsListBox.SelectedIndexChanged += songsListBox_SelectedIndexChanged;
            // 
            // selSongGroupBox
            // 
            selSongGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            selSongGroupBox.Controls.Add(genreComboBox);
            selSongGroupBox.Controls.Add(artistTextBox);
            selSongGroupBox.Controls.Add(durationTextBox);
            selSongGroupBox.Controls.Add(titleTextBox);
            selSongGroupBox.Controls.Add(genreLabel);
            selSongGroupBox.Controls.Add(durationLabel);
            selSongGroupBox.Controls.Add(artistLabel);
            selSongGroupBox.Controls.Add(titleLabel);
            selSongGroupBox.FlatStyle = FlatStyle.Flat;
            selSongGroupBox.Location = new Point(340, 12);
            selSongGroupBox.Name = "selSongGroupBox";
            selSongGroupBox.Size = new Size(340, 136);
            selSongGroupBox.TabIndex = 1;
            selSongGroupBox.TabStop = false;
            selSongGroupBox.Text = "Selected song";
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(85, 106);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(120, 23);
            genreComboBox.TabIndex = 5;
            // 
            // artistTextBox
            // 
            artistTextBox.Location = new Point(85, 48);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(245, 23);
            artistTextBox.TabIndex = 3;
            artistTextBox.TextChanged += artistTextBox_TextChanged;
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(85, 78);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(120, 23);
            durationTextBox.TabIndex = 4;
            durationTextBox.TextChanged += durationTextBox_TextChanged;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(85, 20);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(245, 23);
            titleTextBox.TabIndex = 2;
            titleTextBox.TextChanged += titleTextBox_TextChanged;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(40, 110);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(38, 15);
            genreLabel.TabIndex = 5;
            genreLabel.Text = "Genre";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(24, 80);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(53, 15);
            durationLabel.TabIndex = 4;
            durationLabel.Text = "Duration";
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new Point(10, 50);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(68, 15);
            artistLabel.TabIndex = 3;
            artistLabel.Text = "Artist name";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(20, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(57, 15);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Song title";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Image = Properties.Resources.AddIcon3;
            addButton.Location = new Point(12, 382);
            addButton.Name = "addButton";
            addButton.Size = new Size(55, 55);
            addButton.TabIndex = 6;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            editButton.Image = Properties.Resources.EditIcon1;
            editButton.Location = new Point(75, 382);
            editButton.Name = "editButton";
            editButton.Size = new Size(55, 55);
            editButton.TabIndex = 7;
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteButton.BackgroundImageLayout = ImageLayout.Center;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Image = Properties.Resources.DeleteIcon;
            deleteButton.Location = new Point(135, 382);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(55, 55);
            deleteButton.TabIndex = 8;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 451);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(selSongGroupBox);
            Controls.Add(songsListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(705, 490);
            Name = "mainForm";
            Text = "SongApp";
            FormClosed += mainForm_FormClosed;
            Load += mainForm_Load;
            selSongGroupBox.ResumeLayout(false);
            selSongGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox songsListBox;
        private GroupBox selSongGroupBox;
        private ComboBox genreComboBox;
        private TextBox artistTextBox;
        private TextBox durationTextBox;
        private TextBox titleTextBox;
        private Label genreLabel;
        private Label durationLabel;
        private Label artistLabel;
        private Label titleLabel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
    }
}