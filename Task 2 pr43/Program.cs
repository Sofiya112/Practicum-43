using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_pr43
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook myNotebook = new Notebook("ThinkPad X1", "Lenovo", 85000);

            // Вывод информации о ноутбуке
            myNotebook.DisplayInfo();

            Console.ReadLine();
        }
    }
}
