using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FrequencyCounter
    {
        public string Count(string text)
        {
            IDictionary<char, int> freq = new Dictionary<char, int>();
            char c;
            string res = "";
            for(int i=0; i<26; i++)
            {
                freq.Add(Convert.ToChar(i+Convert.ToInt32('a')),0);
            }
            foreach (var ch in text)
            {
                if (Convert.ToInt32(ch) >= Convert.ToInt32('a') && Convert.ToInt32(ch) <= Convert.ToInt32('z')) freq[ch]++;
                else
                {
                    c = Convert.ToChar(Convert.ToInt32(ch) - Convert.ToInt32('A') + Convert.ToInt32('a'));
                    freq[c]++;;
                }
            }
            c = 'a';
            foreach (var cont in freq)
            {
                if(cont.Value==0) continue;
                if(cont.Key != 'a') res += ",";
                res += cont.Key + "-" + cont.Value;
                //res += ((c + 'a').ToString()) + "-" + (cont);
                if (cont.Key == 'z') break;
            }
            return res;
        }
    }
}
