using System;
namespace classAssignment
{

    public class Parent : Person
    {
        public Parent(string name, string CHILD, int age): base(name, age)
        {
            Console.WriteLine("You are the parent of "+CHILD + " and your name is "+name );
            Console.WriteLine("You are "+ age + " years old.");
        }


            int  _BadlifeChoices = 2;

            public int BadlifeChoices
            {
                get
                {
                    return _BadlifeChoices;
                }

                set
                {
                    _BadlifeChoices = value;
                }
            }



    }

}


