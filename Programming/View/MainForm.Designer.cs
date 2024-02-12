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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            SeasonHandleGroupBox = new GroupBox();
            ChooseSeasonButton = new Button();
            ChooseSeasonComboBox = new ComboBox();
            ChooseSeasonLabel = new Label();
            WeekdayGroupBox = new GroupBox();
            WeekdayValidLabel = new Label();
            ParseWeekdayButton = new Button();
            WeekdayValueTextBox = new TextBox();
            ParseValTypeLabel = new Label();
            EnumsGroupBox = new GroupBox();
            IntValueTextBox = new TextBox();
            IntValueLabel = new Label();
            ValueChooseLabel = new Label();
            EnumChooseLabel = new Label();
            ValueListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SeasonHandleGroupBox.SuspendLayout();
            WeekdayGroupBox.SuspendLayout();
            EnumsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SeasonHandleGroupBox);
            tabPage1.Controls.Add(WeekdayGroupBox);
            tabPage1.Controls.Add(EnumsGroupBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            SeasonHandleGroupBox.Controls.Add(ChooseSeasonButton);
            SeasonHandleGroupBox.Controls.Add(ChooseSeasonComboBox);
            SeasonHandleGroupBox.Controls.Add(ChooseSeasonLabel);
            SeasonHandleGroupBox.Location = new Point(400, 244);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Size = new Size(389, 170);
            SeasonHandleGroupBox.TabIndex = 1;
            SeasonHandleGroupBox.TabStop = false;
            SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // ChooseSeasonButton
            // 
            ChooseSeasonButton.Location = new Point(287, 45);
            ChooseSeasonButton.Name = "ChooseSeasonButton";
            ChooseSeasonButton.Size = new Size(75, 23);
            ChooseSeasonButton.TabIndex = 3;
            ChooseSeasonButton.Text = "Go!";
            ChooseSeasonButton.UseVisualStyleBackColor = true;
            ChooseSeasonButton.Click += ChooseSeasonButton_Click;
            // 
            // ChooseSeasonComboBox
            // 
            ChooseSeasonComboBox.FormattingEnabled = true;
            ChooseSeasonComboBox.Location = new Point(6, 46);
            ChooseSeasonComboBox.Name = "ChooseSeasonComboBox";
            ChooseSeasonComboBox.Size = new Size(238, 23);
            ChooseSeasonComboBox.TabIndex = 4;
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.Location = new Point(6, 29);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(89, 15);
            ChooseSeasonLabel.TabIndex = 3;
            ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(WeekdayValidLabel);
            WeekdayGroupBox.Controls.Add(ParseWeekdayButton);
            WeekdayGroupBox.Controls.Add(WeekdayValueTextBox);
            WeekdayGroupBox.Controls.Add(ParseValTypeLabel);
            WeekdayGroupBox.Location = new Point(3, 244);
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.Size = new Size(391, 170);
            WeekdayGroupBox.TabIndex = 6;
            WeekdayGroupBox.TabStop = false;
            WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayValidLabel
            // 
            WeekdayValidLabel.AutoSize = true;
            WeekdayValidLabel.Location = new Point(6, 93);
            WeekdayValidLabel.Name = "WeekdayValidLabel";
            WeekdayValidLabel.Size = new Size(38, 15);
            WeekdayValidLabel.TabIndex = 3;
            WeekdayValidLabel.Text = "label1";
            // 
            // ParseWeekdayButton
            // 
            ParseWeekdayButton.Location = new Point(285, 46);
            ParseWeekdayButton.Name = "ParseWeekdayButton";
            ParseWeekdayButton.Size = new Size(81, 23);
            ParseWeekdayButton.TabIndex = 2;
            ParseWeekdayButton.Text = "Parse";
            ParseWeekdayButton.UseVisualStyleBackColor = true;
            ParseWeekdayButton.Click += ParseWeekdayButton_Click;
            // 
            // WeekdayValueTextBox
            // 
            WeekdayValueTextBox.Location = new Point(6, 47);
            WeekdayValueTextBox.Name = "WeekdayValueTextBox";
            WeekdayValueTextBox.Size = new Size(238, 23);
            WeekdayValueTextBox.TabIndex = 1;
            // 
            // ParseValTypeLabel
            // 
            ParseValTypeLabel.AutoSize = true;
            ParseValTypeLabel.Location = new Point(6, 29);
            ParseValTypeLabel.Name = "ParseValTypeLabel";
            ParseValTypeLabel.Size = new Size(125, 15);
            ParseValTypeLabel.TabIndex = 0;
            ParseValTypeLabel.Text = "Type value for parsing:";
            // 
            // EnumsGroupBox
            // 
            EnumsGroupBox.Controls.Add(IntValueTextBox);
            EnumsGroupBox.Controls.Add(IntValueLabel);
            EnumsGroupBox.Controls.Add(ValueChooseLabel);
            EnumsGroupBox.Controls.Add(EnumChooseLabel);
            EnumsGroupBox.Controls.Add(ValueListBox);
            EnumsGroupBox.Controls.Add(EnumsListBox);
            EnumsGroupBox.Dock = DockStyle.Top;
            EnumsGroupBox.Location = new Point(3, 3);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(786, 235);
            EnumsGroupBox.TabIndex = 0;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(416, 55);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.Size = new Size(156, 23);
            IntValueTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(416, 28);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(55, 15);
            IntValueLabel.TabIndex = 4;
            IntValueLabel.Text = "Int value:";
            // 
            // ValueChooseLabel
            // 
            ValueChooseLabel.AutoSize = true;
            ValueChooseLabel.Location = new Point(210, 28);
            ValueChooseLabel.Name = "ValueChooseLabel";
            ValueChooseLabel.Size = new Size(81, 15);
            ValueChooseLabel.TabIndex = 3;
            ValueChooseLabel.Text = "Choose value:";
            // 
            // EnumChooseLabel
            // 
            EnumChooseLabel.AutoSize = true;
            EnumChooseLabel.Location = new Point(6, 28);
            EnumChooseLabel.Name = "EnumChooseLabel";
            EnumChooseLabel.Size = new Size(121, 15);
            EnumChooseLabel.TabIndex = 2;
            EnumChooseLabel.Text = "Choose enumeration:";
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.ItemHeight = 15;
            ValueListBox.Location = new Point(210, 55);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Size = new Size(181, 169);
            ValueListBox.TabIndex = 1;
            ValueListBox.SelectedIndexChanged += ValueListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Season", "SmartphoneMaker", "Weekday" });
            EnumsListBox.Location = new Point(5, 55);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(181, 169);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Programming Demo";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            SeasonHandleGroupBox.ResumeLayout(false);
            SeasonHandleGroupBox.PerformLayout();
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox EnumsGroupBox;
        private TextBox IntValueTextBox;
        private Label IntValueLabel;
        private Label ValueChooseLabel;
        private Label EnumChooseLabel;
        private ListBox ValueListBox;
        private ListBox EnumsListBox;
        private GroupBox WeekdayGroupBox;
        private Label ParseValTypeLabel;
        private GroupBox SeasonHandleGroupBox;
        private Button ParseWeekdayButton;
        private TextBox WeekdayValueTextBox;
        private Label ChooseSeasonLabel;
        private Button ChooseSeasonButton;
        private ComboBox ChooseSeasonComboBox;
        private Label WeekdayValidLabel;
    }
}