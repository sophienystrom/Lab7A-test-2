using System;

class MainClass {
  public static void Main (string[] args) {

for (int counter = 1; counter >0; counter++) {

Console.WriteLine("How many hours was person " + counter + " parked?");
double hours = Convert.ToDouble(Console.ReadLine());
// gets how many hours one was parked as input

MainClass.calculatecharges(hours);

Console.WriteLine ("Are there any more customers?");
string answer = Console.ReadLine();

if (answer == "No" || answer == "no") 
{
  Console.WriteLine ("There are no more customers");
  break;
}




}

}


public static void calculatecharges(double hours) {
if (hours <= 3) 
{
double cost = (2 * hours);
Console.WriteLine ("Cost for parking is: $" + cost);
}
else if (hours > 3 && hours < 24) 
{
double cost = ((hours-3) * 0.5)+6;
Console.WriteLine ("Cost for parking is: $" + cost);
}
else if (hours == 24)
{
double cost = 10;
Console.WriteLine ("Cost for parking is: $" + cost);
}
}
}