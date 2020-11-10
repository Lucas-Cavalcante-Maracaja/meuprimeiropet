using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    public class CadastroDto
    {
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public EnderecoDto endereco { get; set; }
    }
}
