// <copyright file="AuthorMap.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using Library.Core;

    /// <summary>
    /// Mapping на <see cref="Author"/>.
    /// </summary>
    public class AuthorMap : ClassMap<Author>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AuthorMap"/>.
        /// </summary>
        public AuthorMap()
        {
            this.Table("Author");

            this.Id(x => x.Id);

            this.Map(x => x.FistName)
                .Not.Nullable().Length(50);

            this.Map(x => x.LastName)
                .Not.Nullable().Length(50);

            this.Map(x => x.MiddleName)
                .Length(50);

            this.HasManyToMany(x => x.Books)
                .Cascade.Delete();
        }
    }
}
