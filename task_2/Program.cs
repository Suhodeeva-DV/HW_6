using System;
using System.Collections.Generic;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>
            {
                "Голова моя машет ушами,",
                "Как крыльями птица.",
                "Ей на шее ноги",
                "Маячить больше невмочь.",
                "Черный человек,",
                "Черный, черный,",
                "Черный человек на кровать ко мне садится,",
                "Черный человек спать не дает мне всю ночь."
            };

            StringSearcher searchString = new StringSearcher();
            searchString.SearchStr += StringSearchMessage;
            searchString.Search(strList);

        }

        static void StringSearchMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
