

using System;
namespace ApplicationConsole {
  
  class HelloWorld {
    
    static void Main () {
       
        Console.WriteLine ("Hello World");
        Habit_Tracker hour = new Habit_Tracker ();
        Person p = new Person ();
        DateTime yesterday = DateTime.Today.AddDays(-1);
        Console.WriteLine ("your fisrt name is {0} , and your last name is {1}. {2} {3 :d}"/*only day, :t only hour*/, p.firstName, p.lastName,hour.msg ,  yesterday );

    }
  }
   class Habit_Tracker {
        public string msg = "You slept at 9 a.m on";
    
  }
  class Person
  {
    public string firstName = "Phillipe";
    public string lastName = " Jean";
    public int age = 70 ; 
    
  }
}