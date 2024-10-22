using System;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException("Input string cannot be null.");
            }

            stringValue = stringValue.Trim();

            if (string.IsNullOrEmpty(stringValue))
            {
                throw new FormatException("Input string cannot be empty.");
            }

            int result = 0;
            bool isNegative = false;
            int startIndex = 0;

            if (stringValue[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }
            else if (stringValue[0] == '+')
            {
                startIndex = 1;
            }

            for (int i = startIndex; i < stringValue.Length; i++)
            {
                char c = stringValue[i];
                if (c < '0' || c > '9')
                {
                    throw new FormatException("Input string was not in a correct format.");
                }

                if (isNegative)
                {
                    result = checked(result * 10 - (c - '0'));
                }
                else
                {
                    result = checked(result * 10 + (c - '0'));
                }
            }

            return result;
        }
    }
}