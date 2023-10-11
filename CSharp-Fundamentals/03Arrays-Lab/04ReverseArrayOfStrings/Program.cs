string[] text = Console.ReadLine().Split();

for (int i = 0; i < text.Length / 2; i++)
{
    string firstSymbl = text[i];
    int reversedIndex = text.Length - i - 1;

    text[i] = text[reversedIndex];
    text[reversedIndex] = firstSymbl;

}
Console.Write(string.Join(" ", text));