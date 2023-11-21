using System.Diagnostics;
using System.Text;

namespace _01_SpeedTest
{
    public class Program
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 50000; i++)
            {
                sb.Append('+');
            }
            
            Console.WriteLine(sw.Elapsed);

            sw = Stopwatch.StartNew();

            string result = "";
            for (int i = 0;i < 50000; i++)
            {
                result += "+";
            }
            Console.WriteLine(sw.Elapsed);
        }
    }
}