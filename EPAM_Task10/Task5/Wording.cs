using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Task10.Task5
{
    public class Wording
    {
        public string ReverseWords(string text)
        {
            string[] words = text.Split(' ');
            Array.Reverse(words);
            text = String.Join(" ", words);
            return text;
        }
    }
}
