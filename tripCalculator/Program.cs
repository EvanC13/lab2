//Part 1:
/*
//Input for Part 1
System.Console.Write("How many miles for your trip? ");
double tripMiles = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How many miles per gallon can your car go? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How much is one gallon of gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

//Calculations for Part 1

double gallonsNeeded = tripMiles / milesPerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print Calculations
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

//Part 2

const double pizzaSlices = 8;
System.Console.Write("How many people are going? ");
double peopleGoing = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How many pizzas? ");
double numberOfPizzas = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Price per pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//Calculations for Part 2

double totalSlices = numberOfPizzas * pizzaSlices;
double slicesPerPerson = totalSlices / peopleGoing;
double pizzaCost = numberOfPizzas * pricePerPizza;

//Print for Part 2

System.Console.WriteLine("Total slices: " + totalSlices.ToString("F0"));
System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
*/
//Part 3

System.Console.Write("How many hours have you worked this week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How much do you make an hour? ");
double payRate = Convert.ToDouble(Console.ReadLine());

const double taxRate = 0.18;

//Calculations for Part 3

double grossPay = hoursWorked * payRate;
double taxWithheld = grossPay * taxRate;
double takeHome = grossPay - taxWithheld;

//Print for Part 3
System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home: " + takeHome.ToString("C"));