using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Cadastrar : Form
    {
        private List<Cliente> cliente = new List<Cliente>();

        public Cadastrar()
        {
            InitializeComponent();

            Endereco endereco = new Endereco() { Logradouro = "Rua Batalha Reis", Numero = "11", Complemento = "", Bairro = "São Bento Novo", Municipio = "São Paulo", Estado = "São Paulo", CEP = "05111111" };
            cliente.Add(new Cliente() { Id = "11", Name = "Neymar", DataNascimento = "05/02/1992", Telefone = "1191111-1111", Email = "neymar.jr@email.com", NomeSocial = "Ney", Estrangeiro = false, Tipo = TipoCliente.PF, Genero = GeneroCliente.Homem, Etnia = EtniaCliente.Preto });

            Endereco endereco1 = new Endereco() { Logradouro = "Rua Afonso Sanches", Numero = "10", Complemento = "Próximo a escola Afiz Gebara", Bairro = "São Bento", Municipio = "São Paulo", Estado = "São Paulo", CEP = "05101010" };
            cliente.Add(new Cliente() { Id = "10", Name = "Messi", DataNascimento = "24/06/1987", Telefone = "1191010-1010", Email = "messi.jr@email.com", NomeSocial = "Et", Estrangeiro = false, Tipo = TipoCliente.PF, Genero = GeneroCliente.Homem, Etnia = EtniaCliente.Branco });

            Endereco endereco2 = new Endereco() { Logradouro = "Aviadora Anésia Pinheiro Machado", Numero = "9", Complemento = "Ao lado da pizzaria Raeleza", Bairro = "Cohab São Bento", Municipio = "São Paulo", Estado = "São Paulo", CEP = "05999999" };
            cliente.Add(new Cliente() { Id = "9", Name = "Suarez", DataNascimento = "24/01/1997", Telefone = "1199999-9999", Email = "suarez.jr@email.com", NomeSocial = "Pistoleiro", Estrangeiro = true, Tipo = TipoCliente.PJ, Genero = GeneroCliente.Homem, Etnia = EtniaCliente.Branco });

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
