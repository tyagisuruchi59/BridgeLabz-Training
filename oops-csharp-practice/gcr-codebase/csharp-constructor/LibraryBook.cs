class LibraryBook
{
    private string title;
    private string author;
    private double price;
    private bool isAvailable = true;

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book not available.");
        }
    }
}
