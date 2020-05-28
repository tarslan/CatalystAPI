using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalystAPI.Data
{
    public interface IEntity
    {
        long Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
