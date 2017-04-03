using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MemoryCalculator : Calculator
    {

        private decimal memory;
        public bool isSet; 

        public MemoryCalculator()  // set memory 0  instead of null
        {
            this.memory = 0;
            isSet = false;
        }

        //public decimal Memory
        //{
        //    get { return memory; }
        //    set { memory = value; }
        //}

        public void MemoryStore(decimal value)
        {
            memory = value;
            isSet = true;

        }

        public decimal MemoryRecall()
        {
            return memory;
        
        }

        public void MemoryAdd(decimal value)
        {
            memory += value;
            isSet = true;

        }

        public void MemoryClear()
        {
            memory = 0;
            isSet = false;
        }


    }


}
