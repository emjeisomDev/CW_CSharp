using System;

namespace CW_CSharp.Practicalities
{
    public class NumberSystemsConvert
    {
        public int DecimalNumber { get; set; }
        public string OtherBaseNumber { get; set; }

        public NumberSystemsConvert(int decimalNumber)
        {
            DecimalNumber = decimalNumber;
        }
        public NumberSystemsConvert(string otherBaseNumber)
        {
            OtherBaseNumber = otherBaseNumber;
        }

        public string toBinary(int zerosToTheLeft = 1)
            => string.Format("{0:B" + zerosToTheLeft + "}", DecimalNumber);

        public string toHex(int zerosToTheLeft = 1)
            => string.Format("{0:X" + zerosToTheLeft + "}", DecimalNumber);

        public string toOctal(int zerosToTheLeft = 1)
            => $"{Convert.ToString(DecimalNumber, 8).PadLeft(zerosToTheLeft, '0')}";

        public int toBinToDec()
            => Convert.ToInt32(OtherBaseNumber, 2);

        public int toHexToDec()
            => Convert.ToInt32(OtherBaseNumber, 16);

        public int toOctToDec()
            => Convert.ToInt32(OtherBaseNumber, 8);




    }
}
