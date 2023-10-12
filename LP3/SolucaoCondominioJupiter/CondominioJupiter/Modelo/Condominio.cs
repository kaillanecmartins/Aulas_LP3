using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioJupiter.Modelo
{
    internal class Condominio
    {
        private string nome;
        private string cep;
        private string endereco;
        private int numero;

        public Condominio(string nome, string cep, string endereco, int numero)
        {
            this.nome = nome;
            this.cep = cep;
            this.endereco = endereco;
            this.numero = numero;
        }

        public override string? ToString()
        {
            return "Nome: " + this.nome + "\nEndereço: " + this.endereco + "\nNúmero: " + this.numero + "\nCEP: " + this.cep;
        }
    }
}
