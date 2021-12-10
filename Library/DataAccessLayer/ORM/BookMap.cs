namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using Library.Core;
    public class BookMap : ClassMap<Book>
    {
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
        }
    }
}
