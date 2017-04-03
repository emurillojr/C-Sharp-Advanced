Lab 1
Create a basic calculator
For this project, you’ll create a form that lets the user perform the operations provided by a basic calculator. You’ll also create a class that performs the required operations.

Lab 2
New Employees
Part 1 - Expand the “Person” class that we used in class so that it contains the following values: First Name, Last Name, GPA, Date of Birth(DOB), Salary, Phone Number and Hire Date.  Build a form that includes labels, textboxes, and a buttons so that the user can fill out the form and click a button to fill the class object based on the form’s data.   Make all fields mandatory except the hire date
Part 2 – Add a second class that contains a list of person objects.  Add the ability to retrieve a person and display their information in a message box using an indexer that uses their last name.  
Add an additional constructor to the person class that uses the current date as the Hire Date if one is not entered by the user.  
Part 3 - Create a static Validation Class that validates the data entered.  Come up with a list of various validation schemes for different types of input data.  (For example, all data is required except hire date, confirm DOB and Hire dates are dates, GPA between 0 and 4.0, no letters in numeric fields, and salary between 0 and 113 billion)  Please complete the functions necessary and implement them within your form code so that I cannot break your page

Lab 3
Direct a simple robot 
For this project, you’ll create a form that lets the user move a simple robot a given direction and distance. You’ll also create a class that performs the robot movements.

Lab 4
NEIT New Hire application
Create a application that allows the user to select from 3 types of objects, a teacher object, a student object, and a Administration object..  
The teacher object should contain the following fields:
•	Object Type – (Teacher)
•	Id number – 5 characters, all numbers
•	First Name
•	Last Name
•	Rank – Either Professor, Associate Professor or Adjunct Faculty
•	Annual Salary
The Student Object should contain the following fields:
•	Object Type- (Student)
•	Id number – 5 characters, all numbers
•	First Name
•	Last Name
•	Major – Either Networking, Software Engineering, or Game Development
•	GPA – decimal number between 0.00 and 4.00
The Administration Object should contain the following fields:
•	Object Type – (Admin)
•	Id number – 5 characters, all numbers
•	First Name
•	Last Name
•	Department: Either Maintenance, Security, or Clerical
•	Hourly Rate – between 0.00 and 20.00

The application should contain a “Person” base class that has object type, id num, first name Last name.  There should be a sub class for each object type with their individual fields and each sub class should override the display method in the base class to include the fields that are specific to the individual sub classes.


Lab 5
Fix and enhance the calculator
An intern was hired to create a calculator in C#.  He quit after 2 weeks.  In this lab you need to go in and finish the project.  The code currently does not compile.    You must use the current design and approach.  
•	Add Comments in both the class and the form code
•	Remember to make sure hitting equals button repeats the calculation over and over using the last entered value 
•	Remember to not allow more than one decimal 
•	Do not allow divide by zero
•	Remember to make sure all buttons work 
•	Test it thoroughly
Enhancement Specifications
•	Add buttons to the calculator so it matches the design shown below
•	Create a class named MemoryCalculator that inherits the Calculator class. The MemoryCalculator class should add properties and methods as needed to implement the memory function.
Operation
•	To save the value that’s currently displayed in memory, the user clicks the MS button.
•	To clear the contents of memory, the user clicks the MC button. 
•	To recall the value that’s currently in memory and display it in the calculator, the user clicks the MR button. 
•	To add the value that’s currently displayed to the value in memory, the user clicks the M+ button.
•	An M is displayed in the box above the MC button whenever the memory contains a value.
•	The MemoryCalculator class should have 4 separate methods to perform these functions.


Lab 6
Part 1 Maintain products/TechSupport Database
For this project, you’ll create a form that lets the user maintain products using a DataGridView control.
The design of the Product Maintenance form
Operation
•	When this application starts, all the rows in the Products table of the TechSupport database are displayed in the DataGridView control.
•	The user can use the toolbar and the DataGridView control to add new rows, delete rows, modify the data in existing rows, and save changes to the database.
•	By change the display to appear by release date in descending order.
Specifications
•	This application should handle SQL Server exceptions, ADO.NET exceptions, and data errors that occur when working with the DataGridView control.


Lab 7
Part 2:  Maintain technicians
For this project, you’ll create a form that lets the user maintain technicians.


Lab 8
Display customer incidents
For this project, you’ll use the TechSupport database and create a form that lets the user display the incidents for a selected customer.


Lab 9
Register products
For this project, you’ll develop an application that lets the user register products to customers.


Midterm
Travel Time Calculator
Create an application called Vehicles that calculates the time it takes for trips taken by different kinds of vehicles.  The application should have 5 classes, a class called Vehicle, a class called Trip, as well as a class for Plane, Train, and Automobile.   The application should take in data from the user and calculate the average time it takes for that type of vehicle to complete a trip of a given distance.
Class Details:
Vehicle class should contain 2 fields, vehicle type and average speed and a display function that displays both.
Trip class should have 2 functions.  One function to calculate the trip time using a version of the following formula:
Time = Distance / Vehicle’s Average Speed
And one function that overrides the Display function and adds the distance and trip time to the display function from the vehicle class. 
Automobile class has one field for the transmission type; choices are manual or automatic and a function that overrides the Display function to add transmission to the display
Plane class has one field for type of engine; choices are jet or turboprop and a function that overrides the Display function by adding engine type to the class
The train class should have one field for the number of trolley cars in the train and a function that overrides the Display function by adding the number of cars to the display
Average Speed:
If the type of vehicle selected is a car the vehicle speed is 60 mph regardless of the transmission type. If the user selects train the vehicle speed is 100mph if it has less than 20 trolley cars, 70 mph for 20 or more trolley cars.  If the vehicle type selected is a plane the average speed is 300 mph if it has a turboprop and 500 mph for jet. 


Final
Maintain technicians
For this project, you’ll create a form that lets the user maintain the technicians in the TechSupport database
Operation
•	When this application first starts, the data in the first row of the Technicians table is displayed. (Id, Name, Email and Phone#) 
•	To modify an existing row, the user enters the modifications and then clicks the Save Data button in the toolbar.
•	To delete an existing row, the user clicks the Delete button in the toolbar, followed by the Save Data button.
•	To add a new row, the user clicks the Add New button in the toolbar, enters the data for the new row, and then clicks the Save Data button.
Specifications
•	This application should handle SQL Server exceptions.
•	Because the TechID column is an identity column, don’t allow the user to change the value in this column.
•	Limit the number of characters that can be entered into the Name, Email, and Phone text boxes so that the entries don’t exceed the sizes allowed by the Name, Email, and Phone columns.
•	Enhance the toolbar so it provides a button for canceling an edit operation. 
•	Add a parameterized query that retrieves a technician by technician ID.
