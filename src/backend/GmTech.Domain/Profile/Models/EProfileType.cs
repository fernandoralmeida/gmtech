using GmTech.Domain.Profile.Enums;

namespace GmTech.Domain.Profile.Models;
public class EProfileType {
    public Guid Id { get; private set; }
    public EnumProfiles Account { get; private set; }
    public EnumProfiles Client { get; private set; }
}