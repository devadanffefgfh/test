using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LineqSample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreatList();




            try //First找不到例外處理
            {
                var person1 = list.First((x) => x.Age < 30);
                Console.WriteLine($"小於37歲的人第一個被找到的是{person1.Name}");
            }
            catch(Exception ex)
            {
                
                Console.WriteLine("null");
            }

            var person2 = list.FirstOrDefault((x) => x.Age < 30);
            
            if(person2==null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"小於37歲的人第一個被找到的是{person2.Name}");
            }
            



            //var person2 = list.First((x) => x.Age < 37);
            //Console.WriteLine($"小於37歲的人第一個被找到的是{person2.Name}");
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
