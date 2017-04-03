using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    // admin sub class
    public class Admin : Person
    {
        // fields
        public string department;
        public decimal rate;

        // default
        public Admin()
        {

        }

        // admin : base Person
        public Admin(string obj, int id, string fName, string lName, string department, decimal rate) : base(obj, id, fName, lName)
        {
            this.department = department;
            this.rate = rate;
        }


        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public decimal Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }

        // numeric format for hourly rate
        public string HourString
        {
            get { return rate.ToString("N"); }
        }

        // this method adds to method in Person class - return string for use in message box in main
        public override string displayUserInput()
        {
            return base.displayUserInput() + "\n" + "Department: " + department + "\n" + "Hourly Rate: $" + HourString;
        }
    }
}
