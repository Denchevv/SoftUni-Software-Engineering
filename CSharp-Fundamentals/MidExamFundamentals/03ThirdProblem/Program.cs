namespace _03ThirdProblem
{
    internal class Program
    {
        static void Main()
        {
            List<string> phoneList = Console.ReadLine()
                                    .Split(new char[] { ',', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(s => s.Trim()) 
                                     .ToList();


            while (true)
            {
                string[] token = Console.ReadLine().Split(':', ' ');
                string command = token[0];

                if (command == "End")
                {
                    break;
                }

                if (command == "Add")
                {
                    string currentPhone = token[2];
                    

                    if (!CheckIfItExist(phoneList,currentPhone))
                    {
                        phoneList.Add(currentPhone);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Remove")
                {
                    string currentPhone = token[2];

                    if (CheckIfItExist(phoneList, currentPhone))
                    {
                        phoneList.Remove(currentPhone);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Bonus")
                {
                    string oldPhone = token[3];
                    string newPhone = token[4];
                    if (CheckIfItExist(phoneList, oldPhone))
                    {
                    
                        phoneList.Remove(oldPhone);
                        phoneList.Add(oldPhone);
                        phoneList.Add(newPhone);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if(command == "Last")
                {

                    string currentPhone = token[2];

                    if (CheckIfItExist(phoneList, currentPhone))
                    {
                        phoneList.Remove(currentPhone);
                        phoneList.Add(currentPhone);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", phoneList));


        }

        private static bool CheckIfItExist(List<string> phoneList, string currentPhone)
        {
            return phoneList.Contains(currentPhone);
        }
    }
}