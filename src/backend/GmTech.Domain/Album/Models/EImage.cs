namespace GmTech.Domain.Album.Models;

public class EImage {
    public Guid Id { get; private set; }
    public string? Path { get; private set; }

    public EImage(){}

    public EImage(Guid id, string path) {
        Id = id;
        Path = path;
    }
}