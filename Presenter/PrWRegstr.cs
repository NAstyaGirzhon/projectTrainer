using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Model;
namespace Presenter
{
    public class PrWRegstr
    {
        string writePath = @"listDataPatients.txt";
        string writePathfReport = @"Report.txt";
        public PrWRegstr() { }
        
        public void WritetoFile(PatientM patient ) {
             try
            {
                //Конструкция using оформляет блок кода и создает объект некоторого класса, который реализует интерфейс IDisposable, в частности, его метод Dispose. 
                //При завершении блока кода у объекта вызывается метод Dispose.
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(patient.Name +" " + patient.Age+" " + patient.Gender);
                    
                }
                // false указывает на перезаписывание файла
                using (StreamWriter sww = new StreamWriter(writePathfReport, false, System.Text.Encoding.Default))
                {
                    sww.WriteLine("Patient: " + patient.Name + "  Age: " + patient.Age + "  Gender: " + patient.Gender);
                    sww.WriteLine("Date of reception: " + patient.DateTime);

                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
    }
       
    }
}
