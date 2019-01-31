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
    public class Tests
    {
        private KYNSDemo kyns;
        private DbController dbController;
        private readonly MyDbContext _db;
        private readonly IConfiguration _config;

        [SetUp]
        public void Setup()
        {
            kyns = new KYNSDemo();
            dbController = new DbController(_db, _config);
        }

      
        [TestCase("Shakes", "Shakes")]
        public void Test(string name,string outcome)
        {
            //assign
            //act
            var result = kyns.SpeedysFriend(name);
            //assert
            Assert.AreEqual(result, outcome);
        }
        

        [TestCase]
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
        }

    }
    
}