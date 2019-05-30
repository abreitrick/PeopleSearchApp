using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearchApplication.Controllers;
using PeopleSearchApplication.Models;

namespace PeopleSearchApplication.Tests.Controllers
{
    [TestClass]
    public class PeopleControllerTest
    {
        PeopleSearchApplicationContext db;
        PeopleController controller;
        People stu, ashley;

        [TestInitialize]
        public void SetUp()
        {
            db = new PeopleSearchApplicationContext();
            controller = new PeopleController();
            stu = new People(20, "Stu", "Robinson", "344 9th Street", "Fond du Lac", "Wisconsin", "54935", 27, "Sports, Hiking, Swimming", null);
            ashley = new People(21, "Ashley", "Hill", "90 Franklin Court", "Detroit", "Michigan", "28398", 37, "Hiking, Basketball", null);
        }

        [TestMethod]
        public void Get()
        {
            // Arrange
            //controller = new PeopleController();

            // Act
            //IEnumerable<string> result = controller.Get();
            IQueryable<People> result = controller.GetPeople();

            // Assert
            Assert.IsNotNull(result);
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            //controller = new PeopleController();

            // Act
            //string result = controller.GetPeople(2).ToString();
            //var result = db.People

            // Assert
            //Assert.AreEqual("Sherry", result);
        }

        [TestMethod]
        public async Task PostAsync()
        {
            // Arrange
            
            //controller = new PeopleController();
      
            // Act
            await controller.PostPeople(stu);
           
            // Assert
            Assert.AreEqual("Stu", stu.FirstName);
            //Assert.AreEqual(9, db.People.Count());
        }

        //[TestMethod]
        //public void Put()
        //{
        //    // Arrange
        //    ValuesController controller = new ValuesController();

        //    // Act
        //    controller.Put(5, "value");

        //    // Assert
        //}

        //[TestMethod]
        //public void Delete()
        //{
        //    // Arrange
        //    ValuesController controller = new ValuesController();

        //    // Act
        //    controller.Delete(5);

        //    // Assert
        //}
    }
}
