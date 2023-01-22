using GmTech.Domain.Address.Models;
using GmTech.Domain.Album.Models;
using GmTech.Domain.Company.Models;
using GmTech.Domain.Contact.Models;
using GmTech.Domain.Person.Models;
using GmTech.Domain.Profile.Enums;

namespace GmTech.Domain.Profile.Models;

public class EProfile {
    public Guid Id { get; private set; }
    public Guid UserID { get; private set; } 
    public EProfileType? Profile { get; private set; }
    public EFront? Front {get; private set;}
    public EPerson? Person { get; private set; }
    public ECompany? Company { get; private set; }
    public EAddress? Address { get; private set; }
    public ICollection<EFone>? Fones { get; private set; }
    public ICollection<EEmail>? Emails { get; private set; }
    public ICollection<EAlbum>? Albums { get; private set; } 

    public EProfile() {}

    public EProfile(Guid id, Guid userid,
        EProfileType profile, EFront front,
        EPerson person, ECompany company,
        EAddress address, ICollection<EFone> fones,
        ICollection<EEmail> emails,
        ICollection<EAlbum> albums) {
            Id = id;
            UserID = userid;
            Profile = profile;
            Front = front;
            Person = person;
            Company = company;
            Address = address;
            Fones = fones;
            Emails = emails;
            Albums = albums;
    }
}