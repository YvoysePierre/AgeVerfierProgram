using System.Collections.Generic;
using AgeVerfierWebApplication.AgeVerifierModels;
using Microsoft.AspNetCore.Mvc;

namespace AgeVerfierWebApplication.AgeVerifierControllers
{
    [Route("api/[AgeVerifier]")]
    public class AgeVerifier : Controller
    {
        private readonly AgeVerifierRepository _ageVerifierRepositoryRepository;
        private readonly AgeVerifierRepository _todoRepository;

        public AgeVerifier(AgeVerifierRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet]
        public IEnumerable<AgeVerifierItem> GetAll()
        {
            return _todoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "AgeVerifier")]
        public IActionResult GetById(long id)
        {
            var item = _todoRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}