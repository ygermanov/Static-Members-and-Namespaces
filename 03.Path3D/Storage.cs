using System;
using System.Collections.Generic;
using System.IO;

namespace _03.Path3D
{
    class Storage
    {
        public static List<string> FillFromFile(string userFilePath)
        {
            List<string> temp = new List<string>();
            string stringLine;
            using (StreamReader readFromTxt = new StreamReader(userFilePath))
            {
                while ((stringLine = readFromTxt.ReadLine()) != null)
                {
                    temp.Add(stringLine);
                }
            }
            return temp;

            /*
             * StreamReader readFromTxt = new StreamReader(userFilePath)
             * string stringLine = string.Empty;
             * while ((stringLine = readFromTxt.ReadLine()) != null)
                {
                    temp.Add(stringLine);
                }
             * readFromTxt.Close()
             */
        }
        public static void SaveToFile(string userFilePath, string point)
        {
            using (StreamWriter writeToFile = File.AppendText(userFilePath))
            {
                writeToFile.WriteLine("\n");
                writeToFile.Write(point);
            }
            /*StreamWriter writeToFile = new StreamWriter(userFilePath)
             * foreach (string v in points)
                {
                    writeToFile.WriteLine(v);
                }
             * writeToFile.Close();
             */
        }
    }
}
