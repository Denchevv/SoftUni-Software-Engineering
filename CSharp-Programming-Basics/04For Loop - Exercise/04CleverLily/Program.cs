//1. Read input
int age = int.Parse(Console.ReadLine());
double washMachPrice = double.Parse(Console.ReadLine());
int pricePerToy = int.Parse(Console.ReadLine());

//2. Odd/toys/ or even/money/ birthdays
int savedMoney = 0;
int giftedMoney = 10;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        savedMoney += giftedMoney - 1;
        giftedMoney += 10;
            }
    else { savedMoney += pricePerToy; }
}

//3. Print output
if (savedMoney >= washMachPrice)
{
    Console.WriteLine($"Yes! {savedMoney-washMachPrice:f2}");
}
else
{
    {
        Console.WriteLine($"No! {washMachPrice-savedMoney:f2}");
    }
}
