using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.For.Foreach.While
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////// FOR FOR FOR FOR FOR //////////////////
            //for (итератор;условие;изменение)
            //{
            //
            //}
            //for(int i = 0; i < 10; i++) // i += 5 шаг на 5 // i-=5 // вместо int можно писать var
            //{
            //
            //}

            ////////// FOR FOR FOR FOR FOR //////////////////
            /*var list = new List<int>();
            for (var i = 0; i <10; i+=2)
            {
                list.Add(i);
            }
            for (var i = 0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }
            Console.ReadLine();*/

            ////////// While While While While While //////////////////
            //while (условие)
            //{
            //
            //}

            ////////// While While While While While //////////////////
            /*var list = new List<string>();
            while (list.Count<5)
            {
                list.Add(Console.ReadLine());
            }

            var i = 0;
            while (i<list.Count)
            {
                Console.WriteLine(list[i]);
                i++;
            }
            Console.ReadKey();*/

            //////////////Do While Do While Do While //////////////////// - предусловие
            /*var list = new List<string>();
            while (list.Count < 5)
            {
                list.Add(Console.ReadLine());
            }
            var i = 0;
            do// тут 
            {
                Console.WriteLine(list[i]);
                i++;
            }
            while (i < list.Count);
            Console.ReadKey();*/

            //////////////////////FOREACH FOREACH FOREACH /////////////////////////////////////
            //var list = new List<string>();
            //foreach (элемент in коллекция) // элемент внутри цикла
            //{
            //
            //}

            //////////////////////FOREACH FOREACH FOREACH /////////////////////////////////////
            /*var list = new List<string>();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0, 100).ToString());
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);  
            }*/

            ///////////////////Break Break Break////////////////////
            /*var list = new List<string>();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0, 100).ToString());
                break;// цикл завершился вышли из цикла
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }*/

            ///////////////////continue continue continue continue continue////////////////////
            /* var list = new List<string>();
             var rnd = new Random();
             for (int i = 0; i < 10; i++)
             {
                 continue;// перескакиваем на новый круг после него не выполнится 
                 list.Add(rnd.Next(0, 100).ToString());

             }
             foreach (var item in list)
             {
                 Console.WriteLine(item);
             }*/

            ////////////////// вложенные циклы ////////////////////
           /* int[,] mas = new int[10, 10];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j  < length; j ++)
                {
                    mas[i, j] = 8;
                }
            }*/

            Console.ReadKey();
        }
    }
}
