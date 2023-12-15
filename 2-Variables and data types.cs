using System;

class HelloWorld {
    
  static void Main() {
    // Variables and data types
    // int
    int id = 132;
    // string
    string name = "Jon Snow";
    // double
    double cgpa = 3.33;
    // grade
    char grade = 'A';
    // boolean
    bool isStudent = true;
    
    // Displaying variables
    Console.WriteLine("Name: "+name);
    Console.WriteLine("Id: "+id);
    Console.WriteLine("Cgpa: "+cgpa);
    Console.WriteLine("Grade: "+grade);
    Console.WriteLine("Enrolled: "+isStudent);
    
    // Constant
    const int this_is_a_const_var = 1;
    // this_is_a_const_var = 2;
    Console.WriteLine(this_is_a_const_var);
    
    
    //Multiple variables
    int a = 1, b = 2, c = 3;
    Console.WriteLine("a="+a+" b="+b+" c="+c);
    
    //Type Casting
    int num = 5;
    double d = 3.3;
    // Explicit Casting
    Console.WriteLine((int)d);
    Console.WriteLine((double)num);
    // Type Conversion Methods
    Console.WriteLine(Convert.ToDouble(num));
    Console.WriteLine(Convert.ToString(num));
    
  }
  
}