// <copyright file="Book.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Library.Core
{
    using System;

    /// <summary>
    /// Книга.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Book"/>.
        /// </summary>
        /// <param name="id"> Идентификатор. </param>
        /// <param name="title"> Название. </param>
        /// <exception cref="ArgumentNullException">
        /// В случае если <paramref name="title"/> <see langword="null"/> или пустая строка <see cref="string.Empty"/>.
        /// </exception>
        public Book(int id, string title)
        {
            if (title == null || title.Trim().Length == 0)
            {
                throw new ArgumentNullException();
            }

            this.Id = id;
            this.Title = title;
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// Название книги.
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// Представление объекта книга в виде строки.
        /// </summary>
        /// <returns> Строковое представление книги. </returns>
        public override string ToString() => this.Title;
    }
}
