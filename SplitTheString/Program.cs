using System;
using System.Linq;
namespace SplitTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A B C D";
            char[] charArr = str.ToCharArray();


            string[] splitArray = new string[4];
            int start = 0;
            int len = 0;
            int j = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                len++;
                if (charArr[i] == ' ')
                {
                    splitArray[j] = str.Substring(start, len);
                    j++;
                    start = i + 1;
                    len = 0;
                }

                if (i == charArr.Length - 1)
                {
                    splitArray[j] = str.Substring(start, len);
                }
            }


            Array.ForEach(splitArray, x => Console.WriteLine(x));
        }
    }
}
