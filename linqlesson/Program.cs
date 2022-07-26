using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqlesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<Product>();
            Random rnd = new Random();
            var collection1 = new List<int>();
            for(var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Prodyct" + 1,
                    Energy = rnd.Next(10, 500)
                };
                collection.Add(product);
            }
            var result3 = from item in collection
                          where item.Energy < 200
                          select item;

            var result4 = collection.Where(item => item.Energy < 200);

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            
            foreach(var item in result4)
            {
                Console.WriteLine(item);
            }


            for (var i = 0; i < 10; i++)
            {
                collection1.Add(i);
            }

            var result = from  item in collection1
                         where item < 5
                         select item;
            var rsesult2 = collection1.Where(item => item < 5);
            foreach(var item in rsesult2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            

            var selectCollection = collection.Select(product => product.Energy);
            foreach(var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            var OrederByCollection = collection.OrderBy(product => product.Energy) // sort collection
                                               .ThenBy(product => product.Name);
            
            foreach (var item in OrederByCollection) 
            {
                Console.WriteLine(item);
            }

            var GroupCollection = collection.GroupBy(product => product.Energy);
            foreach(var group in GroupCollection)
            {
                Console.WriteLine($"Ключ:{group.Key}");
                foreach(var item in group)
                {
                    Console.WriteLine($"\t{item}") ;
                }
                Console.WriteLine();
            }
            collection.Reverse(); // Reverse collection
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("revers");
            collection.Reverse();
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }

            var prod = new Product();
            Console.WriteLine(collection.All(item => item.Energy == 10)); //true and false // bool type 
            Console.WriteLine(collection.Any(item => item.Energy == 10)); // true and false //bool type
            Console.WriteLine(collection.Contains(prod)); // Проверка налижит он ли коленкции
            
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            var union = array.Union(array); //Union обеднуэ масивы без дубликатов 
            foreach(var item in union)
            {
                Console.WriteLine(item);
            }
            var intersect = array.Intersect(array);
            var except = array.Except(array);

            var sum = array.Sum();
            var min = array.Min();
            var aggregate = array.Aggregate((x, y) => x * y); //множим колекцию4
            var sum2 = array.Skip(1).Take(1).Sum(); //Skip - Пропуск елемента // Take - взять колл елеменлтов
            var first = array.First(); // First - Перевий елемент колекции // FirstofDeffal - null defender
            var last = array.Last(); // Last - Последный елемент из колекции
            var single = array.Single(a => a == 5);
            var elementat = collection.ElementAt(5);//Получить елемент по индексу
            
            Console.ReadKey();
        }
    }
}
