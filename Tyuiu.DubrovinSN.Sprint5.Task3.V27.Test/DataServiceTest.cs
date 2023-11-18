using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint5.Task3.V27.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint5.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedFile()
        {
            string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint5\Tyuiu.DubrovinSN.Sprint5.Task3.V27\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

        }
    }
}
