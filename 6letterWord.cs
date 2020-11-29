using System;
 
class MainClass {
 public static void Main (string[] args) {
   Console.WriteLine ("What is your 6 letter word");
   var word = Console.ReadLine();
   Console.WriteLine (word.Substring(1,1));
   Console.WriteLine (word.Substring(3,1));
   Console.WriteLine (word.Substring(5,1));
 }
}
//Input a 6-letter word and output the 2nd, 4th and 6th characters
