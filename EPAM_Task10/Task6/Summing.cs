using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Task10.Task6
{
    public class Summing
    {
        public string findSum(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }

            string str = "";

            int n1 = str1.Length, n2 = str2.Length;

            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);
            str1 = new string(ch);
            char[] ch1 = str2.ToCharArray();
            Array.Reverse(ch1);
            str2 = new string(ch1);

            int count = 0;
            for (int i = 0; i < n1; i++)
            {
                int sum = ((int)(str1[i] - '0') +
                        (int)(str2[i] - '0') + count);
                str += (char)(sum % 10 + '0');

                count = sum / 10;
            }

            for (int i = n1; i < n2; i++)
            {
                int sum = ((int)(str2[i] - '0') + count);
                str += (char)(sum % 10 + '0');
                count = sum / 10;
            }

            if (count > 0)
                str += (char)(count + '0');

            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);

            return str;
        }
    }

}

