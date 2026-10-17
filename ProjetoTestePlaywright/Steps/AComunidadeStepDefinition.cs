using Microsoft.Playwright;
using ProjetoTestePlaywright.PageObjects.AComunidadePageObjects;
using Reqnroll;

namespace ProjetoTestePlaywright.Steps
{
    [Binding]
    public class AComunidadeStepDefinition
    {
        private readonly AComunidadeActions _acomunidadeActions;

        public AComunidadeStepDefinition(IPage page)
        {
            _acomunidadeActions = new AComunidadeActions(page);
        }

        [Given("que o usuário está na aba {string} com o formulário de registro de defeitos disponível")]
        public async Task GivenQueOUsuarioEstaNaAbaComOFormularioDeRegistroDeDefeitosDisponivel(
            string nomeAba)
        {
            await _acomunidadeActions.SelecionarAbaAsync(nomeAba);
        }
    }
}