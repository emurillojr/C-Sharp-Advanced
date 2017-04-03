using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;   // added this for Point to work
using System.Windows.Forms;  // added this for Panel function to work

// Ernesto Murillo C# Direct a simple robot  Robot class


namespace SimpleRobot
{
    // This will make the enum type globally accessible without having to reference the class name everytime if it was inside the class .
    //set each value to the wingdings int arrow.   //makes this global constant to use in main -  cant be inside Robot class
    public enum Direction  //enumerator -place to store and keep track of constants with integers values -  all enum constants are type int by default,
    {
        North = 233,  // constant North = 233  up arrow
        West = 231,   // constant West = 231  left arrow
        South = 234,  // constant South = 234  down arrow
        East = 232   // constant East = 232  right arrow
    }

    class Robot   // name of class
    {

        //delegate
        public delegate void Collision();
        //event
        public event Collision WallCrash;


        // public field that contains the current direction
        public Direction direction;


        //When robot is instantiated
        public Robot() // Default constructor       runs at form load
        {
            location = new Point(); // initially sets location.X=0 and location.Y=0  (for lbllocation )           
            direction = Direction.North;  // call public enum Direction set to North  - (also used in override string method below)  alt233
        }

        // commented out: direction is now a public field and not a property anymore
        //public Direction direction { get; set; } 

        public Point location { get; set; }

        public void Move(int unitToMove)  // passes in number from button as int   if go 1  unitToMove =1   10 for 10
        {
            Point P = new Point();  // 0,0 or current coordinates
            switch (direction)
            {
                case Direction.North:   // if i am facing north
                    P.X = location.X;   // x stays the same coordinate
                    P.Y = location.Y - unitToMove;  // y - 1, or y - 10
                    if (P.Y > -101)
                    {
                        location = P;
                    }
                    else
                    {
                        WallCrash();
                    }
                    break;
                case Direction.West:   // if i am facing west
                    P.X = location.X - unitToMove;   // x - 1, or x - 10
                    P.Y = location.Y;  // y stays the same coordinate
                    if (P.X > -101)
                    {
                        location = P;
                    }
                    else
                    {
                        WallCrash();
                    }
                    break;
                case Direction.South:  // if i am facing south
                    P.X = location.X;  // x stays the same coordinate
                    P.Y = location.Y + unitToMove;   // y + 1, or y + 10
                    if (P.Y < 101)
                    {
                        location = P;
                    }
                    else
                    {
                        WallCrash();
                    }
                    break;
                case Direction.East:  // if i am facing east
                    P.X = location.X + unitToMove;    // x + 1, or x+10
                    P.Y = location.Y;   // y stays the same coordinate
                    if (P.X < 101)
                    {
                        location = P;
                    }
                    else
                    {
                        WallCrash();
                    }
                    break;
                default:
                    break;
            }

        }
        public void Draw(Panel P)
        {
            // location x, y is (0,0) set by default constructor 
            //p.Witdth is width of panel  = 200     same for Height               x =0   0+200 /2 = x   same for y 
            Point L = new Point(location.X + P.Width / 2, location.Y + P.Height / 2);    // set location lblArrow.Text new x,y coordinates)
            P.Controls[0].Location = L;   //Controls[0] is lblArrow - draw or put lblArrow.Text into its new coordinates /// + or - unit to move coordinates
            // Controls means  - because we dropped one control on the panel
            // we know that the first control in the Controls collection 
            // of the Panel Controls[0] must be our robot label

        }
        public override string ToString()
        {
            // direction is an enum and used as an ASCII code,
            // we cast it to a char and make it into a string
            return ((char)direction).ToString();   //override whatever is in lblArrow.Text to alt*** - like its typing it in and grabbing that character and convert to string
        }


    }
}
