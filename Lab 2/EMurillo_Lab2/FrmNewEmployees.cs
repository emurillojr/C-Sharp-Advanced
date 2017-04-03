using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ernesto Murillo Lab 2 - Form 

namespace EMurillo_Lab2
{
    public partial class FrmNewEmployees : Form
    {
        public FrmNewEmployees()
        {
            InitializeComponent();
        }

        public PersonList List1 = new PersonList();   // new list
        int Count;    // counter for each entry

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

            if (IsValidData())   // verification function
            {
                if (txtHireDate.Text == "")  // if there is no hire date
                {
              ///      txtHireDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());  // set hire date to todays date
                    // put everything in class
                    Person person = new Person(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtGPA.Text), txtDOB.Text, Convert.ToDecimal(txtSalary.Text), Validator.formatPhoneNumber(txtPhoneNumber.Text));
                    List1.add(person); // add to list
                    Count = List1.Count;   // count it
                    // confirmation message
                    MessageBox.Show("A new person has been added to the database they are the " + Count + " added to the list.", "Entry");
                    clearAll();  // clear all textboxes
                    txtFirstName.Focus(); // focus back to first name
                }
                // if hire date is entered
                else if (Validator.IsValidDateHire(txtHireDate))   // if hire date validate is true  - based on hire date validation, DOB & hiredate will never be the same
                {
                       // put everything in class
                        Person person = new Person(txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtGPA.Text), txtDOB.Text, Convert.ToDecimal(txtSalary.Text), Validator.formatPhoneNumber(txtPhoneNumber.Text), txtHireDate.Text);
                        List1.add(person);   // add to list
                        Count = List1.Count; // count it
                        // confirmation message
                        MessageBox.Show("A new person has been added to the database they are the " + Count + " added to the list.", "Entry");
                        clearAll(); // clear all textboxes
                        txtFirstName.Focus(); // focus back to first name
                }
            }
        }

        // clear all function
        public void clearAll()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtGPA.Clear();
            txtDOB.Clear();
            txtSalary.Clear();
            txtPhoneNumber.Clear();
            txtHireDate.Clear();
            txtFirstName.Focus();
        }

        // is valid data bool function to test all except hire date
        private bool IsValidData()
        {
            if (
                // Validate for First Name
                Validator.IsPresent(txtFirstName, lblFirstName) &&
                Validator.IsNotDigits(txtFirstName.Text) &&
                // Validate for Last Name
                Validator.IsPresent(txtLastName, lblLastName) &&
                Validator.IsNotDigits(txtLastName.Text) &&
                // Validate for GPA
                Validator.IsDecimal(txtGPA) &&
                Validator.IsPresent(txtGPA, lblGPA) &&
                Validator.IsWithinRange(txtGPA, 0, 4, lblGPA) &&
                // Validate for DOB
                Validator.IsValidDate(txtDOB) &&
                Validator.IsPresent(txtDOB, lblDOB) &&
                // Validate fo Salary
                Validator.IsDecimal(txtSalary) &&
                Validator.IsPresent(txtSalary, lblSalary) &&
                Validator.IsWithinRange(txtSalary, 0, 113000000000, lblSalary) &&
                // Validate for Phone Number
                Validator.IsPresent(txtPhoneNumber, lblPhoneNumber) &&
                Validator.IsDigits(txtPhoneNumber.Text)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string getname = txtSearch.Text;    // whatever name typed set to variable getname
                Person p2 = new Person();  // class goes to default constructor
                p2 = List1[getname];  // search list to get name info

                MessageBox.Show(p2.getpersoninfo(), "Information:");   // if matches, pull all info from list to display in messagebox
                txtSearch.Clear();  // cleat the search box after completing search  
                txtSearch.Focus();  // focus on search box
            }
            catch (NullReferenceException)   // if search entry is blank or name not on list, display error
            {
                MessageBox.Show("There is no one by that Last Name.  Please search again.", "Error");
                txtSearch.Focus();
            }
        }

        private void FrmNewEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
