using GmTech.Domain.Album.Models;
using GmTech.Domain.Company.Models;
using GmTech.Domain.Person.Models;
using GmTech.Domain.Profile.Enums;

namespace GmTech.Domain.Profile.Models;

public class EProfile {
    public Guid Id { get; private set; }
    public Guid UserID { get; private set; } 
    public EnumProfile Profile { get; private set; }
    public string? Avatar {get; private set;}
    public string? Cover { get; private set; }
    public EPerson? Person { get; private set; }
    public ECompany? Company { get; private set; }
    public ICollection<EAlbum>? Albums { get; private set; } 

    public EProfile() {}

    public EProfile(Guid id, Guid userid,
        EnumProfile profile, EPerson person,
        string cover, string avatar,
        ECompany company, ICollection<EAlbum> albums) {
            Id = id;
            UserID = userid;
            Profile = profile;
            Avatar = avatar;
            Cover = cover;
            Person = person;
            Company = company;
            Albums = albums;
    }
}