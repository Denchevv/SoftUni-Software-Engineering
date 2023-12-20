namespace _06_JaggedArrMod
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int row = 0; row < n; row++)
            {          
                jagged[row] = ReadArr();            
            }

            string input; 
            while((input=Console.ReadLine()?.ToUpper()) != "END")
            {
                string[] token = input.Split();

                string command = token[0];
                int row = int.Parse(token[1]);
                int col = int.Parse(token[2]);
                int value = int.Parse(token[3]);

                if(row >= n || row < 0 || col < 0 || jagged[row].Length <= col)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if(command == "ADD")
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        jagged[row][col] -= value;

                    }
                }
            }

            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
           
        }

        private static int[] ReadArr()
        {
            return Console.ReadLine()
                 .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
        }
    }
}
