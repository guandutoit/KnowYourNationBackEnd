using Know_Your_Nation_Speedy;
using Know_Your_Nation_Speedy.Controllers;
using Know_Your_Nation_Speedy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Net.Http;

namespace Tests
{
    public class Tests
    {
       private DbController dbController;
       private readonly MyDbContext _db;
       private readonly IConfiguration _config;

        [SetUp]
        public void Setup()
        {
            dbController = new DbController(_db, _config);
        }

      
        [TestCase(2)]
        public void NumberOfEntries(int input)
        {

            // Arrange
            var options = new DbContextOptionsBuilder<MyDbContext>().UseInMemoryDatabase(databaseName:"ereader").Options;
            var _db = new MyDbContext(options);
             Seed(_db);
            var query = new GetEntriesQuery(_db);
            var result = query.Execute();

            // Act
           
            // Assert
            Assert.AreEqual(input,result.Count);
        }

        private void Seed(MyDbContext _db)
        {
            var entries = new[]
            {
                new Entry{ Name="Mpilo Mshengu",Email="mpilo@gmail.com",Password="1234"},
                new Entry{ Name="Linda",Email="Linda@gmail.com",Password="4321"},
                new Entry{ Name="Buhle",Email="Buhle@gmail.com",Password="4321"}
            };
            _db.Entries.AddRange(entries);
            _db.SaveChanges();

        }

   
    }
    
}