namespace csharp_boolflix.Models
{
    public class FilmMediainfo
    {
        public Film Film { get; set; }
        public TVSeries TVSeries { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Feature> Features { get; set; }

        public FilmMediainfo()
        {
            Genres = new List<Genre>();
            Actors = new List<Actor>();
            Features = new List<Feature>();

        }
    }
}
