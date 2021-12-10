using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using Library.Core;
    class AuthorMap : ClassMap<Author>
    {
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
