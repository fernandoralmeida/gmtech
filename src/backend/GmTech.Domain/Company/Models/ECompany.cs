namespace GmTech.Domain.Company.Models;

public class ECompany {
    
    public Guid Id { get; private set; }
    public string? CompanayName { get; private set; }
    public string? Document { get; private set; }
    public DateTime FundationDate { get; private set; }
    public string? BusinessArea { get; private set; }

    public ECompany() { }

    public ECompany(Guid id, string companyname, 
        string document, DateTime fundation,
        string businessarea) {
            Id = id;
            CompanayName = companyname;
            Document = document;
            BusinessArea = businessarea;
            FundationDate = fundation;
        }

}