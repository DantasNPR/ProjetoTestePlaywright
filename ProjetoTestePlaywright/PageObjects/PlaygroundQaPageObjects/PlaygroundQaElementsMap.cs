using Microsoft.Playwright;

namespace ProjetoTestePlaywright.PageObjects.PlaygroundQaPageObjects
{
    public class PlaygroundQaElementsMap
    {
        private readonly IPage _page;

        public PlaygroundQaElementsMap(IPage page)
        {
            _page = page;
        }

        public ILocator TituloDefeito =>
            _page.Locator("#campo-titulo");

        public ILocator Modulo =>
            _page.Locator("#campo-modulo");

        public ILocator Severidade =>
            _page.Locator("#campo-severidade");

        public ILocator Ambiente =>
            _page.Locator("#campo-ambiente");

        public ILocator CampoEmailReportado =>
            _page.Locator("#campo-reporter");

        public ILocator DataDeteccao =>
            _page.Locator("#campo-data");

        public ILocator CampoOcorrencias =>
            _page.Locator("#campo-ocorrencias");

        public ILocator CampoPassosReproduzir =>
            _page.Locator("#campo-passos");

        public ILocator InformacoesSensiveis =>
            _page.Locator("#campo-aceite");

        public ILocator Prioridade(string prioridade) =>
            _page.Locator(
                $"input[type='radio'][name='prioridade'][value='{prioridade}']");

        public ILocator BotaoRegistrar(string nomeBotao) =>
            _page
                .Locator("#painel-registrar")
                .GetByRole(AriaRole.Button, new() { Name = nomeBotao });

        public ILocator MensagemSucesso(string mensagem) =>
            _page.GetByText(mensagem, new() { Exact = true });
    }
}