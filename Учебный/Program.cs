using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Учебный
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int programCount;
            int money;
            int time;
            bool truth;

            name = "Михаил";
            age = 33;
            programCount = 2;
            money = 100;
            time = 50;
            truth = true;

            Console.WriteLine("Здравствуйте, меня зовут " + name + ".");
            Console.WriteLine("Мне " + age + " лет.");
            Console.WriteLine("Я хочу научиться делать игры, это моя " + programCount + " программа на языке C#.");
            Console.WriteLine("Когда я закончу обучение я хочу зарабатывать " + money + " денег в " + time + " наносекунд.");
            Console.WriteLine("Достигну ли я желаемого? " + truth + "!");
        }
    }
}
