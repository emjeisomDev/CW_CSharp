/// <summary>
/// Weight-based ordering for FFC members' numbers — <c>WeightOrder</c> (suggested class name).
/// </summary>
/// <remarks>
/// My friend John and I are members of the "Fat to Fit Club (FFC)". John is worried because each month a list with the weights of members is published and each month he is the last on the list which means he is the heaviest.
/// </remarks>
/// <remarks>
/// I am the one who establishes the list so I told him: "Don't worry any more, I will modify the order of the list". It was decided to attribute a "weight" to numbers. The weight of a number will be from now on the sum of its digits.
/// </remarks>
/// <remarks>
/// For example 99 will have "weight" 18, 100 will have "weight" 1 so in the list 100 will come before 99.
/// </remarks>
/// <remarks>
/// Given a string with the weights of FFC members in normal order can you give this string ordered by "weights" of these numbers?
/// </remarks>
/// <example>
/// Input: "56 65 74 100 99 68 86 180 90"
/// Output: "100 180 90 56 65 74 68 86 99"
/// </example>
/// <remarks>
/// When two numbers have the same "weight", let us class them as if they were strings (alphabetical ordering) and not numbers: 180 is before 90 since, having the same "weight" (9), it comes before as a string.
/// </remarks>
/// <remarks>
/// All numbers in the list are positive numbers and the list can be empty.
/// </remarks>
/// <remarks>
/// Notes: it may happen that the input string have leading, trailing whitespaces and more than a unique whitespace between two consecutive numbers.
/// </remarks>
/// <remarks>
/// For C: The result is freed.
/// </remarks>
// ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- -----
// ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- -----
/// <summary>
/// Ordenação por “peso” dos números dos membros do FFC — <c>WeightOrder</c> (nome sugerido para a classe).
/// </summary>
/// <remarks>
/// Meu amigo John e eu somos membros do "Fat to Fit Club (FFC)". John está preocupado porque todo mês é 
/// publicada uma lista com os pesos dos membros e, em cada mês, ele aparece por último na lista, o que significa que é o mais pesado.
/// </remarks>
/// <remarks>
/// Eu sou quem define a lista, então disse a ele: "Não se preocupe mais, vou modificar a ordem da lista". Ficou decidido atribuir um "peso" 
/// aos números. O peso de um número será, a partir de agora, a soma de seus dígitos.
/// </remarks>
/// <remarks>
/// Por exemplo, 99 terá "peso" 18, 100 terá "peso" 1; portanto, na lista, 100 virá antes de 99.
/// </remarks>
/// <remarks>
/// Dada uma string com os pesos dos membros do FFC em ordem normal, você pode devolver essa string ordenada pelos "pesos" desses números?
/// </remarks>
/// <example>
/// Entrada: "56 65 74 100 99 68 86 180 90"
/// Saída: "100 180 90 56 65 74 68 86 99"
/// </example>
/// <remarks>
/// Quando dois números tiverem o mesmo "peso", classifique-os como strings (ordem alfabética) e não como números: 180 vem antes de 90, pois, 
/// tendo o mesmo "peso" (9), aparece antes como string.
/// </remarks>
/// <remarks>
/// Todos os números da lista são positivos e a lista pode estar vazia.
/// </remarks>
/// <remarks>
/// Observações: pode acontecer de a string de entrada ter espaços em branco no início ou no fim e mais de um espaço entre dois números consecutivos.
/// </remarks>
/// <remarks>
/// Para C: O resultado é liberado (free).
/// https://www.codewars.com/kata/55c6126177c9441a570000cc/train/csharp
/// </remarks>

using System;
using System.Linq;
using System.Collections.Generic;
using CW_CSharp.Printers;


namespace CW_CSharp.Katas.Rank.Kyu5
{
    public class WeightSort
    {
        public static string orderWeight(string strng)
        {
            if (strng.Equals(string.Empty)) return "String vazia";

            List<SortWeight> sums = new List<SortWeight>();
            var newOrder = strng.Split(" ").ToArray();

            for (int i = 0; i < newOrder.Length; i++)
            {
                sums.Add(
                    new SortWeight
                    {
                        NewWeight = (int)newOrder[i].Select(c => Convert.ToInt64(c.ToString())).Sum(),
                        CurrWeight = newOrder[i]
                    }
                );
            }

            return string.Join(" ", sums.OrderBy(cw => cw.NewWeight).ThenBy(nw => nw.CurrWeight).Select(nw => nw.CurrWeight).ToList());
        }
    }

    public class SortWeight
    {
        public string CurrWeight { get; set; }
        public int NewWeight { get; set; }
    }


}
