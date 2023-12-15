using System;

class HelloWorld {
    
  static void Main() {
      
   Console.Write("Enter name: ");
   string name = Console.ReadLine();
   Console.Write("Enter id: ");
   int id = Convert.ToInt32(Console.ReadLine());
   Console.Write("Enter cgpa: ");
   double cgpa = Convert.ToDouble(Console.ReadLine());
   
   // Print
   Console.WriteLine("Name: "+name);
   Console.WriteLine("ID: "+id);
   Console.WriteLine("Cgpa: "+cgpa);
    
  }
  
}