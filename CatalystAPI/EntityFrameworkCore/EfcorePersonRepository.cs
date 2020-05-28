using CatalystAPI.Data;
using CatalystAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalystAPI.EntityFrameworkCore
{
    public class EfcorePersonRepository : EfcoreRepository<Person, CatalystAPIContext>
    {
        public EfcorePersonRepository (CatalystAPIContext context) : base(context)
        {

        }
    }
}
