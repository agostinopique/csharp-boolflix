public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<MediaInfo>? MediaInfos { get; set; }
    public Genre(string name)
    {
        int id = 0;
        this.Id = id;
        this.Name = name;
        id++;
    }
    public Genre()
    {

    }
}
