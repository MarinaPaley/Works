// <copyright file="Shelf.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Library.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Extensions;
    using Staff.Extensions;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Shelf"/>.
    /// </summary>
    public class Shelf
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Shelf"/>.
        /// </summary>
        /// <param name="id"> Идентификатор. </param>
        /// <param name="shelf"> Полка. </param>
        public Shelf(int id, string shelf)
        {
            this.Id = id;
            this.Name = shelf.TrimOrNull()
                ?? throw new ArgumentOutOfRangeException(nameof(shelf));
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Shelf"/>.
        /// </summary>
        [Obsolete("For ORM only")]
        protected Shelf()
        {
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public virtual int Id { get; protected set; }

        /// <summary>
        /// Полка.
        /// </summary>
        public virtual string Name { get; protected set; }

        /// <summary>
        /// Книги на полке.
        /// </summary>
        public virtual ISet<Book> Books { get; protected set; }
            = new HashSet<Book>();

        /// <inheritdoc/>
        public override string ToString()
        {
            var separator = $"{Environment.NewLine}\t";
            return $"{this.Name}:{separator}{this.Books.Join(separator)}".Trim();
        }
    }
}
