//-Transforme o trecho abaixo em forma de documentação em C#
//-Faça uma documentação no idioma original.
//-Faça uma documentaçã em português pt-br. 
//-Caso o idioma original seja pt-br faça apenas em pt-br.
//-NÃO FAÇA NENHUM CÓDIGO. APENAS A DOCUMENTAÇÃO.
//-NÃO INTERPRETE O QUE DEVE SER FEITO. APENAS TRANSFORME O TEXTO NO FORMATO DE DOCUMENTAÇÃO DE CÓDIGO
//-Dê um nome intuitivo para a classe
// ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- -----
// ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- -----
//Otimize o código C# abaixo utilizando o mínimo de linhas de código possível
//Dê preferência ao LINQ e funções LAMBDA

using CW_CSharp.Katas.Rank.Kyu6;

internal class Program
{
    private static void Main(string[] args)
    {
        string word = "(( @";
        string Newword = ParenthesesDecoding.DuplicateEncode2(word);
        Console.WriteLine($"{word} was decoded to {Newword}.");
    }
}