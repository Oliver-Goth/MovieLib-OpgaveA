using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLib
{
    public class MoviesRepository
    {
        private int _id = 1;
        private readonly List<Movie> movies = new List<Movie>();

        public MoviesRepository()
        {
            movies.Add(new Movie() { Id = _id++, Title = "Snehvide", ReleaseYear = 1937 });
            movies.Add(new Movie() { Id = _id++, Title = "Citizen Kane", ReleaseYear = 1941 });
            movies.Add(new Movie() { Id = _id++, Title = "Ternet Ninja", ReleaseYear = 2018 });
            movies.Add(new Movie() { Id = _id++, Title = "Italiensk for begyndere", ReleaseYear = 2000 });
            movies.Add(new Movie() { Id = _id++, Title = "Journal 18", ReleaseYear = 2018 });
        }

        public List<Movie> GetAll()
        {
            return new List<Movie>(movies);
        }

        public Movie? GetById(int id)
        {
            Movie? movie = movies.Where(mo => mo.Id == id).FirstOrDefault();
            if (movie == null) 
            {
                return null;
            }
            return movie;
        }

        public Movie Add(Movie movie)
        {
            movie.Validate();
            int currentMaxId = movies.Select(mo => mo.Id).Max();
            movie.Id = currentMaxId++;
            movies.Add(movie);
            return movie;
        }

        public void Update(Movie movie, int id)
        {
            movie.Validate();
            Movie? movieToUpdate = GetById(id);
            if (movieToUpdate == null)
            {
                throw new ArgumentOutOfRangeException("Movie is not found");
            }
            movieToUpdate.Title = movie.Title;
            movieToUpdate.ReleaseYear = movie.ReleaseYear;
        }

        public Movie? Remove(int id)
        {
            Movie? movieToRemove = GetById(id);
            if (movieToRemove == null)
            {
                return null;
            }
            movies.Remove(movieToRemove);
            return movieToRemove;
        }
    }
}
