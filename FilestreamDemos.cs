using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingDemo
{
    class FilestreamDemos
    {
        static void FileCreate()
        {
            //creation--filename, fileaccess--Read/Write/ReadWrite,filemode--create,open,truncate etc
            Console.WriteLine("Enter file name");
            string fname = Console.ReadLine();
               

            FileStream fs = new FileStream(fname,FileMode.Create, FileAccess.Write);

            //Writing--- writer & Reading---reader
            //TextWriter--- abstract class
            //constructor
            StreamWriter sw = new StreamWriter(fs);//Pen
            Console.WriteLine("Enter the contents of file");
            string c = Console.ReadLine();

            sw.WriteLine(c);
            sw.Close();//completed writing
            fs.Close();//saving the file
            sw.Dispose();//remove the object from the heap and manage memory--destructor
            fs.Dispose();
        }

        static void ReadFile()
        {

            FileStream fs = new FileStream("demo1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string filecontents = sr.ReadToEnd();
            Console.WriteLine(filecontents);


            sr.Close();
            sr.Dispose();
            fs.Close();
            fs.Dispose();

        }

        static void AppendToFile()
        {

            FileStream fs = new FileStream("demo1.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write("Some amore appended contnet..12345666676 76868");



            sw.Close();
            sw.Dispose();
            fs.Close();
            fs.Dispose();
        }
        static void Main(string[] args)
        {
            
            //ReadFile();
            //AppendToFile();


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
                    AppendToFile();
                    break;
                case 4:
                    File.Delete("demo1.txt");
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
