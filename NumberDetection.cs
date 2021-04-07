using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishList
{
    static class NumberDetection
    {
        public static string FilterNumbers(string text)
        {
            foreach (var itemI in text)
            {
                if ((itemI < '0' || itemI > '9') && itemI != ',')
                {
                    text = text.Remove(text.IndexOf(itemI), 1);
                }
            }
            return text;
        }

        public static string CommaCheck(string text)
        {
            int commaIndex = text.IndexOf(',');
            int commaLastIndex = text.LastIndexOf(',');

            switch (commaIndex)
            {
                case -1:
                    return text;

                case 0:
                    if (commaIndex == 0)
                    {
                        text = "0" + text;
                    }
                    break;
            }

            if (commaIndex != commaLastIndex)
            {
                text = text.Remove(commaLastIndex, 1);
            }

            if (commaIndex == text.Length - 4)
            {
                text = text.Remove(text.Length - 1, 1);
            }

            return text;
        }
    }
}
