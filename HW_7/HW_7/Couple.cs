using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class Couple: IComparable
    {
        //----data fields----
        protected Male male;
        protected Female female;

        //----properties----
        internal Male Male { get => male; set => male = value; }
        internal Female Female { get => female; set => female = value; }

        //-----methods-----
        //constractors:
        public Couple()
        {
            male = new Male();
            female = new Female();
        }
        public Couple(Male male, Female female)
        {
            Male = male;
            Female = female;
        }
            //
        public override string ToString()
        {
            return male.FirstName + " and " + female.FirstName + " " + male.LastName + " -" + male.NameOfCity;
        }

        //----interface----
        public int CompareTo(object obj) //sorting by Last Name
        {
            if (!(obj is Couple))
                throw new Exception("this is not a vegtable");

            int result = String.Compare(((Couple)obj).male.LastName, male.LastName);
            if (result < 0) // male.LastNAme > ((Couple)obj).male.LastName
                return 1;
            if (result > 0) //male.LastName < ((Couple)obj).male.LastName
                return -1;
            return 0;       //male.LastName == ((Couple)obj).male.LastName
        }

    }
}
