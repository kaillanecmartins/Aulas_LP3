using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula010.modelo
{
    internal class Pet
    {
        private string nome;
        private string especie;
        private string raca;
        private string genero;
        private string cor;
        private string observacoes;

        public Pet(string nome, string especie, string raca, string genero, string cor, string observacoes)
        {
            this.Nome = nome;
            this.Especie = especie;
            this.Raca = raca;
            this.Genero = genero;
            this.Cor = cor;
            this.Observacoes = observacoes;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raca { get => raca; set => raca = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }
    }
}
