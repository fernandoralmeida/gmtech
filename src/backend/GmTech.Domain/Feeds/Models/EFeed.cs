using GmTech.Domain.Profile.Models;

namespace GmTech.Domain.Feeds.Models;
public class EFeed {
    public ICollection<EProfile>? Profiles { get; private set; }    
    public EFeed(IEnumerable<EProfile> profiles){
        Profiles = (ICollection<EProfile>)profiles;
    }
}