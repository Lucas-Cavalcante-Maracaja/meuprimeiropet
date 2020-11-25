using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserService
    {
        Task<User> VerifyAccont(LoginDto login);
        Task<bool> CadastrarConta(CadastroDto cadastro);

    }
}
