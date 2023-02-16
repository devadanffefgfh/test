using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var list = CreatList();
            var person1 = list.LastOrDefault((x) => x.Age > 35);
            Console.WriteLine($"大於35歲的人最後一個是{person1.Name}");

            //因為找不到，跳出例外
            var person2 =list.Last((x) => x.Age > 45);
            Console.WriteLine($"大於50歲的人最後一個是{person2.Name}");
            Console.ReadKey();
        }
        static List<MyData> CreatList()
        {
            return new List<MyData>()
            {
                new MyData {Name = "Bill",Age=47},
                new MyData {Name = "John",Age=37},
                new MyData {Name = "Tom",Age=48},
                new MyData {Name = "David",Age=36},
                new MyData {Name = "Bill",Age=35},
            };
        }
    }
}
