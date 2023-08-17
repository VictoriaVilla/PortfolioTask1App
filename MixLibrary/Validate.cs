using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixLibrary
{
    public class Validate
    {
        static public int ValidateInt(int value)
        {

            if (value >= 0)
            {
                return value;
            }
            else
            {
                return -1;
            }

        }

        static public void ValidationIntMessage(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Please enter number  greater or equal to zero:");
            }
        }
    }
}
