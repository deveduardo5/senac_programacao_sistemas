﻿namespace CadastroCliente
{
    public partial class Cadastrar : Form
    {
        private List<Cliente> cliente = new List<Cliente>();
        private readonly BindingSource BindingSource = [];

        public Cadastrar()
        {
            InitializeComponent();

            Endereco endereco = new Endereco() { Logradouro = "Rua Batalha Reis", Numero = "11", Complemento = "", Bairro = "São Bento Novo", Municipio = "São Paulo", Estado = "São Paulo", CEP = "05111111" };
            cliente.Add(new Cliente() { Id = 11, Name = "Neymar", DataNascimento = "05/02/1992", Telefone = "1191111-1111", Email = "neymar.jr@email.com", NomeSocial = "Ney", Estrangeiro = false, Tipo = TipoCliente.PF, Genero = GeneroCliente.Homem, Etnia = EtniaCliente.Preto });

            Endereco endereco1 = new Endereco() { Logradouro = "Rua Afonso Sanches", Numero = "10", Complemento = "Próximo a escola Afiz Gebara", Bairro = "São Bento", Municipio = "São Paulo", Estado = "São Paulo", CEP = "05101010" };
            cliente.Add(new Cliente() { Id = 10, Name = "Messi", DataNascimento = "24/06/1987", Telefone = "1191010-1010", Email = "messi.jr@email.com", NomeSocial = "Et", Estrangeiro = false, Tipo = TipoCliente.PF, Genero = GeneroCliente.Homem, Etnia = EtniaCliente.Branco });

            Endereco endereco2 = new Endereco() { Logradouro = "Aviadora Anésia Pinheiro Machado", Numero = "9", Complemento = "Ao lado da pizzaria Raeleza", Bairro = "Cohab São Bento", Municipio = "São Paulo", Estado = "São Paulo", CEP = "05999999" };
            cliente.Add(new Cliente() { Id = 9, Name = "Suarez", DataNascimento = "24/01/1997", Telefone = "1199999-9999", Email = "suarez.jr@email.com", NomeSocial = "Pistoleiro", Estrangeiro = true, Tipo = TipoCliente.PJ, Genero = GeneroCliente.Homem, Etnia = EtniaCliente.Branco });


            BindingSource.DataSource = cliente;
            dataGridViewClientes.DataSource = BindingSource;
        }

        private bool LimparLabelErro()
        {
            labelErro.Text = "";
            return true;
        }

        private int GerarNovoId()
        {
            return cliente.Max(cliente => cliente.Id) + 1;
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

        private bool DataNascismento() 
        {
            if (maskedTextBoxNascimento.Text.Contains(" "))
            {
                labelErro.Text = "Data não pode estar vazia";
                return false;
            }

            if (maskedTextBoxNascimento.Text.Length < 10)
            {
                labelErro.Text = "Data Incompleta";
                return false;
            }
            try
            {
                Convert.ToDateTime(maskedTextBoxNascimento.Text);
            }
            catch 
            {
                labelErro.Text = "Insira uma data válida";
                return false;
            }
            return true;
        }

        private bool Telefone() 
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text)) 
            {
                labelErro.Text = "Telefone não pode estar vazio";
                return false;
            }
            if (maskedTextBoxTelefone.Text.Length < 13) 
            {
                labelErro.Text = "Telefone Incompleto";
                return false;
            }
            if (maskedTextBoxTelefone.Text.Contains(" "))
            {
                labelErro.Text = "Telefone Incompleto";
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
            if (textBoxMunicipio.Text.All(char.IsLetter))
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

        private bool CEP()
        {
            if (!maskedTextBoxCEP.Text.Any(char.IsNumber))
            {
                labelErro.Text = "CEP Invalido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (maskedTextBoxCEP.Text.Length < 9)
            {
                labelErro.Text = "CEP Invalido";
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
            if (!DataNascismento())
            {
                return;
            }
            if (!Telefone())
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
            if (!CEP())
            {
                return;
            }

            TipoCliente tipo = 0;
            if (radioButtonPF.Checked)
            {
                tipo = TipoCliente.PF;
            }
            if (radioButtonPJ.Checked)
            {
                tipo = TipoCliente.PJ;
            }

            int novoId = GerarNovoId();

            Endereco endereco = new()
            {
                Logradouro = textBoxLogradouro.Text,
                Numero = textBoxNumero.Text,
                Complemento = textBoxComplemento.Text,
                Bairro = textBoxBairro.Text,
                Municipio = textBoxMunicipio.Text,
                Estado = comboBoxEstado.Text,
                CEP = maskedTextBoxCEP.Text,
            };

            cliente.Add(new Cliente()
            {
                Id = novoId,
                Name = textBoxNome.Text,
                DataNascimento = maskedTextBoxNascimento.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = textBoxEmail.Text,
                Genero = (GeneroCliente)comboBoxGenero.SelectedIndex,
                NomeSocial = textBoxNomeSocial.Text,
                Etnia = (EtniaCliente)comboBoxEtnia.SelectedIndex,
                Estrangeiro = checkBoxSimOuNao.Checked,
                Tipo = tipo,
                Endereco = endereco,
            });
            BindingSource.ResetBindings(false);

            labelErro.Text = "Cadastrado com sucesso!";
            labelErro.ForeColor = Color.Green;
        }
    }
}
