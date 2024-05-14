using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premiere_Pro_Project_Setup
{
    public partial class AutoClosingMessageBox : Form
    {
        readonly System.Windows.Forms.Timer _timeoutTimer;
        readonly string _caption;

        public AutoClosingMessageBox()
        {
            InitializeComponent();
        }
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

        void Timer_Tick(object sender, EventArgs e)
        {
            _timeoutTimer.Stop();
            DialogResult = DialogResult.OK;
            Close();
        }
        public static void Show(string text, string caption, int timeout)
        {
            AutoClosingMessageBox acmb = new(text, caption, timeout);
            acmb.ShowDialog();
        }

    }
}
