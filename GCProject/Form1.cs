
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

    }
}
