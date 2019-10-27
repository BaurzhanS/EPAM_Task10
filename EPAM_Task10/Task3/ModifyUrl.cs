using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Task10.Task3
{
    class ModifyUrl
    {
        public static void AddOrChangeUrlParameter(string url, string param)
        {
            string newUrl = url;

            int indexOfChar = param.IndexOf('=');

            string key = param.Substring(0, indexOfChar);

            if (!url.Contains('?') && !url.Contains('='))
            {
                newUrl = url + '?' + param;
                Console.WriteLine(newUrl);
            }

            else if (url.Contains('?') && url.Contains('=') && !url.Contains(key))
            {
                newUrl = url + '&' + param;
                Console.WriteLine(newUrl);
            }

            else if (url.Contains('?') && url.Contains('=') && url.Contains(key))
            {
                int indexOfKey = url.IndexOf(key);
                string urlPart = url.Substring(0, indexOfKey);
                newUrl = urlPart + param;
                Console.WriteLine(newUrl);
            }
        }
    }
}
