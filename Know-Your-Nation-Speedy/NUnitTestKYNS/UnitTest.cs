using Know_Your_Nation_Speedy;
using Know_Your_Nation_Speedy.Controllers;
using Know_Your_Nation_Speedy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Net.Http;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    //[TestClass]
    public class Tests {
        private KYNSDemo kyns;
        private DbController dbController;
        private readonly MyDbContext _db;
        private readonly IConfiguration _config;
        Entry entry;

        [SetUp]
        public void Setup()
        {
            kyns = new KYNSDemo();
            dbController = new DbController(_db, _config);
            entry = new Entry();
        }


        [TestCase(6, 6)]
        public void IdTest(int id, int outcome)
        {

            int myId = entry.Id = id;


            NUnit.Framework.Assert.AreEqual(myId, outcome);
        }

        [TestCase("", "dell")]
        public void NameTest(string _name, string outcome)
        {
            string myName = entry.Name = _name;
            NUnit.Framework.Assert.AreEqual(myName, outcome);
        }


        public void EmailTest(string _email, string outcome)
        {
            string myEmail = entry.Email = _email;
            NUnit.Framework.Assert.AreEqual(myEmail, outcome);
        }






        //----------------------------------------Database tests-------------------------------------

        [TestCase("string")]
        public void MockTest(string email) {
            DbController Obj = new DbController();

            Mock<DbController> chk = new Mock<DbController>();
            chk.Setup(x => x.DoesEmailExist(Obj,email)).Returns(true);


            NUnit.Framework.Assert.AreEqual(Obj.InsertEmail(chk.Object), true);
        }



        [TestCase("Shakes", "Shakes")]
        public void Test(string name,string outcome)
        {
            //assign
            //act
            var result = kyns.SpeedysFriend(name);
            //assert
            NUnit.Framework.Assert.AreEqual(result, outcome);
        }
        

        /*[TestCase]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Entry testItem = new Entry()
            {
                Name = "Guinness Original 6 Pack",
                Email = "email.co.za",
                Password = "1234"
            };

            // Act
            System.Threading.Tasks.Task createdResponse =  dbController.Post(testItem);
           

            // Assert
            Assert.IsInstanceOf<CreatedAtActionResult>(createdResponse);
        }*/

    }
    
}