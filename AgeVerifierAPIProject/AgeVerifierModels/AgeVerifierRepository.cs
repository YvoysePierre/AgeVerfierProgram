using System.Collections.Generic;

namespace AgeVerifierWebApplication.AgeVerifierModels
{
    // TODO: interfaces begin with I, I changed this one already.
    public interface IAgeVerifierRepository
    {
        void Add(AgeVerifierItem item);
        IEnumerable<AgeVerifierItem> GetAll();
        AgeVerifierItem Find(long key);
        void Remove(long key);
        void Update(AgeVerifierItem item);
    }
}