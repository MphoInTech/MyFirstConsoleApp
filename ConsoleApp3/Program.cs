using System;

namespace Program
{
    class ConsoleApp
    {
        static void Main(string[] args) {

            Console.Write("Hi, this is my first console program.\nI'm new here so please be kind, here is what I\'ve learnt so far: ");
            Console.WriteLine("1. Data Types - There are 5 data types in c#.");

            int age = 21;
            double cash = 17.50;
            char userName= '@';
            string name= "Mpho";
            bool gender = false;

            Console.WriteLine("Yes, I did this all by myself...Here is the result.");
            Console.WriteLine("My name is " + name + ",I am " + age + " years old.");
            Console.WriteLine("Currently I have R " + cash + " in my pocket.You are probably asking yourself how that is relevant...Well I just thought I could share.");
            Console.WriteLine("Am i male ? " + gender + "\nThen what am I ?");
            Console.WriteLine("Here is my username: " + userName + name);

            Console.ReadKey();
            Console.Beep();
        }
    }

}