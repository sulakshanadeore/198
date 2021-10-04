using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static Method Classes can be called  directly

            //Output Directory---- :Project
            //             \\, /,@ +\
            //File.Create(@"D:\Sulakshana\198-Mphasis\abc.txt");
            //string s = @"D:\Sulakshana\198-Mphasis\xyz.txt";
            ////string d = @"D:\Sulakshana\198-Mphasis\C#\abc.txt";
            //////File.Copy(s, d);
            //File.Exists
            ////File.Delete(s);
            ////File.Move(d, s);
            ////File.WriteAllText(s, "Hello");
            //string[] s1 = new string[3] {"Hello  ", "welcome" , "Hwo r  u" };
            //File.WriteAllLines(s, s1);


            Directory.CreateDirectory("NEWDIR");
            bool ans=Directory.Exists("NEWDR");
            Console.WriteLine(ans);
            string[] a=Directory.GetDirectories(@"D:\Sulakshana\198-Mphasis\C#\FileHandlingDemo\FileHandlingDemo");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            //Directory.Move
            Console.WriteLine("Directory name");
            FileInfo fileInfo = new FileInfo("abc.txt");
            string dirname=fileInfo.DirectoryName;
            Console.WriteLine(dirname);
            DirectoryInfo dirinfo = new DirectoryInfo(@"D:\Sulakshana\198-Mphasis\C#\FileHandlingDemo\FileHandlingDemo");
            Console.WriteLine("IEnumerable");
            IEnumerable<DirectoryInfo> dinfo=dirinfo.EnumerateDirectories();
            foreach (var item in dinfo)
            {
                Console.WriteLine(item.Name);
            }
            DriveInfo drinfo = new DriveInfo("D");
            Console.WriteLine("Name="+drinfo.Name);
            Console.WriteLine("Root =" + drinfo.RootDirectory);
            Console.WriteLine("Total Size= " + drinfo.TotalSize);
            Console.WriteLine("Free size" + drinfo.TotalFreeSpace);
            Console.WriteLine("Label " + drinfo.VolumeLabel);
            Console.WriteLine("Type "+ drinfo.DriveType);
            Console.WriteLine("Available Free space= " +drinfo.AvailableFreeSpace);
            Console.WriteLine("Drive Format" + drinfo.DriveFormat);
            Console.Read();
           

        }
    }
}
