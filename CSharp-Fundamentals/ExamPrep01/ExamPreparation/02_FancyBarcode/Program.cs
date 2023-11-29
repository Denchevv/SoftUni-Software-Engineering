using System.Text.RegularExpressions;

namespace _02_FancyBarcode
{
    public class Program
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                string barcode = Console.ReadLine();

                var validBarcodes = new Regex(@"^@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+$");

                bool isValid = validBarcodes.Match(barcode).Success;

                string groupNum = "";

                if (!isValid)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    groupNum = new string(barcode.Where(x => char.IsDigit(x)).ToArray());

                    if (groupNum == "" && isValid)
                    {
                        groupNum = "00";
                    }

                    Console.WriteLine($"Product group: {groupNum}");

                }
            }
        }
    }
}