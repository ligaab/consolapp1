// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





Console.WriteLine("Kā tevi sauc?");
string userInput = Console.ReadLine();
Console.WriteLine("Sveiks," + userInput);


Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();


Console.WriteLine("Kāds ir tavs vecums?");
int userNumber = int.Parse(Console.ReadLine());
int addedToUserNumber = userNumber + 1;
Console.WriteLine("Nākamgad tev paliks" + addedToUserNumber);



Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();



Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi ceturto skaitli");
int fourthNumber = int.Parse(Console.ReadLine());

int firstMaxNumber = Math.Max(firstNumber, secondNumber);
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);

Console.WriteLine(maxNumber);



Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();


int firstMinNumber = Math.Min(firstNumber, secondNumber);
int secondMinNumber = Math.Min(firstNumber, thirdNumber);
int minNumber = Math.Min(firstMinNumber, secondMinNumber);
Console.WriteLine(minNumber);


Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();

int result = firstNumber % secondNumber;
Console.WriteLine(result);



Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();


Console.WriteLine("Lūdzu, ievadi skaitli");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis:" + isEven);


Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();



int area = firstNumber * secondNumber;
Console.WriteLine(area);



Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();


Console.WriteLine("Lūdzu ievadi trīstūra malas garumu");
int number1 = int.Parse(Console.ReadLine());

int area1 = number1 * number1 / 2;
Console.WriteLine(area1);


Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();


Console.WriteLine("Lūdzu ievadi savu vārdu");
string userName1 = Console.ReadLine();
Console.WriteLine("Lūdzu ievadi savu vecumu");
int userAge = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks {userName1}, tavs vecums ir {userAge}.");









