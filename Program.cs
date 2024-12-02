// // See https://aka.ms/new-console-template for more information

// // namespace variables{
// //     class Program{
// //         static void Main(string[] args){
// //             Console.WriteLine(args[0]);
// //             Console.WriteLine(args[1]);

// //             Console.WriteLine("Hello, World!");
// //             Console.ReadLine();
// //         }
// //     }
// // }


// // Variables:

// // String
// using static System.Console;

// string firstName = String.Empty;
// string lastName;
// string age;
// var bio = "Lorem ipsum dolor sit amet, consectetur \n adipiscing elit. Sed do eiusmod tempor \t incididunt ut labore et dolore magna \t aliqua. Ut enim ad minim veniam.";
// // Console.WriteLine(bio);
// bio = """
//     Lorem ipsum dolor sit amet, consectetur
//     adipiscing elit. Sed do eiusmod tempor 
//     incididunt ut "labore" et dolore magna 
//     aliqua. Ut enim ad minim veniam.
// """;
// Console.WriteLine(bio);
// string esempio = "Esempio di stringa con caratteri speciali:\nNuovariga\tTabulazione\bBackspace";
// Console.WriteLine(esempio);



// Console.WriteLine("Enter your name:");
// firstName = ReadLine().Trim().ToLower();
// string rest = firstName.Substring(1);
// lastName = lastName.FirstOrDefault().ToString().ToUpper() + rest;

// Console.WriteLine("Enter your lastname:");
// lastName = ReadLine().Trim().ToUpper();

// Console.WriteLine("Enter your age:");
// age = Console.ReadLine();

// string message = "These are the data you entered:" + firstName + ", " + lastName + ", " + age;
// message = $"Your name is {firstName}, your last name is {lastName} and you are {age} years old";
// // message = String.Format("Your name is {0}, your last name is {1} and you are {2} years old", firstName, lastName, age);
// Console.WriteLine(message);

// var myName = "Gabriele    ";
// WriteLine(myName.ToLower());

// Char

// char myKey = 'A';
// char myChar = '\u0061';

// for(char c = 'A'; c <= 'Z'; c++){
//     Console.WriteLine(c);
// }

// Console.WriteLine("Please, press A, W, S or Z");
// char k = Console.ReadKey().KeyChar;
// Console.WriteLine($"You pressed {k}");

// string command = k.ToString();
// Console.WriteLine(command);


// Integer

// byte: 8 bit, da 0 a 255;
// sbyte: 8 bit, da -128 a 127;
// short: 16 bit, da -32.768 a 32767
// ushort: 16bit, da 0 a 65535;
// int: 32 bit, da -21478483648 a 2147483647,
// uint: 32 bit, da 0 a 4294967295
// long: 64 bit, da -9223372036854775808 a 9223372036854775807,
// ulong: 64 bit, da 0 a 18446744073709551615

// using System.Runtime.InteropServices;

// byte age = 36;
// Console.WriteLine($"You are {age} years old");
// var ageType = age.GetType();
// Console.WriteLine(ageType);
// var ageLength = Marshal.SizeOf(ageType);
// Console.WriteLine(ageLength);
// Console.WriteLine($"Age length {age.GetType()}");

// int myInt = 42;
// byte myByte = (byte) myInt;
// myByte = 45;
// // long è un integer che puo' gestire il valore di myByte quindi c'e' bisogno di conversione
// long myLong = myByte;
// // myLong essendo di tipo long deve essere convertito in tipo short anche se il valore contenuto al suo interno è gestibile dal tipo short
// short myShort = (short) myLong;

// Console.WriteLine("Insert your first number");
// string input = Console.ReadLine();
// bool res1 = int.TryParse(input, out int firstNumber);

// Console.WriteLine("Insert your second number");
// string secondInput = Console.ReadLine();
// // int secondNumber = int.Parse(secondInput);
// bool res2 = int.TryParse(secondInput, out int secondNumber);

// if(res1 && res2){
//     int result = firstNumber + secondNumber;
//     Console.WriteLine(result);
// } else {
//     Console.WriteLine($"Wrong numbers: {input}, {secondInput}");
// }

// Floating

// float floatNumber = 3.1415926465464651654165f;
// double doubleNumber = 3.14159264546546546565;
// decimal decimalNumber = 3.14159264565465465654m;

// // Console.WriteLine($"{floatNumber} \n {doubleNumber} \n {decimalNumber}");
// doubleNumber = floatNumber;
// decimalNumber = (decimal)floatNumber;
// Console.WriteLine(decimalNumber);

