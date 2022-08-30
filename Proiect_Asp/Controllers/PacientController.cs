using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect_Asp.Entities;
using Proiect_Asp.Entities.DTOs;
using Proiect_Asp.Repositories.AuthorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientController : ControllerBase
    {
        private readonly IPacientRepository _repository;

        public PacientController(IPacientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPacienti()
        {
            var pacienti = await _repository.GetAllPacientiWithAddress();
            var pacientiToReturn = new List<PacientDTO>();

            foreach (var pacient in pacienti)
            {
                pacientiToReturn.Add(new PacientDTO(pacient));
            }

            return Ok(pacientiToReturn);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePacient(CreatePacientDTO dto)
        {
            Pacient NouPacient = new Pacient();
            NouPacient.Nume = dto.Nume;
            NouPacient.Prenume = dto.Prenume;
            NouPacient.CNP = dto.CNP;
            NouPacient.Adresa = dto.Adresa;

            _repository.Create(NouPacient);

            await _repository.SaveAsync();

            return Ok(new PacientDTO(NouPacient));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPacientById(int id)
        {
            var pacient = await _repository.GetByIdAsync(id);

            return Ok(new PacientDTO(pacient));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePacientById(int id)
        {
            var pacient = await _repository.GetByIdAsync(id);
            if (pacient == null)
            {
                return NotFound("Pacient dosen't exist.");
            }

            _repository.Delete(pacient);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
