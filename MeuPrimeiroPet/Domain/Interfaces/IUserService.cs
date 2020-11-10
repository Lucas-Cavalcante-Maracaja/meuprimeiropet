using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserService
    {
        Task<bool> VerifyAccont(LoginDto login);
        Task<bool> CadastrarConta(CadastroDto cadastro);

    }
}
