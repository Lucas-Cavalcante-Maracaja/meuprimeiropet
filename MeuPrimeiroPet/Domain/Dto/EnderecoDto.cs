using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    public class EnderecoDto
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
    }
}
