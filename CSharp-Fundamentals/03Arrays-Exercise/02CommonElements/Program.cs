string[] elements = Console.ReadLine().Split();
string[] secondElements = Console.ReadLine().Split();

for (int i = 0; i < elements.Length; i++)
{
    for (int j = 0; j < secondElements.Length; j++)
    {
        if (secondElements[i] == elements[j])
        {
            Console.Write($"{secondElements[i]} ");
        }

    }

}