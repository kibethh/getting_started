using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //StringBuilder stringBuilder = new StringBuilder(5);
            //StringBuilder stringBuilder = new StringBuilder("Hello World");
            //StringBuilder stringBuilder = new StringBuilder(5, 20);
            //StringBuilder stringBuilder = new StringBuilder("Hello", 0, 5);
            StringBuilder stringBuilder = new StringBuilder("Hello", 0, 5, 10);
            stringBuilder.AppendLine("Hello");
            stringBuilder.AppendLine("Hello");
            /*stringBuilder.AppendLine("Hello");
            stringBuilder.AppendLine("World");
            stringBuilder.Insert(stringBuilder.Length, "Hi" + Environment.NewLine, 5);
            stringBuilder.Replace("Hi", "Hello");
            stringBuilder.Remove(0, 7);
            stringBuilder.Clear();*/

            string message = "";
            message += "Hello" + Environment.NewLine;
            message += "World" + Environment.NewLine;
            message += "Hello" + Environment.NewLine;
            message += "World" + Environment.NewLine;

            for (int i = 0; i < 5; i++)
            {
                message += "Hi" + Environment.NewLine;
            }

            message = message.Replace("Hi", "Hello");
            message = message.Remove(0, 7);
            message = "";

            Console.WriteLine(stringBuilder);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
