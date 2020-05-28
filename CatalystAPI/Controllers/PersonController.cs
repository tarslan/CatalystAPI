using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatalystAPI.Data;
using CatalystAPI.Models;
using CatalystAPI.EntityFrameworkCore;

namespace CatalystAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : CatalystController<Person, EfcorePersonRepository> 
    {

        public PersonController(EfcorePersonRepository repository) : base(repository)
        {
            //_context = context;
        }

    }
}
