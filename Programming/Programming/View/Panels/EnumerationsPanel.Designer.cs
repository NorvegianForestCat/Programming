namespace Programming.View.Panels
{
    partial class EnumerationsPanel
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
            intValueTextBox = new TextBox();
            intValueLabel = new Label();
            valueChooseLabel = new Label();
            enumChooseLabel = new Label();
            valueListBox = new ListBox();
            enumsListBox = new ListBox();
            SuspendLayout();
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
            // EnumerationsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(intValueTextBox);
            Controls.Add(intValueLabel);
            Controls.Add(valueChooseLabel);
            Controls.Add(enumChooseLabel);
            Controls.Add(valueListBox);
            Controls.Add(enumsListBox);
            Location = new Point(3, 3);
            Name = "EnumerationsPanel";
            Size = new Size(1301, 235);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enumChooseLabel;
        private Label valueChooseLabel;
        private Label intValueLabel;
        private ListBox enumsListBox;
        private ListBox valueListBox;
        private TextBox intValueTextBox;
    }
}
