using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint5.Task0.V26.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint5.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedFile()
        {
            string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint5\Tyuiu.DubrovinSN.Sprint5.Task0.V26\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
