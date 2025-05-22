using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_pr_43
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ввод количества книг
            Console.Write("Введите количество книг: ");
            int n = int.Parse(Console.ReadLine());

            // Создание массива книг
            Book[] books = new Book[n];

            // Ввод информации о каждой книге
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВвод информации для книги #{i + 1}:");
                Console.Write("Введите название книги: ");
                string title = Console.ReadLine();

                Console.Write("Введите Ф.И.О. автора: ");
                string author = Console.ReadLine();

                Console.Write("Введите год издания: ");
                int publicationYear = int.Parse(Console.ReadLine());

                Console.Write("Введите количество страниц: ");
                int pageCount = int.Parse(Console.ReadLine());

                // Создание экземпляра книги и добавление в массив
                books[i] = new Book(title, author, publicationYear, pageCount);
            }

            // Вывод информации о всех книгах
            Console.WriteLine("\nИнформация о книгах:");
            for (int i = 0; i < n; i++)
            {
                books[i].DisplayInfo();
            }

            Console.ReadLine();

        }
    }
}
