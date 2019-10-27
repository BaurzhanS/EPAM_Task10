using EPAM_Task10.Task2;
using EPAM_Task10.Task3;
using EPAM_Task10.Task4;
using EPAM_Task10.Task5;
using EPAM_Task10.Task6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EPAM_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //A string is considered to be in title case if each word in the string is 
            //either (a)capitalised(that is, only the first letter of the word is in upper case) 
            //or(b) considered to be an exception and put entirely into lower case unless it is the 
            //first word, which is always capitalised. Write a function that will convert a string 
            //into title case, given an optional list of exceptions(minor words). 
            //Вызов

            StringConversion sc = new StringConversion();
            string title1 = sc.ToTitleWords("a clash of KINGS");

            Console.WriteLine(title1);

            string title2 = sc.ToTitleWords("THE WIND IN THE WILLOWS");

            Console.WriteLine(title2);

            //You need to write a function AddOrChangeUrlParameter(url, keyValueParameter) that 
            //can manipulate URL parameters. It should be able to add a parameter to an existing URL, but
            //also to change a parameter if it already exists. 
            //Вызов
            
            ModifyUrl.AddOrChangeUrlParameter("www.example.com", "key=value");
            ModifyUrl.AddOrChangeUrlParameter("www.example.com?key=value", "key2=value2");
            ModifyUrl.AddOrChangeUrlParameter("www.example.com?key=oldValue", "key=newValue");

            //Implement the function UniqueInOrder which takes as argument a sequence and returns a list of 
            //items without any elements with the same value next to each other and preserving
            //the original order of elements.
            //Вызов

            UniqueOrder<string,char> list1 = new UniqueOrder<string,char>();
            string s1 = list1.UniqueInOrder("AAAABBBCCDAABBB").ToString();
            string s2 = list1.UniqueInOrder("ABBCcAD").ToString();
            string s3 = list1.UniqueInOrder("12233").ToString();
            UniqueOrder<List<double>, double>list2 = new UniqueOrder<List<double>, double>();
            List<double> num = list2.UniqueInOrder(new List<double> { 1.1, 2.2, 2.2, 3.3 });

            //Complete the solution so that it reverses all of the words within the string passed in
            //Вызов

            Wording words = new Wording();
            string text = words.ReverseWords("The greatest victory is that which requires no battle");
            Console.WriteLine(text);

            //Write a function that returns the sum of two big numbers. The input numbers are strings and the function must return a string.
            Summing sum = new Summing();
            string sumTotal = sum.findSum("4567902", "245666");
            Console.WriteLine(sumTotal);
        }
    }
}
