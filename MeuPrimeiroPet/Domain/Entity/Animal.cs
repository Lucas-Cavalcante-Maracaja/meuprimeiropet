﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Animal
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

        public Animal(string nome, string idade, string idadeAproximada, string cor, string especie, string raca, float peso, string porte, string status, string descricao)
        {
            Nome = nome;
            Idade = idade;
            IdadeAproximada = idadeAproximada;
            Cor = cor;
            Especie = especie;
            Raca = raca;
            Peso = peso;
            Porte = porte;
            Status = status;
            Descricao = descricao;
        }
    }
}
