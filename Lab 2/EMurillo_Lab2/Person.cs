using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ernesto murillo Lab 2  - Person class

namespace EMurillo_Lab2
{

    public class Person
    {
        // fields
        private string fName;
        private string lName;
        private decimal gpa;
        private string dob;
        private decimal salary;
        private string phone;
        private string hireDate;

        public Person()  // Default constructor
        {
        }

        public Person(string fName, string lName, decimal gpa, string dob, decimal salary, string phone)  // constructor without hiredate
        {
            this.FName = fName;
            this.LName = lName;
            this.GPA = gpa;
            this.DOB = dob;
            this.Salary = salary;
            this.PhoneNum = phone;
            this.HireDate = DateTime.Today.ToShortDateString();
        }
       
        public Person(string fName, string lName, decimal gpa, string dob, decimal salary, string phone, string hireDate)  // constructor with hiredate
        {
            this.FName = fName;
            this.LName = lName;
            this.GPA = gpa;
            this.DOB = dob;
            this.Salary = salary;
            this.PhoneNum = phone;
            this.HireDate = hireDate;

        }


        public string FName   // property for FirstName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        public string LName   // property for LastName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        public decimal GPA   // property for GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                gpa = value;
            }
        }

        // read only -get GPA value and return it as string in the correct numeric value   ///// use this only in message box for display info message box
        public string GPAString
        {
            get { return GPA.ToString("N"); }   // standard Numeric format... commas and decimal with 2 decimal spaces after decimal
        }
        //
        
        public string DOB   // property for DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public decimal Salary   // property for Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        // read only - get Salary value and return it as string in the correct numeric value   ///// use this only in message box for display info message box
        public string SALARYString
        {
            get { return Salary.ToString("N"); }  // standard Numeric format... commas and decimal with 2 decimal spaces after decimal
        }


        public string PhoneNum   // property for PhoneNum
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string HireDate   // property for HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                hireDate = value;
            }
        }

        // method to return all info and display it when Search is clicked
        //updated for read only gpa & salary // instead of salary, it is SALARYString  // instead of gpa, it is GPAString to display correct format
        public string getpersoninfo()  //updated for read only salary = SALARYString and gpa = GPAString
        {
            return "Full Name: " + fName + " " + lName + "\n"
                    + "GPA: " + GPAString + "\n" + "DOB: " + dob + "\n" + "Salary: $" + SALARYString + "\n"
                    + "Phone Number: " + phone + "\n" + "Hire Date: " + hireDate + ".";
        }
    }
}
