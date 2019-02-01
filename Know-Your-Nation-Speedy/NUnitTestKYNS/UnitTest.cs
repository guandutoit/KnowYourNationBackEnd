using Know_Your_Nation_Speedy;
using Know_Your_Nation_Speedy.Controllers;
using Know_Your_Nation_Speedy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Net.Http;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    public class Tests
    {
        private DbController dbController;
       private readonly MyDbContext _db;
       private readonly IConfiguration _config;
        Entry entry;

        [SetUp]
        public void Setup()
        {
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


            [TestCase(2)]
            public void NumberOfEntries(int input)
            {
                var options = new DbContextOptionsBuilder<MyDbContext>().UseInMemoryDatabase(databaseName: "ereader").Options;
                var _db = new MyDbContext(options);
                Seed(_db);
                var query = new GetEntriesQuery(_db);
                var result = query.Execute();

            // Act

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(input, result.Count);
            }



            //----------------------------------------Database tests-------------------------------------

            [TestCase("string")]
            public void MockTest(string email)
            {
                DbController Obj = new DbController();

                Mock<DbController> chk = new Mock<DbController>();
                chk.Setup(x => x.DoesEmailExist(Obj, email)).Returns(true);


                NUnit.Framework.Assert.AreEqual(Obj.InsertEmail(chk.Object), true);
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