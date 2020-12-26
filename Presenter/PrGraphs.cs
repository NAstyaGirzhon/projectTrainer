using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

using System.Diagnostics;
using Model;
namespace Presenter
{
    public class PrGraphs
    {
        private Thread cpuThread;
        //private Thread Thread2;
        //private Thread Thread3;
        private int[] chart1Array = new int[14];
       // private int[] chart2Array = new int[14];
        //private int[] chart3Array = new int[14];
        private int[,] arrayy = new int[3, 3];

        string _series = " ";
        //string _series2 = " ";
       // string _series3 = " ";
        int min = 0, min1 = 0, min2 = 0;
        int max = 0, max1 = 0, max2 = 0;

        int number = 0;
        int k = 0;
        int j = 0;
       // PrGraphs prG = new PrGraphs();
        //Displaying_Graphs _Graphs = new Displaying_Graphs();
        Chart chart1 = new Chart();
        Chart chart2 = new Chart();
        Chart chart3 = new Chart();
       
        public void WorkGraphs1(ChartM cha)
        {

            foreach (int i in DocaDGModel.getArray)
            {
                arrayy[j, k] = i;
                k++;
                if (k == 3)
                {
                    k = 0;

                    //max = arrayy[j, 0];
                    //min = arrayy[j, 1];
                    //WhileArr(min, max);
                    j++;
                }

            }
            chart1 = cha.Plot;
            _series = cha.Series;
            cpuThread = new Thread(new ThreadStart(this.getRandom1));
            cpuThread.IsBackground = true;
            cpuThread.Start();
            

        }
        //public void WorkGraphs2()
        //{
        //    Thread2 = new Thread(new ThreadStart(this.getRandom2));
        //    Thread2.IsBackground = true;
        //    Thread2.Start();
        //}
        //public void WorkGraphs3()
        //{
        //    Thread3 = new Thread(new ThreadStart(this.getRandom3));
        //    Thread3.IsBackground = true;
        //    Thread3.Start();
        //}
        private void getRandom1()
        {
            j = DocaDGModel.GetI;
            max = arrayy[j, 0];
            min = arrayy[j, 1];
            WhileArr(min, max);

            //while (true)
            //{

            //    chart1Array[chart1Array.Length - 1] = rnd.Next(min, max);
            //    Array.Copy(chart1Array, 1, chart1Array, 0, chart1Array.Length - 1);
            //    // IsHandleCreated Получает значение, указывающее, имеет ли элемент управления связанный с ним дескриптор.
            //    //делегаты - это указатели на методы и с помощью делегатов мы можем вызвать данные методы.
            //   // if (!chart1.IsHandleCreated || chart1.IsDisposed) return;
            //    if (chart1.IsHandleCreated)
            //    {
            //        // Invoke Выполняет указанный делегат в потоке, которому принадлежит базовый дескриптор окна элемента управления.
            //        //делегат представляет собой структуру данных, которая ссылается на статический метод.
            //        //MethodInvoker предоставляет простой делегат, который используется для вызова метода с пустым списком параметров.
            //         chart1.Invoke((MethodInvoker)delegate { UpdateChart(); });

            //    }
            //    else
            //    {
            //        //....
            //    }
            //    Thread.Sleep(200);
            //}

        }

        public void WhileArr(int min, int max) {
            Random rnd = new Random();
            while (true)
            {

                chart1Array[chart1Array.Length - 1] = rnd.Next(min, max);
                Array.Copy(chart1Array, 1, chart1Array, 0, chart1Array.Length - 1);
                // IsHandleCreated Получает значение, указывающее, имеет ли элемент управления связанный с ним дескриптор.
                //делегаты - это указатели на методы и с помощью делегатов мы можем вызвать данные методы.
                // if (!chart1.IsHandleCreated || chart1.IsDisposed) return;
                if (chart1.IsHandleCreated)
                {
                    // Invoke Выполняет указанный делегат в потоке, которому принадлежит базовый дескриптор окна элемента управления.
                    //делегат представляет собой структуру данных, которая ссылается на статический метод.
                    //MethodInvoker предоставляет простой делегат, который используется для вызова метода с пустым списком параметров.
                    chart1.Invoke((MethodInvoker)delegate { UpdateChart(); });

                }
                else
                {
                    //....
                }
                Thread.Sleep(50);
            }
        }
        private void UpdateChart()
        {
            chart1.ChartAreas[0].AxisY.Minimum = min;
            chart1.ChartAreas[0].AxisY.Maximum = max;
            // chart1.ChartAreas[0].AxisY.Interval = 5;

            chart1.Series[_series].Points.Clear();
            for (int i = 0; i < chart1Array.Length - 1; ++i)
            {
                chart1.Series[_series].Points.AddY(chart1Array[i]);
            }
        }

