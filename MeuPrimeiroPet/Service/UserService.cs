using Data.Context;
using Domain.Dto;
using Domain.Entity;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private MyContext _context;
        private DbSet<User> _repository;
        private DbSet<Endereco> _enderecoRepository;
        public UserService(MyContext context)
        {
            _repository = context.Set<User>();
            _enderecoRepository = context.Set<Endereco>();
            _context = context;
        }

        public async Task<bool> CadastrarConta(CadastroDto cadastro)
        {
            try
            {
                Endereco newendereco = new Endereco(cadastro.endereco.Pais, cadastro.endereco.Uf, cadastro.endereco.Cidade, 
                    cadastro.endereco.Bairro, cadastro.endereco.Numero, cadastro.endereco.Rua);
                newendereco.EnderecoId = Guid.NewGuid();

                User newuser = new User(cadastro.Usuario, cadastro.Senha, newendereco.EnderecoId, cadastro.Email);
                newuser.UserId = Guid.NewGuid();
                await _enderecoRepository.AddAsync(newendereco);
                await _repository.AddAsync(newuser);
                await _context.SaveChangesAsync();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }

        public async Task<User> VerifyAccont(LoginDto login)
        {
            return await _repository.FirstOrDefaultAsync(l => l.Nome.Equals(login.Usuario) && l.Senha.Equals(login.Senha));
        }
    }
}
