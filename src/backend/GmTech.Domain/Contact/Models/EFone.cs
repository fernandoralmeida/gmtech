namespace GmTech.Domain.Contact.Models;

public class EFone {
    public Guid Id { get; private set; }
    public string? Number { get; internal set; }
    public string? Description { get; internal set; }

    public EFone(){}
    public EFone(Guid id,
        string number, string descp) {
            Id = id;
            Number = number;
            Description = descp;
        }
}