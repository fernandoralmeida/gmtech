namespace GmTech.Domain.Person.Models;
public class EPerson {
    public Guid Id { get; private set; }
    public string? Name { get; private set; }
    public string? SocialName { get; private set; }
    public string? Document { get; private set; }
    public DateTime Birthdate { get; private set; }


    public EPerson(){}
    public EPerson(Guid id, string doc, 
        string name, string socialname, 
        DateTime birhtdate) {
            Id = id;
            Document = doc;
            Name = name;
            SocialName = socialname;
            Birthdate = birhtdate;
        } 
}