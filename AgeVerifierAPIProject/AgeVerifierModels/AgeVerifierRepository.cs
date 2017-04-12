using System.Collections.Generic;

namespace AgeVerfierWebApplication.AgeVerifierModels
{
    public interface AgeVerifierRepository
    {
        void Add(AgeVerifierItem item);
        IEnumerable<AgeVerifierItem> GetAll();
        AgeVerifierItem Find(long key);
        void Remove(long key);
        void Update(AgeVerifierItem item);
    }
}