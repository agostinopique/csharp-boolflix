public class Feature
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<MediaInfo>? MediaInfos { get; set; }

    public Feature(string name)
    {
        int id = 0;
        this.Name = name;
        this.Id = id;
        id++;

    }
    public Feature()
    {

    }
}
