using System;

namespace Library.Core
{/// <summary>
/// Книга.
/// </summary>
    public class Book
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="id"></param> идентификатор
        /// <param name="title"></param> название
        public Book(int id, string title)
        {
            if (title == null || title.Trim().Length == 0)
                throw new ArgumentNullException();

            Id = id;
            Title = title;

        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; protected set;}

        /// <summary>
        /// Название книги.
        /// </summary>
        public string Title { get; protected set;}

        /// <summary>
        /// Представление объекта книга в виде строки.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Title;
    }
}
