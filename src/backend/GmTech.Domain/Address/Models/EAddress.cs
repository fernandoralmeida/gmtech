namespace GmTech.Domain.Address.Models;

public class EAddress {
    public Guid Id { get; private set; }
    public string? Zipcode { get; internal set; }
    public string? Address { get; internal set; }
    public string? Number { get; internal set; }
    public string? District { get; internal set; }
    public string? City { get; internal set; }
    public string? State { get; internal set; }
    public string? Country { get; internal set; }

    public EAddress(){}
    public EAddress(Guid id,  string zipcode, string address,
        string number, string district, string city,
        string state, string country) {
            Id = id;
            Zipcode = zipcode;
            Address = address;
            Number = number;
            District = district;
            City = city;
            State = state;
            Country = country;  
        }
}