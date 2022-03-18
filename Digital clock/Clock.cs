using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Digital_clock
{
    public partial class Clock : Form
    {
        Timer start = new Timer();

        public Clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //when this button is clicked start the clock

            start.Interval = 1000; //millisecond which is 1 second

            start.Tick += new EventHandler( this.OnTick );

            //the start the timer
            start.Start();

        }
            
        //timer eveent handler
        private void OnTick(object sender, EventArgs e)
        {
            //lets get the current time of our PC   

            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;

            //time that will be displayed on the screen
            string displayedTime = "";

            //formatting
            if (hours < 10)
            {
                displayedTime += "0" + hours;
            }
            else
            {
                displayedTime += hours;
            }

            displayedTime += ":";

            if (minutes < 10)
            {
                displayedTime += "0" + minutes;
            }
            else
            {
                displayedTime += minutes;
            }

            displayedTime += ":";

            if (seconds < 10)
            {
                displayedTime += "0" + seconds;
            }
            else
            {
                displayedTime += seconds;
            }


            label1.Text = displayedTime;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            start.Stop();
        }
    }
}
