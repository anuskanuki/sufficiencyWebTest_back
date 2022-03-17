using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProvaSuficiencia.Dtos;
using ProvaSuficiencia.Entities;
using ProvaSuficiencia.Extensions;
using ProvaSuficiencia.Repositories;
using System;
using System.Collections.Generic;

namespace ProvaSuficiencia.Controllers
{
    [Route("api/alunos")]
    public class AlunosController : MainController
    {
        private readonly AlunosRepository _alunosRepository;

        public AlunosController(AlunosRepository alunosRepository, IAspNetUser user) : base(user)
        {
            _alunosRepository = alunosRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Aluno>> GetAll()
        {
            try
            {
                return Ok(_alunosRepository.GetAll());
            }
            catch (Exception e)
            {
                throw new Exception(e?.Message);
            }
        }

        [HttpPost]
        [Authorize] // Retirar para não precisar usar o token
        public ActionResult Post([FromBody] AlunoInputDto aluno)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                _alunosRepository.Insert(aluno.AsAluno());
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e?.Message);
            }
        }
    }
}
