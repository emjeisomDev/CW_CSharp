/// <summary>
/// Represents a function that converts a Roman numeral to its equivalent decimal integer value.
/// </summary>
/// 
/// <remarks>
/// The function takes a Roman numeral string as input and returns its numeric decimal equivalent. The function does not validate the 
/// format of the Roman numeral but assumes that the input is a valid Roman numeral string.
/// 
/// Roman numerals are written by expressing each decimal digit separately, starting from the leftmost digit. For example, 1990 is 
/// represented as "MCMXC", and 2008 is represented as "MMVIII". The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.
/// </remarks>
/// 
/// <method>
/// Converts a Roman numeral string to a decimal integer.
/// </method>
/// 
/// <param name="romanNumeral">The Roman numeral string to be converted to a decimal integer.</param>
/// <returns>The decimal integer equivalent of the provided Roman numeral.</returns>
/// 
/// <example>
/// <p>For the input:</p>
/// <pre>"MM"</pre>
/// <p>The function will return:</p>
/// <pre>2000</pre>
/// </example>
/// 
/// <example>
/// <p>For the input:</p>
/// <pre>"MDCLXVI"</pre>
/// <p>The function will return:</p>
/// <pre>1666</pre>
/// </example>
/// 
/// <example>
/// <p>For the input:</p>
/// <pre>"M"</pre>
/// <p>The function will return:</p>
/// <pre>1000</pre>
/// </example>
/// 
/// <remarks>
/// The Roman numeral system uses the following symbols and values:
/// <ul>
///   <li>I = 1</li>
///   <li>V = 5</li>
///   <li>X = 10</li>
///   <li>L = 50</li>
///   <li>C = 100</li>
///   <li>D = 500</li>
///   <li>M = 1000</li>
/// </ul>
/// </remarks>
/// <summary>
/// Representa uma função que converte um numeral romano em seu equivalente valor inteiro decimal.
/// </summary>
/// 
/// <remarks>
/// A função recebe uma string representando um numeral romano e retorna seu valor equivalente em decimal. A função não valida o formato 
/// do numeral romano, mas assume que a entrada é uma string válida representando um numeral romano.
/// 
/// Os numerais romanos são escritos expressando cada dígito decimal separadamente, começando pelo dígito mais à esquerda. Por exemplo, 
/// 1990 é representado como "MCMXC", e 2008 é representado como "MMVIII". O numeral romano para 1666, "MDCLXVI", utiliza cada letra 
/// em ordem decrescente.
/// </remarks>
/// 
/// <method>
/// Converte uma string de numeral romano em um número inteiro decimal.
/// </method>
/// 
/// <param name="romanNumeral">A string de numeral romano a ser convertida em um número inteiro decimal.</param>
/// <returns>O valor inteiro decimal equivalente ao numeral romano fornecido.</returns>
/// 
/// <example>
/// <p>Para a entrada:</p>
/// <pre>"MM"</pre>
/// <p>A função retornará:</p>
/// <pre>2000</pre>
/// </example>
/// 
/// <example>
/// <p>Para a entrada:</p>
/// <pre>"MDCLXVI"</pre>
/// <p>A função retornará:</p>
/// <pre>1666</pre>
/// </example>
/// 
/// <example>
/// <p>Para a entrada:</p>
/// <pre>"M"</pre>
/// <p>A função retornará:</p>
/// <pre>1000</pre>
/// </example>
/// 
/// <remarks>
/// O sistema de numerais romanos usa os seguintes símbolos e valores:
/// <ul>
///   <li>I = 1</li>
///   <li>V = 5</li>
///   <li>X = 10</li>
///   <li>L = 50</li>
///   <li>C = 100</li>
///   <li>D = 500</li>
///   <li>M = 1000</li>
/// </ul>
/// https://www.codewars.com/kata/51b6249c4612257ac0000005/train/csharp
/// </remarks>

using System.Collections.Generic;
using System.Linq;

namespace CW_CSharp.Katas.Rank.Kyu6
{
    public class RomanDecode
    {



        public static int FromRoman(string roman)
        {
            var decNum = roman.Select(x => EqRom()[x]);
            return decNum.Zip(decNum.Skip(1), (curr, next) => curr >= next ? curr : -curr).Sum() + decNum.LastOrDefault();
        }

        private static Dictionary<char, int> EqRom()
            => new Dictionary<char, int>()
                {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 },
                };



    public static int FromRoman_2(string roman)
        {
            int[] decNum = new int[roman.Length];
            int result = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                decNum[i] = EqRom_2(roman[i].ToString());
            }

            if (decNum.Length >= 1) { result = decNum[decNum.Length - 1]; }

            for (int i = 0; i < (decNum.Length - 1); i++)
            {
                if (decNum[i] >= decNum[i + 1])
                {
                    result += decNum[i];
                }
                else
                {
                    result -= decNum[i];
                }
            }


            return result;
        }
        private static int EqRom_2(string roman)
        {

            switch (roman.ToUpper())
            {
                case "I": return 1;
                case "V": return 5;
                case "X": return 10;
                case "L": return 50;
                case "C": return 100;
                case "D": return 500;
                case "M": return 1000;
                default: return 0;
            }
        }

    }
}
