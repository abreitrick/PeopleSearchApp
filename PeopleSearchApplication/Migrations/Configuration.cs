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
            AutomaticMigrationsEnabled = true;
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
        new People() { Id = 1, FirstName = "Steve", LastName="Robinson", StreetAddress="11 Main Street", City="Fond du Lac", State="Wisconsin", Zip="54935", Age=27, Interests="Sports, Hiking, Swimming", Image=null},
        new People() { Id = 2, FirstName = "Sherry", LastName="Smith", StreetAddress="332 7th Street", City="Fond du Lac", State="Wisconsin", Zip="54935", Age=24, Interests="Video games, Hiking", Image=null},
        new People() { Id = 3, FirstName = "Haley", LastName="Rull", StreetAddress="454 Jackson Avenue", City="New York", State="New York", Zip="88929", Age=33, Interests="Sports, Traveling", Image=null},
        new People() { Id = 4, FirstName = "Peter", LastName="Burg", StreetAddress="89 Johnson Street", City="Miami", State="Florida", Zip="82800", Age=47, Interests="Swimming, Baseball", Image=null}
        });

        
        }
    }
}
