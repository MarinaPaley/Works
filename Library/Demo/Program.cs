// <copyright file="Program.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Demo
{
    using System;
    using Library.Core;

    /// <summary>
    /// Исполняемый файл.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        private static void Main()
        {
            var author = new Author(1, "Пушкин", "Александр", "Сергеевич");
            var book = new Book(1, "Сказки", author);

            Console.WriteLine(book);
            Console.WriteLine(author);
        }
    }
}
