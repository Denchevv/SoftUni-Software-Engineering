namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string test = "abcd";

              string substring = test.Remove(test.Length - 1-2, test.Length-1);


              Console.WriteLine(test);
              Console.WriteLine(substring);*/


            string originalString = "abcd!";
            int lengthToRemove = 3;

            // Extract the substring to be removed
            string removedSubstring = originalString.Substring(originalString.Length - lengthToRemove);

            // Extract the remaining string
            string remainingString = originalString.Substring(0, originalString.Length - lengthToRemove);

            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Removed Substring: " + removedSubstring);
            Console.WriteLine("Remaining String: " + remainingString);

        }
    }
}
