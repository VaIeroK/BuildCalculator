using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildCalculator.Classes
{
    public static class MathHelper
    {
        public static bool IsFloat(string val)
        {
            return float.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        }
    }
}
