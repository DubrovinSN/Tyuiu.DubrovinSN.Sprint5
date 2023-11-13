using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint5.Task1.V3.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint5.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint5\Tyuiu.DubrovinSN.Sprint5.Task1.V3\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
