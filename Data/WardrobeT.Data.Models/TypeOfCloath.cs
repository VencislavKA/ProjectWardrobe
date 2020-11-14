
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Wardrobe.Data
{
    public class TypeOfCloath
    {
        public TypeOfCloath()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public bool Official { get; set; }

        [Required]
        public bool CanBeUsedAlone { get; set; }
    }
}
