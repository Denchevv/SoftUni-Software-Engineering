namespace _11ArrayManipulator
{
    // След изпита ще се пререши !
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }


                string[] tokens = line.Split();

                string command = tokens[0];

                if (command == "exchange")
                {
                    int indexOfRotations = int.Parse(tokens[1]);

                    if (indexOfRotations > array.Length - 1 || indexOfRotations < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    Exchange(array, indexOfRotations);
           
                }
                else if (command == "max")
                {
                    string typeNumber = tokens[1];
                    int index = -1;

                    if (typeNumber == "odd")
                    {
                        index = GetMaxEvenOrOddIndex(array, 1);
                    }
                    else
                    {
                        index = GetMaxEvenOrOddIndex(array, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    
                }
                else if (command == "min")
                {
                    string typeNumber = tokens[1];
                    int index = -1;

                    if (typeNumber == "odd")
                    {
                        index = GetMinEvenOrOddIndex(array, 1);
                    }
                    else
                    {
                        index = GetMinEvenOrOddIndex(array, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }

                   
                }
                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    string typeNumber = tokens[2];

                    int[] result = new int[0];
                    if(typeNumber == "odd")
                    {
                        result = GetFirstCountEvenOrOddNumbers(array, count, 1);
                    }
                    else
                    {
                        result = GetFirstCountEvenOrOddNumbers(array, count, 0);
                    }

                    Console.WriteLine("[" + string.Join(",", result)+ "]");


                }
                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    string typeNumber = tokens[2];

                    int[] result = new int[0];
                    if (typeNumber == "odd")
                    {
                        result = GetLastCountEvenOrOddNumbers(array, count, 1);
                    }
                    else
                    {
                        result = GetLastCountEvenOrOddNumbers(array, count, 0);
                    }

                    Console.WriteLine("[" + string.Join(",", result) + "]");
                }
            }
            Console.WriteLine($"[{string.Join(",", array)}]");
        }

        private static int[] GetLastCountEvenOrOddNumbers(int[] array, int count, int divisionResult)
        {
            int[] arrResult = new int[count];
            int currentCount = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (array[i] % 2 == divisionResult && currentCount < count) 
                {                                                           
                    arrResult[currentCount] += array[i];
                    currentCount++;
                }
            }

            if (currentCount >= count) 
            {
                return arrResult.Reverse().ToArray(); 
            }
            else 
            {
                int[] temp = new int[currentCount];    
                Array.Copy(arrResult, temp, currentCount); 
                arrResult = temp; 
                return arrResult.Reverse().ToArray(); 

            }

        }

        private static int[] GetFirstCountEvenOrOddNumbers(int[] array, int count, int divisionResult)
        {
            int[] arrResult = new int[count]; 
            int currentCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == divisionResult && currentCount < count) //Ако е нечетно число && числата в нашия масив currentCount" 
                {                                                           // са по-малко от искания count => за да не гръмне
                    arrResult[currentCount] += array[i];
                    currentCount++;
                }
            }

            if (currentCount >= count) // Ако сегашния масив е по-голям или равен на броя на числата, които искаме в условиете
            {
                return arrResult; // връщаме масива
            }
            else // Ако броя на исканите числа е по-голям от тези, които имаме =>
            {
                int[] temp = new int[currentCount];     // Правим временен масив
                Array.Copy(arrResult, temp, currentCount); // Копи оригиналния масив, към временния масив, с размер числата, които имаме
                arrResult = temp; // основния бива равен на временния 
                return arrResult; // връщаме масива

            }
        }

        private static int GetMinEvenOrOddIndex(int[] array, int divisionResult)
        {
            int minNum = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                if (currentNum <= minNum && currentNum % 2 == divisionResult)
                {
                    minNum = currentNum;
                    index = i;

                }
            }

            return index;
        }

        private static int GetMaxEvenOrOddIndex(int[] array, int divisionResult)
        {
            int maxNum = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                if (currentNum >= maxNum && currentNum % 2 == divisionResult)
                {
                    maxNum = currentNum;
                    index = i;

                }
            }

            return index;
        }

        private static void Exchange(int[] array, int indexOfRotations)
        {
            for (int i = 0; i < indexOfRotations + 1; i++)
            {
                int firstNum = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = firstNum;
            }
        }
    }
}