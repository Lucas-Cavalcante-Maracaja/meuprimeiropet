using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    public class AnimalDto
    {
        public Guid AnimalId { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }

        public string IdadeAproximada { get; set; }

        public string Cor { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public float Peso { get; set; }

        public string Porte { get; set; }

        public DateTime DataAdicionado { get; set; }

        public string Status { get; set; }

        public string Descricao { get; set; }
    }
}
