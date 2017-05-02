using GCProject.SensorPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GCProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /****************** /
                   Init
            / ******************/
            SensorHandler sHandler = new SensorHandler(@"c:\example.txt");
            iSensor mockSensor = iSensor.makeSensor("DATE", "01/01/2017", "String");

            /****************** /
                    GUI
            / ******************/            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /****************** /
                    Program
            / ******************/
            
}

}
}
