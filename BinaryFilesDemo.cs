using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingDemo
{
    class BinaryFilesDemo
    {
        static void FileCreate()
        {
            //creation--filename, fileaccess--Read/Write/ReadWrite,filemode--create,open,truncate etc
            Console.WriteLine("Enter file name");
            string fname = Console.ReadLine();


            FileStream fs = new FileStream(fname, FileMode.Create, FileAccess.Write);

            //Writing--- writer & Reading---reader
            //TextWriter--- abstract class
            //constructor
            BinaryWriter sw = new BinaryWriter(fs);
            Console.WriteLine("Enter the contents of file");
            string c = Console.ReadLine();

            sw.Write(c);
            sw.Close();//completed writing
            fs.Close();//saving the file
            sw.Dispose();//remove the object from the heap and manage memory--destructor
            fs.Dispose();
        }


        static void ReadFile()
        {
            Console.WriteLine("Enter file name");
            string fname = Console.ReadLine();

            FileStream fs = new FileStream(fname,FileMode.Open, FileAccess.Read);
            BinaryReader sr = new BinaryReader(fs);
            int filecontents = sr.ReadInt32();
            Console.WriteLine(filecontents);


            sr.Close();
            sr.Dispose();
            fs.Close();
            fs.Dispose();

        }


        static void Main(string[] args)
        {
            Console.WriteLine(" 1. Create \n 2. Read \n 3. Append \n 4. Delete \n 5. Exit");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    FileCreate();
                    break;
                case 2:
                    ReadFile();
                    break;
                case 3:
                    //AppendToFile();
                    break;
                case 4:
                    //File.Delete("demo1.txt");
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }

            Console.Read();

        }
    }
}
