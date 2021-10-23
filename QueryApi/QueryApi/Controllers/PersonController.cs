using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("GetCampos")]
        public IActionResult GetCampos()
        {
            var repository = new PersonRepository();
            var persons = repository.GetCampos();
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetByGenero")]
        public IActionResult GetByGenero(char Genero)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGenero(Genero);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetRango")]
        public IActionResult GetRango(int minAge, int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetRango(minAge,maxAge);
            return Ok(persons);
        }  

        [HttpGet]
        [Route("GetTrabajos")]
        public IActionResult GetTrabajos()
        {
            var repository = new PersonRepository();
            var persons = repository.GetTrabajos();
            return Ok(persons);
        }    

        [HttpGet]
        [Route("GetContains")]
        public IActionResult GetContains(string word)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(word);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("GetPersona")]
        public IActionResult GetPersona(int Age1,int Age2,int Age3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersona(Age1,Age2,Age3);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("GetOrdenada")]
        public IActionResult GetOrdenada(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetOrdenada(age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetOrdenadaDesc")]
        public IActionResult GetOrdenadaDesc(char gender, int minAge,int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetOrdenadaDesc(gender,minAge,maxAge);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetCount")]
        public IActionResult GetCount(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetCount(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetExist")]
        public IActionResult GetExist(string LastName)
        {
            var repository = new PersonRepository();
            var persons = repository.GetExist(LastName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("JobAge")]
        public IActionResult JobAge(string Job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.JobAge(Job,age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetTake")]
        public IActionResult GetTake(string job, int Take)
        {
            var repository = new PersonRepository();
            var persons = repository.GetTake(job,Take);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetSkip")]
        public IActionResult GetSkip(int skip,string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetSkip(skip,job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetSkipTake")]
        public IActionResult GetSkipTake(int skip,int take, string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetSkipTake(skip,take,job);
            return Ok(persons);
        }
    }
}