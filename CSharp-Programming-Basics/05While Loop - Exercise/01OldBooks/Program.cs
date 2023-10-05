string favoriteBook = Console.ReadLine();

int booksCount =  0;

string currentBook = Console.ReadLine();
while  (currentBook != "No More Books")
{
    if (currentBook == favoriteBook)
    {
        Console.WriteLine($"You checked {booksCount} books and found it.");
        break;
    }

    booksCount++;
    currentBook = Console.ReadLine();
}


if (currentBook != favoriteBook)
{ 
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {booksCount} books.");
}