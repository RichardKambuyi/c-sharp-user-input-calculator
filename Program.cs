
 //User number input
Console.WriteLine("Enter the first number?");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.WriteLine("Enter the second number?");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

//Process calculation
int addition = number1 + number2;
int subtract = number1 - number2;
int multiply = number1 * number2;
int division = number1 / number2;

// Display the results
Console.WriteLine("The results are:");
Console.WriteLine($"Addition: {addition}");
Console.WriteLine($"Subtraction: {subtract}");
Console.WriteLine($"Multiplication: {multiply}");
Console.WriteLine($"Division: {division}");


   
