namespace Programming.View.Panels
{
    partial class RectanglePanel
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
            SuspendLayout();
            // 
            // rectangleIDTextBox
            // 
            rectangleIDTextBox.Location = new Point(560, 81);
            rectangleIDTextBox.Name = "rectangleIDTextBox";
            rectangleIDTextBox.Size = new Size(166, 23);
            rectangleIDTextBox.TabIndex = 11;
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
            // RectanglePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rectangleIDTextBox);
            Controls.Add(rectangleIDLabel);
            Controls.Add(rectangleCenterTextBox);
            Controls.Add(centerRectangleLabel);
            Controls.Add(rectFindButton);
            Controls.Add(colorListBox);
            Controls.Add(rectColorTextBox);
            Controls.Add(widthLabel);
            Controls.Add(widthTextBox);
            Controls.Add(lengthLabel);
            Controls.Add(lengthTextBox);
            Controls.Add(rectangleListBox);
            Location = new Point(3, 3);
            Name = "RectanglePanel";
            Size = new Size(1301, 644);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox rectangleListBox;
        private Button rectFindButton;
        private Label lengthLabel;
        private Label widthLabel;
        private Label centerRectangleLabel;
        private Label rectangleIDLabel;
        private Label colorListBox;
        private TextBox widthTextBox;
        private TextBox rectColorTextBox;
        private TextBox lengthTextBox;
        private TextBox rectangleCenterTextBox;
        private TextBox rectangleIDTextBox;
    }
}
