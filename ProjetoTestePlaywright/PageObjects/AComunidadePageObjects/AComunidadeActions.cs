using Microsoft.Playwright;

namespace ProjetoTestePlaywright.PageObjects.AComunidadePageObjects
{
    public class AComunidadeActions
    {
        private readonly IPage _page;

        public AComunidadeActions(IPage page)
        {
            _page = page
                ?? throw new ArgumentNullException(nameof(page));
        }

        public async Task SelecionarAbaAsync(string nomeAba)
        {
            await _page
                .GetByTestId("nav-playground")
                .ClickAsync();
        }
    }
}