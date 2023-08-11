using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public class Operations
    {
        public static void FileExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists");
            }
        }
        public static void ReadAllLines(string filePath) 
        {
            if(File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var data in lines)
                {
                    Console.WriteLine(data);
                }
            }
            else
            {
                Console.WriteLine("File doesnt exists");
            }
        }
        public static void ReadAllText(string filePath)
        {
            if (File.Exists(filePath))
            {
                string lines = File.ReadAllText(filePath);
                Console.WriteLine(lines);
            }
            else
            {
                Console.WriteLine("File doesnt exists");
            }
        }
        public static void CreateFile(string filePath)
        {
            File.Create(filePath);
        }
        public static void CopyFilePath(string existing, string copyFilePath)
        {
            File.Copy(existing, copyFilePath);
        }
        public static void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }
        public static void ReadFromStreamReader(string filePath)
        {
            using(StreamReader reader = File.OpenText(filePath)) 
            {
                string s = "";
                while((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteFromStreamWriter(string filePath)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine("Hello World! .NET is Awesome");
                writer.Close();
                ReadAllText(filePath);
            }
        }
    }
}
