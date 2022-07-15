namespace Indexers
{
    public class Book
    {
        public Book(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public string Title { get; set; }
        public int Year { get; set; }

        public override string ToString() => $"{Title} ({Year})";
    }
}
