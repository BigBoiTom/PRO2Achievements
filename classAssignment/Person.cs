using System;
namespace classAssignment
{
    public class Person
    {
        private string name = "noname";
        public int age = 0;
        public Person(string name, int age){
            //constructor
            this.name = name;
            this.age = age;

            Console.WriteLine("Hi there "+name + ". You are "+age+ " years old.");
        }
        
    }
}