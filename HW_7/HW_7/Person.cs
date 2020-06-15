using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class Person
    {
        //-----data fields----
        protected string firstName;
        protected string lastName;
        protected string nameOfCity;

        //----properties----
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string NameOfCity { get => nameOfCity; set => nameOfCity = value; }

        //----methods---
        //constractor:
        public Person()
        {
            FirstName = "Not named yet";
            LastName = "Not named yet";
            NameOfCity = "Not named yet";
        }
        public Person (string firstName, string lastName, string nameOfCity)
        {
            if (firstName == String.Empty || lastName == String.Empty || nameOfCity == String.Empty)
                throw new ArgumentNullException("You didn't put a name");

            foreach( char c in firstName)
            {
                if (c >= '0' && c <= '9')
                    throw new ArgumentException("You put a number in the name");
            }
            FirstName = firstName;

            foreach (char c in lastName)
            {
                if (c >= '0' && c <= '9')
                    throw new ArgumentException("You put a number in the name");
            }
            LastName = lastName;

            foreach (char c in nameOfCity)
            {
                if (c >= '0' && c <= '9')
                    throw new ArgumentException("You put a number in the name");
            }
            NameOfCity = nameOfCity;
        }
        //
        public override string ToString()
        {
            return  firstName+ " "+lastName+" "+nameOfCity;
        }
    }
}
