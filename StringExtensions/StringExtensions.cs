using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ExtentionMethods
{
    public static class StringExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Capitalize(this String str)
        {
            string first = str[0].ToString().ToUpper();
            return first + str.Substring(1);
        }
        public static void DeCapitalize(this String str)
        {
            //DOESNT WORK//
            string first = str[0].ToString().ToLower();
            str = first + str.Substring(1);
        }

        public static string Titlize(this String title)
        {
            List<string> parts = new List<string>(title.Split(" "));
            List<string> articles = new List<string>(0)
            {
                "a",
                "an",
                "the"
            };
            string first = parts[0];
            if (articles.Contains(parts[0].ToLower()))
            {
                parts.RemoveAt(0);
                parts.Add(", ");
                parts.Add(first);
                first = parts[0];

                while (articles.Contains(first.ToLower()))
                {
                    parts.RemoveAt(0);
                    parts.Add(first);
                    first = parts[0];
                }
            }
            string result = " ";
            foreach (string part in parts)
            {
                result += part + " ";
            }
            return result;
        }
    }
}
