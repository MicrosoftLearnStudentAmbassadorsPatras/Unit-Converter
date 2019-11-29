using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    class Distance:Unit
    {
        public Distance(string name, double convertToMeters)
        {
            this.name = name;
            conversionRate = convertToMeters;
        }

        public double ConvertToMeters(double input)
        {
            return input * conversionRate;
        }
    }
}
