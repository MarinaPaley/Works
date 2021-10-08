using System;

namespace Demo
{
    /// <summary>
    /// Исполняемый файл.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            var book = new Library.Core.Book(1, "Сказки");
            var author = new Library.Core.Author();

            Console.WriteLine(book);
            Console.WriteLine(author);
        }
    }
}
