using System.Collections;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace CW_CSharp.Printers
{
    public class Print
    {
        public static void Array(Array arr)
        {
            if (arr is not Array array) return;

            if (array.Rank == 1)
                Console.WriteLine("{ " + string.Join(", ", array.Cast<object>()) + " }");

            else if (array.Rank == 2)
                Enumerable.Range(0, array.GetLength(0))
                    .ToList()
                    .ForEach(i => Console.WriteLine("{ " + string.Join(", ",
                        Enumerable.Range(0, array.GetLength(1))
                                  .Select(j => array.GetValue(i, j))) + " }"));
        }

        public static void Array(IEnumerable list) =>
            Console.WriteLine("{ " + string.Join(", ", list.Cast<object>()) + " }");

        public static void Dict(IDictionary dict)
        {
            var json = JsonSerializer.Serialize(dict, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            Console.WriteLine(json);
        }



    }
}
