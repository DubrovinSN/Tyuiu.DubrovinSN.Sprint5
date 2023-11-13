using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DubrovinSN.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if(fileExists)
            {
                File.Delete(path);
            }
            double f;
            string strF;
            for(int x = startValue; x <= stopValue; x++)
            {
                f = Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x,2);
                strF = Convert.ToString(f);

                if(x != stopValue)
                {
                    File.AppendAllText(path, strF + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strF);
                }
            }
            return path;
        }
    }
}
