namespace SampleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart.Date, monthView1.SelectionEnd.Date);
        }

#if false
        #region Calendar Methods

        /// <summary>
        /// Handles the LoadItems event of the calendar1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="WindowsFormsCalendar.CalendarLoadEventArgs"/> instance containing the event data.</param>
        private void calendar1_LoadItems( object sender, CalendarLoadEventArgs e )
        {
            foreach( CalendarItem calendarItem in _items )
            {
                if( this.calendar1.ViewIntersects( calendarItem ) )
                {
                    this.calendar1.Items.Add( calendarItem );
                }
            }
        }

        #endregion
#endif
    }
}
