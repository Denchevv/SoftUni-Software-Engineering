namespace MockExams
{
    public class Program
    {
        public static void Main()
        {
            string commands = Console.ReadLine();

            int verticalScore = 0;
            int horizontalScore = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                char command = commands[i];
                
                if(command == 'R')
                {
                    horizontalScore++;
                }
                else if(command == 'L')
                {
                    horizontalScore--;
                }
                else if( command == 'U')
                {
                    verticalScore++;   
                }
                else if( command == 'D')
                {
                    verticalScore--;
                }
            }

            Console.WriteLine($"({horizontalScore}, {verticalScore})");
        }
    }
}