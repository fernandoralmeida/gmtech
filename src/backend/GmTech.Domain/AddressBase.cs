namespace GmTech.Domain;

public abstract class AddressBase: ContactBase {
    public string? Zipcode { get; internal set; }
    public string? Address { get; internal set; }
    public string? Number { get; internal set; }
    public string? District { get; internal set; }
    public string? City {get; internal set; }
    public string? State { get; internal set; }
    public string? Country {get; internal set;}    

}