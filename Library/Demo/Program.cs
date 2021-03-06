// <copyright file="Program.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Demo
{
    using System;
    using DataAccessLayer;
    using DataAccessLayer.ORM;
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
            var shelf = new Shelf(1, "Полка 1");
            book.AddBookToShelf(shelf);

            Console.WriteLine(book);
            Console.WriteLine(author);
            Console.WriteLine(shelf);

            var settings = new Settings();

            settings.AddDatabaseServer(@"LAPTOP-2ALR8J1J\SQLEXPRESS");

            settings.AddDatabaseName("LibraryUIS");

            using var sessionFactory = FluentNHibernateConfigurator
                .GetSessionFactory(settings, showSql: true);

            using (var session = sessionFactory.OpenSession())
            {
                session.Save(author);
                session.Save(shelf);
                session.Save(book);
                session.Flush();
            }
        }
    }
}
