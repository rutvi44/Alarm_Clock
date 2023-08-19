
using System.Security.Claims;
using System.Windows.Forms;

namespace MistryRInclass2
{
    public partial class Inclass2 : Form
    {
        private bool isAlarmOn = false;
        public Inclass2()
        {
            InitializeComponent();

            DateTime currentDate = DateTime.Now;

            // Set the current day in the day label
            dayLabel.Text = currentDate.ToString("dddd");

            // Set the current date in the date label
            dateLabel.Text = currentDate.ToString("dd MMMM , yyyy");

            //to start timer
            timer.Start();
        }

        private void Inclass2_Load(object sender, EventArgs e)
        {
            // to not show picture in starting
            pictureBox1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pmLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAlarmOn_Click(object sender, EventArgs e)
        {
            // to start timer when alarm on 
            timer.Start();

            

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // to show seconds
            this.secondsLabel.Text = DateTime.Now.ToString("ss");

            //to show hours in clock
            this.timeLabel.Text = DateTime.Now.ToString("H:m");

            //to show AM/PM 
            this.pmLabel.Text = DateTime.Now.ToString("tt");

            DateTime currentTime = DateTime.Now;
            DateTime alarmTime = dateTimePicker.Value;

            
            if (currentTime.Hour == alarmTime.Hour && currentTime.Minute == alarmTime.Minute && currentTime.Second == alarmTime.Second)
            {
                pictureBox1.Visible = true;

                statusLabel.Text = "Alarm on";

            }
        }

        private void Inclass2_FormClosing(object sender, FormClosingEventArgs e)
        {
           // to stop the timer
            timer.Stop();
        }

        private void buttonAlarmOff_Click(object sender, EventArgs e)
        {
            // to stop the alarm when alarm off button is pressed
            isAlarmOn = false;
            pictureBox1.Visible = false;
            statusLabel.Text = "Alarm off";
        }
    }
}
