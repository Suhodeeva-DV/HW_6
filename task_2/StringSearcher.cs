using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class StringSearcher
    {
        public delegate void SearchStringsWithTemplate(string message);

        public event SearchStringsWithTemplate SearchStr;


        public string StrTemplate { get; } = "Черный человек";

        
        public void Search(List<string> strings)
        {
            foreach (string s in strings)
            {
                if (s.Contains(StrTemplate))
                {
                    SearchStr?.Invoke(s);
                }
            }
        }
    }
}
