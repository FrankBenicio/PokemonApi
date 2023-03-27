using Poke.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Domain.Dto.Request
{
    public class PokemonMasterRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Cpf { get; set; }

        public static implicit operator PokemonMaster(PokemonMasterRequest request)
        {
            return new PokemonMaster
            {
                Age = request.Age,
                Cpf = request.Cpf,
                Name = request.Name,
            };
        }
    }
}
