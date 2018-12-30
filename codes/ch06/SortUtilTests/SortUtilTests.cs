using Microsoft.VisualStudio.TestTools.UnitTesting;
using ch06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace ch06.Tests
{
    [TestClass()]
    public class SortUtilTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            int[] array = { 10,23,1,33,100,23};
            int[] result = { 1, 10, 23, 23, 33, 100 };
            SortUtil.BubbleSort(array);
            CollectionAssert.Equals(result, array);

        }

        [TestMethod()]
        public void BubbleSortTest2()
        {
            int[] array = {};
            int[] result = {};
            SortUtil.BubbleSort(array);
            CollectionAssert.Equals(result, array);
        }

        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void BubbleSortTest3()
        {
            XmlSerializer z;
            int[] array =null;
            SortUtil.BubbleSort(array);
        }


    }
}