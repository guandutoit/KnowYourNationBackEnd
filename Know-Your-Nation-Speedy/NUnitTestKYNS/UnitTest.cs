using Know_Your_Nation_Speedy;
using Know_Your_Nation_Speedy.Controllers;
using Know_Your_Nation_Speedy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Net.Http;

namespace Tests
{
    public class Tests{
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


        [TestCase(6,6)]
    public void IdTest(int id,int outcome)
    {

   int myId =  entry.Id = id;


    Assert.AreEqual(myId, outcome );
    }

    [TestCase("", "dell")]
    public void NameTest(string _name, string outcome)
    {
        string myName = entry.Name = _name;
        Assert.AreEqual(myName, outcome);
    }

        public void EmailTest(string _email, string outcome)
        {
            string myEmail = entry.Email = _email;
            Assert.AreEqual(myEmail, outcome);
        }






        //----------------------------------------Database tests-------------------------------------






        [TestCase("Shakes", "Shakes")]
        public void Test(string name,string outcome)
        {
            //assign
            //act
            var result = kyns.SpeedysFriend(name);
            //assert
            Assert.AreEqual(result, outcome);
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