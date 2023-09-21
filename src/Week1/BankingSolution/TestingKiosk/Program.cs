// Welcome them
// Show them their current balance
// Ask them if they want to do a deposit or withdrawl or quit
// Collect the amount - apply it to the account
// Show them their new balance


using Banking.Domain;

Console.WriteLine("Welcome to the Bank!");
var account = new Account(new StandardBonusCalculator());

while (true)
{
    Console.WriteLine($"Your Current Balance is {account.GetBalance():c}");
    Console.Write("Do you want to make a (d)eposit, (w)ithdrawal, or (q)uit? ");
    var response = Console.ReadLine();

    if (response == "d")
    {

    }

    if (response == "w")
    {

    }

    if (response == "q")
    {
        break; // quit looping
    }
}