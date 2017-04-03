using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTimeCalculator
{
    public class Plane : Vehicle
    {
         // fields
        private string engineType;
      //  private int distance;
     
        // default
        public Plane()
        {

        }
        // plane: base vehicle
        public Plane(string vehicleType, string engineType, decimal distance)
            : base(vehicleType)
        {
            this.engineType = engineType;
           // this.distance = distance;
        }


        public string EngineType
        {
            get
            {
                return engineType;
            }
            set
            {
                engineType = value;
            }
        }


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

     
        // this method adds to method in Person class - return string for use in message box in main
        public override string displayTypeandAverageSpeed()
        {
            return base.displayTypeandAverageSpeed() + "\n" + "Engine Type: " + engineType;
        }
    }





    }

