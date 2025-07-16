/// <summary>
/// This method converts a string into a new string where each character is replaced by "(" if it appears only once 
/// in the original string, or ")" if it appears more than once. The method ignores capitalization when determining 
/// if a character is a duplicate.
/// </summary>
/// <param name="input">The original string to be processed.</param>
/// <returns>A new string where each character is replaced by "(" or ")" based on its frequency in the original string.</returns>
/// <example>
/// For example:
///  - ConvertString("din") returns "(((".
///  - ConvertString("recede") returns "()()()".
///  - ConvertString("Success") returns ")())())".
///  - ConvertString("(( @") returns "))((".
/// </example>
/// <summary>
/// Este método converte uma string para uma nova string onde cada caractere é substituído por "(" se aparecer 
/// apenas uma vez na string original, ou ")" se aparecer mais de uma vez. O método ignora a capitalização ao 
/// determinar se um caractere é duplicado.
/// </summary>
/// <param name="entrada">A string original a ser processada.</param>
/// <returns>Uma nova string onde cada caractere é substituído por "(" ou ")" com base em sua frequência n
/// a string original.</returns>
/// <example>
/// Por exemplo:
///  - ConvertString("din") retorna "(((".
///  - ConvertString("recede") retorna "()()()".
///  - ConvertString("Success") retorna ")())())".
///  - ConvertString("(( @") retorna "))((".
///  https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
/// </example>

using System.Linq;
using System.Text;

namespace CW_CSharp.Katas.Rank.Kyu6
{
    public class ParenthesesDecoding
    {
        //
        public static string DuplicateEncode(string word)
        {
            char[] wordArrays = word.ToLower().ToCharArray();
            StringBuilder newWord = new StringBuilder();
            
            int contChar = 0;

            for (int i = 0; i < wordArrays.Length; i++)
            {
                for (int j = 0; j < wordArrays.Length; j++)
                {
                    if (wordArrays[i] == wordArrays[j])
                    {
                        contChar++;
                    }
                }

                if (contChar < 2)
                    newWord.Append("(");
                else
                    newWord.Append(")");

                contChar = 0;
            }

            return newWord.ToString();
        }

        public static string DuplicateEncode2(string word) {

            word = word.ToLower();
            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();


            foreach (char c in word)
            {
                if (charOccurrences.ContainsKey(c)) 
                { 
                    charOccurrences[c]++; 
                } 
                else 
                { 
                    charOccurrences[c] = 1; 
                }
            }

            StringBuilder newWord = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (charOccurrences[word[i]] < 2){
                    newWord.Append("(");
                }
                else { 
                    newWord.Append(")");
                }
            }
            return newWord.ToString();
        }


        public static string DuplicateEncode3(string word)
        {
            Dictionary<char, int> charOccurrences = word.ToLower().GroupBy(k => k).ToDictionary(k => k.Key, v => v.Count());
            return string.Concat(word.ToLower().Select(c => charOccurrences[c] < 2 ? '(' : ')'));
        }

        public static string DuplicateEncode4(string word) 
            => string.Concat(
                    word
                    .ToLower()
                    .Select(
                         c => word
                        .ToLower()
                        .GroupBy(k => k)
                        .ToDictionary(k => k.Key, v => v.Count())[c] < 2 ? '(' : ')'
                     )
                );


    }
}
