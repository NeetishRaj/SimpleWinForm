using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWinForm
{
    public partial class Matrix : Form
    {
        private string[] Messages = { 
            "You're better than this!",
            "You are the best!",
            "Remember, You are among greatness!",
            "You chose this and you choose wisely!",
            "You never take the easy route!",
            "I thought weakness disgusts you!",
            "Just do it! Don't think much about it.",
            "Listen!, I know you are smart but where's dedication?",
            "Never forget your long term goals!",
            "Healthy mind resides in a healthy body!",
            "What good is money, if you are not fit to enjoy it!",
            "Why ignoring me?",
            "So.. How was your morning run today?",
            "Again planning to eat unhealthy?",
            "Don't forget to have some fun!",
            "Respect and trust builds foundation!",
            "Don't make me come out of screen to beat your ass!",
            "Tum kya lekar aaye the aur kya lekar jaaoge?",
            "Body will become dust but karma will stay many generations",
            "You can tame any element of nature",
            "Remember that day when you helped that kid get his first job",
            "Your Dad is proud of you!",
            "You suck!",
            "Today is not your day my friend. Just relax!",
            "Let your work speak for you!",
            "Short term goals helps build discipline for long term goals",
            "Just be yourself!",
            "You are an alpha! Act like one!",
            "How are you doing, Neetish?",
            "Remember me?",
            "You just talk big!",
            "Just chill!",
            "You strength gives other hope!"
        };
        private Timer tmr;
        private int AUTOMATIC_CLOSINGTIME = 1800;
        private int getRandomInt(int low = 0, int high = 10)
        {
            Random rand = new Random();
            int randIntValue = rand.Next(low, high);

            return randIntValue;
        }
        private void SetupAutoCloseTimer() {
            tmr = new Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(AUTOMATIC_CLOSINGTIME).TotalMilliseconds;
            tmr.Start();
        }
        public Matrix()
        {
            InitializeComponent();
            textBox1.Text = Messages[getRandomInt(0, Messages.Length)];
            textBox1.Enabled = false;

            SetupAutoCloseTimer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
