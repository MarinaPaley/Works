// <copyright file="ShelfMap.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using Library.Core;

    /// <summary>
    /// Mapping на <see cref="Shelf"/>.
    /// </summary>
    public class ShelfMap : ClassMap<Shelf>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ShelfMap"/>.
        /// </summary>
        public ShelfMap()
        {
            this.Table("Shelf");

            this.Id(x => x.Id);

            this.Map(x => x.Name)
                .Not.Nullable()
                .Length(50);

            this.HasMany(x => x.Books)
                .Not.Inverse()
                .Cascade.Delete();
        }
    }
}
