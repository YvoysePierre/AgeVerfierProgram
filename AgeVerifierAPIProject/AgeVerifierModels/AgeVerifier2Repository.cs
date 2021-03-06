﻿using System.Collections.Generic;
using System.Linq;

namespace AgeVerifierWebApplication.AgeVerifierModels
{
    public class AgeVerifierRepository : IAgeVerifierRepository
    {
        private readonly AgeVerifierContext _context;

        public AgeVerifierRepository(AgeVerifierContext context)
        {
            _context = context;
        }

        public IEnumerable<AgeVerifierItem> GetAll()
        {
            return _context.AgeVerifier.ToList();
        }

        public void Add(AgeVerifierItem item)
        {
            _context.AgeVerifier.Add(item);
            _context.SaveChanges();
        }

        public AgeVerifierItem Find(long key)
        {
            return _context.AgeVerifier.FirstOrDefault(t => t.Key == key);
        }

        public void Remove(long key)
        {
            var entity = _context.AgeVerifier.First(t => t.Key == key);
            _context.AgeVerifier.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(AgeVerifierItem item)
        {
            _context.AgeVerifier.Update(item);
            _context.SaveChanges();
        }
    }
}