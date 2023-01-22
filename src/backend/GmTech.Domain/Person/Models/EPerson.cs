namespace GmTech.Domain.Person.Models;
public class EPerson : AddressBase {
    public Guid Id { get; private set; }
    public string? Name { get; private set; }
    public string? SocialName { get; private set; }
    public string? Document { get; private set; }
    public DateTime Birthdate { get; private set; }

    public EPerson(){}
    public EPerson(Guid id, string doc, 
        string name, string socialname, 
        DateTime birhtdate, string zipcode, 
        string address, string number,
        string district, string city,
        string state, string country,
        List<string> fone, List<string> email)
    {
        Id = id;
        Document = doc;
        Name = name;
        SocialName = socialname;
        Birthdate = birhtdate;
        Zipcode = zipcode;
        Address = address;
        Number = number;
        District = district;
        City = city;
        State = state;
        Country = country;
        Fone = new List<string>();
        Email = new List<string>();
    } 
}