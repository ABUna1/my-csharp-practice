string message = "The quick brown fox jumps over the lazy dog.";

char[] messageCharacters = message.ToCharArray();

Array.Reverse(messageCharacters);

int letterCount = 0;

foreach (char character in messageCharacters)
{
    if (character == 'o')
    {
        letterCount++;
    }
}

string reversedMessage = new string(messageCharacters);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {letterCount} times.");