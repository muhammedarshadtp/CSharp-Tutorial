
// int num1 = 10;
// long num2 = 12345;
// float num3 = 1.42f;
// double num4 = 2.234566;
// bool boolum = false;
// char A = 'b';
// string abc = "Arshad";

// Console.WriteLine(num1);
// Console.WriteLine(num2);
// Console.WriteLine(num3);
// Console.WriteLine(num4);
// Console.WriteLine(boolum);
// Console.WriteLine(A);
// Console.WriteLine(abc);



// Arithmetic operation

// int a = 30;
// int b = 20;

// Console.WriteLine(a + b);- 50
// Console.WriteLine(a - b);- 10
// Console.WriteLine(a * b);- 600
// Console.WriteLine(a / b);- 1
// Console.WriteLine(a % b);- 10

// Relational 

// int a = 30;
// int b = 20;

// Console.WriteLine(a < b);- false
// Console.WriteLine(a > b);- true
// Console.WriteLine(a <= b);- false
// Console.WriteLine(a >= b);- true
// Console.WriteLine(a == b);- false 
// Console.WriteLine(a != b);- true          


// Logical

//  int a = 30;
// int b = 20;

// Console.WriteLine(a == 30 && b == 20);- true
// Console.WriteLine(a == 10 || b == 20);- true
// Console.WriteLine(!(a == 30));- false


// Assignment

// int a = 10;
// Console.WriteLine(a); 10

// int b = 20;
// b += 10;
// Console.WriteLine(b); 30

// int c = 20;
// c -= 10;
// Console.WriteLine(c); 10

// int d = 20;
// d *= 10;
// Console.WriteLine(d); 200

// int e = 20;
// e /= 10;
// Console.WriteLine(e); 2



// unary

// int a = 10;
// a++;
// Console.WriteLine(a); 11

// int a = 10;
// a--;
// Console.WriteLine(a); 9


// Ternary

// int a = 10;

//  String result =a > 9 ? "positive number" : "Negative number";

// Console.WriteLine(result);


//  userInputs

// Console.WriteLine("Enter your name:");
// string? name = Console.ReadLine();
// Console.WriteLine("Your name is "  +  name);

// Console.WriteLine("enter a number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("your number is  " + number);


// Convert.ToInt32()   // Convert to int
// Convert.ToDouble()  // Convert to double
// Convert.ToString()  // Convert to string
// Convert.ToBoolean() // Convert to bool


//  IF statement

// Console.WriteLine("Enter Your Age:");
// int age = Convert.ToInt32(Console.ReadLine());

// if(age >= 18)
// {
//     Console.WriteLine("Permission Granted");
// }


//  If else statement 

// Console.WriteLine("Enter Your Age:");
// int age = Convert.ToInt32(Console.ReadLine());

// if(age >= 18)
// {
//     Console.WriteLine("Permission Granted");
// }
// else
// {
//   Console.WriteLine(" No Permission ");  
// }


//  If else If statement

// Console.WriteLine("Enter Your State:");
// string? place = Console.ReadLine();

// if(place == "kerala")
// {
//     Console.WriteLine("Your language is malayalam");
// }else if(place== "tamil")
// {
//     Console.WriteLine("Your language is tamil");
// }else if(place == "karnadaka")
// {
//     Console.WriteLine("Your language is karanadake");
// }
// else
// {
//     Console.WriteLine("Your language is " + place + " language");
// }

// Console.WriteLine("South or North");
// string? part = Console.ReadLine();

// if(part == "South")
// {
//    Console.WriteLine("Enter Your State:");
// string? place = Console.ReadLine();

// if(place == "kerala")
// {
//     Console.WriteLine("Your can speak malayalam");
// }else if(place== "tamil")
// {
//     Console.WriteLine("Your can speak tamil");
// }else if(place == "karnadaka")
// {
//     Console.WriteLine("Your can speak karanadake");
// } 
// }
// else
// {
//     Console.WriteLine("Your can speak Hindhi");
// }


// for Loop

// for(int i = 1; i <= 5; i++)
// {
//     Console.WriteLine("hai");
// }

//  While Loop

// int i = 1;

// while (i <= 5)
// {
//     Console.WriteLine("Hello");
//     i++;
// }

//  Do While Loop

// int i = 1;

// do
// {
//     Console.WriteLine("Hai");
//     i++;
// } while (i<=5);



//  Switch Statement

// Console.WriteLine("Enter an Alphabet :");
// string? letter = Console.ReadLine();

// switch (letter)
// {
//     case "A":
//         Console.WriteLine("Apple");
//         break;

//     case "B":
//         Console.WriteLine("Bat");
//         break;
//     case "C":
//         Console.WriteLine("Cat");
//         break;
//     case "D":
//         Console.WriteLine("Dog");
//         break;    

//     default:
//         Console.WriteLine("Invalid Alphabet");
//         break;
// }