// <copyright file="Book.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Library.Core
{
    using System;
    using System.Collections.Generic;

    using Extensions;

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
        /// <param name="authors"> Авторы книги. </param>
        public Book(int id, string title, params Author[] authors)
            : this(id, title, new HashSet<Author>(authors))
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Book"/>.
        /// </summary>
        /// <param name="id">
        /// Идентификатор.
        /// </param>
        /// <param name="title">
        /// Название.
        /// </param>
        /// <param name="authors">
        /// Авторы книги.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// В случае если <paramref name="title"/> – <see langword="null"/> или пустая строка <see cref="string.Empty"/>.
        /// </exception>
        public Book(int id, string title, ISet<Author> authors)
        {
            this.Id = id;
            this.Title = title.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(title));
            if (authors == null)
            {
                throw new ArgumentNullException(nameof(authors));
            }

            foreach (var author in authors)
            {
                this.Authors.Add(author);
                author.AddBook(this);
            }
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public virtual int Id { get; protected set; }

        /// <summary>
        /// Название книги.
        /// </summary>
        public virtual string Title { get; protected set; }

        /// <summary>
        /// Авторы книги.
        /// </summary>
        public virtual ISet<Author> Authors { get; protected set; } = new HashSet<Author>();

        /// <summary>
        /// Представление объекта книга в виде строки.
        /// </summary>
        /// <returns> Строковое представление книги. </returns>
        public override string ToString()
        {
            return $"{string.Join(", ", this.Authors)} {this.Title}".Trim();
        }
    }
}
