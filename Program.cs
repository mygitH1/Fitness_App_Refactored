using System;

class Program
{
    static void Main()
    {
      /*
      
      Goal for our Program:
      
      * Prompt the user for minutes excercised 
      * Add minutes excercised to total
      * Display total minutes excercised to the screen
      * Repeat until the user quits
      
      
      
      */
        
      var runningTotal = 0.0;
     
      
      while(true)
      {
      
      // * Prompt the user for minutes excercised 
      Console.WriteLine("Enter how many minutes you exercised or type \"quit\" to finish ");
      
      // Took the users value they entered and stored it in a variable 
      var entry = Console.ReadLine();
        
        // Value gets compared if the user enters quit
        if (entry.ToLower() == "quit" ) 
        { 
          
         break;
          
        }
        
          //converts value entered to an integer in case it is a string
          try{
            
            var minutes = double.Parse(entry);
            
            if (minutes <= 0){
            
           Console.WriteLine(minutes + " is not an acceptable value.");
            continue;
            
          }
          else if (minutes <= 10)
          {
            
           Console.WriteLine("Better than nothing, am I right?");
            
          }
          else if( minutes <= 30)
          {

            Console.WriteLine("Way to go hot stuff");
          }
          else if (minutes <= 60)
          {
           
           Console.WriteLine("You must be a ninja warrior in training");
            
          }
          else
          {

            Console.WriteLine("Okay, now you're just showing off!");
            
          }
          
          // Add minutes excercised to total
         runningTotal += minutes;
            
          }
          catch(FormatException)
          {
            
            Console.WriteLine("That is not valid input.");
            continue;
            
          }
         
          // Display the value with a sentence
          Console.WriteLine("You've entered "  + runningTotal + " minutes");
         
    }  
      
      Console.WriteLine("Goodbye");
  }
    
}
