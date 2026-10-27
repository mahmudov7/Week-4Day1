public abstract class AbstractBook : Readable
{
    protected string Title;
    protected string Author;

    public void SetTitle(string title)
    {
        Title = title;
    }

    public string GetTitle()
    {
        return Title;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public void Read()
    {
        Console.WriteLine("Reading the book");
    }
}