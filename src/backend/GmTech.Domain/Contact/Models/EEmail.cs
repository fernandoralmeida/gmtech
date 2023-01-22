namespace GmTech.Domain.Contact.Models;

public class EEmail
{
    public Guid Id { get; private set; }
    public string? Address { get; internal set; }
    public string? Description { get; internal set; }

    public EEmail() { }
    public EEmail(Guid id,
        string address, string descp)
    {
        Id = id;
        Address = address;
        Description = descp;
    }
}