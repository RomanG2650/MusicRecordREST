namespace MusicRecordREST.Models
{
    public class MusicRecord
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }


        public void ValidateYear()
        {
            if (PublicationYear == null)
            {
                throw new ArgumentNullException("publication year cannot be null");
            }

        }
    }
}
