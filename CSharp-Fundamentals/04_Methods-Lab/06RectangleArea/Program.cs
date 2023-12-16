int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int result = GetRectangleArea(a, b);
Console.WriteLine(result);
static int GetRectangleArea (int a, int b)
{
    return a * b;
}