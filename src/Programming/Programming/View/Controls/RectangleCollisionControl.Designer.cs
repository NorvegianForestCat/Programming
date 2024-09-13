namespace Programming.View.Controls
{
    partial class RectangleCollisionControl
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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.Location = new Point(4, 24);
            this.Size = new Size(792, 589);
            this.ResumeLayout(false);

            selectedRectangleHeightTextBox = new TextBox();
            selectedRectangleWidthTextBox = new TextBox();
            selectedRectangleYTextBox = new TextBox();
            selectedRectangleXTextBox = new TextBox();
            selectedRectangleIDTextBox = new TextBox();
            selectedRectangleWidthLabel = new Label();
            selectedRectangleXLabel = new Label();
            selectedRectangleHeightLabel = new Label();
            selecetedRectangleYLabel = new Label();
            selectedRectangleIDLabel = new Label();
            selectedRectLabel = new Label();
            removeRectangleButton = new Button();
            addRectangleButton = new Button();
            rectangleLabel = new Label();
            rectangleColListBox = new ListBox();
            rectangleCanvasPanel = new Panel();

            // 
            // selectedRectangleHeightTextBox
            // 
            selectedRectangleHeightTextBox.Location = new Point(58, 383);
            selectedRectangleHeightTextBox.Name = "selectedRectangleHeightTextBox";
            selectedRectangleHeightTextBox.Size = new Size(100, 23);
            selectedRectangleHeightTextBox.TabIndex = 14;
            selectedRectangleHeightTextBox.MouseLeave += selectedRectangleHeightTextBox_MouseLeave;
            // 
            // selectedRectangleWidthTextBox
            // 
            selectedRectangleWidthTextBox.Location = new Point(58, 354);
            selectedRectangleWidthTextBox.Name = "selectedRectangleWidthTextBox";
            selectedRectangleWidthTextBox.Size = new Size(100, 23);
            selectedRectangleWidthTextBox.TabIndex = 13;
            selectedRectangleWidthTextBox.MouseLeave += selectedRectangleWidthTextBox_MouseLeave;
            // 
            // selectedRectangleYTextBox
            // 
            selectedRectangleYTextBox.Location = new Point(58, 325);
            selectedRectangleYTextBox.Name = "selectedRectangleYTextBox";
            selectedRectangleYTextBox.Size = new Size(100, 23);
            selectedRectangleYTextBox.TabIndex = 12;
            selectedRectangleYTextBox.MouseLeave += selectedRectangleYTextBox_MouseLeave;
            // 
            // selectedRectangleXTextBox
            // 
            selectedRectangleXTextBox.Location = new Point(58, 296);
            selectedRectangleXTextBox.Name = "selectedRectangleXTextBox";
            selectedRectangleXTextBox.Size = new Size(100, 23);
            selectedRectangleXTextBox.TabIndex = 11;
            selectedRectangleXTextBox.MouseLeave += selectedRectangleXTextBox_MouseLeave;
            // 
            // selectedRectangleIDTextBox
            // 
            selectedRectangleIDTextBox.Location = new Point(58, 267);
            selectedRectangleIDTextBox.Name = "selectedRectangleIDTextBox";
            selectedRectangleIDTextBox.Size = new Size(100, 23);
            selectedRectangleIDTextBox.TabIndex = 10;
            selectedRectangleIDTextBox.TextChanged += selectedRectangleIDTextBox_TextChanged;
            // 
            // selectedRectangleWidthLabel
            // 
            selectedRectangleWidthLabel.AutoSize = true;
            selectedRectangleWidthLabel.Location = new Point(13, 357);
            selectedRectangleWidthLabel.Name = "selectedRectangleWidthLabel";
            selectedRectangleWidthLabel.Size = new Size(39, 15);
            selectedRectangleWidthLabel.TabIndex = 0;
            selectedRectangleWidthLabel.Text = "Width";
            // 
            // selectedRectangleXLabel
            // 
            selectedRectangleXLabel.AutoSize = true;
            selectedRectangleXLabel.Location = new Point(38, 299);
            selectedRectangleXLabel.Name = "selectedRectangleXLabel";
            selectedRectangleXLabel.Size = new Size(14, 15);
            selectedRectangleXLabel.TabIndex = 9;
            selectedRectangleXLabel.Text = "X";
            // 
            // selectedRectangleHeightLabel
            // 
            selectedRectangleHeightLabel.AutoSize = true;
            selectedRectangleHeightLabel.Location = new Point(9, 386);
            selectedRectangleHeightLabel.Name = "selectedRectangleHeightLabel";
            selectedRectangleHeightLabel.Size = new Size(43, 15);
            selectedRectangleHeightLabel.TabIndex = 8;
            selectedRectangleHeightLabel.Text = "Height";
            // 
            // selecetedRectangleYLabel
            // 
            selecetedRectangleYLabel.AutoSize = true;
            selecetedRectangleYLabel.Location = new Point(38, 328);
            selecetedRectangleYLabel.Name = "selecetedRectangleYLabel";
            selecetedRectangleYLabel.Size = new Size(14, 15);
            selecetedRectangleYLabel.TabIndex = 7;
            selecetedRectangleYLabel.Text = "Y";
            // 
            // selectedRectangleIDLabel
            // 
            selectedRectangleIDLabel.AutoSize = true;
            selectedRectangleIDLabel.Location = new Point(34, 270);
            selectedRectangleIDLabel.Name = "selectedRectangleIDLabel";
            selectedRectangleIDLabel.Size = new Size(18, 15);
            selectedRectangleIDLabel.TabIndex = 5;
            selectedRectangleIDLabel.Text = "ID";
            // 
            // selectedRectLabel
            // 
            selectedRectLabel.AutoSize = true;
            selectedRectLabel.Location = new Point(7, 249);
            selectedRectLabel.Name = "selectedRectLabel";
            selectedRectLabel.Size = new Size(106, 15);
            selectedRectLabel.TabIndex = 4;
            selectedRectLabel.Text = "Selected rectangle:";
            // 
            // removeRectangleButton
            // 
            removeRectangleButton.BackgroundImageLayout = ImageLayout.Center;
            removeRectangleButton.Location = new Point(247, 201);
            removeRectangleButton.Name = "removeRectangleButton";
            removeRectangleButton.Size = new Size(38, 38);
            removeRectangleButton.TabIndex = 3;
            removeRectangleButton.Text = "-";
            removeRectangleButton.UseVisualStyleBackColor = true;
            removeRectangleButton.Click += removeRectangleButton_Click;
            // 
            // addRectangleButton
            // 
            addRectangleButton.BackgroundImageLayout = ImageLayout.Center;
            addRectangleButton.Location = new Point(7, 201);
            addRectangleButton.Name = "addRectangleButton";
            addRectangleButton.Size = new Size(38, 38);
            addRectangleButton.TabIndex = 2;
            addRectangleButton.Text = "+";
            addRectangleButton.UseVisualStyleBackColor = true;
            addRectangleButton.Click += addRectangleButton_Click;
            // 
            // rectLabel
            // 
            rectangleLabel.AutoSize = true;
            rectangleLabel.Location = new Point(7, 8);
            rectangleLabel.Name = "rectangleLabel";
            rectangleLabel.Size = new Size(64, 15);
            rectangleLabel.TabIndex = 1;
            rectangleLabel.Text = "Rectangles";
            // 
            // rectangleColListBox
            // 
            rectangleColListBox.FormattingEnabled = true;
            rectangleColListBox.ItemHeight = 15;
            rectangleColListBox.Location = new Point(8, 26);
            rectangleColListBox.Name = "rectangleColListBox";
            rectangleColListBox.Size = new Size(277, 169);
            rectangleColListBox.TabIndex = 0;
            rectangleColListBox.SelectedIndexChanged += rectangleColListBox_SelectedIndexChanged;
            // 
            // rectangleCanvasPanel
            // 
            rectangleCanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            rectangleCanvasPanel.Location = new Point(303, 8);
            rectangleCanvasPanel.Name = "rectangleCanvasPanel";
            rectangleCanvasPanel.Size = new Size(481, 406);
            rectangleCanvasPanel.TabIndex = 0;

            Controls.Add(rectangleLabel);
            Controls.Add(rectangleColListBox);
            Controls.Add(rectangleCanvasPanel);
            Controls.Add(removeRectangleButton);
            Controls.Add(addRectangleButton);
            Controls.Add(selectedRectangleWidthLabel);
            Controls.Add(selectedRectangleXLabel);
            Controls.Add(selectedRectangleHeightLabel);
            Controls.Add(selecetedRectangleYLabel);
            Controls.Add(selectedRectangleIDLabel);
            Controls.Add(selectedRectLabel);
            Controls.Add(selectedRectangleHeightTextBox);
            Controls.Add(selectedRectangleWidthTextBox);
            Controls.Add(selectedRectangleYTextBox);
            Controls.Add(selectedRectangleXTextBox);
            Controls.Add(selectedRectangleIDTextBox);
        }

        #endregion

        private Label rectangleLabel;
        private ListBox rectangleColListBox;
        private Panel rectangleCanvasPanel;
        private Button removeRectangleButton;
        private Button addRectangleButton;
        private Label selectedRectangleWidthLabel;
        private Label selectedRectangleXLabel;
        private Label selectedRectangleHeightLabel;
        private Label selecetedRectangleYLabel;
        private Label selectedRectangleIDLabel;
        private Label selectedRectLabel;
        private TextBox selectedRectangleHeightTextBox;
        private TextBox selectedRectangleWidthTextBox;
        private TextBox selectedRectangleYTextBox;
        private TextBox selectedRectangleXTextBox;
        private TextBox selectedRectangleIDTextBox;
    }
}
