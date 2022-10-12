public class Actor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<MediaInfo>? MediaInfos { get; set; }
    
    public Actor(string name, string surname)
    {
        int id = 0;
        this.Name = name;
        this.Surname = surname;
        this.Id = id;
        id++;
    }

    public Actor()
    {

    }
}
