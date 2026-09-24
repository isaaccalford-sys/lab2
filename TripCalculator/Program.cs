//part 1: Road Trip
Console.Write("How many miles are you driving ");
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon can your car go? ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much did you pay for gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());


//calculations
double gallonsNeeded = tripMiles / milePerGallon;
double fuelCost = gallonsNeeded / pricePerGallon;

//print

System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel cost " + fuelCost.ToString("C") );