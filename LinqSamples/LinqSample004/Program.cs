using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreatList();
            var person1 = list.SingleOrDefault((x)=>x.Age>47);
            Console.WriteLine($"大於47歲的人唯一符合{person1.Name}");

            var person2 = list.Single((x) => x.Age > 47);
            Console.WriteLine($"大於47歲的人唯一符合{person2.Name}");


            int index = 1;
            var person3 = list.ElementAtOrDefault(index);
            if(person3 == null )
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為:{index}的人是{person3.Name} - {person3.Age}");
            }

            string name = "David";
            bool result = list.Any((x) => x.Name == name);
            if(result )
            {
                Console.WriteLine($"找到了:{name}");
            }
            else
            {
                Console.WriteLine($"找不到:{name}");
            }
            string namebill = "Bill";
            bool isAllBill = list.All((x) => x.Name == namebill);
            if(isAllBill )
            {
                Console.WriteLine($"全部都是{namebill}");
            }
            else
            {
                Console.WriteLine($"有些人不叫{namebill}");
            }
            
            int total = list.Sum((x)=>x.Age);
            Console.WriteLine($"年齡總和{total}");
            var minAge = list.Min((x) => x.Age);
            Console.WriteLine($"年齡最小{minAge}");
            var maxAge = list.Max((x) => x.Age);
            Console.WriteLine($"年齡最大{maxAge}");
            //Count和Count()是不一樣
            int count = list.Count();
            Console.WriteLine($"list總個數為{count}");
            int countOfBill = list.Count((x) => x.Name == "Bill");
            Console.WriteLine($"list中的Bill總數量為:{countOfBill}");
            var average = list.Average((x) => x.Age);
            Console.WriteLine($"年齡的平均值為{average}");

            var min = list.Where((x)=>x.Name=="Bill").Min(x=>x.Age);
            Console.WriteLine($"叫Bill的人中年齡最小的{min}");

            var Billtotal = list.Where((x) => x.Name == "Bill").Sum(x => x.Age);
            Console.WriteLine($"叫Bill的人中年齡的總和{Billtotal}");

            var Billaverage = list.Where((x) => x.Name == "Bill").Average(x => x.Age);
            Console.WriteLine($"叫Bill的人中年齡的平均值{Billaverage}");

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
