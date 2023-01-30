using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Zad4.Models;
using Zad4.Services;
using System;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Zad4.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IDbService _dbService;

        public AnimalController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimals([FromQuery] string orderBy)
        {
            try
            {
                if (!String.IsNullOrEmpty(orderBy))
                {
                    return orderBy.ToLower() switch
                    {
                        "description" => Ok(_dbService.GetAnimals("Description")),
                        "area" => Ok(_dbService.GetAnimals("Area")),
                        "name" => Ok(_dbService.GetAnimals("Name")),
                        "category" => Ok(_dbService.GetAnimals("Category")),
                        _ => BadRequest($"Order by can't be used with {orderBy}"),
                    };
                }
                else
                {
                    return Ok(_dbService.GetAnimals("Name"));
                }
            }
            catch (SqlException e) {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> AddAnimal([FromBody] Animal animal)
        {
            try
            {
                _dbService.PostAnimal(animal);
                return Ok("Animal successfully created");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{idAnimal}")]
            public async Task<IActionResult> EditAnimal([FromRoute] int idAnimal, [FromBody] Animal animal) {

            if(_dbService.GetAnimalById(idAnimal) != null)
            {
                try
                {
                    if (animal.IdAnimal == idAnimal)
                    {
                        _dbService.PutAnimal(idAnimal, animal);
                        return Ok("Animal succesfully modified");
                    }
                    else
                    {
                        return BadRequest("ID is a primary key and can not be modified");
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            } else
            {
                return NotFound("Aniaml with an ID \"" + idAnimal + "\" does not exists");
            }  
        } 


        [HttpDelete("{idAnimal}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteAnimal([FromRoute] int idAnimal)
        {
            try {
                _dbService.DeleteAnimal(idAnimal);
                return Ok($"Animal with id={idAnimal} deleted");
            } catch(KeyNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
