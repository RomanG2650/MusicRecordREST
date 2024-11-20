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
            MusicRecordRepositoryList recordsRepositoryList = new MusicRecordRepositoryList();

           var list = recordsRepositoryList.GetAll();

            Assert.AreEqual(7, list.Count);



        }
    }
}