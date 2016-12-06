using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMover1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootFolderPath = @"D:\Documents\Folder A\";
            string destinationPath = "D:\\Documents\\Folder B\\";
            string txtFile = "*.txt";
            string[] sourceFileList = Directory.GetFiles(rootFolderPath, txtFile);

            //if (File.GetLastWriteTime(rootFolderPath) && )
            //{
                //asd
            
            foreach (var file in sourceFileList)
            {
                //string fileToMove = file;
                Console.WriteLine("Moving " + file);
                string moveTo = destinationPath;
                Console.WriteLine("New location " + moveTo);
                Console.Read();
                string combine = Path.Combine(moveTo, Path.GetFileName(file));
                Console.WriteLine("Combined path: " + combine);
                Console.Read();
                //string fileName = Path.GetFileName(file);
                //Console.WriteLine("Filename: " + fileName);
                //Console.Read();
                //moving file
                //Directory.Move(fileToMove, moveTo);
                File.Move(file, combine);
            }
            //}
        }
    }
}
