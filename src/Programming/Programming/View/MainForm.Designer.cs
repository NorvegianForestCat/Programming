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
            seasonHandlePanel1 = new View.Panels.SeasonHandlePanel();
            weekdayGroupBox = new GroupBox();
            weekdayPanel1 = new View.Panels.WeekdayPanel();
            enumsGroupBox = new GroupBox();
            enumerationsPanel1 = new View.Panels.EnumerationsPanel();
            classesTabPage = new TabPage();
            filmsGroupBox = new GroupBox();
            rectangleGroupBox = new GroupBox();
            rectanglePanel1 = new View.Panels.RectanglePanel();
            rectTabPage = new TabPage();
            rectangleCollisionControl1 = new View.Controls.RectangleCollisionControl();
            filmPanel1 = new View.Panels.FilmPanel();
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
            mainTabControl.Size = new Size(800, 617);
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
            enumTabPage.Size = new Size(792, 589);
            enumTabPage.TabIndex = 0;
            enumTabPage.Text = "Enums";
            enumTabPage.UseVisualStyleBackColor = true;
            // 
            // seasonHandleGroupBox
            // 
            seasonHandleGroupBox.Controls.Add(seasonHandlePanel1);
            seasonHandleGroupBox.Location = new Point(400, 244);
            seasonHandleGroupBox.Name = "seasonHandleGroupBox";
            seasonHandleGroupBox.Size = new Size(389, 170);
            seasonHandleGroupBox.TabIndex = 1;
            seasonHandleGroupBox.TabStop = false;
            seasonHandleGroupBox.Text = "Season Handle";
            // 
            // seasonHandlePanel1
            // 
            seasonHandlePanel1.Dock = DockStyle.Fill;
            seasonHandlePanel1.Location = new Point(3, 19);
            seasonHandlePanel1.Name = "seasonHandlePanel1";
            seasonHandlePanel1.Size = new Size(383, 148);
            seasonHandlePanel1.TabIndex = 0;
            // 
            // weekdayGroupBox
            // 
            weekdayGroupBox.Controls.Add(weekdayPanel1);
            weekdayGroupBox.Location = new Point(3, 244);
            weekdayGroupBox.Name = "weekdayGroupBox";
            weekdayGroupBox.Size = new Size(391, 170);
            weekdayGroupBox.TabIndex = 6;
            weekdayGroupBox.TabStop = false;
            weekdayGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayPanel1
            // 
            weekdayPanel1.Dock = DockStyle.Fill;
            weekdayPanel1.Location = new Point(3, 19);
            weekdayPanel1.Name = "weekdayPanel1";
            weekdayPanel1.Size = new Size(385, 148);
            weekdayPanel1.TabIndex = 0;
            // 
            // enumsGroupBox
            // 
            enumsGroupBox.Controls.Add(enumerationsPanel1);
            enumsGroupBox.Location = new Point(0, 0);
            enumsGroupBox.Name = "enumsGroupBox";
            enumsGroupBox.Size = new Size(786, 235);
            enumsGroupBox.TabIndex = 0;
            enumsGroupBox.TabStop = false;
            enumsGroupBox.Text = "Enumerations";
            // 
            // enumerationsPanel1
            // 
            enumerationsPanel1.Location = new Point(0, 6);
            enumerationsPanel1.Name = "enumerationsPanel1";
            enumerationsPanel1.Size = new Size(1301, 235);
            enumerationsPanel1.TabIndex = 0;
            // 
            // classesTabPage
            // 
            classesTabPage.Controls.Add(filmsGroupBox);
            classesTabPage.Controls.Add(rectangleGroupBox);
            classesTabPage.Location = new Point(4, 24);
            classesTabPage.Name = "classesTabPage";
            classesTabPage.Padding = new Padding(3);
            classesTabPage.Size = new Size(792, 589);
            classesTabPage.TabIndex = 1;
            classesTabPage.Text = "Classes";
            classesTabPage.UseVisualStyleBackColor = true;
            // 
            // filmsGroupBox
            // 
            filmsGroupBox.Controls.Add(filmPanel1);
            filmsGroupBox.Dock = DockStyle.Fill;
            filmsGroupBox.Location = new Point(3, 222);
            filmsGroupBox.Name = "filmsGroupBox";
            filmsGroupBox.Size = new Size(786, 364);
            filmsGroupBox.TabIndex = 8;
            filmsGroupBox.TabStop = false;
            filmsGroupBox.Text = "Films";
            // 
            // rectangleGroupBox
            // 
            rectangleGroupBox.Controls.Add(rectanglePanel1);
            rectangleGroupBox.Dock = DockStyle.Top;
            rectangleGroupBox.Location = new Point(3, 3);
            rectangleGroupBox.Name = "rectangleGroupBox";
            rectangleGroupBox.Size = new Size(786, 219);
            rectangleGroupBox.TabIndex = 0;
            rectangleGroupBox.TabStop = false;
            rectangleGroupBox.Text = "Rectangle";
            // 
            // rectanglePanel1
            // 
            rectanglePanel1.Dock = DockStyle.Fill;
            rectanglePanel1.Location = new Point(3, 19);
            rectanglePanel1.Name = "rectanglePanel1";
            rectanglePanel1.Size = new Size(780, 197);
            rectanglePanel1.TabIndex = 0;
            // 
            // rectTabPage
            // 
            rectTabPage.Controls.Add(rectangleCollisionControl1);
            rectTabPage.Location = new Point(4, 24);
            rectTabPage.Name = "rectTabPage";
            rectTabPage.Size = new Size(792, 589);
            rectTabPage.TabIndex = 2;
            rectTabPage.Text = "Rectangles";
            rectTabPage.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            rectangleCollisionControl1.Dock = DockStyle.Fill;
            rectangleCollisionControl1.Location = new Point(0, 0);
            rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            rectangleCollisionControl1.Size = new Size(792, 589);
            rectangleCollisionControl1.TabIndex = 0;
            // 
            // filmPanel1
            // 
            filmPanel1.Location = new Point(3, 22);
            filmPanel1.Name = "filmPanel1";
            filmPanel1.Size = new Size(1301, 644);
            filmPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(mainTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Programming Demo";
            mainTabControl.ResumeLayout(false);
            enumTabPage.ResumeLayout(false);
            seasonHandleGroupBox.ResumeLayout(false);
            weekdayGroupBox.ResumeLayout(false);
            enumsGroupBox.ResumeLayout(false);
            classesTabPage.ResumeLayout(false);
            filmsGroupBox.ResumeLayout(false);
            rectangleGroupBox.ResumeLayout(false);
            rectTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage rectTabPage;
        private TabPage enumTabPage;
        private TabPage classesTabPage;
        private GroupBox enumsGroupBox;
        private GroupBox weekdayGroupBox;
        private GroupBox seasonHandleGroupBox;        
        private GroupBox rectangleGroupBox;
        private GroupBox filmsGroupBox;        
        private View.Controls.RectangleCollisionControl rectangleCollisionControl1;
        private View.Panels.EnumerationsPanel enumerationsPanel1;
        private View.Panels.WeekdayPanel weekdayPanel1;
        private View.Panels.SeasonHandlePanel seasonHandlePanel1;
        private View.Panels.RectanglePanel rectanglePanel1;
        private View.Panels.FilmPanel filmPanel1;
    }
}