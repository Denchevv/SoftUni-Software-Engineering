
namespace _07_LadyBugs
{
    public class Program
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugsPositions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            FillTheField(field, bugsPositions);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split();
                int bugIndex = int.Parse(tokens[0]);
                string way = tokens[1];
                int goToLength = int.Parse(tokens[2]);

                if (IsValid(field, bugIndex) && field[bugIndex] == 1)
                {
                    if (way == "right")
                    {
                        int bugNewIndex = bugIndex + goToLength;
                        if (IsValid(field, bugNewIndex)) // If its in the field
                        {
                            if (field[bugNewIndex] == 1) // If there is bug on the index
                            {
                                bugNewIndex += goToLength;
                                while (true)
                                {
                                    if (IsValid(field, bugNewIndex)) // If the newBugIndex is in the field
                                    {
                                        if (field[bugNewIndex] == 0) // If there is no bug on the new bug index
                                        {
                                            field[bugNewIndex] = 1;
                                            field[bugIndex] = 0;
                                            break;
                                        }
                                        else // If there is a bug on the new bug index
                                        {
                                            bugNewIndex += goToLength; // Increase the GoTo index 
                                        }
                                    }
                                    else // If the newBugIndex is outside the field - bug is free
                                    {
                                        field[bugIndex] = 0;
                                        break;
                                    }
                                }
                            }
                            else // There is no bug on the index
                            {
                                field[bugNewIndex] = 1;
                                field[bugIndex] = 0;
                            }
                        }
                        else // bugNewIndex is outside the field => bug is free
                        {
                            field[bugIndex] = 0;
                        }
                    }
                    else if (way == "left")
                    {
                        int bugNewIndex = bugIndex - goToLength;
                        if (IsValid(field, bugNewIndex))
                        {
                            if (field[bugNewIndex] == 1)
                            {
                                bugNewIndex -= goToLength;
                                while (true)
                                {
                                    if (IsValid(field, bugNewIndex))
                                    {
                                        if (field[bugNewIndex] == 0) // newBugIndex is valid && there is no bug 
                                        {
                                            field[bugIndex] = 0;
                                            field[bugNewIndex] = 1;
                                            break;
                                        }
                                        else // is valid but there is a bug
                                        {
                                            bugNewIndex -= goToLength;
                                        }
                                    }
                                    else // bug is free
                                    {
                                        field[bugIndex] = 0;
                                        break;
                                    }
                                }
                            }
                            else // there is no bug on the bugNewIndex, so we move the bug there
                            {
                                field[bugNewIndex] = 1;
                                field[bugIndex] = 0;
                            }
                        }
                        else // bug fly away from the field
                        {
                            field[bugIndex] = 0;
                        }
                    }
                }
            }

            Console.WriteLine($"{string.Join(" ", field)}");
        }
        static void FillTheField(int[] field, int[] bugsPositions)
        {
            for (int i = 0; i < bugsPositions.Length; i++)
            {
                if (IsValid(field, bugsPositions[i]))
                {
                    field[bugsPositions[i]] = 1;
                }
            }
        }

        static bool IsValid(int[] field, int index)
        {
            return index >= 0 && index < field.Length;
        }
    }
}
