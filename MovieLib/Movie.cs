namespace MoviesLib
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        private void ValidateId()
        {
            if (Id < 0)
            {
                throw new ArgumentOutOfRangeException("Id must be above 0");
            }
        }

        private void ValidateTitle()
        {
            if (Title == null)
            {
                throw new ArgumentNullException("Title must not be null");
            }
            if (Title.Length < 1)
            {
                throw new ArgumentOutOfRangeException ("Title must be atleast 1 character");
            }
        }

        private void ValidateReleaseYear()
        {
            if (ReleaseYear <= 1895)
            {
                throw new ArgumentOutOfRangeException("ReleaseYear must be in or after 1895");
            }
        }

        public void Validate()
        {
            ValidateId();
            ValidateTitle();
            ValidateReleaseYear();
        }

        public override string ToString()
        {
            return "Id: " + Id + "Title: " + Title + "ReleaseYear: " + ReleaseYear;
        }
    }
}