using SneakersSenac.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakersSenac.dominio
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; }

        private readonly sneakersRepositorio repositorio = new();



    }
}
