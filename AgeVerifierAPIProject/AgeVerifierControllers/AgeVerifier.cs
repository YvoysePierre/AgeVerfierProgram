using System.Collections.Generic;
using AgeVerifierWebApplication.AgeVerifierModels;
using Microsoft.AspNetCore.Mvc;

namespace AgeVerifierWebApplication.AgeVerifierControllers
{
    [Route("api/[AgeVerifier]")]
    public class AgeVerifier : Controller
    {
        private readonly IAgeVerifierRepository _ageVerifierRepository;

        public AgeVerifier(IAgeVerifierRepository repo)
        {
            _ageVerifierRepository = repo;
        }

        [HttpGet]
        public IEnumerable<AgeVerifierItem> GetAll()
        {
            return _ageVerifierRepository.GetAll();
        }

        [HttpGet("{id}", Name = "AgeVerifier")]
        public IActionResult GetById(long id)
        {
            var item = _ageVerifierRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // TODO: Add some more "GetBy..." methods, such as "Get all in state"
    }
}