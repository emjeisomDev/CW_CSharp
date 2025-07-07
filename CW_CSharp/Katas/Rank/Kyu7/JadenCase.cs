/// <summary>
/// This method converts a string into "Jaden case", which means capitalizing every word in the string, similar to how Jaden Smith
/// types his philosophical tweets. The method ensures that contractions such as "aren't" are properly capitalized while keeping the
/// first letter of each word in uppercase.
/// </summary>
/// <param name="text">A string containing the quote or sentence to be converted into Jaden case.</param>
/// <returns>A new string where each word is capitalized, following the capitalization style typically used by Jaden Smith.</returns>
/// <example>
/// For example:
///  - ToJadenCase("How can mirrors be real if our eyes aren't real") will return "How Can Mirrors Be Real If Our Eyes Aren't Real".
/// </example>
/// <summary>
/// Este método converte uma string para o "Jaden case", o que significa capitalizar cada palavra na string, de forma semelhante a como
/// Jaden Smith escreve suas frases filosóficas no Twitter. O método garante que contrações como "aren't" sejam corretamente capitalizadas,
/// mantendo a primeira letra de cada palavra em maiúscula.
/// </summary>
/// <param name="texto">Uma string contendo a citação ou frase a ser convertida para o Jaden case.</param>
/// <returns>Uma nova string onde cada palavra é capitalizada, seguindo o estilo de capitalização tipicamente usado por Jaden Smith.</returns>
/// <example>
/// Por exemplo:
///  - ParaJadenCase("How can mirrors be real if our eyes aren't real") retornará "How Can Mirrors Be Real If Our Eyes Aren't Real".
/// </example>

using System.Globalization;

namespace CW_CSharp.Katas.Rank.Kyu7
{
    public class JadenCase
    {
        public static string ToJadenCase(string phrase)
            => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase.ToLower());
    }
}
