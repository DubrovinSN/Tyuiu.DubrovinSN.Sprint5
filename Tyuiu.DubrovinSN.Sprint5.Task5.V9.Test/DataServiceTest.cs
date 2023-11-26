using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint5.Task5.V9.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint5.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoad()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
