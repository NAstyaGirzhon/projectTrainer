using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Common;
namespace WindowsFormsApp1.Views
{
    interface IRegistrView: IView
    {
        //string Name { get; }
        //string Age { get; }
        //string Gender { get; }
        //возвращает путь к файлу
       string FilePath { get;}
       //
        string Content { get; set; }
        event EventHandler RegisterClick;
    }
}
