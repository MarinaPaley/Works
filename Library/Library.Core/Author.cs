// <copyright file="Author.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Library.Core
{
    using System;
    using System.Collections.Generic;

    using Extensions;

    /// <summary>
    /// Автор.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Author"/>.
        /// </summary>
        /// <param name="id"> Идентификатор. </param>
        /// <param name="lastName"> Фамилия. </param>
        /// <param name="fistName"> Имя. </param>
        /// <param name="middleName"> Отчество. </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// В случае если <paramref name="lastName"/> или <paramref name="fistName"/> – <see langword="null"/>
        /// или пустая строка (<see cref="string.Empty"/>).
        /// </exception>
        public Author(int id, string lastName, string fistName, string middleName = null)
        {
            this.Id = id;
            this.LastName = lastName.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(lastName));
            this.FistName = fistName.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(fistName));
            this.MiddleName = middleName.TrimOrNull();
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; protected set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string FistName { get; protected set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        public string MiddleName { get; protected set; }

        /// <summary>
        /// Коллекция книг.
        /// </summary>
        public ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        /// <summary>
        /// Добавление книги автору.
        /// </summary>
        /// <param name="book"> Книга. </param>
        /// <returns> <see langword="true"/> в случае успешного добавления. </returns>
        public bool AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            return this.Books.Add(book);
        }

        /// <summary>
        /// Полное имя.
        /// </summary>
        public string FullName => $"{this.LastName} {this.FistName} {this.MiddleName}".Trim();
        
        /// <inheritdoc />
        public override string ToString() => this.FullName;
    }
}
