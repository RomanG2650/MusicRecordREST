namespace MusicRecordREST.Models
{
    public class RepositoryList
    {
        private static int _nextId = 1;
        private static readonly List<MusicRecord> _musicRecords = new();


        public RepositoryList()
        {

            _musicRecords.Add(new MusicRecord { Id = _nextId++, Title = "The Dark Side of the Moon", Artist = "Pink Floyd", Duration = 43, PublicationYear = 1973 });
            _musicRecords.Add(new MusicRecord { Id = _nextId++, Title = "Back in Black", Artist = "AC/DC", Duration = 42, PublicationYear = 1980 });
            _musicRecords.Add(new MusicRecord { Id = _nextId++, Title = "The Bodyguard", Artist = "Whitney Houston", Duration = 57, PublicationYear = 1992 });
            _musicRecords.Add(new MusicRecord { Id = _nextId++, Title = "Bat Out of Hell", Artist = "Meat Loaf", Duration = 46, PublicationYear = 1977 });
            _musicRecords.Add(new MusicRecord { Id = _nextId++, Title = "Their Greatest Hits (1971-1975)", Artist = "Eagles", Duration = 43, PublicationYear = 1976 });
            _musicRecords.Add(new MusicRecord { Id = _nextId++, Title = "Saturday Night Fever", Artist = "Bee Gees", Duration = 75, PublicationYear = 1977 });
            _musicRecords.Add(new MusicRecord { Id = _nextId++, Title = "Rumours", Artist = "Fleetwood Mac", Duration = 40, PublicationYear = 1977 });

        }
        public List<MusicRecord> GetAll()
        {
            return new List<MusicRecord>(_musicRecords);
        }

    }
}



