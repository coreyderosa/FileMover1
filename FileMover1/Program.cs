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
        static void FileMover()
        {
            string rootFolderPath = "D:\\Documents\\Folder A\\";
            string destinationPath = "D:\\Documents\\Folder B\\";
            string txtFile = "*.txt";
            string[] sourceFileList = Directory.GetFiles(rootFolderPath, txtFile);

            //if (File.GetLastWriteTime(rootFolderPath) && )
            //{
            //asd

            foreach (var file in sourceFileList)
            {
                DateTime dt = File.GetLastWriteTime(file); //gets file's most recent modified time
                Console.WriteLine(file + " modified time: " + dt);
                Console.Read();
                Console.WriteLine("Moving " + file);
                string moveTo = destinationPath;
                Console.WriteLine("New location " + moveTo);
                Console.Read();
                string combine = Path.Combine(moveTo, Path.GetFileName(file)); //combines the dest folder and source file name
                Console.WriteLine("Combined path: " + combine);
                Console.Read();

                if (Math.Abs((File.GetLastWriteTime(file) - DateTime.Today.Date).TotalHours) < 24)
                {
                    File.Move(file, combine);
                }
            }
            //}
        }

        static void Main(string[] args)
        {
            FileMover();
        }
    }
}
