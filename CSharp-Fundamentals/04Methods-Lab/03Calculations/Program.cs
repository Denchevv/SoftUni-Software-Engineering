string operation = Console.ReadLine();
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

if (operation == "add")
{
    OperationAdd(firstNumber, secondNumber);
}
else if (operation == "substract")
{
    OperationSubstract(firstNumber, secondNumber);
}
else if (operation == "multiply")
{
    OperationMultiply(firstNumber, secondNumber);
}
else if(operation == "divide")
{
    OperationDivide(firstNumber, secondNumber);
}

static void OperationAdd(int a, int b)
{
    int result = a + b;
    Console.WriteLine(result);
}
static void OperationSubstract(int a, int b)
{
    int result = a - b;
    Console.WriteLine(result);
}
static void OperationMultiply(int a, int b)
{
    int result = a * b;
    Console.WriteLine(result);
}
static void OperationDivide(int a, int b)
{
    int result = a / b;
    Console.WriteLine(result);
}