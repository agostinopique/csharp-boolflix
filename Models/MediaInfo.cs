public class MediaInfo
{
    public int Id { get; set; }
    public string Year { get; set; }
    public bool IsNew { get; set; }
    public int? FilmID { get; set; }
    public Film? Film { get; set; }

    public int? TVSeriesId { get; set; }
    public TVSeries? TVSeries { get; set; }

    public List<Actor> Cast { get; set; }
    public List<Genre> Genres { get; set; }
    public List<Feature> Features { get; set; }

    public MediaInfo(string year, bool isNew, int? filmID, Film? film, int? tVSeriesId, TVSeries? tVSeries, List<Actor> cast, List<Genre> genres, List<Feature> features)
    {
        int id = 0; 
        Id = id;
        Year = year;
        IsNew = isNew;
        FilmID = filmID;
        Film = film;
        TVSeriesId = tVSeriesId;
        TVSeries = tVSeries;
        Cast = cast;
        Genres = genres;
        Features = features;
        id++;
    }

    public MediaInfo()
    {

    }
}
