namespace GmTech.Domain;

public abstract class ContactBase {
    public List<string>? Fone { get; internal set; }
    public List<string>? Email { get; internal set; }
}