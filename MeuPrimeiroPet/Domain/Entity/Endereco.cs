using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Endereco
    {
        public Guid EnderecoId { get; set; }
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Rua { get; set; }

        public Endereco(string pais, string uF, string cidade, string bairro, string numero, string rua)
        {
            Pais = pais;
            UF = uF;
            Cidade = cidade;
            Bairro = bairro;
            Numero = numero;
            Rua = rua;
        }
    }
}
