namespace csharp_boolflix.Models
{
    public abstract class MediaContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrizione { get; set; }
        public int Durata { get; set; }
        public int VisualizationCount { get; set; }

    }
}
