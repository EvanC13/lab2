//Part 1:

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