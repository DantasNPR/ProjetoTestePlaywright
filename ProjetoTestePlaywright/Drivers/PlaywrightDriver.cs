using Microsoft.Playwright;
using ProjetoTestePlaywright.Config;

namespace ProjetoTestePlaywright.Drivers
{
    public class PlaywrightDriver
    {
        private IPlaywright? _playwright;
        private IBrowser? _browser;

        public async Task<IPage> CreatePageAsync()
        {
            var settings = ConfigurationManager.Settings;

            _playwright = await Playwright.CreateAsync();

            var launchOptions = new BrowserTypeLaunchOptions
            {
                Headless = settings.Headless
            };

            _browser = settings.Browser.ToLowerInvariant() switch
            {
                "chromium" => await _playwright.Chromium.LaunchAsync(launchOptions),
                "firefox" => await _playwright.Firefox.LaunchAsync(launchOptions),
                "webkit" => await _playwright.Webkit.LaunchAsync(launchOptions),

                _ => throw new ArgumentException(
                    $"Navegador '{settings.Browser}' não suportado.")
            };

            var context = await _browser.NewContextAsync();

            var page = await context.NewPageAsync();

            page.SetDefaultTimeout(settings.Timeout);

            return page;
        }

        public async Task CloseAsync()
        {
            if (_browser is not null)
            {
                await _browser.CloseAsync();
            }

            _playwright?.Dispose();
        }
    }
}