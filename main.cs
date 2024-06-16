using System;

class Program 
{
  static void Main (string[] args) 
  {
    //Initialize total sales for each salesperson to zero
    double totalD = 0, totalE = 0, totalF = 0;
    string input;

    //Prompt user for input
    Console.WriteLine("Enter a salesperson's initial (D, E, F) or Z to quit:");

    //Infinate loop to continuously accept input from user
    while(true)
    {
      //Prompt user for sales person's initial. Read input and convert to uppercase
      Console.Write("Salesperson initial: ");
      input = Console.ReadLine().ToUpper();

      //Check if user wants to quit. Exit loop if "Z" is entered
      if(input == "Z")
      {
        break;
      }

      //Checks if input is valid. If not, prompt user to enter valid input
      if (input !="D" && input !="E" && input !="F")
      {
        Console.WriteLine("Error, invalid salesperson selected, please try again");
        continue;
      }

      //Prompt user for sales amount
      Console.Write("Enter sale amount: ");
      if (!double.TryParse(Console.ReadLine(), out double saleAmount) || saleAmount < 0)
      {
        //Checks if inpput is valid. If not, prompt user to enter valid input
        Console.WriteLine("Error, Invaid sale amount. Please try again.");
        continue;
      }

      //Add sale amount to total sales for corresponding salesperson
      switch (input)
      {
        case "D":
          totalD += saleAmount;
          break;
        case "E":
          totalE += saleAmount;
          break;
        case "F":
          totalF += saleAmount;
          break;
      }
    }

    //calculate total sales for all salespersons
    double grandTotal = totalD + totalE + totalF;
    string topSalesperson = "";

    //Determine top salesperson
    if (totalD >= totalE && totalD >= totalF)
    {
      topSalesperson = "D";
    }
    else if (totalE >= totalD && totalE >= totalF)
    {
      topSalesperson = "E";
    }
    else if (totalF >= totalD && totalF >= totalE)
    {
      topSalesperson = "F";
    }

    //Display results
    Console.WriteLine();
    Console.WriteLine($"D Sales: {totalD:C}");
    Console.WriteLine($"E Sales: {totalE:C}");
    Console.WriteLine($"F Sales: {totalF:C}");
    Console.WriteLine();
    Console.WriteLine($"Grand Total: {grandTotal:C}");
    Console.WriteLine($"Top salesperson: {topSalesperson}");
  }
}