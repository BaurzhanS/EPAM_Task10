using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Task10.Task2
{
    public class StringConversion
    {
        public string ToTitleWords(string title)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            string titleStr;

            int count = 0;

            for (int i = 0; i < title.Length; i++)
            {
                if (char.IsUpper(title[i]) || !char.IsLetter(title[i]))
                {
                    count++;
                }
            }

            if (count == title.Length)
            {
                titleStr = textInfo.ToTitleCase(title.ToLower());
            }
            else
            {
                titleStr = textInfo.ToTitleCase(title);
            }

            return titleStr;
        }

    }
}
