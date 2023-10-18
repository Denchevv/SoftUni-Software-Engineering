int DNAlength = int.Parse(Console.ReadLine());

//Всички променливи, които ни трябват. В процеса на решаване ги разбираме
int length = 0; // Най-добра дължина
int sum = 0; // Най-добра сума
int startIndex = -1; // най-преден индекс
int row = 0; // Реда, който принтираме накрая
int currentRow = 1; // Променяме го с итерацията на цикъла - ТРЯБВА да е 1 - редовете почват от първи ред

int[] DNA = new int[DNAlength];

while (true)
{
    string line = Console.ReadLine();

    if (line == "Clone them!")
        break;

    int[] currentDNA = line
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

    // Общо има 3 подусловия: 1.Дължината на поредицата, 2.Започващ индекс, 3.Сума на единиците
    // Освен това ни трябват още няколко променливи: 

    // Сума на единиците - изчлисление
    int currentSum = 0;
    for (int i = 0; i < currentDNA.Length; i++)
    {
        if (currentDNA[i] == 1)
        {
            currentSum++;
        }
    }

    // Проверка дали работи като взимаме за вход само първите 2 реда от условиете в уордския файл-> 5
    //                                                                                              1!0!1!1!0
    //Console.WriteLine(currentSum);

    //Сетване на променливите за подусловията:       
    int currentStartIndex = -1; //Сетва на -1 за да си проследим грешката - ако в края индекса не е променен
    int currentLength = 0; // 
    bool isFound = false; // Провери го и дебъгни да видиш къде се променя, щото е съмнителна работата :Д и изтрий коментара

    // Изчисление на стартиращ индекс:
    for (int i = 0; i < currentDNA.Length; i++)
    {
        if (currentDNA[i] == 1)
        {
            if (!isFound)
            {
                currentStartIndex = i;
            }

            currentLength++;

            //1. Подусловие ако дължината е най-големя - присвояваме всички променливи, които принтираме накрая   
            if (currentLength > length)
            {
                length = currentLength;
                startIndex = currentStartIndex;
                sum = currentSum;
                row = currentRow;

                DNA = currentDNA;
            }
            else if (currentLength == length) // 2. Второ подусловие - ако и дължините са равни гледаме стартинг индекс
            {
                if (currentStartIndex < startIndex) //По-малък означава, че поредицата е започнала първа
                {
                    length = currentLength;
                    startIndex = currentStartIndex;   // Сетваме същите неща => те ни трябват за финалния аутпут
                    sum = currentSum;
                    row = currentRow;

                    DNA = currentDNA;
                }
                else if (currentSum > sum)
                {
                    length = currentLength;
                    startIndex = currentStartIndex;   // Сетваме същите неща => те ни трябват за финалния аутпут
                    sum = currentSum;
                    row = currentRow;

                    DNA = currentDNA;
                }


            }

        }
        else
        {
            currentStartIndex = -1;
            currentLength = 0;
            isFound = false;
        }
    }

    currentRow++;
}
Console.WriteLine($"Best DNA sample {startIndex} with sum: {sum}.");
Console.WriteLine(string.Join(" ", DNA));