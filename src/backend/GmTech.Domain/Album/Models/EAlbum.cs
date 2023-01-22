namespace GmTech.Domain.Album.Models;

public class EAlbum {
    public Guid Id { get; private set; }
    public string? Title { get; private set; }
    public DateTime CreatingIn { get; private set; }
    public ICollection<EImage>? Images { get; private set; }

    public EAlbum(){}
    public EAlbum(Guid id, string title, DateTime creatingin, ICollection<EImage> images) {
        Id = id;
        Title = title;
        CreatingIn = creatingin;
        Images = images;
    }

}