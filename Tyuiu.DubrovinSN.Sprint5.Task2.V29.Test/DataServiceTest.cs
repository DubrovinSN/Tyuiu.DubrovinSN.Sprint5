using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint5.Task2.V29.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveFile()
        {
            string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint5\Tyuiu.DubrovinSN.Sprint5.Task2.V29\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
