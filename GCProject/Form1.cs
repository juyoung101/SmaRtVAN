
using GCProject.SensorPackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Update_Remaining_Power(decimal power)
        {

            Math.Round(power, 2);
            string p = power.ToString();
            CurrentStoredPower.Text = p + " MaH";
        }

        public void Update_Power_Generation(decimal power)
        {
            Math.Round(power, 2);
            string p = power.ToString();
            CurrentPowerGeneration.Text = p + " MaH";
        }

        public void Update_Power_Expendeture(decimal power)
        {
            Math.Round(power, 2);
            string p = power.ToString();
            CurrentPowerExpendeture.Text = p + " MaH";
        }

        public void Update_Time_Remaining(int time)
        {
            string t = time.ToString();
            TimeRemaining.Text = "Est. Remaining Time: " + t + " min.";
        }

        private void InputDevices_add_Click(object sender, EventArgs e)
        {
            //input device add
        }

        private void OutputDevices_add_Click(object sender, EventArgs e)
        {
            //output device add
        }

        private void InteriorSensors_add_Click(object sender, EventArgs e)
        {
            //interiorsensors add
        }

        private void ExteriorSensors_add_Click(object sender, EventArgs e)
        {
            //exterior sensors add
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // a;slkdjf;alsdkjf;alsdkja;sdlkjfa;lsdkfja;ldskfj
            Update_Power_Expendeture(SensorHandler.getRandom());
        }

    }
}
