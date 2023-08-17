using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixLibrary
{
    public class Read
    {
        static public int ReadInteger()
        {
            int value = 0;
            string stringValue = "";
            do
            {
                stringValue = Console.ReadLine();
                if (!int.TryParse(stringValue, out value))
                {
                    value = -1;
                }
                MixLibrary.Validate.ValidationIntMessage(value);
            } while (value < 0);

            return value;

        }
    }
}
