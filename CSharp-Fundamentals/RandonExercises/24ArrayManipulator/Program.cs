using System.Threading.Tasks.Dataflow;

namespace _24ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
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

                string[] token = line.Split();

                string command = token[0];

                // 1.Exchange condition -----------------------------------------------------------------------------------
                if (command == "exchange")
                {
                    int rotationIndex = int.Parse(token[1]);

                    if (rotationIndex < 0 || rotationIndex > numbers.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(numbers, rotationIndex);
                    
                }
                else if (command == "max")
                {
                    string evenOrOdd = token[1];
                    int index = -1;

                    if (evenOrOdd == "odd")
                    {
                        index = MaxNumIndex(numbers, 1);
                    }
                    else
                    {
                        index = MaxNumIndex(numbers, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    Console.WriteLine(index);

                }
                else if (command == "min")
                {
                    string evenOrOdd = token[1];
                    int index = -1;
                    if (evenOrOdd == "odd")
                    {
                        index = MinNumIndex(numbers, 1);
                    }
                    else
                    {
                        index = MinNumIndex(numbers, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(index);
                }
                // To do: First {count} even/odd
                else if (command == "first")
                {
                    int count = int.Parse(token[1]);
                    if (count >= numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string oddOrEven = token[2];

                    int[] result = new int[0];

                    if (oddOrEven == "odd")
                    {
                        result = FirstCountEvenOdd(numbers, count, 1);
                    }
                    else
                    {
                        result = FirstCountEvenOdd(numbers, count, 0);
                    }
                    Console.WriteLine($"[{string.Join(", ", result)}]");


                }

                // To do: Last {count} even/odd 
                else if (command == "last")
                {
                    int count = int.Parse(token[1]);
                    if (count >= numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string oddOrEven = token[2];

                    int[] result = new int[0];

                    if (oddOrEven == "odd")
                    {
                        result = LastCountEvenOdd(numbers, count, 1);
                    }
                    else
                    {
                        result = LastCountEvenOdd(numbers, count, 0);
                    }
                    Console.WriteLine($"[{string.Join(", ", result)}]");

                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }


        private static void Exchange(int[] numbers, int rotationIndex)
        {
            for (int i = 0; i < rotationIndex + 1; i++)
            {
                int firstNum = numbers[0];
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = firstNum;
            }
        }

        private static int MaxNumIndex(int[] numbers, int oddOrEven)
        {
            int maxNum = int.MinValue;
            int resultIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == oddOrEven)
                {
                    if (numbers[i] >= maxNum)
                    {
                        maxNum = numbers[i];
                        resultIndex = i;
                    }
                }
            }
            return resultIndex;
        }

        private static int MinNumIndex(int[] numbers, int oddOrEven)
        {
            int minValue = int.MaxValue;
            int resultIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == oddOrEven)
                {
                    if (numbers[i] <= minValue)
                    {
                        minValue = numbers[i];
                        resultIndex = i;
                    }
                }
            }
            return resultIndex;
        }

        private static int[] FirstCountEvenOdd(int[] numbers, int count, int evenOrOdd)
        {
            int[] resultArray = new int[count];
            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == evenOrOdd && counter < count)
                {
                    resultArray[counter] = numbers[i];
                    counter++;
                }
            }

            if (counter >= count)
            {
                return resultArray;
            }
            else
            {
                int[] tempArr = new int[counter];
                Array.Copy(resultArray, tempArr, counter); //Functionality copy, (SOURCEarr, CopyTOarr, items/count)
                return tempArr;
            }
        }

        private static int[] LastCountEvenOdd(int[] numbers, int count, int evenOrOdd)
        {
            int[] resultArray = new int[count];
            int counter = 0;

            for (int i = numbers.Length-1; i>= 0; i--)
            {
                if (numbers[i] % 2 == evenOrOdd && counter < count)
                {
                    resultArray[counter] = numbers[i];
                    counter++;
                }
            }

            if (counter >= count)
            {
                return resultArray.Reverse().ToArray();
            }
            else
            {
                int[] tempArr = new int[counter];
                Array.Copy(resultArray, tempArr, counter); //Functionality copy, (SOURCEarr, CopyTOarr, items/count)
                return tempArr.Reverse().ToArray();
            }
        }
    }
}