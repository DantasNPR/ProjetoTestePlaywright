using Microsoft.Playwright;
using ProjetoTestePlaywright.PageObjects.PlaygroundQaPageObjects;
using Reqnroll;

namespace ProjetoTestePlaywright.Steps
{
    [Binding]
    public class PlaygroundQaStepDefinition
    {
        private readonly PlaygroundQaActions _playgroundQaActions;

        public PlaygroundQaStepDefinition(IPage page)
        {
            _playgroundQaActions = new PlaygroundQaActions(page);
        }

        [When("preenche o campo Título do defeito com {string}")]
        public async Task WhenPreencheOCampoTituloDoDefeitoCom(string tituloDefeito)
        {
            await _playgroundQaActions
                .PreencherCampoTituloDefeitoAsync(tituloDefeito);
        }

        [When("seleciona o módulo afetado {string}")]
        public async Task WhenSelecionaOModuloAfetado(string modulo)
        {
            await _playgroundQaActions
                .SelecionarModuloAfetadoAsync(modulo);
        }

        [When("seleciona a severidade {string}")]
        public async Task WhenSelecionaASeveridade(string tipoSeveridade)
        {
            await _playgroundQaActions
                .SelecionarSeveridadeAsync(tipoSeveridade);
        }

        [When("seleciona o ambiente {string}")]
        public async Task WhenSelecionaOAmbiente(string ambiente)
        {
            await _playgroundQaActions
                .SelecionarAmbienteAsync(ambiente);
        }

        [When("preenche o campo E-mail de quem reportou com {string}")]
        public async Task WhenPreencheOCampoEmailDeQuemReportouCom(string email)
        {
            await _playgroundQaActions
                .PreencherCampoEmailReportouAsync(email);
        }

        [When("informa a data de deteccao {string}")]
        public async Task WhenInformaADataDeDeteccao(string dataDeteccao)
        {
            await _playgroundQaActions
                .InserirDataDeteccaoAsync(dataDeteccao);
        }

        [When("informa {string} no campo Ocorrencias")]
        public async Task WhenInformaNoCampoOcorrencias(string qtdOcorrencias)
        {
            await _playgroundQaActions
                .InserirQtdOcorrenciasAsync(qtdOcorrencias);
        }

        [When("seleciona a prioridade {string}")]
        public async Task WhenSelecionaAPrioridade(string prioridade)
        {
            await _playgroundQaActions
                .SelecionarPrioridadeAsync(prioridade);
        }

        [When("preenche o campo Passos para reproduzir com:")]
        public async Task WhenPreencheOCampoPassosParaReproduzirCom(
            string passosReproduzir)
        {
            await _playgroundQaActions
                .PreencherCampoPassosReproduzirAsync(passosReproduzir);
        }

        [When("marca a confirmacao de que o relato nao contém informacoes sensíveis")]
        public async Task WhenMarcaAConfirmacaoDeQueORelatoNaoContemInformacoesSensiveis()
        {
            await _playgroundQaActions
                .MarcarConfirmacaoInformacoesSensiveisAsync();
        }

        [When("clica no botao {string}")]
        public async Task WhenClicaNoBotao(string nomeBotao)
        {
            await _playgroundQaActions
                .ClicarBotaoDoPainelRegistrarAsync(nomeBotao);
        }

        [Then("deve visualizar a mensagem {string}")]
        public async Task ThenDeveVisualizarAMensagem(string mensagem)
        {
            await _playgroundQaActions
                .VerificarMensagemSucessoAsync(mensagem);
        }
    }
}