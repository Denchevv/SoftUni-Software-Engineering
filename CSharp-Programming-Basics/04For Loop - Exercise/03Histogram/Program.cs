int n = int.Parse(Console.ReadLine());

int p1Count = 0;
int p2Count = 0;
int p3Count = 0;
int p4Count = 0;
int p5Count = 0;

for (int i = 1; i <= n; i++)
{
    int number = int.Parse((Console.ReadLine()));

    if (number < 200) { p1Count++; }
    else if (number >= 200 && number <= 399) {  p2Count++; }
    else if (number >= 400 && number <= 599) {  p3Count++; }
    else if (number >= 600 && number <= 799) {  p4Count++; }
    else if (number >= 800) {  p5Count++; }
}



/*double p1 = ((double)p1Count / n) * 100;
double p2 = ((double)p2Count / n) * 100;
double p3 = ((double)p3Count / n) * 100;
double p4 = ((double)p4Count / n) * 100;
double p5 = ((double)p5Count / n) * 100;*/

Console.WriteLine($"{100.0 * p1Count / n:f2}%");
Console.WriteLine($"{100.0 * p2Count / n:f2}%");
Console.WriteLine($"{100.0 * p3Count / n:f2}%");
Console.WriteLine($"{100.0 * p4Count / n:f2}%");
Console.WriteLine($"{100.0 * p5Count / n:f2}%");
