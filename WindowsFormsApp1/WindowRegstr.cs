using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // класс для работы с файлами

namespace WindowsFormsApp1
{
    public partial class WindowRegstr : Form
    {
        public WindowRegstr()
        {
            InitializeComponent();
          
        }
      
        string writePath = @"listDataPatients.txt";
        string writePathfReport = @"Report.txt";
       
        private void registerButton_Click(object sender, EventArgs e)
        {
          
            try
            {
                //Конструкция using оформляет блок кода и создает объект некоторого класса, который реализует интерфейс IDisposable, в частности, его метод Dispose. 
                //При завершении блока кода у объекта вызывается метод Dispose.
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(namesTextBox.Text+" " + ageTextBox.Text+" " + genderTextBox.Text);
                    
                }
                // false указывает на перезаписывание файла
                using (StreamWriter sww = new StreamWriter(writePathfReport, false, System.Text.Encoding.Default))
                {
                    sww.WriteLine("Patient: " + namesTextBox.Text + " " + ageTextBox.Text + " " + genderTextBox.Text);

                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
       
            // заполнение строки
             dataGridView1.Rows.Add(namesTextBox.Text, ageTextBox.Text, genderTextBox.Text);
            //обновляем таблицу
            dataGridView1.Refresh();
            namesTextBox.Clear();
            ageTextBox.Clear();
            genderTextBox.Clear();

        }

        private void WindowRegstr_Load(object sender, EventArgs e)
        {
            
            foreach (var line in File.ReadLines("listDataPatients.txt"))
            {
                var array = line.Split();
                dataGridView1.Rows.Add(array);
            }
            dataGridView1.Refresh();
            
        }

        private void ViewReportButton_Click(object sender, EventArgs e)
        {
           // OpenFileDialog openFileDialog1 = new OpenFileDialog();
            try
            {
                MessageBox.Show(File.ReadAllText(writePathfReport, System.Text.Encoding.Default));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }
    }
}
