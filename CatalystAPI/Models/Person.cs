using CatalystAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalystAPI.Models
{
    public class Person : IEntity
    {

        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        [Required]
        public int Age { get; set; }

        public string Interest { get; set; }

        [Required]
        public string PictureURL { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

    }
}
