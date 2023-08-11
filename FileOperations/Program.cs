using System;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\BridgeLabs Training\FileOperations\FileOperations\Sample.txt";
            string createFilePath = @"D:\BridgeLabs Training\FileOperations\FileOperations\Create.txt";
            string copyFilePath = @"D:\BridgeLabs Training\FileOperations\FileOperations\Copy.txt";
            Operations.FileExists(filePath);
            Operations.ReadAllLines(filePath);
            Operations.ReadAllText(filePath);
            Operations.CreateFile(createFilePath);
            Operations.CopyFilePath(filePath, copyFilePath);
            Operations.DeleteFile(copyFilePath);
            Operations.ReadFromStreamReader(filePath);
            Operations.WriteFromStreamWriter(filePath);
        }
    }
}