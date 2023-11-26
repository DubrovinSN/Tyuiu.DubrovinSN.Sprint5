using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint5.Task6.V17.Lib;
using System.IO;


namespace Tyuiu.DubrovinSN.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void  CheckedFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