        //private void getRandom2()
        //{
        //    // Thread.Sleep(500);
        //    k = 1;
        //    j = 0;

        //    Random rnd2 = new Random();
        //    max1 = arrayy[k, j];
        //    j++;
        //    min1 = arrayy[k, j];
        //    j++;
        //    number = arrayy[k, j];

        //    switch (number)
        //    {
        //        case 0:
        //            chart2 = pressureChart;
        //            _series2 = "PressureS";
        //            break;
        //        case 1:
        //            chart2 = temperatureChart;
        //            _series2 = "TemperatureS";
        //            break;
        //        case 2:
        //            chart2 = pulseChart;
        //            _series2 = "PulseS";
        //            break;
        //        case 3:
        //            chart2 = wetСhart;
        //            _series2 = "WetS";
        //            break;
        //        case 4:
        //            chart2 = electroСhart;
        //            _series2 = "ElectoS";
        //            break;
        //    }

        //    while (true)
        //    {

        //        chart2Array[chart2Array.Length - 1] = rnd2.Next(min1, max1);
        //        Array.Copy(chart2Array, 1, chart2Array, 0, chart2Array.Length - 1);

        //        if (chart2.IsHandleCreated)
        //        {
        //            // Invoke Выполняет указанный делегат в потоке, которому принадлежит базовый дескриптор окна элемента управления.
        //            //делегат представляет собой структуру данных, которая ссылается на статический метод.
        //            this.Invoke((MethodInvoker)delegate { UpdateChart2(); });

        //        }
        //        else
        //        {
        //            //....
        //        }
        //        Thread.Sleep(200);
        //    }

        //}
        //private void UpdateChart2()
        //{

        //    chart2.ChartAreas[0].AxisY.Minimum = min1;
        //    chart2.ChartAreas[0].AxisY.Maximum = max1;
        //    // chart1.ChartAreas[0].AxisY.Interval = 5;

        //    chart2.Series[_series2].Points.Clear();
        //    for (int i = 0; i < chart1Array.Length - 1; ++i)
        //    {
        //        chart2.Series[_series2].Points.AddY(chart2Array[i]);
        //    }
        //}

        //private void getRandom3()
        //{
        //    // Thread.Sleep(700);
        //    k = 2;
        //    j = 0;

        //    Random rnd3 = new Random();
        //    max2 = arrayy[k, j];
        //    j++;
        //    min2 = arrayy[k, j];
        //    j++;
        //    number = arrayy[k, j];
        //    switch (number)
        //    {
        //        case 0:
        //            chart2 = pressureChart;
        //            _series2 = "PressureS";
        //            break;
        //        case 1:
        //            chart2 = temperatureChart;
        //            _series2 = "TemperatureS";
        //            break;
        //        case 2:
        //            chart2 = pulseChart;
        //            _series2 = "PulseS";
        //            break;
        //        case 3:
        //            chart2 = wetСhart;
        //            _series2 = "WetS";
        //            break;
        //        case 4:
        //            chart2 = electroСhart;
        //            _series2 = "ElectoS";
        //            break;
        //    }

        //    while (true)
        //    {

        //        chart3Array[chart3Array.Length - 1] = rnd3.Next(min2, max2);
        //        Array.Copy(chart3Array, 1, chart3Array, 0, chart3Array.Length - 1);

        //        if (chart3.IsHandleCreated)
        //        {
        //            // Invoke Выполняет указанный делегат в потоке, которому принадлежит базовый дескриптор окна элемента управления.
        //            //делегат представляет собой структуру данных, которая ссылается на статический метод.
        //            this.Invoke((MethodInvoker)delegate { UpdateChart3(); });

        //        }
        //        else
        //        {
        //            //....
        //        }
        //        Thread.Sleep(200);
        //    }

        //}
        //private void UpdateChart3()
        //{
        //    chart3.ChartAreas[0].AxisY.Minimum = min2;
        //    chart3.ChartAreas[0].AxisY.Maximum = max2;
        //    // chart1.ChartAreas[0].AxisY.Interval = 5;

        //    chart3.Series[_series3].Points.Clear();
        //    for (int i = 0; i < chart3Array.Length - 1; ++i)
        //    {
        //        chart3.Series[_series3].Points.AddY(chart3Array[i]);
        //    }
        //}
    }
}
