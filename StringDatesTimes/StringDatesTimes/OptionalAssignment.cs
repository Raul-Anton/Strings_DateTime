using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDatesTimes
{
    public static class OptionalAssignment
    {
        public static int Interpret(string s)
        {
            string[] orderArr = new string[s.Length];
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '<')
                {
                    orderArr[index] = "open";
                    index++;
                }

                if (s[i] == '/' && s[i - 1] == '<')
                {
                    index--;
                    orderArr[index] = "closed";
                    index++;
                }
            }

            for (int i = 0; i < index; i++)
            {
                if (orderArr[i] == "open")
                {
                    for (int j = i; j < index; j++)
                    {
                        if (orderArr[j] == "closed")
                        {
                            orderArr[i] = null;
                            orderArr[j] = null;
                            j=orderArr.Length;
                        }
                    }
                }
            }

            int numberOfIncorrectTags = 0;

            for (int i = 0; i < index; i++)
            {
                if (orderArr[i] != null)
                    numberOfIncorrectTags++;
            }

            return numberOfIncorrectTags;
        }
    }
}
