namespace Programming.View.Panels
{
    partial class FilmPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            releaseYearLabel = new Label();
            releaseYearTextBox = new TextBox();
            genreLabel = new Label();
            genreTextBox = new TextBox();
            filmFindButton = new Button();
            ratingLabel = new Label();
            ratingTextBox = new TextBox();
            durationLabel = new Label();
            durationTextBox = new TextBox();
            titleLabel = new Label();
            titleTextBox = new TextBox();
            filmsListBox = new ListBox();
            SuspendLayout();
            // 
            // releaseYearLabel
            // 
            releaseYearLabel.AutoSize = true;
            releaseYearLabel.Location = new Point(560, 66);
            releaseYearLabel.Name = "releaseYearLabel";
            releaseYearLabel.Size = new Size(71, 15);
            releaseYearLabel.TabIndex = 18;
            releaseYearLabel.Text = "Release year";
            // 
            // releaseYearTextBox
            // 
            releaseYearTextBox.Location = new Point(560, 84);
            releaseYearTextBox.Name = "releaseYearTextBox";
            releaseYearTextBox.Size = new Size(166, 23);
            releaseYearTextBox.TabIndex = 19;
            releaseYearTextBox.TextChanged += releaseYearTextBox_TextChanged;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(560, 22);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(38, 15);
            genreLabel.TabIndex = 16;
            genreLabel.Text = "Genre";
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(560, 40);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(166, 23);
            genreTextBox.TabIndex = 17;
            genreTextBox.TextChanged += genreTextBox_TextChanged;
            // 
            // filmFindButton
            // 
            filmFindButton.Location = new Point(388, 157);
            filmFindButton.Name = "filmFindButton";
            filmFindButton.Size = new Size(338, 23);
            filmFindButton.TabIndex = 15;
            filmFindButton.Text = "Find";
            filmFindButton.UseVisualStyleBackColor = true;
            filmFindButton.Click += filmFindButton_Click;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new Point(388, 110);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(41, 15);
            ratingLabel.TabIndex = 13;
            ratingLabel.Text = "Rating";
            // 
            // ratingTextBox
            // 
            ratingTextBox.Location = new Point(388, 128);
            ratingTextBox.Name = "ratingTextBox";
            ratingTextBox.Size = new Size(338, 23);
            ratingTextBox.TabIndex = 14;
            ratingTextBox.TextChanged += ratingTextBox_TextChanged;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(388, 66);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(53, 15);
            durationLabel.TabIndex = 11;
            durationLabel.Text = "Duration";
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(388, 84);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(166, 23);
            durationTextBox.TabIndex = 12;
            durationTextBox.TextChanged += durationTextBox_TextChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(388, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(29, 15);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(388, 40);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(166, 23);
            titleTextBox.TabIndex = 10;
            titleTextBox.TextChanged += titleTextBox_TextChanged;
            // 
            // filmsListBox
            // 
            filmsListBox.FormattingEnabled = true;
            filmsListBox.ItemHeight = 15;
            filmsListBox.Location = new Point(6, 22);
            filmsListBox.Name = "filmsListBox";
            filmsListBox.Size = new Size(376, 154);
            filmsListBox.TabIndex = 8;
            filmsListBox.SelectedIndexChanged += filmsListBox_SelectedIndexChanged;
            // 
            // FilmPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(releaseYearLabel);
            Controls.Add(releaseYearTextBox);
            Controls.Add(genreLabel);
            Controls.Add(genreTextBox);
            Controls.Add(filmFindButton);
            Controls.Add(ratingLabel);
            Controls.Add(ratingTextBox);
            Controls.Add(durationLabel);
            Controls.Add(durationTextBox);
            Controls.Add(titleLabel);
            Controls.Add(titleTextBox);
            Controls.Add(filmsListBox);
            Location = new Point(3, 3);
            Name = "FilmPanel";
            Size = new Size(1301, 644);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button filmFindButton;
        private Label ratingLabel;
        private TextBox ratingTextBox;
        private Label durationLabel;
        private TextBox durationTextBox;
        private Label titleLabel;
        private TextBox titleTextBox;
        private ListBox filmsListBox;
        private Label releaseYearLabel;
        private TextBox releaseYearTextBox;
        private Label genreLabel;
        private TextBox genreTextBox;
    }
}
