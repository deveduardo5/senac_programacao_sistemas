namespace CadastroCliente
{
    partial class Cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            labelNascimento = new Label();
            labelTelefone = new Label();
            labelEmail = new Label();
            labelGenero = new Label();
            labelNomeSocial = new Label();
            labelEtnia = new Label();
            labelEstrangeiro = new Label();
            labelTipo = new Label();
            labelLogradouro = new Label();
            labelNumero = new Label();
            labelComplemento = new Label();
            labelBairro = new Label();
            labelMunicipio = new Label();
            labelEstado = new Label();
            labelCEP = new Label();
            textBoxNome = new TextBox();
            maskedTextBoxNascimento = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            textBoxEmail = new TextBox();
            comboBoxGenero = new ComboBox();
            textBoxNomeSocial = new TextBox();
            comboBoxEtnia = new ComboBox();
            checkBoxSimOuNao = new CheckBox();
            radioButtonPF = new RadioButton();
            radioButtonPJ = new RadioButton();
            textBoxLogradouro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            textBoxMunicipio = new TextBox();
            comboBoxEstado = new ComboBox();
            maskedTextBoxCEP = new MaskedTextBox();
            labelCadastro = new Label();
            labelDados = new Label();
            labelEndereco = new Label();
            pictureBox1 = new PictureBox();
            buttonCadastrar = new Button();
            labelErro = new Label();
            dataGridViewClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(119, 175);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // labelNascimento
            // 
            labelNascimento.AutoSize = true;
            labelNascimento.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNascimento.Location = new Point(31, 205);
            labelNascimento.Name = "labelNascimento";
            labelNascimento.Size = new Size(131, 15);
            labelNascimento.TabIndex = 1;
            labelNascimento.Text = "Data de Nascismento:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefone.Location = new Point(104, 234);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(58, 15);
            labelTelefone.TabIndex = 2;
            labelTelefone.Text = "Telefone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(117, 263);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(45, 15);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "E-mail:";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGenero.Location = new Point(111, 292);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(51, 15);
            labelGenero.TabIndex = 4;
            labelGenero.Text = "Gênero:";
            // 
            // labelNomeSocial
            // 
            labelNomeSocial.AutoSize = true;
            labelNomeSocial.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomeSocial.Location = new Point(81, 321);
            labelNomeSocial.Name = "labelNomeSocial";
            labelNomeSocial.Size = new Size(81, 15);
            labelNomeSocial.TabIndex = 5;
            labelNomeSocial.Text = "Nome Social:";
            // 
            // labelEtnia
            // 
            labelEtnia.AutoSize = true;
            labelEtnia.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEtnia.Location = new Point(124, 349);
            labelEtnia.Name = "labelEtnia";
            labelEtnia.Size = new Size(38, 15);
            labelEtnia.TabIndex = 6;
            labelEtnia.Text = "Etnia:";
            // 
            // labelEstrangeiro
            // 
            labelEstrangeiro.AutoSize = true;
            labelEstrangeiro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstrangeiro.Location = new Point(86, 377);
            labelEstrangeiro.Name = "labelEstrangeiro";
            labelEstrangeiro.Size = new Size(76, 15);
            labelEstrangeiro.TabIndex = 7;
            labelEstrangeiro.Text = "Estrangeiro:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(128, 403);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(34, 15);
            labelTipo.TabIndex = 8;
            labelTipo.Text = "Tipo:";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogradouro.Location = new Point(470, 175);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(76, 15);
            labelLogradouro.TabIndex = 9;
            labelLogradouro.Text = "Logradouro:";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(491, 204);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(55, 15);
            labelNumero.TabIndex = 10;
            labelNumero.Text = "Número:";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComplemento.Location = new Point(457, 234);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(89, 15);
            labelComplemento.TabIndex = 11;
            labelComplemento.Text = "Complemento:";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBairro.Location = new Point(501, 263);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(45, 15);
            labelBairro.TabIndex = 12;
            labelBairro.Text = "Bairro:";
            // 
            // labelMunicipio
            // 
            labelMunicipio.AutoSize = true;
            labelMunicipio.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMunicipio.Location = new Point(482, 291);
            labelMunicipio.Name = "labelMunicipio";
            labelMunicipio.Size = new Size(64, 15);
            labelMunicipio.TabIndex = 13;
            labelMunicipio.Text = "Município:";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstado.Location = new Point(497, 321);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(49, 15);
            labelEstado.TabIndex = 14;
            labelEstado.Text = "Estado:";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCEP.Location = new Point(513, 349);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(33, 15);
            labelCEP.TabIndex = 15;
            labelCEP.Text = "CEP:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(168, 172);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 16;
            // 
            // maskedTextBoxNascimento
            // 
            maskedTextBoxNascimento.Location = new Point(168, 202);
            maskedTextBoxNascimento.Mask = "00/00/0000";
            maskedTextBoxNascimento.Name = "maskedTextBoxNascimento";
            maskedTextBoxNascimento.Size = new Size(100, 23);
            maskedTextBoxNascimento.TabIndex = 17;
            maskedTextBoxNascimento.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(168, 231);
            maskedTextBoxTelefone.Mask = "(00)00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(100, 23);
            maskedTextBoxTelefone.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(168, 260);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 19;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Homem", "Mulher", "Não Binário", "Outro" });
            comboBoxGenero.Location = new Point(168, 289);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(100, 23);
            comboBoxGenero.TabIndex = 20;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(168, 318);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(100, 23);
            textBoxNomeSocial.TabIndex = 21;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Preto", "Pardo", "Indígena", "Amarelo" });
            comboBoxEtnia.Location = new Point(168, 347);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(100, 23);
            comboBoxEtnia.TabIndex = 22;
            // 
            // checkBoxSimOuNao
            // 
            checkBoxSimOuNao.AutoSize = true;
            checkBoxSimOuNao.Location = new Point(168, 378);
            checkBoxSimOuNao.Name = "checkBoxSimOuNao";
            checkBoxSimOuNao.Size = new Size(15, 14);
            checkBoxSimOuNao.TabIndex = 23;
            checkBoxSimOuNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonPF
            // 
            radioButtonPF.AutoSize = true;
            radioButtonPF.Location = new Point(168, 401);
            radioButtonPF.Name = "radioButtonPF";
            radioButtonPF.Size = new Size(38, 19);
            radioButtonPF.TabIndex = 24;
            radioButtonPF.TabStop = true;
            radioButtonPF.Text = "PF";
            radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonPJ
            // 
            radioButtonPJ.AutoSize = true;
            radioButtonPJ.Location = new Point(220, 401);
            radioButtonPJ.Name = "radioButtonPJ";
            radioButtonPJ.Size = new Size(35, 19);
            radioButtonPJ.TabIndex = 25;
            radioButtonPJ.TabStop = true;
            radioButtonPJ.Text = "PJ";
            radioButtonPJ.UseVisualStyleBackColor = true;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(552, 172);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(100, 23);
            textBoxLogradouro.TabIndex = 27;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(552, 201);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 28;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(552, 230);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(100, 23);
            textBoxComplemento.TabIndex = 29;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(552, 259);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(100, 23);
            textBoxBairro.TabIndex = 30;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(552, 288);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(100, 23);
            textBoxMunicipio.TabIndex = 31;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            comboBoxEstado.Location = new Point(552, 317);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(100, 23);
            comboBoxEstado.TabIndex = 32;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(552, 346);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(100, 23);
            maskedTextBoxCEP.TabIndex = 33;
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCadastro.Location = new Point(327, 98);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(133, 32);
            labelCadastro.TabIndex = 34;
            labelCadastro.Text = "Cadastro";
            // 
            // labelDados
            // 
            labelDados.AutoSize = true;
            labelDados.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDados.Location = new Point(180, 129);
            labelDados.Name = "labelDados";
            labelDados.Size = new Size(75, 24);
            labelDados.TabIndex = 35;
            labelDados.Text = "Dados";
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEndereco.Location = new Point(545, 129);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(107, 24);
            labelEndereco.TabIndex = 36;
            labelEndereco.Text = "Endereço";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tela_de_Fundo___Projeto_Forms1;
            pictureBox1.Location = new Point(255, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(365, 415);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 38;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErro.ForeColor = Color.Red;
            labelErro.Location = new Point(31, 469);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 39;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(698, 161);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(568, 209);
            dataGridViewClientes.TabIndex = 3;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 659);
            Controls.Add(dataGridViewClientes);
            Controls.Add(labelErro);
            Controls.Add(buttonCadastrar);
            Controls.Add(pictureBox1);
            Controls.Add(labelEndereco);
            Controls.Add(labelDados);
            Controls.Add(labelCadastro);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxMunicipio);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(radioButtonPJ);
            Controls.Add(radioButtonPF);
            Controls.Add(checkBoxSimOuNao);
            Controls.Add(comboBoxEtnia);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxEmail);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(labelCEP);
            Controls.Add(labelEstado);
            Controls.Add(labelMunicipio);
            Controls.Add(labelBairro);
            Controls.Add(labelComplemento);
            Controls.Add(labelNumero);
            Controls.Add(labelLogradouro);
            Controls.Add(labelTipo);
            Controls.Add(labelEstrangeiro);
            Controls.Add(labelEtnia);
            Controls.Add(labelNomeSocial);
            Controls.Add(labelGenero);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefone);
            Controls.Add(labelNascimento);
            Controls.Add(labelNome);
            Name = "Cadastrar";
            Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelNascimento;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelGenero;
        private Label labelNomeSocial;
        private Label labelEtnia;
        private Label labelEstrangeiro;
        private Label labelTipo;
        private Label labelLogradouro;
        private Label labelNumero;
        private Label labelComplemento;
        private Label labelBairro;
        private Label labelMunicipio;
        private Label labelEstado;
        private Label labelCEP;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxNascimento;
        private MaskedTextBox maskedTextBoxTelefone;
        private TextBox textBoxEmail;
        private ComboBox comboBoxGenero;
        private TextBox textBoxNomeSocial;
        private ComboBox comboBoxEtnia;
        private CheckBox checkBoxSimOuNao;
        private RadioButton radioButtonPF;
        private RadioButton radioButtonPJ;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private TextBox textBoxBairro;
        private TextBox textBoxMunicipio;
        private ComboBox comboBoxEstado;
        private MaskedTextBox maskedTextBoxCEP;
        private Label labelCadastro;
        private Label labelDados;
        private Label labelEndereco;
        private PictureBox pictureBox1;
        private Button buttonCadastrar;
        private Label labelErro;
        private DataGridView dataGridViewClientes;
    }
}