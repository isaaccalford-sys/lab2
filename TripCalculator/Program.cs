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

//part: 2 pizza
 const int amountOfSlices = 8;

 System.Console.Write("How many people came to your party? ");
 double amountOfPeopleComing = Convert.ToDouble(Console.ReadLine());

  System.Console.Write("How many pizzas do you get? ");
 double  amountOfPizzas= Convert.ToDouble(Console.ReadLine());

  System.Console.Write("What is the price per pizza? ");
 double pricePerPizza = Convert.ToDouble(Console.ReadLine());


//calculations 
double totalSlices = amountOfPizzas * amountOfSlices;
double slicesPerPerson = amountOfPeopleComing / totalSlices;
double pizzaCost =amountOfPizzas * pricePerPizza;


System.Console.WriteLine("Total slices: " + totalSlices.ToString("F2"));
System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

//part 3: paycheck
const Decimal taxRate = .18m;

System.Console.Write("How many hours did you work this week? ");
Decimal hoursWorked = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("What is you hourly rate? ");
Decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());


Decimal grossPay = hoursWorked * hourlyRate;
Decimal taxWithheld = grossPay * taxRate;
Decimal takeHomePay = grossPay - taxWithheld;


System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

