namespace Premiere_Pro_Project_Setup
{
    /// <summary>
    /// Represents a message box that automatically closes after a specified timeout.
    /// </summary>
    public partial class AutoClosingMessageBox : Form
    {
        readonly System.Windows.Forms.Timer _timeoutTimer;
        readonly string _caption;

        public AutoClosingMessageBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initializes a new instance of the AutoClosingMessageBox class with the specified text, caption, and timeout.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="timeout">The time after which the message box should close, in milliseconds.</param>
        private AutoClosingMessageBox(string text, string caption, int timeout)
        {
            InitializeComponent();
            _caption = caption;
            this.Text = _caption;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 
                Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            labelMessage.Text = text;
            _timeoutTimer = new System.Windows.Forms.Timer
            {
                Interval = timeout
            };
            _timeoutTimer.Tick += new EventHandler(Timer_Tick);
            _timeoutTimer.Start();
        }


        /// <summary>
        /// Handles the Tick event of the Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        void Timer_Tick(object sender, EventArgs e)
        {
            _timeoutTimer.Stop();
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Displays a message box with the specified text, caption, and timeout.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="timeout">The time after which the message box should close, in milliseconds.</param>
        public static void Show(string text, string caption, int timeout)
        {
            AutoClosingMessageBox acmb = new(text, caption, timeout);
            acmb.ShowDialog();
        }

    }
}
