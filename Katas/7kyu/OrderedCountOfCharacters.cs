/* 7kyu - Ordered Count of Characters
 * Count the number of occurrences of each character and return it as a (list of tuples) in order of appearance. For empty output return (an empty list).
 *
 * Consult the solution set-up for the exact data structure implementation depending on your language.
 *
 * Example:
 *
 * Kata.OrderedCount("abracadabra") == new List<Tuple<char, int>> () {
 *  new Tuple<char, int>('a', 5),
 *  new Tuple<char, int>('b', 2),
 *  new Tuple<char, int>('r', 2), 
 *  new Tuple<char, int>('c', 1),
 *  new Tuple<char, int>('d', 1)
 *}
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas {
    public class OrderedCountOfCharacters {
        public static List<Tuple<char, int>> OrderedCount(string input) {
            var res = new List<Tuple<char, int>>();
            res = input.ToList().GroupBy(x => x).Select(c => new Tuple<char, int>(c.Key, c.Count())).ToList();
            return res;
        }
    }
}
