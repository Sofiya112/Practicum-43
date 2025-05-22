using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_43
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено"; // Меняем значение поля
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено"; // Меняем значение поля
        }

        static void Main(string[] args)
        {
            // Создание экземпляра класса MyClass
            MyClass myClassInstance = new MyClass();
            myClassInstance.change = "не изменено"; 

            // Создание экземпляра структуры MyStruct
            MyStruct myStructInstance = new MyStruct();
            myStructInstance.change = "не изменено"; 

            
            Console.WriteLine("До изменений:");
            Console.WriteLine($"myClassInstance.change: {myClassInstance.change}");
            Console.WriteLine($"myStructInstance.change: {myStructInstance.change}");

            ClassTaker(myClassInstance); // Изменение поля в классе
            StruktTaker(myStructInstance); // Изменение поля в структуре

            // Выводим значения после изменений
            Console.WriteLine("\nПосле изменений:");
            Console.WriteLine($"myClassInstance.change: {myClassInstance.change}");
            Console.WriteLine($"myStructInstance.change: {myStructInstance.change}");

            Console.ReadLine();
        }
        
    }
}
