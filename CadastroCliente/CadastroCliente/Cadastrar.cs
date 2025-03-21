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

        private bool LimparLabelErro()
        {
            labelErro.Text = "";
            return true;
        }

        private bool Nome()
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "Preencha nome";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxNome.Text.All(char.IsLetter))
            {
                labelErro.Text = "Preencha somente com letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Email()
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                labelErro.Text = "Preencha Email";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxEmail.Text.EndsWith("@email.com"))
            {
                labelErro.Text = "E-mail deve conter @email.com";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (textBoxEmail.Text.Length >= 20)
            {
                labelErro.Text = "E-mail deve conter 10 caracteres";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Genero()
        {
            if (comboBoxGenero.SelectedItem == null)
            {
                labelErro.Text = "Selecione uma opção em gênero";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool NomeSocial()
        {
            if (!textBoxNome.Text.All(char.IsLetter))
            {
                labelErro.Text = "Preencha somente com letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Etnia()
        {
            if (comboBoxEtnia.SelectedItem == null)
            {
                labelErro.Text = "Selecione uma opção em etnia";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Tipo()
        {
            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                labelErro.Text = "Selecione uma opção entre PF ou PJ";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Logradouro()
        {
            if (string.IsNullOrWhiteSpace(textBoxLogradouro.Text))
            {
                labelErro.Text = "Preencha Logradouro";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Numero()
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero.Text))
            {
                labelErro.Text = "Preencha campo número";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxNumero.Text.All(char.IsNumber))
            {
                labelErro.Text = "Não é possível realizar a validação somente com letras, insira números";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Complemento()
        {
            if (textBoxComplemento.Text.All(char.IsSymbol))
            {
                labelErro.Text = "Não é possível realizar a validação somente com simbolos, insira letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Bairro() 
        {
            if (string.IsNullOrWhiteSpace(textBoxBairro.Text))
            {
                labelErro.Text = "Preencha campo Bairro";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Municipio() 
        {
            if (string.IsNullOrWhiteSpace(textBoxMunicipio.Text))
            {
                labelErro.Text = "Preencha campo Município";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxMunicipio.Text.All(char.IsLetter))
            {
                labelErro.Text = "Não é possível realizar a validação somente com números, insira letras";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool Estado()
        {
            if (comboBoxEstado.SelectedItem == null)
            {
                labelErro.Text = "Selecione uma opção em Estado";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            return true;
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!LimparLabelErro())
            {
                return;
            }
            if (!Nome())
            {
                return;
            }
            if (!Email())
            {
                return;
            }
            if (!Genero())
            {
                return;
            }
            if (!NomeSocial())
            {
                return;
            }
            if (!Etnia())
            {
                return;
            }
            if (!Tipo())
            {
                return;
            }
            if (!Logradouro())
            {
                return;
            }
            if (!Numero())
            {
                return;
            }
            if (!Complemento())
            {
                return;
            }
            if (!Bairro())
            {
                return;
            }
            if (!Municipio())
            {
                return;
            }
            if (!Estado())
            {
                return;
            }

            labelErro.Text = "Cadastrado com sucesso!";
            labelErro.ForeColor = Color.Green;
        }
    }
}
