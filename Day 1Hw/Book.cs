public class Book : AbstractBook, Borrowable
{
    public void Borrow()
    {
        Console.WriteLine("Book has been borrowed");
    }

    public void ReturnBook()
    {
        Console.WriteLine("Book has been returned");
    }
}