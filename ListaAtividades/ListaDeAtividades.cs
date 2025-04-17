using ListaAtividades.Dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        private Atividade? atividadeEmAndamento;
        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;

            CarregarListaDeAtvidades();
            CarregarAtividadeEmAndamento();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento == null || atividadeEmAndamento.Id <= 0)
            {
                labelErro.Text = "N�o h� atividade em andamento.";
                return;
            }

            if (!atividadeEmAndamento.AtualizarSituacao())
            {
                labelErro.Text = "Erro ao finalizar atividade.";
                return;
            }
            labelErro.Text = string.Empty;

            CarregarAtividadeEmAndamento();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione uma atividade.";
                return;
            }

            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];

            Atividade atividade = new()
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value
            };

            if (!atividade.AtualizarSituacao())
            {
                labelErro.Text = "N�o foi poss�vel atualizar a atividade.";
                return;
            }

            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
            CarregarListaDeAtvidades();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new CriarAtividade().ShowDialog();

            if (resultado != DialogResult.OK)
            {
                labelErro.Text = "Cria��o da atividade n�o foi conclu�da.";
                return;
            }

            labelErro.Text = "Atividade criada com sucesso!";
            CarregarListaDeAtvidades();
        }

        private void CarregarListaDeAtvidades()
        {
            Atividade atividade = new();

            var atividadesPendentes = atividade.ListarAtividadePendentes();
            dataGridViewAtividades.DataSource = atividadesPendentes;
        }

        private void CarregarAtividadeEmAndamento()
        {
            Atividade atividade = new();

            atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            string textoAtividade = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            textBoxAtividadeEmAndamento.Text = atividadeEmAndamento.Id > 0 ? textoAtividade : string.Empty;
        }
    }
}

