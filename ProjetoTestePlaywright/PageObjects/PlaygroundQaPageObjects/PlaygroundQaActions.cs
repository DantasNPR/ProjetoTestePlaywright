using Microsoft.Playwright;
using System.Globalization;

namespace ProjetoTestePlaywright.PageObjects.PlaygroundQaPageObjects
{
    public class PlaygroundQaActions
    {
        private readonly PlaygroundQaElementsMap _elements;

        public PlaygroundQaActions(IPage page)
        {
            _elements = new PlaygroundQaElementsMap(
                page ?? throw new ArgumentNullException(nameof(page)));
        }

        public async Task PreencherCampoTituloDefeitoAsync(string tituloDefeito)
        {
            await _elements.TituloDefeito.FillAsync(tituloDefeito);
        }

        public async Task SelecionarModuloAfetadoAsync(string modulo)
        {
            await _elements.Modulo.SelectOptionAsync(
                new SelectOptionValue { Label = modulo });
        }

        public async Task SelecionarSeveridadeAsync(string tipoSeveridade)
        {
            await _elements.Severidade.SelectOptionAsync(
                new SelectOptionValue { Label = tipoSeveridade });
        }

        public async Task SelecionarAmbienteAsync(string ambiente)
        {
            await _elements.Ambiente.SelectOptionAsync(
                new SelectOptionValue { Label = ambiente });
        }

        public async Task PreencherCampoEmailReportouAsync(string email)
        {
            await _elements.CampoEmailReportado.FillAsync(email);
        }

        public async Task InserirDataDeteccaoAsync(string dataDeteccao)
        {
            var data = DateTime.ParseExact(
                dataDeteccao,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture);

            var dataFormatada = data.ToString("yyyy-MM-dd");

            await _elements.DataDeteccao.FillAsync(dataFormatada);
        }

        public async Task InserirQtdOcorrenciasAsync(string qtdOcorrencias)
        {
            await _elements.CampoOcorrencias.FillAsync(qtdOcorrencias);
        }

        public async Task SelecionarPrioridadeAsync(string prioridade)
        {
            await _elements.Prioridade(prioridade).CheckAsync();
        }

        public async Task PreencherCampoPassosReproduzirAsync(
            string passosReproduzir)
        {
            await _elements.CampoPassosReproduzir.FillAsync(passosReproduzir);
        }

        public async Task MarcarConfirmacaoInformacoesSensiveisAsync()
        {
            await _elements.InformacoesSensiveis.CheckAsync();
        }

        public async Task ClicarBotaoDoPainelRegistrarAsync(string nomeBotao)
        {
            await _elements.BotaoRegistrar(nomeBotao).ClickAsync();
        }

        public async Task VerificarMensagemSucessoAsync(string mensagem)
        {
            await Assertions.Expect(
                _elements.MensagemSucesso(mensagem))
                .ToBeVisibleAsync();
        }
    }
}