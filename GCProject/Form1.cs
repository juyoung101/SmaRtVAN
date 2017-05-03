
using GCProject.SensorPackage;
using GCProject.DevicePackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCProject
{
    public partial class Form1 : Form
    {
        public SensorHandler sHandler { get; set; }
        public decimal battery { get; set; }

        public DeviceHandler deviceHandler = new DeviceHandler();
       

        public Form1()
        {
            InitializeComponent();

            /****************** /
                   Init
            / ******************/
            battery = 500; //Initial setup with battery containing 500 MaH
            sHandler = new SensorHandler(@".\SensorPackage\DataSets\location1\December.csv");
            deviceHandler.generateDebugList();
            //DEBUG
            iSensor mockSensor = iSensor.makeSensor("DATE", "01/01/2017", "String", false);
            //SensorParser sparse = new SensorParser();
            //sparse.filename = @"C:\Users\Justin\Dropbox\class\CS5860\project\SensorPackage\DataSets\location1\December.csv";
            //sparse.readFile();

            /****************** /
                    Program
            / ******************/
            //TODO run program

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

        public void Update_Time_And_Date(string time, string date)
        {
            this.Text = "SmaRtVAN         -          " + time + "       " + date;
        }

        private void InputDevices_add_Click(object sender, EventArgs e)
        {
            //input device add

            //TODO this should pop up a modal window to create new devices
            //DEBUG
            InputDevices.Items.Add("iDev " + SensorHandler.getRandom() % 100);
        }

        private void OutputDevices_add_Click(object sender, EventArgs e)
        {
            //output device add

            //TODO this should pop up a modal window to create new devices
            //DEBUG
            OutputDevices.Items.Add("oDev " + SensorHandler.getRandom() % 100);
        }

        private void InteriorSensors_add_Click(object sender, EventArgs e)
        {
            //interiorsensors add

            //TODO this should pop up a modal window to create new sensor
            //DEBUG
            InteriorSensors.Items.Add("iSens " + SensorHandler.getRandom() % 100);
        }

        private void ExteriorSensors_add_Click(object sender, EventArgs e)
        {
            //exterior sensors add

            //TODO this should pop up a modal window to create new sensor
            //DEBUG
            ExteriorSensors.Items.Add("eSens " + SensorHandler.getRandom() % 100);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // a;slkdjf;alsdkjf;alsdkja;sdlkjfa;lsdkfja;ldskfj

            sHandler.updateSensors();
            deviceHandler.updateDevices();
            Update_Time_And_Date(sHandler.getDateSensor().read(), sHandler.getTimeSensor().read());
            decimal powerIn = 0;
            decimal powerOut = 0;
            powerIn = deviceHandler.getInputEnergy();
            powerOut = deviceHandler.getOutputEnergy();
            battery += deviceHandler.getEnergyDifference();

            Update_Power_Expendeture(powerOut);
            Update_Power_Generation(powerIn);
            Update_Remaining_Power(battery);
            Update_Time_Remaining(0);

            Update_Input_Device_List();
            Update_Output_Device_List();

            /*
            //DEBUG 
            Update_Power_Expendeture(SensorHandler.getRandom() % 1000);
            Update_Power_Generation(SensorHandler.getRandom() % 1100);
            Update_Remaining_Power(SensorHandler.getRandom() % 459);
            Update_Time_Remaining(SensorHandler.getRandom() % 20);
            //Update_Time_And_Date("Str1", "str2");
            //DEBUG
            */

            if (battery <= 0)
                battery = 1000000000;
        }

        public void Update_Input_Device_List()
        {
            //code here
        }

        public void Update_Output_Device_List()
        {
            //code here
        }

    }
}
