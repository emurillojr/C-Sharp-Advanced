using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTimeCalculator
{
    public class Train : Vehicle
    {

        // fields
        public string trollys;
     //   public int distance;
       
        // default
        public Train()
        {

        }

        // admin : base Person
        public Train(string vehicleType, string trollys, decimal distance)
            : base(vehicleType)
        {
            this.trollys = trollys;
        //    this.distance = distance;
        }


        public string Trollys
        {
            get
            {
                return trollys;
            }
            set
            {
                trollys = value;
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

      
        // this method adds to method in vehicle class - return string for use in message box in main
        public override string displayTypeandAverageSpeed()
        {
            return base.displayTypeandAverageSpeed() + "\n" + trollys;
        }
    }




    }

