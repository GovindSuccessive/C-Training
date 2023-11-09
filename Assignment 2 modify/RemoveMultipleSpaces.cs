using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Day2
{
    class RemoveMultipleSpaces
    {
        private static string RemoveSpace1(string str)
        {

            string ans = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && (i + 1 < str.Length && str[i + 1] == ' '))
                {
                    continue;
                }
                else
                {
                    ans += str[i];
                }
            }

            return ans;
        }
        public static void RemoveSpace()
        {
            string str = "  i  am   a    govind    sharma";

            int len = str.Length;

            string ans = "";

            str = str.Trim();

            ans = RemoveSpace1(str);

            foreach (var val in ans)
            {
                Console.Write(val);
            }
/*
            string str = "  i  am   a    govind    sharma";
            char prev = str[0];

            StringBuilder ans = new StringBuilder(prev != ' ' ? prev.ToString() : "");
            //ans = prev != ' ' ? prev.ToString() : "";

            for (int i = 1; i < str.Length; i++)
            {
                if (prev != ' ' || str[i] != ' ')
                {
                    //ans += str[i].ToString();
                    ans.Append(str[i]);
                }
                prev = str[i - 1];

            }
            Console.WriteLine(ans);
*/        }
    }
}
