using System;
using FizzBuzzLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzTest
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void ProcessBulkSmallNumber()
        {
            FizzBuzz fb = new FizzBuzz();
            long start = 1;
            long end = 3;
            string ParmStr = "THREE";
            int ParmInt = 3;

            List<FizzBuzzArgs> pl = new List<FizzBuzzArgs>();

            pl.Add(new FizzBuzzArgs(ParmStr, ParmInt));
            
            string[] TestRet = fb.ProcessBulk(start, end, pl);

            long RetLength = (end - start) + 1;

            //Assert.AreEqual(RetLength, TestRet.LongLength, "Not all items were returned as expected!");

            Assert.AreEqual(TestRet[ParmInt - 1], ParmStr, "Returned Converted String was incorrect!");
            Assert.AreEqual(TestRet[Convert.ToInt32(start) - 1], start.ToString(), "Returned Start number was incorrect!");
            Assert.AreEqual(TestRet[Convert.ToInt32(start)], (start + 1).ToString(), "Returned Start + 1 number was incorrect!");
        }

        [TestMethod]
        public void ProcessNext()
        {            
            long start = 1;
            long end = 3;
            string ParmStr = "THREE";
            int ParmInt = 3;

            List<FizzBuzzArgs> pl = new List<FizzBuzzArgs>();

            pl.Add(new FizzBuzzArgs(ParmStr, ParmInt));

            FizzBuzz fb = new FizzBuzz(start,end,pl);

            string _retstr = fb.Next();
            Assert.AreEqual(_retstr, "1", "Returned Converted String was incorrect!");

            _retstr = fb.Next();
            Assert.AreEqual(_retstr, "2", "Returned Converted String was incorrect!");

            _retstr = fb.Next();
            Assert.AreEqual(_retstr, ParmStr, "Returned Converted String was incorrect!");

            _retstr = fb.Next();
            Assert.AreEqual(_retstr, null, "Returned Converted String was not null!");            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ProcessBulkVeryLargeNumberOutOfRange()
        {
            FizzBuzz fb = new FizzBuzz();
            long start = 1;
            long end = 100000001;
            string ParmStr = "THREE";
            int ParmInt = 3;

            List<FizzBuzzArgs> pl = new List<FizzBuzzArgs>();

            pl.Add(new FizzBuzzArgs(ParmStr, ParmInt));

            //List<string> TestRet = fb.ProcessBigFizzBuzzLong(start, end, pl);
            string[] TestRet = fb.ProcessBulk(start, end, pl);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ProcessNextVeryLargeNumberOutOfRange()
        {
            long start = 1;
            long end = 100000001;
            string ParmStr = "THREE";
            int ParmInt = 3;

            List<FizzBuzzArgs> pl = new List<FizzBuzzArgs>();

            pl.Add(new FizzBuzzArgs(ParmStr, ParmInt));

            FizzBuzz fb = new FizzBuzz(start, end, pl);

            string _retstr = string.Empty;
            for(long cnt = start; cnt<=end; cnt++)
                _retstr = fb.Next();

        }
    }
}
