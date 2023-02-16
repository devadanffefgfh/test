using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreatList();
            var result1 = list.Where(x=>x.Age>40).ToList();
            var result2 = list.Where(x => x.Age > 40).ToArray();

            var result3 = list.Where(x => x.Age > 40).ToDictionary(x => x.Name);
            foreach(var item in result3)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"{item.Value.Name}--{item.Value.Age}");
            }
            Console.WriteLine("------------");
            var result4 = list.ToDictionary(x => x.Name, y=>y.Age);
            foreach(var item in result4)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
        static List<MyData> CreatList()
        {
            return new List<MyData>()
            {
                new MyData {Name = "Bill",Age=47},
                new MyData {Name = "John",Age=37},
                new MyData {Name = "Tom",Age=48},
                new MyData {Name = "David",Age=36},
              
            };
        }
    }
}
