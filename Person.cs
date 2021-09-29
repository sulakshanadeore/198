using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MphasisMathsLibrary
{
  public class Person
    {

        private int _personid;
        //Accept value-- constructor
        //    Print value--Method
        //Smart method--- property-- read/write feature
        public int PersonId
        {
            get { return _personid; }//return the value & printing it
            set
            {
                _personid= value; 
            if(_personid<0)
                {

                    Console.WriteLine("not a valid person id");
                }
            
            }//assign the value to the variable to process 
        
        }

        private string _personname;
        public string PersonName
        {
            get { return _personname; }
            set { _personname = value; }
        
        }


        private DateTime _birthdate;
        public DateTime BirthDate
        {
            //read/write properties
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        private int _age;
        public int Age
        {
            //Read only property
            get {
                _age = DateTime.Now.Year - _birthdate.Year;
                return _age;
            }
        }

        private string _password;
        public string SetYourPassword
        {
            //Write password --variable _password, write only prop
            set
            {
                if (value.Length > 0)
                {
                    Console.WriteLine("Password is assigned");
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password length must be greater than zero");
                }
            }
        }
                
                
            

            public void ShowPersonDetails()
        {
            Console.WriteLine(PersonId);
            Console.WriteLine(PersonName);
            Console.WriteLine(Age);
            Console.WriteLine(BirthDate);
            Console.WriteLine("Password is not shown for security reason");
        }
        
    }
}
