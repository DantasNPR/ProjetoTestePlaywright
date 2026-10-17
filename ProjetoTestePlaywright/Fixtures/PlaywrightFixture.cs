using Microsoft.Playwright;
using ProjetoTestePlaywright.Config;
using ProjetoTestePlaywright.Drivers;

namespace ProjetoTestePlaywright.Fixtures
{
    public class PlaywrightFixture : IAsyncDisposable
    {
        private readonly PlaywrightDriver _playwrightDriver;

        public IPage Page { get; private set; } = null!;

        public PlaywrightFixture()
        {
            _playwrightDriver = new PlaywrightDriver();
        }

        public async Task InitializeAsync()
        {
            Page = await _playwrightDriver.CreatePageAsync();

            await Page.GotoAsync(
                ConfigurationManager.Settings.BaseUrl);
        }

        public async ValueTask DisposeAsync()
        {
            await _playwrightDriver.CloseAsync();
        }
    }
}