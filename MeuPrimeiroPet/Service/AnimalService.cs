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
    public class AnimalService : IAnimalService
    {
        private MyContext _context;
        private DbSet<Animal> _repository;
        private DbSet<User_Animal> _userAnimalRepository;
        public AnimalService(MyContext context)
        {
            _repository = context.Set<Animal>();
            _userAnimalRepository = context.Set<User_Animal>();
            _context = context;
        }
        public async Task<Animal> BuscarPorId(Guid animalId)
        {
            return await _repository.FindAsync(animalId);
        }

        public async Task<IEnumerable<Animal>> BuscarPorUsuario(Guid userId)
        {
            var listaUsarioAnimal = await _userAnimalRepository.ToListAsync();
            var listaDoUsuario = listaUsarioAnimal.FindAll(e => e.UserId == userId);
            var listaDeAnimais = new List<Animal>();
            foreach(var item in listaDoUsuario)
            {
                listaDeAnimais.Add(await _repository.FindAsync(item.AnimalId));
            }
            return listaDeAnimais;
        }

        public async Task<IEnumerable<Animal>> BuscarTodos()
        {
            return await _repository.ToListAsync();
        }

        public async Task<bool> CadastrarAnimal(CadastrarAnimalDto cadastro)
        {
            try
            {
                var Animal = new Animal(cadastro.Nome, cadastro.Idade, cadastro.IdadeAproximada, cadastro.Cor, cadastro.Especie, cadastro.Raca, cadastro.Peso, cadastro.Porte, cadastro.Status, cadastro.Descricao);

                Animal.AnimalId = Guid.NewGuid();

                var newRelacao = new User_Animal();
                newRelacao.UserId = cadastro.DonoId;
                newRelacao.AnimalId = Animal.AnimalId;
                await _repository.AddAsync(Animal);
                await _userAnimalRepository.AddAsync(newRelacao);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
