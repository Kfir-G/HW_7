using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class Male: Person
    {
        //-----data fields----
        //protected string firstName;
        //protected string lastName;
        // protected string nameOfCity;
        protected int distanceFromWork;

        //----properties---
        public int DistanceFromWork { get => distanceFromWork; set => distanceFromWork = value; }

        //----methods----
        //constrators:
        public Male():base()
        {
            DistanceFromWork = 0; //default
        }
        public Male(string firstName, string lastName, string nameOfCity,int distanceFromWork) : base(firstName, lastName,nameOfCity)
        {
            if (distanceFromWork < 0)
                throw new Exception("The distance from work could not be negative");
            DistanceFromWork = distanceFromWork;
        }
            //
        public override string ToString()
        {
            return base.ToString() + " (" + distanceFromWork+")";
        }
        public string GetLnFNameAndDis()
        {
            return firstName + " " + lastName + " (" + distanceFromWork + ")";
        }
    }
}
