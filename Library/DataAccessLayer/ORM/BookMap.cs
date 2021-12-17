// <copyright file="BookMap.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using Library.Core;

    /// <summary>
    /// Mapping на <see cref="Book"/>.
    /// </summary>
    public class BookMap : ClassMap<Book>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BookMap"/>.
        /// </summary>
        public BookMap()
        {
            this.Table("Book");

            this.Id(x => x.Id);

            this.Map(x => x.Title)
                .Not.Nullable()
                .Length(50);

            this.HasManyToMany(x => x.Authors)
                .Cascade.Delete()
                .Inverse();

            this.References(x => x.Shelf);
        }
    }
}
