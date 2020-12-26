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
using Presenter;
using Model;
namespace WindowsFormsApp1
{
    public partial class WindowRegstr : Form
    {
        public WindowRegstr()
        {
            InitializeComponent();
          
        }

        //string writePath = @"listDataPatients.txt";
        string writePathfReport = @"Report.txt";

        private void registerButton_Click(object sender, EventArgs e)
        {

            var PM = new PatientM {
                Name = namesTextBox.Text,
                Gender = genderTextBox.Text,
                Age = ageTextBox.Text
            };
            var PReg = new PrWRegstr();
            PReg.WritetoFile(PM);


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
