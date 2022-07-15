using System.Text;

namespace Indexers
{
    public static class SeriesExtensions
    {
        public static string ToString(this IEnumerable<Book> series, string prefix)
        {
            var bob = new StringBuilder();

            foreach (var book in series)
                bob.Append(prefix).AppendLine(book.ToString());

            return bob.ToString();
        }
    }
}
