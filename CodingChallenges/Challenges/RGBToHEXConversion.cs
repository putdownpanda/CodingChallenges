using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Challenges
{
    /*The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.*/
    public class RGBToHEXConversion
    {
        public static string GetHEXFromRGB(int r, int g, int b)
        {
            string hex = "#";
            hex += CheckValue(r);
            hex += CheckValue(g);
            hex += CheckValue(b);

            return hex;
        }
        private static string CheckValue(int value)
        {
            if (value > 254)
            {
                return "FF";
            }
            else if (value < 1)
            {
                return "00";
            }
            else
            {
                return GetHexValue(value);
            }
        }
        private static string GetHexValue(int value)
        {
            int quotient = value / 16;
            int remainder = value % 16;

            string hexCode = string.Empty;

            if (quotient > 9)
            {
                hexCode = GetLetterCode(quotient);
            }
            else
            {
                hexCode = quotient.ToString();
            }
            if (remainder > 9)
            {
                hexCode += GetLetterCode(remainder);
            }
            else
            {
                hexCode += remainder;
            }
            return hexCode;
        }

        private static string GetLetterCode(int value)
        {
            if (value > 14)
            {
                return "F";
            }
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return alphabet[value - 10].ToString();
        }
    }
}