// float val1 = 0.1f, val2 = 0.2f;
// Console.WriteLine(val1 + val2);
// float res = val1 + val2;
// Console.WriteLine(res == 0.3f);

// double val3 = 0.1, val4 = 0.2;
// Console.WriteLine(val3 + val4);
// double res2 = val3 + val4;
// Console.WriteLine($"res2 = {res2}");
// Console.WriteLine(res2 == 0.3);

// decimal val5 = 0.1m, val6 = 0.2m;
// Console.WriteLine(val5 + val6);
// decimal res3 = val5 + val6;
// Console.WriteLine($"res3 = {res3}");
// Console.WriteLine(res3 == 0.3m);

// Console.WriteLine("Inserisci il raggio del cerchio");
// string input = Console.ReadLine();
// bool raggio = int.TryParse(input, out int r);

// float raggioFloat = r;
// float areaFloat = (float)(raggioFloat * raggioFloat * Math.PI);
// Console.WriteLine($"Area calcolata con float: {areaFloat}");

// double raggiodouble = r;
// double areaDouble = (double)(raggiodouble * raggiodouble * Math.PI);
// Console.WriteLine($"Area calcolata con double: {areaDouble}");

// decimal raggioDecimal = r;
// decimal areaDecimal = (decimal)(raggioDecimal * raggioDecimal * (decimal)Math.PI);
// Console.WriteLine($"Area calcolata con decimal: {areaDecimal}");


// Boolean

// bool lessThan21 = false;
// bool canContinue = true;

// Console.WriteLine("Inserire un numero");
// string input = Console.ReadLine();
// bool parsed = int.TryParse(input, out int number);

// if (parsed)
// {
//     bool isEven = number % 2 == 0;
//     if (isEven)
//     {
//         Console.WriteLine("4 is Even");
//     }
//     else
//     {
//         Console.WriteLine("It's odd");
//     }

// } else {
//         Console.WriteLine("Wrong input");
// }

// LISTE

// List<int> ints = new List<int>();
// ints.Add(12);
// for (int i = 0; i < 20; i++)
// {
//     ints.Add(i);
// }

// var myNumbers = new List<int>();

// var predifinedNumbers = new List<int>[1,2,3,4];

// foreach (var item in ints)
// {
//     Console.WriteLine(item);
// }

// // var fruits = new List<string> {"Apple", "Orange"};
// // List<string> fruits2 = new() {"Apple", "Orange"};
// List<string> fruits3 = ["Apple", "Orange"];
// Console.WriteLine("Type your favourite fruit");
// string fruit = Console.ReadLine();

// if(!string.IsNullOrEmpty(fruit)){
//     fruits3.Add(fruit);
// };

// string[] defaultFruits = ["Kiwi", "Papaya"];
// fruits3.Insert(0, "Pear");
// fruits3.AddRange(defaultFruits);

// fruits3.ForEach(ele => Console.WriteLine(ele));

// if(fruits3.Contains("Mango")){
//     Console.WriteLine("You love mangoes!");
// }

// List<int> numeri = new List<int> { 5, 7, 2, 8, 3 };

// int max = numeri.Max();
// Console.WriteLine(max);
// int min = numeri.Min();
// Console.WriteLine(min);

// HashSet

// var hobbies = new HashSet<string>();
// hobbies.Add("Chess");
// hobbies.Add("Guitar");
// List<string> myList = ["Running", "Reading", "Watching tv", "Running"];
// // myList.ForEach(Console.WriteLine);
// var newHobbies = new HashSet<string>(myList);
// hobbies.UnionWith(myList);
// foreach (var hobby in newHobbies)
// {
//     Console.WriteLine(hobby);
// }

// HashSet<string> animals = new HashSet<string>() {
//     "Cane", "Gatto", "Elefante", "Leone"
// };
// animals.Remove("Elefante");
// Console.WriteLine("HashSet aggiornato:\n" + string.Join("\n", animals));

// QUEUE

// Queue<int> queue = new();
// queue.Enqueue(1);
// queue.Enqueue(2);
// Console.WriteLine($"There are {queue.Count} elements, and the first is {queue.Peek()}");
// int current = queue.Dequeue();
// Console.WriteLine($"Element value {current}. There are {queue.Count} elements, and the first is {queue.Peek()}");
// queue.Clear();
// Console.WriteLine($"There are {queue.Count} elements");

// var data = new[] {1,2,3,4,5};
// // var queueElements = new Queue<int>(new []{1,2,3,4,5});
// var queueElements = new Queue<int>(data);
// Console.Clear();
// Console.WriteLine($"There are {queueElements.Count} elements, and the first is {queueElements.Peek()}");


