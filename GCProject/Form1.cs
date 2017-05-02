
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

        private void Update_Remaining_Power(decimal power)
        {

            Math.Round(power, 2);
            string p = power.ToString();
            CurrentStoredPower.Text = p + " MaH";
        }
    }
}
