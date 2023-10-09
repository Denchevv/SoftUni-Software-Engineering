using System.Numerics;

int snowballsNum = int.Parse(Console.ReadLine());

BigInteger maxValue = 0;
string output = "";

for (int i = 1; i <= snowballsNum; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger snowballValue = (BigInteger)Math.Pow(snowballSnow / snowballTime, snowballQuality);
    

    if (snowballValue > maxValue)
    {
        maxValue = snowballValue;
        output = $"{snowballSnow} : {snowballTime} = {maxValue} ({snowballQuality})";
    }

}

Console.WriteLine(output);

