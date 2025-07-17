/// <summary>
/// This method converts an unsigned 32-bit number into its equivalent IPv4 address representation. The input number is treated
/// as a 32-bit integer, where each 8-bit section (octet) is translated into its corresponding value to form a valid IPv4 address.
/// The resulting address is returned in the standard dot-decimal notation.
/// 
/// Example:
///  - convertToIPv4(2149583361) will return "128.32.10.1".
///  - convertToIPv4(32) will return "0.0.0.32".
///  - convertToIPv4(0) will return "0.0.0.0".
/// </summary>
/// <param name="num">The unsigned 32-bit number to be converted into an IPv4 address.</param>
/// <returns>A string representing the corresponding IPv4 address in dot-decimal notation.</returns>
/// ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- -----
/// ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- -----
/// <summary>
/// Este método converte um número inteiro sem sinal de 32 bits em sua representação equivalente de endereço IPv4. O número de entrada
/// é tratado como um inteiro de 32 bits, onde cada seção de 8 bits (octeto) é traduzida para o valor correspondente para formar um 
/// endereço IPv4 válido. O endereço resultante é retornado na notação padrão de ponto decimal.
/// 
/// Exemplo:
///  - convertToIPv4(2149583361) retornará "128.32.10.1".
///  - convertToIPv4(32) retornará "0.0.0.32".
///  - convertToIPv4(0) retornará "0.0.0.0".
/// </summary>
/// <param name="num">O número inteiro sem sinal de 32 bits a ser convertido para um endereço IPv4.</param>
/// <returns>Uma string representando o endereço IPv4 correspondente na notação de ponto decimal.</returns>
/// https://www.codewars.com/kata/52e88b39ffb6ac53a400022e/train/csharp
using System;
using System.Collections.Generic;
using System.Text;


namespace CW_CSharp.Katas.Rank.Kyu5
{
    internal class IPv4Converter
    {
        /// <summary>
        /// Converte um número inteiro sem sinal de 32 bits em um endereço IPv4 na notação de ponto decimal.
        /// </summary>
        /// <param name="num">O número inteiro sem sinal de 32 bits a ser convertido.</param>
        /// <returns>Uma string representando o endereço IPv4.</returns>
        
        public static string UInt32ToIP(uint ip)
        {
            string binNumber = $"{ip:B32}";
            int byteLen = 8;
            var ipv4 = binNumber.Select((c, index) => new { Char = c, Index = index })
                                .GroupBy(x => x.Index / byteLen)
                                .Select(g => new string(
                                                            g.Select(x => x.Char).ToArray()
                                                       )
                                )
                                .Select(g => Convert.ToInt32(g, 2));
            return string.Join(".", ipv4);
        }

        public static string UInt32ToIP_2(uint ip)
        {
            StringBuilder ipv4 = new StringBuilder();
            string binNumber = $"{ip:B32}";
            for (int i = 0; i < binNumber.Length; i++)
            {
                if ((i + 1) % 8 == 0)
                {
                    int decNumber = Convert.ToInt32(binNumber.Substring(i - 7, 8), 2);
                    ipv4.Append(decNumber);
                    ipv4.Append(".");
                }
            }
            return ipv4.ToString().Remove(ipv4.ToString().Length-1);
        }


    }
}
