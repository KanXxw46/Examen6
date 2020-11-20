using System;
using System.Net;

namespace Examen666
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Создавать посты. ");
            Console.WriteLine("2. Получать список постов. ");
            Console.WriteLine("3. Получать 1 пост. ");

            int m = int.Parse(Console.ReadLine());

            switch (m)
            {
                case 1:
                    {
                        Console.WriteLine("1. Создавать посты.");
                        var getRequest = new WebRequest.Create("https://jsonplaceholder.typicode.com/todos/1");
                        getRequest.Method = "POST";
                        
                    }
                case 2:
                    {
                        Console.WriteLine("2. Получать список постов.");
                        var getRequest = new WebRequest.Get("https://jsonplaceholder.typicode.com/todos/1");
                        getRequest.Method = "/posts";
                        var getResponse = getRequest.GetResponse() as HttpWebResponse;
                        using (var stream = StreamReader(getResponse.GetResponseStream()))
                            {
                            do
                            {
                                Console.WriteLine(stream.ReadToEnd());
                            }
                            while (false);
                            
                        }
                        getResponse.Close();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("3. Получать 1 пост.");
                        var getRequest = new WebRequest.Get("https://jsonplaceholder.typicode.com/todos/1");
                        getRequest.Method = "/posts/1";
                        var getResponse = getRequest.GetResponse() as HttpWebResponse;
                        using (var stream = StreamReader(getResponse.GetResponseStream()))
                        {
                            do
                            {
                                Console.WriteLine(stream.ReadToEnd());
                            }
                            while (false);

                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("вы ничего не выбрали.(нет такого варианта)");
                        break;
                    }
            }
        }
    }
}
