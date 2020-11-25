using Domain.Dto;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAnimalService
    {
        Task<IEnumerable<Animal>> BuscarTodos();
        Task<IEnumerable<Animal>> BuscarPorUsuario(Guid userId);
        Task<Animal> BuscarPorId(Guid animalId);
        Task<bool> CadastrarAnimal(CadastrarAnimalDto cadastro);

    }
}
