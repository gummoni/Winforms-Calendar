namespace SampleForm
{
    partial class Form1
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
            monthView1 = new Gummoni.UI.MonthViewControl.MonthView();
            splitter1 = new Splitter();
            calendar1 = new Gummoni.UI.CalendarControl.Calendar();
            SuspendLayout();
            // 
            // monthView1
            // 
            monthView1.ArrowsColor = SystemColors.Window;
            monthView1.ArrowsSelectedColor = Color.Gold;
            monthView1.DayBackgroundColor = Color.Empty;
            monthView1.DayGrayedText = SystemColors.GrayText;
            monthView1.DaySelectedBackgroundColor = SystemColors.Highlight;
            monthView1.DaySelectedColor = SystemColors.WindowText;
            monthView1.DaySelectedTextColor = SystemColors.HighlightText;
            monthView1.Dock = DockStyle.Left;
            monthView1.ItemPadding = new Padding(2);
            monthView1.Location = new Point(0, 0);
            monthView1.MonthTitleColor = SystemColors.ActiveCaption;
            monthView1.MonthTitleColorInactive = SystemColors.InactiveCaption;
            monthView1.MonthTitleTextColor = SystemColors.ActiveCaptionText;
            monthView1.MonthTitleTextColorInactive = SystemColors.InactiveCaptionText;
            monthView1.Name = "monthView1";
            monthView1.Size = new Size(204, 549);
            monthView1.TabIndex = 0;
            monthView1.Text = "monthView1";
            monthView1.TodayBorderColor = Color.Maroon;
            monthView1.SelectionChanged += monthView1_SelectionChanged;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(204, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 549);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // calendar1
            // 
            calendar1.Dock = DockStyle.Fill;
            calendar1.Font = new Font("Yu Gothic UI", 9F);
            calendar1.ItemsBackgroundColor = Color.RoyalBlue;
            calendar1.ItemsFont = null;
            calendar1.ItemsForeColor = Color.Black;
            calendar1.Location = new Point(214, 0);
            calendar1.Name = "calendar1";
            calendar1.Size = new Size(774, 549);
            calendar1.TabIndex = 2;
            calendar1.Text = "calendar1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 549);
            Controls.Add(calendar1);
            Controls.Add(splitter1);
            Controls.Add(monthView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Gummoni.UI.MonthViewControl.MonthView monthView1;
        private Splitter splitter1;
        private Gummoni.UI.CalendarControl.Calendar calendar1;
    }
}
