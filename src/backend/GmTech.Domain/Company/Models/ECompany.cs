namespace GmTech.Domain.Company.Models;

public class ECompany : AddressBase {
    
    public Guid Id { get; private set; }
    public string? CompanayName { get; private set; }
    public string? Document { get; private set; }
    public DateTime FundationDate { get; private set; }
    public string? BusinessArea { get; private set; }

    public ECompany() { }

    public ECompany(Guid id, string companyname, string document, DateTime fundation,
        string businessarea, string zipcode, string address,
        string number, string district, string city,
        string state, string country, List<string> fones, List<string> emails) {
            Id = id;
            CompanayName = companyname;
            Document = document;
            BusinessArea = businessarea;
            FundationDate = fundation;
            Zipcode = zipcode;
            Address = address;
            Number = number;
            District = district;
            City = city;
            State = state;
            Country = country;
            Fone = fones;
            Email = emails;
    }

}