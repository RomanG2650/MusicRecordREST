using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicRecordREST.Controllers;
using MusicRecordREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRecordREST.Controllers.Tests
{
    [TestClass()]
    public class MusicRecordsControllerTests
    {
        [TestMethod()]  
        public void GetTest()
        {
            //Arrange
            MusicRecordRepositoryList recordsRepositoryList = new MusicRecordRepositoryList();
            //Act
            var list = recordsRepositoryList.GetAll();
            //Assert
            Assert.AreEqual(7, list.Count);



        }
    }
}