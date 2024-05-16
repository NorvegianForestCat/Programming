namespace Programming.View.Panels
{
    partial class WeekdayPanel
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
            weekdayValidLabel = new Label();
            parseWeekdayButton = new Button();
            weekdayValueTextBox = new TextBox();
            parseValTypeLabel = new Label();
            SuspendLayout();
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
            // WeekdayPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(weekdayValidLabel);
            Controls.Add(parseWeekdayButton);
            Controls.Add(weekdayValueTextBox);
            Controls.Add(parseValTypeLabel);
            Location = new Point(3, 244);
            Name = "WeekdayPanel";
            Size = new Size(1301, 644);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label parseValTypeLabel;
        private Button parseWeekdayButton;
        private TextBox weekdayValueTextBox;
        private Label weekdayValidLabel;
    }
}
