namespace PeopleSearchApplication.Migrations
{
    using PeopleSearchApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearchApplication.Models.PeopleSearchApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PeopleSearchApplication.Models.PeopleSearchApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

        context.People.AddOrUpdate(new People[] {
        new People() { Id = 1, Name = "Robinson, Steve", StreetAddress="11 Main Street", City="Fond du Lac", State="Wisconsin", Zip="54935", Age=27, Interests="Sports, Hiking, Swimming", Image=" " },
        new People() { Id = 2, Name = "Smith, Sherry", StreetAddress="332 7th Street", City="Fond du Lac", State="Wisconsin", Zip="54935", Age=24, Interests="Video games, Hiking", Image=" "  },
        new People() { Id = 3, Name = "Rull, Haley", StreetAddress="454 Jackson Avenue", City="New York", State="New York", Zip="88929", Age=33, Interests="Sports, Traveling", Image=" "  },
        new People() { Id = 4, Name = "Burg, Peter", StreetAddress="89 Johnson Street", City="Miami", State="Florida", Zip="82800", Age=47, Interests="Swimming, Baseball", Image=" "  }
        });

        
        }
    }
}
