namespace Programming
{
    partial class MainForm
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
            mainTabControl = new TabControl();
            enumTabPage = new TabPage();
            seasonHandleGroupBox = new GroupBox();
            chooseSeasonButton = new Button();
            chooseSeasonComboBox = new ComboBox();
            chooseSeasonLabel = new Label();
            weekdayGroupBox = new GroupBox();
            weekdayValidLabel = new Label();
            parseWeekdayButton = new Button();
            weekdayValueTextBox = new TextBox();
            parseValTypeLabel = new Label();
            enumsGroupBox = new GroupBox();
            intValueTextBox = new TextBox();
            intValueLabel = new Label();
            valueChooseLabel = new Label();
            enumChooseLabel = new Label();
            valueListBox = new ListBox();
            enumsListBox = new ListBox();
            classesTabPage = new TabPage();
            filmsGroupBox = new GroupBox();
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
            rectangleGroupBox = new GroupBox();
            rectangleIDTextBox = new TextBox();
            rectangleIDLabel = new Label();
            rectangleCenterTextBox = new TextBox();
            centerRectangleLabel = new Label();
            rectFindButton = new Button();
            colorListBox = new Label();
            rectColorTextBox = new TextBox();
            widthLabel = new Label();
            widthTextBox = new TextBox();
            lengthLabel = new Label();
            lengthTextBox = new TextBox();
            rectangleListBox = new ListBox();
            rectTabPage = new TabPage();
            panel1 = new Panel();
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            mainTabControl.SuspendLayout();
            enumTabPage.SuspendLayout();
            seasonHandleGroupBox.SuspendLayout();
            weekdayGroupBox.SuspendLayout();
            enumsGroupBox.SuspendLayout();
            classesTabPage.SuspendLayout();
            filmsGroupBox.SuspendLayout();
            rectangleGroupBox.SuspendLayout();
            rectTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(enumTabPage);
            mainTabControl.Controls.Add(classesTabPage);
            mainTabControl.Controls.Add(rectTabPage);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 450);
            mainTabControl.TabIndex = 0;
            // 
            // enumTabPage
            // 
            enumTabPage.Controls.Add(seasonHandleGroupBox);
            enumTabPage.Controls.Add(weekdayGroupBox);
            enumTabPage.Controls.Add(enumsGroupBox);
            enumTabPage.Location = new Point(4, 24);
            enumTabPage.Name = "enumTabPage";
            enumTabPage.Padding = new Padding(3);
            enumTabPage.Size = new Size(792, 422);
            enumTabPage.TabIndex = 0;
            enumTabPage.Text = "Enums";
            enumTabPage.UseVisualStyleBackColor = true;
            // 
            // seasonHandleGroupBox
            // 
            seasonHandleGroupBox.Controls.Add(chooseSeasonButton);
            seasonHandleGroupBox.Controls.Add(chooseSeasonComboBox);
            seasonHandleGroupBox.Controls.Add(chooseSeasonLabel);
            seasonHandleGroupBox.Location = new Point(400, 244);
            seasonHandleGroupBox.Name = "seasonHandleGroupBox";
            seasonHandleGroupBox.Size = new Size(389, 170);
            seasonHandleGroupBox.TabIndex = 1;
            seasonHandleGroupBox.TabStop = false;
            seasonHandleGroupBox.Text = "Season Handle";
            // 
            // chooseSeasonButton
            // 
            chooseSeasonButton.Location = new Point(287, 45);
            chooseSeasonButton.Name = "chooseSeasonButton";
            chooseSeasonButton.Size = new Size(75, 23);
            chooseSeasonButton.TabIndex = 3;
            chooseSeasonButton.Text = "Go!";
            chooseSeasonButton.UseVisualStyleBackColor = true;
            chooseSeasonButton.Click += chooseSeasonButton_Click;
            // 
            // chooseSeasonComboBox
            // 
            chooseSeasonComboBox.FormattingEnabled = true;
            chooseSeasonComboBox.Location = new Point(6, 46);
            chooseSeasonComboBox.Name = "chooseSeasonComboBox";
            chooseSeasonComboBox.Size = new Size(238, 23);
            chooseSeasonComboBox.TabIndex = 4;
            // 
            // chooseSeasonLabel
            // 
            chooseSeasonLabel.AutoSize = true;
            chooseSeasonLabel.Location = new Point(6, 29);
            chooseSeasonLabel.Name = "chooseSeasonLabel";
            chooseSeasonLabel.Size = new Size(89, 15);
            chooseSeasonLabel.TabIndex = 3;
            chooseSeasonLabel.Text = "Choose season:";
            // 
            // weekdayGroupBox
            // 
            weekdayGroupBox.Controls.Add(weekdayValidLabel);
            weekdayGroupBox.Controls.Add(parseWeekdayButton);
            weekdayGroupBox.Controls.Add(weekdayValueTextBox);
            weekdayGroupBox.Controls.Add(parseValTypeLabel);
            weekdayGroupBox.Location = new Point(3, 244);
            weekdayGroupBox.Name = "weekdayGroupBox";
            weekdayGroupBox.Size = new Size(391, 170);
            weekdayGroupBox.TabIndex = 6;
            weekdayGroupBox.TabStop = false;
            weekdayGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayValidLabel
            // 
            weekdayValidLabel.AutoSize = true;
            weekdayValidLabel.Location = new Point(6, 93);
            weekdayValidLabel.Name = "weekdayValidLabel";
            weekdayValidLabel.Size = new Size(38, 15);
            weekdayValidLabel.TabIndex = 3;
            weekdayValidLabel.Text = "label1";
            // 
            // parseWeekdayButton
            // 
            parseWeekdayButton.Location = new Point(285, 46);
            parseWeekdayButton.Name = "parseWeekdayButton";
            parseWeekdayButton.Size = new Size(81, 23);
            parseWeekdayButton.TabIndex = 2;
            parseWeekdayButton.Text = "Parse";
            parseWeekdayButton.UseVisualStyleBackColor = true;
            parseWeekdayButton.Click += parseWeekdayButton_Click;
            // 
            // weekdayValueTextBox
            // 
            weekdayValueTextBox.Location = new Point(6, 47);
            weekdayValueTextBox.Name = "weekdayValueTextBox";
            weekdayValueTextBox.Size = new Size(238, 23);
            weekdayValueTextBox.TabIndex = 1;
            // 
            // parseValTypeLabel
            // 
            parseValTypeLabel.AutoSize = true;
            parseValTypeLabel.Location = new Point(6, 29);
            parseValTypeLabel.Name = "parseValTypeLabel";
            parseValTypeLabel.Size = new Size(125, 15);
            parseValTypeLabel.TabIndex = 0;
            parseValTypeLabel.Text = "Type value for parsing:";
            // 
            // enumsGroupBox
            // 
            enumsGroupBox.Controls.Add(intValueTextBox);
            enumsGroupBox.Controls.Add(intValueLabel);
            enumsGroupBox.Controls.Add(valueChooseLabel);
            enumsGroupBox.Controls.Add(enumChooseLabel);
            enumsGroupBox.Controls.Add(valueListBox);
            enumsGroupBox.Controls.Add(enumsListBox);
            enumsGroupBox.Dock = DockStyle.Top;
            enumsGroupBox.Location = new Point(3, 3);
            enumsGroupBox.Name = "enumsGroupBox";
            enumsGroupBox.Size = new Size(786, 235);
            enumsGroupBox.TabIndex = 0;
            enumsGroupBox.TabStop = false;
            enumsGroupBox.Text = "Enumerations";
            // 
            // intValueTextBox
            // 
            intValueTextBox.Location = new Point(416, 55);
            intValueTextBox.Name = "intValueTextBox";
            intValueTextBox.Size = new Size(156, 23);
            intValueTextBox.TabIndex = 5;
            // 
            // intValueLabel
            // 
            intValueLabel.AutoSize = true;
            intValueLabel.Location = new Point(416, 28);
            intValueLabel.Name = "intValueLabel";
            intValueLabel.Size = new Size(55, 15);
            intValueLabel.TabIndex = 4;
            intValueLabel.Text = "Int value:";
            // 
            // valueChooseLabel
            // 
            valueChooseLabel.AutoSize = true;
            valueChooseLabel.Location = new Point(210, 28);
            valueChooseLabel.Name = "valueChooseLabel";
            valueChooseLabel.Size = new Size(81, 15);
            valueChooseLabel.TabIndex = 3;
            valueChooseLabel.Text = "Choose value:";
            // 
            // enumChooseLabel
            // 
            enumChooseLabel.AutoSize = true;
            enumChooseLabel.Location = new Point(6, 28);
            enumChooseLabel.Name = "enumChooseLabel";
            enumChooseLabel.Size = new Size(121, 15);
            enumChooseLabel.TabIndex = 2;
            enumChooseLabel.Text = "Choose enumeration:";
            // 
            // valueListBox
            // 
            valueListBox.FormattingEnabled = true;
            valueListBox.ItemHeight = 15;
            valueListBox.Location = new Point(210, 55);
            valueListBox.Name = "valueListBox";
            valueListBox.Size = new Size(181, 169);
            valueListBox.TabIndex = 1;
            valueListBox.SelectedIndexChanged += valueListBox_SelectedIndexChanged;
            // 
            // enumsListBox
            // 
            enumsListBox.FormattingEnabled = true;
            enumsListBox.ItemHeight = 15;
            enumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Season", "SmartphoneMaker", "Weekday" });
            enumsListBox.Location = new Point(5, 55);
            enumsListBox.Name = "enumsListBox";
            enumsListBox.Size = new Size(181, 169);
            enumsListBox.TabIndex = 0;
            enumsListBox.SelectedIndexChanged += enumsListBox_SelectedIndexChanged;
            // 
            // classesTabPage
            // 
            classesTabPage.Controls.Add(filmsGroupBox);
            classesTabPage.Controls.Add(rectangleGroupBox);
            classesTabPage.Location = new Point(4, 24);
            classesTabPage.Name = "classesTabPage";
            classesTabPage.Padding = new Padding(3);
            classesTabPage.Size = new Size(792, 422);
            classesTabPage.TabIndex = 1;
            classesTabPage.Text = "Classes";
            classesTabPage.UseVisualStyleBackColor = true;
            // 
            // filmsGroupBox
            // 
            filmsGroupBox.Controls.Add(releaseYearLabel);
            filmsGroupBox.Controls.Add(releaseYearTextBox);
            filmsGroupBox.Controls.Add(genreLabel);
            filmsGroupBox.Controls.Add(genreTextBox);
            filmsGroupBox.Controls.Add(filmFindButton);
            filmsGroupBox.Controls.Add(ratingLabel);
            filmsGroupBox.Controls.Add(ratingTextBox);
            filmsGroupBox.Controls.Add(durationLabel);
            filmsGroupBox.Controls.Add(durationTextBox);
            filmsGroupBox.Controls.Add(titleLabel);
            filmsGroupBox.Controls.Add(titleTextBox);
            filmsGroupBox.Controls.Add(filmsListBox);
            filmsGroupBox.Dock = DockStyle.Fill;
            filmsGroupBox.Location = new Point(3, 185);
            filmsGroupBox.Name = "filmsGroupBox";
            filmsGroupBox.Size = new Size(786, 234);
            filmsGroupBox.TabIndex = 8;
            filmsGroupBox.TabStop = false;
            filmsGroupBox.Text = "Films";
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
            // rectangleGroupBox
            // 
            rectangleGroupBox.Controls.Add(rectangleIDTextBox);
            rectangleGroupBox.Controls.Add(rectangleIDLabel);
            rectangleGroupBox.Controls.Add(rectangleCenterTextBox);
            rectangleGroupBox.Controls.Add(centerRectangleLabel);
            rectangleGroupBox.Controls.Add(rectFindButton);
            rectangleGroupBox.Controls.Add(colorListBox);
            rectangleGroupBox.Controls.Add(rectColorTextBox);
            rectangleGroupBox.Controls.Add(widthLabel);
            rectangleGroupBox.Controls.Add(widthTextBox);
            rectangleGroupBox.Controls.Add(lengthLabel);
            rectangleGroupBox.Controls.Add(lengthTextBox);
            rectangleGroupBox.Controls.Add(rectangleListBox);
            rectangleGroupBox.Dock = DockStyle.Top;
            rectangleGroupBox.Location = new Point(3, 3);
            rectangleGroupBox.Name = "rectangleGroupBox";
            rectangleGroupBox.Size = new Size(786, 182);
            rectangleGroupBox.TabIndex = 0;
            rectangleGroupBox.TabStop = false;
            rectangleGroupBox.Text = "Rectangle";
            // 
            // rectangleIDTextBox
            // 
            rectangleIDTextBox.Location = new Point(560, 81);
            rectangleIDTextBox.Name = "rectangleIDTextBox";
            rectangleIDTextBox.Size = new Size(166, 23);
            rectangleIDTextBox.TabIndex = 11;
            rectangleIDTextBox.KeyPress += rectangleIDTextBox_KeyPress;
            // 
            // rectangleIDLabel
            // 
            rectangleIDLabel.AutoSize = true;
            rectangleIDLabel.Location = new Point(560, 63);
            rectangleIDLabel.Name = "rectangleIDLabel";
            rectangleIDLabel.Size = new Size(18, 15);
            rectangleIDLabel.TabIndex = 10;
            rectangleIDLabel.Text = "ID";
            // 
            // rectangleCenterTextBox
            // 
            rectangleCenterTextBox.Location = new Point(560, 37);
            rectangleCenterTextBox.Name = "rectangleCenterTextBox";
            rectangleCenterTextBox.Size = new Size(166, 23);
            rectangleCenterTextBox.TabIndex = 9;
            rectangleCenterTextBox.KeyPress += rectangleCenterTextBox_KeyPress;
            // 
            // centerRectangleLabel
            // 
            centerRectangleLabel.AutoSize = true;
            centerRectangleLabel.Location = new Point(560, 19);
            centerRectangleLabel.Name = "centerRectangleLabel";
            centerRectangleLabel.Size = new Size(42, 15);
            centerRectangleLabel.TabIndex = 8;
            centerRectangleLabel.Text = "Center";
            // 
            // rectFindButton
            // 
            rectFindButton.Location = new Point(244, 153);
            rectFindButton.Name = "rectFindButton";
            rectFindButton.Size = new Size(310, 23);
            rectFindButton.TabIndex = 7;
            rectFindButton.Text = "Find";
            rectFindButton.UseVisualStyleBackColor = true;
            rectFindButton.Click += rectFindButton_Click;
            // 
            // colorListBox
            // 
            colorListBox.AutoSize = true;
            colorListBox.Location = new Point(244, 107);
            colorListBox.Name = "colorListBox";
            colorListBox.Size = new Size(36, 15);
            colorListBox.TabIndex = 5;
            colorListBox.Text = "Color";
            // 
            // rectColorTextBox
            // 
            rectColorTextBox.Location = new Point(244, 125);
            rectColorTextBox.Name = "rectColorTextBox";
            rectColorTextBox.Size = new Size(310, 23);
            rectColorTextBox.TabIndex = 6;
            rectColorTextBox.TextChanged += rectColorTextBox_TextChanged;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(244, 63);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(39, 15);
            widthLabel.TabIndex = 3;
            widthLabel.Text = "Width";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(244, 81);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(310, 23);
            widthTextBox.TabIndex = 4;
            widthTextBox.TextChanged += widthTextBox_TextChanged;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(244, 19);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(44, 15);
            lengthLabel.TabIndex = 1;
            lengthLabel.Text = "Length";
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(244, 37);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(310, 23);
            lengthTextBox.TabIndex = 2;
            lengthTextBox.TextChanged += lengthTextBox_TextChanged;
            // 
            // rectangleListBox
            // 
            rectangleListBox.FormattingEnabled = true;
            rectangleListBox.ItemHeight = 15;
            rectangleListBox.Location = new Point(6, 22);
            rectangleListBox.Name = "rectangleListBox";
            rectangleListBox.Size = new Size(232, 154);
            rectangleListBox.TabIndex = 0;
            rectangleListBox.SelectedIndexChanged += rectangleListBox_SelectedIndexChanged;
            // 
            // rectTabPage
            // 
            rectTabPage.Controls.Add(button2);
            rectTabPage.Controls.Add(button1);
            rectTabPage.Controls.Add(label1);
            rectTabPage.Controls.Add(listBox1);
            rectTabPage.Controls.Add(panel1);
            rectTabPage.Location = new Point(4, 24);
            rectTabPage.Name = "rectTabPage";
            rectTabPage.Size = new Size(792, 422);
            rectTabPage.TabIndex = 2;
            rectTabPage.Text = "Rectangles";
            rectTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(303, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 406);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(8, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 169);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(8, 201);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(247, 201);
            button2.Name = "button2";
            button2.Size = new Size(38, 38);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Programming Demo";
            mainTabControl.ResumeLayout(false);
            enumTabPage.ResumeLayout(false);
            seasonHandleGroupBox.ResumeLayout(false);
            seasonHandleGroupBox.PerformLayout();
            weekdayGroupBox.ResumeLayout(false);
            weekdayGroupBox.PerformLayout();
            enumsGroupBox.ResumeLayout(false);
            enumsGroupBox.PerformLayout();
            classesTabPage.ResumeLayout(false);
            filmsGroupBox.ResumeLayout(false);
            filmsGroupBox.PerformLayout();
            rectangleGroupBox.ResumeLayout(false);
            rectangleGroupBox.PerformLayout();
            rectTabPage.ResumeLayout(false);
            rectTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage enumTabPage;
        private GroupBox enumsGroupBox;
        private TextBox intValueTextBox;
        private Label intValueLabel;
        private Label valueChooseLabel;
        private Label enumChooseLabel;
        private ListBox valueListBox;
        private ListBox enumsListBox;
        private GroupBox weekdayGroupBox;
        private Label parseValTypeLabel;
        private GroupBox seasonHandleGroupBox;
        private Button parseWeekdayButton;
        private TextBox weekdayValueTextBox;
        private Label chooseSeasonLabel;
        private Button chooseSeasonButton;
        private ComboBox chooseSeasonComboBox;
        private Label weekdayValidLabel;
        private TabPage classesTabPage;
        private GroupBox rectangleGroupBox;
        private ListBox rectangleListBox;
        private GroupBox filmsGroupBox;
        private Button rectFindButton;
        private Label colorListBox;
        private TextBox rectColorTextBox;
        private Label widthLabel;
        private TextBox widthTextBox;
        private Label lengthLabel;
        private TextBox lengthTextBox;
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
        private TextBox rectangleCenterTextBox;
        private Label centerRectangleLabel;
        private TextBox rectangleIDTextBox;
        private Label rectangleIDLabel;
        private TabPage rectTabPage;
        private Label label1;
        private ListBox listBox1;
        private Panel panel1;
        private Button button2;
        private Button button1;
    }
}