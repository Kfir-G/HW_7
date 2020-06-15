using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class Female:Person
    {
        //-----data fields----
        //protected string firstName;
        //protected string lastName;
        //protected string nameOfCity;
        protected int numOfKids;

        //----properties----
        public int NumOfKids { get => numOfKids; set => numOfKids = value; }

        //-----methods-----
        //constractors:
        public Female():base()
        {
            NumOfKids = 0; //default
        }
        public Female(string firstName, string lastName, string nameOfCity, int numOfKids) : base(firstName, lastName, nameOfCity)
        {
            if (numOfKids < 0)
                throw new ArgumentException("Number of kids could not be negative");
            NumOfKids = numOfKids;
        }
            //
        //prints:
        public override string ToString()
        {
            return base.ToString() + " (" + numOfKids+ ")";
        }
        public string GetFirstAndLast()
        {
            return firstName + " " + lastName;
        }
        public string GetFnLNameAndKids()
        {
            return GetFirstAndLast() + " (" + numOfKids+")";
        }
            //
    }
}
