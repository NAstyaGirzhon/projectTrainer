using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

using System.IO;
using Presenter;

namespace WindowsFormsApp1
{
    public partial class WindowDoctor : Form
    {


        public WindowDoctor()
        {
            InitializeComponent();
        }
       // WDoctorModel model = new WDoctorModel();

        private int[,] runArr = {
             {180,160,0},
             {38,36,1},
             {170,150,2},
             {52,40,3},
             {22,15,4}
         };
        private int[,] veloArr = {
             {170,130,0},
             {37,36,1},
             {160,140,2},
             {44,36,3},
             {18,10,4}
         };
        private int[,] physicalActivityArr = {
             {190,175,0},
             {39,37,1},
             {180,165,2},
             {55,40,3},
             {20,12,4}            
         };
        private int[,] ArrayfGraphs = new int[3, 3];
        private int[] ArrayS = new int[3];
        //  private enum CheckBox Sensors{ };
        enum Sensors{pressureCheck =0, temperatureCheck=1, pulseCheck=2, wetCheck=3, electroCheck=4};
        Sensors sensor;

        private void RevitalizButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            int a;
            if (pressureCheck.Checked)
            {
                sensor = Sensors.pressureCheck;
                ArrayS[i] = (int)sensor;
                i++;
                BloodPressureSensor.ForeColor = Color.Green;
            }
            if (temperatureCheck.Checked)
            {
                sensor = Sensors.temperatureCheck;
                ArrayS[i] = (int)sensor;
                i++;
                skinTemperatureSensor.ForeColor = Color.Green;
            }
            if (pulseCheck.Checked)
            {
                sensor = Sensors.pulseCheck;
                ArrayS[i] = (int)sensor;
                i++;
                heartRateSensor.ForeColor = Color.Green;
            }
            if (wetCheck.Checked)
            {
                sensor = Sensors.wetCheck;
                ArrayS[i] = (int)sensor;
                i++;
                skinmoistureSensor.ForeColor = Color.Green;
            }
            if (electroCheck.Checked)
            {
                sensor = Sensors.electroCheck;
                ArrayS[i] = (int)sensor;
                i++;
                electricalCoductivitySensor.ForeColor = Color.Green;
            }
            //else
            //{
            //    MessageBox.Show("Выберите один из датчиков");
            //}

            if (VeloCheck.Checked)
            {
                PowerCheck.Checked = false;
                RunCheck.Checked = false;
                for (int k = 0; k < ArrayS.Length; k++)
                {
                    a = ArrayS[k];
                    for (int j = 0; j < 3; j++)
                    {
                        ArrayfGraphs[k, j] = veloArr[a, j];
                    }
                }
            }
            else if (PowerCheck.Checked)
            {
                VeloCheck.Checked = false;
                RunCheck.Checked = false;
          
                    for (int k = 0; k < ArrayS.Length; k++)
                    {
                     a= ArrayS[k];
                        for (int j = 0; j < 3; j++)
                        {
                            ArrayfGraphs[k, j] = physicalActivityArr[a, j];
                        }
                      
                    }
                
            }
            else if (RunCheck.Checked)
            {
                VeloCheck.Checked = false;
                PowerCheck.Checked = false;
                for (int k = 0; k < ArrayS.Length; k++)
                {
                    a = ArrayS[k];
                    for (int j = 0; j < 3; j++)
                    {
                        ArrayfGraphs[k, j] = runArr[a, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите один из типов физ нагрузки");
            }

            double g = 0;
            for (int k = 0; k < ArrayS.Length; k++)
            {
                for (int j = 0; j < 3; j++)
                {

                   g  = ArrayfGraphs[k, j];
                    string str = g.ToString(); 
                    textBox1.Text += str + " ";
                    
                }
                textBox1.Text += "\r\n";


            }
        }

      
        private void GotoWindowDG_Click(object sender, EventArgs e)
        {

            DocaDGModel.getArray = ArrayfGraphs;
            DocaDGModel.getArr = ArrayS;
            Displaying_Graphs graphs = new Displaying_Graphs();
            graphs.Show();

        }
       
        private void WindowDoctor_Load(object sender, EventArgs e)
        {

            var PM = new PatientM
            {
                DateTime = dateTimePicker1.Value.ToString()
            };
            var PReg = new PrWRegstr();
            PReg.WritetoFile(PM);

        }

        
    }

}
