using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Guid EnderecoId { get; set; }
        public string Email { get; set; }

        public User(string nome, string senha, Guid enderecoId, string email)
        {
            Nome = nome;
            Senha = senha;
            EnderecoId = enderecoId;
            Email = email;
        }
    }
}
