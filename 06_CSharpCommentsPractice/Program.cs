/*
  This program demonstrates effective code comments.
  The purpose is to practice adding comments that explain
  the reason behind code.
*/

string firstName = "Bob";
int widgetsPurchased = 7;

// Display the purchase information.
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");


/*
  The following code creates random OrderIDs
  to simulate a fraud detection test.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}