string input = Console.ReadLine();

string reversedString = "";

for (int i = input.Length - 1; i >= 0; i--)
{
    char letter = input[i];
    Console.Write(letter);
}