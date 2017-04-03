using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ernesto Murillo Lab 2  - PersonList class

namespace EMurillo_Lab2
{
    public class PersonList    // class
    {
        private List<Person> peoplelist;   // list

        public PersonList()    // method
        {
            peoplelist = new List<Person>();
        }

        //Read only property to return the count / number of people in the list
        public int Count
        {

            get
            {
                return peoplelist.Count;

            }


        }

        // add
        public void add(Person p)
        {
            peoplelist.Add(p);

        }

        //not needed
        public Person getbyindex(int i)
        {
            return peoplelist[i];

        }

        // last name search 
        public Person this[string name]
        {
            get
            {
                foreach (Person p in peoplelist)
                {
                    if (p.LName == name)
                    {
                        return p;
                    }


                }
                return null;
            }


        }

        // return info, last name
        public static PersonList operator +(PersonList pl, Person p)
        {
            pl.add(p);
            return pl;

        }

    }
}

