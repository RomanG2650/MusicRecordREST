﻿namespace MusicRecordREST.Models
{
    public class Repository
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }


        public void ValidateYear()
        {
            if (PublicationYear == 0)
            {

            }

        }
    }
}
