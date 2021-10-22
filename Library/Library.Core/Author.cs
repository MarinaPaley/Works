// <copyright file="Author.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Library.Core
{
    using System;

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
        public Author(int id, string lastName, string fistName, string middleName = null)
        {
            this.Id = id;
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.FistName = fistName ?? throw new ArgumentNullException(nameof(fistName));
            this.MiddleName = middleName;
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
        /// Полное имя.
        /// </summary>
        public string FullName => $"{this.LastName} {this.FistName} {this.MiddleName}".Trim();

        /// <inheritdoc />
        public override string ToString() => this.FullName;
    }
}
