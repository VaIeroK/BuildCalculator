using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildCalculator.Classes
{
    public class MaterialObject
    {
        public MaterialObject() 
        {
            MaterialId = -1;
            FirstInputValue = -1.0f;
            SecondInputValue = -1.0f;
        }

        public MaterialObject(int mid, float first_val, float second_val)
        {
            MaterialId = mid;
            FirstInputValue = first_val;
            SecondInputValue = second_val;
        }

        public int MaterialId;
        public float FirstInputValue;
        public float SecondInputValue;
    }
}
