using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list1=new List<int> { 1,2,3,4,5,6};
            var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };
            var union = list1.Union(list2);
            Console.WriteLine("聯集結果為:");
            foreach (var item in union)
                Console.Write($"{item} ");
            var intersect = list1.Intersect(list2);
           
            Console.WriteLine("\n交集結果為:");
            foreach (var item in intersect)
                Console.Write($"{item} ");

            var aExb=list1.Except(list2);
            Console.WriteLine("A差集B結果為:");
            foreach (var item in aExb)
                Console.Write($"{item} ");

            var bExa = list2.Except(list1);
            Console.WriteLine("\nB差集A結果為:");
            foreach (var item in bExa)
                Console.Write($"{item} ");
            Console.WriteLine();
            var list = new List<string> { "台北", "台北", "洛杉磯", "紐約", "紐約" };
            var result = list.Distinct();
            foreach (var item in result)
                Console.WriteLine(item);

            var list_s = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
            var resultOfSkip = list_s.Skip(3);
            Console.WriteLine($"Skip(3)的結果");
            Display(resultOfSkip);
            Console.WriteLine();
            var resultOfTake = list_s.Take(3);
            Display(resultOfTake);
            Console.WriteLine();
            var resultOfSkipTake = list_s.Skip(2).Take(2);
            Display(resultOfSkipTake);



            Console.ReadKey();
        }
        static void Display (IEnumerable<string> source)
        {
            foreach(var item in source)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
