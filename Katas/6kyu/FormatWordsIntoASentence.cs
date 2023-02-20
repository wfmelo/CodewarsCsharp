/* 6kyu - Format words into a sentence
 * Complete the method so that it formats the words into a single comma separated value.
 * The last word should be separated by the word 'and' instead of a comma. The method
 * takes in an array of strings and returns a single formatted string.
 * 
 * Note:
 * 
 *     Empty string values should be ignored.
 *     Empty arrays or null/nil/None values being passed into the method should result in an empty string being returned.
 * 
 * Example: (Input --> output)
 * 
 * ['ninja', 'samurai', 'ronin'] --> "ninja, samurai and ronin"
 * ['ninja', '', 'ronin'] --> "ninja and ronin"
 * [] -->""
*/
using System;
using System.Linq;

namespace Katas {
    public class FormatWordsIntoASentence {
        public static string FormatWords(string[] words) {
            string res = String.Empty;
            if (words == null || words.Length <= 0) return res;
            words = words.Where(v => v != "").ToArray();
            for (int i = 0; i <= words.Length - 1; i++) {
                if (words[i].Length > 0) {
                    if (i != words.Length - 1)
                        res += res.Length > 0 ? ", " + words[i] : words[i];
                    else
                        res += res.Length > 0 ? " and " + words[i] : words[i];
                }
            }

            return res;
        }
    }
}
