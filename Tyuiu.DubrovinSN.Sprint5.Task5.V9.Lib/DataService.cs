using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Linq;

namespace Tyuiu.DubrovinSN.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {   
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double minNumber = -1000;
                    double number = Convert.ToDouble(line);
                    if (number % 1 == 0)
                    {
                        res = Math.Max(number, minNumber);
                    }
                }
            }
            return res;
        }
    }
}
