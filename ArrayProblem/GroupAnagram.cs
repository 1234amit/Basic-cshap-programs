using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class GroupAnagram
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
            foreach(string str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string sortedStr = new string(charArray);

                if(!anagramGroups.ContainsKey(sortedStr))
                {
                    anagramGroups[sortedStr] = new List<string>();
                }

                anagramGroups[sortedStr].Add(str);
            }

            return new List<IList<string>>(anagramGroups.Values);

        }
    }
}
