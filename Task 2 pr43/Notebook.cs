using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_pr43
{
    struct Notebook
    {
        public string model; //Модель
        public string manufacturer; //Производитель
        public double price; //Цена

        public Notebook(string model, string manufacturer, double price) //Конструткор
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Производитель: {manufacturer}");
            Console.WriteLine($"Цена: {price} руб.");
        }
    }
}
