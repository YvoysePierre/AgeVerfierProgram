using System.Collections.Generic;

namespace AgeVerifierWebApplication.AgeVerifierModels
{
    public interface IAgeVerifierRepository
    {
        void Add(AgeVerifierItem item);
        IEnumerable<AgeVerifierItem> GetAll();
        AgeVerifierItem Find(long key);
        void Remove(long key);
        void Update(AgeVerifierItem item);
    }
}