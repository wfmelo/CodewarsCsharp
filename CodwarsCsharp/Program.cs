using System;
using System.Linq;

namespace CodwarsCsharp {
    class Program {
        static void Main(string[] args) {
            string str1 = "potato tofu cucumber cabbage turnip pepper onion carrot celery mushroom potato tofu cucumber cabbage";
            var tuples = CountVegetables(str1);
            foreach (var t in tuples) {
                Console.WriteLine("{0}, {1}", t.Item1, t.Item2);
            }
        }
        static Tuple<int, string>[] CountVegetables(string s)
        {
            string[] veggies = { "cabbage", "carrot", "celery", "cucumber", "mushroom", "onion", "pepper", "potato", "tofu", "turnip" }; // Contains all vegetables as strings.
            return s.Split(" ").Where(x => veggies.Any(y => x == y)).GroupBy(v => v)
                .Select(v => new Tuple<int, string>(v.Count(), v.Key)).OrderByDescending(v => v.Item1).ThenByDescending(v => v.Item2).ToArray();
        }
    }
}
