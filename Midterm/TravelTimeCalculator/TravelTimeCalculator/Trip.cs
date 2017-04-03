using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTimeCalculator
{
    public class Trip : Vehicle
    {
        // fields
        //private string vehicleType;
        private string engineType;
        private decimal distance;
        private int averageSpeed;
        private decimal time;
       
        // default
        public Trip()
        {

        }


        public Trip(string vehicleType, string engineType, decimal distance)
            : base(vehicleType)
        {
            this.engineType = engineType;
            this.distance = distance;
       //     this.vehicleType = vehicleType;
        //    this.time = time;
        }

        //public decimal Time
        //{
        //    get
        //    {
        //        return time;
        //    }
        //}

        public decimal Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }

        //public string EngineType
        //{
        //    get
        //    {
        //        return engineType;
        //    }
        //    set
        //    {
        //        engineType = value;
        //    }
        //}

        //public string VehicleType
        //{
        //    get
        //    {
        //        return vehicleType;
        //    }
        //    set
        //    {
        //        vehicleType = value;
        //    }
        //}
     
   

        // admin : base Person
        //public Trip(int distance)
        //{
            
        //    this.distance = distance;
        //}

       

        //public int Distance
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


       
        public decimal TripCalculate()
        {
            //decimal time;
           // int averageSpeed;
            //time = distance / averageSpeed; 

            if (vehicleType == "Automobile")
            {
                averageSpeed = 60;
                time = distance / averageSpeed;
             //   return time;
            }

            if (vehicleType == "Plane" && engineType == "TurboProp")
            {
                averageSpeed = 300;
                time = this.distance / averageSpeed;
        //   return time;
            }

            if (vehicleType == "Plane" && engineType == "Jet")
            {
                averageSpeed = 500;
                time = distance / averageSpeed;
        //   // return time;
            }


            if (vehicleType == "Train" && engineType == "Less than 20")
            {
                averageSpeed = 100;
                time = distance / averageSpeed;
         //   return time;
            }

            if (vehicleType == "Train" && engineType == "Greater than 20")
            {
                averageSpeed = 70;
                time = distance / averageSpeed;
        //    return time;
            }

            return time;

        }

        //public string TimeString
        //{
        //    get
        //    {
        //        return time.timespan.ToString("h\\:mm");

        //    }
        //}


       





     //    this method adds to method in vehicle class - return string for use in message box in main
        //public override string displayTypeandAverageSpeed()
        //{
        //    return displayTypeandAverageSpeed() + "\n" + time;
        //}


        // this method adds to method in Person class - return string for use in message box in main
        public override string displayTypeandAverageSpeed()
        {
            return base.displayTypeandAverageSpeed() + "\n" + "Distance: " + distance + "\n" + "Time Traveled: " + time;
        }
        





    }
}
