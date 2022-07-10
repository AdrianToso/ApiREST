using ApiRESTApplication;
using ApiRESTEntities;
using ApiRESTWebApi.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRESTWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        IApplication<FootballTeam> _football;
        public FootballTeamController(IApplication<FootballTeam> football)
        {
            _football = football;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_football.GetAll());
            
        }
        [HttpPost]
        public IActionResult Save(FootballTeamDto dto)
        {
            var f = new FootballTeam()
            {
                Name = dto.Name,
                Score = dto.Score
            };
            return Ok(_football.save(f));
        }
    }
}
