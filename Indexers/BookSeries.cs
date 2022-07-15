using System.Text;

namespace Indexers
{
    public class BookSeries
    {
        private Dictionary<string, List<Book>> _series;

        public BookSeries()
        {
            _series = new ()
            {
                ["The Chronicles of Narnia"] = new()
                {
                    new Book ("The Magician's Nephew", 1955),
                    new Book ("The Lion the Witch and the Wardrobe", 1950),
                    new Book ("Prince Caspian", 1951),
                    new Book ("The Voyage of the Dawntreader", 1952),
                    new Book ("The Silver Chair", 1953),
                    new Book ("The Horse and his Boy", 1954),
                    new Book ("The Last Battle", 1956)
                },
                ["Harry Potter"] = new()
                {
                    new Book ("Harry Potter and the Philosopher's Stone", 1997),
                    new Book ("Harry Potter and the Chamber of Secrets", 1998),
                    new Book ("Harry Potter and the Prisoner of Azkaban", 1999),
                    new Book ("Harry Potter and the Goblet fo Fire", 2000),
                    new Book ("Harry Potter and the Order of the Phoenix", 2003),
                    new Book ("Harry Potter and the Half-Blood Prince", 2005),
                    new Book ("Harry Potter and the PDeathly Hallows", 2007),
                },
                ["The Danilov Quintet"] = new()
                {
                   new Book ("Twelve", 2009),
                   new Book ("Thirteen Years Later", 2010),
                   new Book ("The Third Section", 2011),
                   new Book ("The People's Will", 2013),
                   new Book ("The Last Rite", 2014)
                },
                ["His Dark Materials"] = new()
                {
                   new Book ("Northern Lights", 1995),
                   new Book ("The Subtle Knife", 1997),
                   new Book ("The Amber Spyglass", 2000)
                }
            };
        }

        public override string ToString()
        {
            var bob = new StringBuilder();

            foreach(var series in _series)
            {
                bob.AppendLine(series.Key);
                bob.Append(series.Value.ToString("\t"));
            }

            return bob.ToString();
        }

        public int Count => _series.Count;

        public List<Book> this[int idx] => _series.Values.ElementAt(idx);   
        
        public List<Book> this[string seriesTitle] => _series[seriesTitle];   

        public Book this[string seriesTitle, int bookIdx]
        {
            get => _series[seriesTitle][bookIdx];
            set
            {
                if (_series[seriesTitle][bookIdx].Year == value.Year)
                    _series[seriesTitle][bookIdx] = value;
                else
                    throw new ArgumentException("Year cannot change");
            }
        }
    }
}
