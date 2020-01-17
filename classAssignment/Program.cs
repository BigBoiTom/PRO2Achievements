using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Erwin", "PRO2", 30);
            Teacher t2 = new Teacher("Erik", "PRO2", 24);
            Teacher t3 = new Teacher("Theo", "PRO1", 829);
            Teacher t4 = new Teacher("Milôs", "WVO", 34);

            Student s1 = new Student("Harry", "Mediadeveloper", 12);
            Student s2 = new Student("Donny", "Gamedeveloper", 20);
            Student s3 = new Student("Tomas", "Gamedeveloper", 18);

            Parent p1 = new Parent("Marco", "Tomas", 49);
            p1.BadlifeChoices = 33;
            Console.WriteLine("You have made " + p1.BadlifeChoices + " Bad Life Choices" );

        }
    }
}
