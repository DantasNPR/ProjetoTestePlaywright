using Microsoft.Playwright;
using ProjetoTestePlaywright.Fixtures;
using Reqnroll;
using Reqnroll.BoDi;

namespace ProjetoTestePlaywright.Hooks
{
    [Binding]
    public class PlaywrightHooks
    {
        private readonly IObjectContainer _container;
        private PlaywrightFixture? _fixture;

        public PlaywrightHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario(Order = 0)]
        public async Task IniciarNavegadorAsync()
        {
            _fixture = new PlaywrightFixture();

            await _fixture.InitializeAsync();

            _container.RegisterInstanceAs<IPage>(
                _fixture.Page,
                dispose: false);
        }

        [AfterScenario]
        public async Task FecharNavegadorAsync()
        {
            if (_fixture is not null)
            {
                await _fixture.DisposeAsync();
            }
        }
    }
}