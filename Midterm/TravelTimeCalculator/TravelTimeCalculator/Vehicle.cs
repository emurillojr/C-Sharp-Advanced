using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ernest Murillo midterm  vehicle class

namespace TravelTimeCalculator
{
    public class Vehicle
    {

        //fields
        public string vehicleType;
    //    public string type;
     //   public int distance;
       
        
        // private decimal averageSpeed;
        

        // default constructor
        public Vehicle()
        { }

        // takes in the first entry from obj type  = vehicle type
        public Vehicle(string vehicleType)
        {
            
            this.vehicleType = vehicleType;
          //  this.type = type;
          //  this.distance = distance;
         //   this.averageSpeed = averageSpeed;
        }


        public string VehicleType    //object type
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = value;
            }
        }

        //public string Type    //object type
        //{
        //    get
        //    {
        //        return type;
        //    }
        //    set
        //    {
        //        type = value;
        //    }
        //}
        //public int Distance    //object type
        //{
        //    get
        //    {
        //        return distance;
        //    }
        //    set
        //    {
        //        distance = value;
        //    }
        //}


        //public decimal AverageSpeed   // id number
        //{
        //    get
        //    {
        //        return averageSpeed;
        //    }
        //    set
        //    {
        //        averageSpeed = value;
        //    }
        //}



        // method to display both
        public virtual string displayTypeandAverageSpeed()
        {
            return "Vehicle Type: " + vehicleType ;   // +"\n" + "Average Speed: " + averageSpeed;
        }

    }
}
