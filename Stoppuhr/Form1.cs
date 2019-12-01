using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoppuhr
{
    public partial class Form1 : Form
    {

        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _elapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;

        private bool _timerRunning = false;

        public Form1()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            _elapsedTimeLabel.Text = _elapsedTime.ToString();

            timer2 = new Timer();
            timer2.Interval = (1000) * 5;
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);

            _elapsedTime = timeSinceStartTime + _totalElapsedTime;
            _elapsedTimeLabel.Text = _elapsedTime.ToString();
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("5-Sekunden-Timer abgelaufen");

            timer2.Tick -= new EventHandler(timer2_Tick);

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!_timerRunning)
            {
                _startTime = DateTime.Now;
                timer1.Start();
                _timerRunning = true;

                _totalElapsedTime = _elapsedTime;
            }
            else
            {
                timer1.Stop();
                _timerRunning = false;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _timerRunning = false;

            _elapsedTime = TimeSpan.Zero;
            _elapsedTimeLabel.Text = _elapsedTime.ToString();
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
