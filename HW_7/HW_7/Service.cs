using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_7
{
    class Service
    {
        //----data fields----
        public  List<Male> males = new List<Male>();
        public  Queue<Female> females = new Queue<Female>();
        public  List<Couple> couples = new List<Couple>();

        //----properties----
        public List<Male> Males { get => males; set => males = value; }
        public  Queue<Female> Females { get => females; set => females = value; }
        public List<Couple> Couples { get => couples; } 
        //----methods----
        //constractor:
        public Service()
        {

        }
            //
        public void AddSignalMen()
        {
            string str, firstName, lastName, city, temp;
            int idx1, idx2, idx3, distance;
            StreamReader sr = new StreamReader(@"C:\Users\kfirg\OneDrive - Ruppin Academic Center\מונחה עצמים C#\מטלות בית\מטלה 7 עד 26.6\HW_7\HW_7\men.txt");
            while ((str = sr.ReadLine()) != null)
            {
                idx1 = str.IndexOf('-');
                firstName = str.Substring(0, idx1);
                idx2 = str.IndexOf('-', idx1+1);
                lastName = str.Substring(idx1 + 1, idx2-idx1-1);
                idx3 = str.IndexOf('-', idx2+1);
                city = str.Substring(idx2+1,idx3-idx2-1);
                temp= str.Substring(idx3 + 2, str.Length-idx3-2);
                distance = int.Parse(temp);

                Male newMale = new Male(firstName, lastName, city, distance);
                males.Add(newMale);
            }
        }
        public void AddSignalWomen()
        {
            string str, firstName, lastName, city, temp;
            int idx1, idx2, idx3, numOfKids;
            StreamReader sr = new StreamReader(@"C:\Users\kfirg\OneDrive - Ruppin Academic Center\מונחה עצמים C#\מטלות בית\מטלה 7 עד 26.6\HW_7\HW_7\women.txt");
            while ((str = sr.ReadLine()) != null)
            {
                idx1 = str.IndexOf('-');
                firstName = str.Substring(0, idx1);
                idx2 = str.IndexOf('-', idx1 + 1);
                lastName = str.Substring(idx1 + 1, idx2 - idx1 - 1);
                idx3 = str.IndexOf('-', idx2 + 1);
                city = str.Substring(idx2 + 1, idx3 - idx2 - 1);
                temp = str.Substring(idx3 + 2, str.Length - idx3 - 2);
                numOfKids = int.Parse(temp);

                Female newFemale = new Female(firstName, lastName, city, numOfKids);
                females.Enqueue(newFemale);
            }
        }
        public bool FindAMatch()
        {
            Female femaleFind = females.Peek();
            foreach(Male male in males)
            {
                if(femaleFind.LastName.Equals(male.LastName))
                {
                    couples.Add( (new Couple(male, femaleFind)) );
                    males.Remove(male);
                    return true; 
                }
            }
            return false;
        }
    }
}
