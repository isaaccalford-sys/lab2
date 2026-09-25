//part 1: Road Trip
using System.Security;

System.Console.WriteLine("=== Part 1: Road Trip ===");


Console.Write("How many miles are you driving ");
Double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon can your car go? ");
Double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much did you pay for gas? ");
Double pricePerGallon = Convert.ToDouble(Console.ReadLine());



//calculations
Double gallonsNeeded = tripMiles / milePerGallon;
Double fuelCost = gallonsNeeded * pricePerGallon;

//print
System.Console.WriteLine(

);

System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel cost " + fuelCost.ToString("C") );

System.Console.WriteLine(

);

//part: 2 pizza

 const Double amountOfSlices = 8;


System.Console.WriteLine("=== Part 2: Pizza Party ===");


 System.Console.Write("How many people came to your party? ");
 Double amountOfPeopleComing = Convert.ToDouble(Console.ReadLine());

  System.Console.Write("How many pizzas do you get? ");
 Double  amountOfPizzas= Convert.ToDouble(Console.ReadLine());

  System.Console.Write("What is the price per pizza? ");
 Double pricePerPizza = Convert.ToDouble(Console.ReadLine());


//calculations 
Double totalSlices = amountOfPizzas * amountOfSlices;
Double slicesPerPerson =  totalSlices / amountOfPeopleComing;
Double pizzaCost =amountOfPizzas * pricePerPizza;

//print
System.Console.WriteLine(

);

System.Console.WriteLine("Total slices: " + totalSlices.ToString("F2"));
System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

System.Console.WriteLine(

);

//part 3: paycheck
const Double taxRate = .18;


System.Console.WriteLine("=== Part 3: Paycheck ===");


System.Console.Write("How many hours did you work this week? ");
Double hoursWorked = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is you hourly rate? ");
Double hourlyRate = Convert.ToDouble(Console.ReadLine());


Double grossPay = hoursWorked * hourlyRate;
Double taxWithheld = grossPay * taxRate;
Double takeHomePay = grossPay - taxWithheld;

//print

System.Console.WriteLine(

);

System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

System.Console.WriteLine(

);

// part: 4 total trip

System.Console.WriteLine("=== Part 4: Total Trip ===");


Double tripTotal = fuelCost + pizzaCost;
Double costPerPerson = tripTotal / amountOfPeopleComing;
Double takeHomePayPerHour = takeHomePay / hoursWorked;
Double hoursYouMustWork = costPerPerson / takeHomePay;

//print

System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
System.Console.WriteLine("Hours you must work in order to cover your share: " + hoursYouMustWork.ToString("C"));