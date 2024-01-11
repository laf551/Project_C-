using System; 

namespace ApplicationConsole {   /** Object name **/
    class Program {
        static void Main (string[] args){
          Console.WriteLine("Hello World");
            
            Habit_Tracker heure = new Habit_Tracker(); 
            Console.WriteLine(heure.msg) ;
        }
    }
    class Habit_Tracker {
        public string msg = "You slept at 7h"; 
        
        
    }
   
}

}