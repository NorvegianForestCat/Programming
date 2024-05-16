namespace Programming.View.Panels
{
    partial class SeasonHandlePanel
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
            chooseSeasonButton = new Button();
            chooseSeasonComboBox = new ComboBox();
            chooseSeasonLabel = new Label();
            SuspendLayout();
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
            // SeasonHandlePanel
            // 
            Controls.Add(chooseSeasonButton);
            Controls.Add(chooseSeasonComboBox);
            Controls.Add(chooseSeasonLabel);
            Location = new Point(400, 244);
            Name = "SeasonHandlePanel";
            Size = new Size(1326, 644);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label chooseSeasonLabel;
        private Button chooseSeasonButton;
        private ComboBox chooseSeasonComboBox;
    }
}
