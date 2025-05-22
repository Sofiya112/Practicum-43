using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_pr_43
{
    struct Book
    {
        public string title;        // Название книги
        public string author;       // Ф.И.О. автора
        public int publicationYear; // Год издания
        public int pageCount;       // Количество страниц

        // Конструктор для инициализации полей
        public Book(string title, string author, int publicationYear, int pageCount)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.pageCount = pageCount;
        }

        // Метод для вывода информации о книге
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {title}");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Год издания: {publicationYear}");
            Console.WriteLine($"Количество страниц: {pageCount}");
            Console.WriteLine(); // Для разделения книг
        }
    }
}
