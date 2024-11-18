using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicRecordREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRecordREST.Models.Tests
{
    [TestClass()]
    public class MusicRecordTests
    {
        [TestMethod()]
        public void ValidateYearTest()
        {
            MusicRecord record1 = new MusicRecord() { PublicationYear = 0 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record1.ValidateYear());

        } 
        
    }
}