using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_3
{
    class Person
    {
        string first, last, email;
        DateTime dob;

        public Person(string F , string L , string e , DateTime d)
        {
            first = F;
            last = L;
            email = e;
            dob = d;
        }

        public Person(string F, string L, string e)
        {
            first = F;
            last = L;
            email = e;
           
        }

        public Person(string F, string L, DateTime d)
        {
            first = F;
            last = L;
            dob = d;
        }

        public void Adult()
        {
            int age;
            age = DateTime.Now.Year - dob.Year;

            if (age > 18)
            {
                Console.WriteLine("Adult");

            }
            else if (age < 18)
            {
                Console.WriteLine("minor");
            }

            else if (age == 18)
                  
            {
                if (DateTime.Now.Month - dob.Month < 0)
                    Console.WriteLine("Minor");

                if (DateTime.Now.Month - dob.Month > 0)
                    Console.WriteLine("Adult");

                if (DateTime.Now.Month - dob.Month == 0)
                {
                    if(DateTime.Now.Day - dob.Day == 0)
                        Console.WriteLine("Adult");

                    if (DateTime.Now.Day - dob.Day > 0)
                        Console.WriteLine("Adult");

                    if (DateTime.Now.Day - dob.Day < 0)
                        Console.WriteLine("Minor");

                }
            }

        }

        public void SunSign()
        {
            switch(dob.Month)
            {
                case 1: Console.WriteLine("SunSign : Aries");
                    break;

                case 2:
                    Console.WriteLine("SunSign : Taurus");
                    break;

                case 3:
                    Console.WriteLine("SunSign : Gemini");
                    break;

                case 4:
                    Console.WriteLine("SunSign : Cancer");
                    break;

                case 5:
                    Console.WriteLine("SunSign : Leo");
                    break;

                case 6:
                    Console.WriteLine("SunSign : Virgo");
                    break;

                case 7:
                    Console.WriteLine("SunSign : Libra");
                    break;

                case 8:
                    Console.WriteLine("SunSign : Scorpio");
                    break;

                case 9:
                    Console.WriteLine("SunSign : Sagittarius ");
                    break;

                case 10:
                    Console.WriteLine("SunSign : Capricorn");
                    break;

                case 11:
                    Console.WriteLine("SunSign : Aquarius");
                    break;

                case 12:
                    Console.WriteLine("SunSign : Pisces");
                    break;

            }
        }

        public void Birthday()
        {
            if (dob.Month == DateTime.Now.Month && dob.Day == DateTime.Now.Day)
                Console.WriteLine("It is your Birthday Today! Have a nice day!");

            else
                Console.WriteLine("It is not your Birthday Today! Have a nice day!");
        }

        public void Display()
        {
            Console.WriteLine("name: " + first + " " + last);
            Console.WriteLine("Email ID : " +email);
            Console.WriteLine("Date of Birth : " + dob);
        }


    }
}
